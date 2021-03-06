﻿'Copyright 2020,Davin Alfarizky Putra Basudewa
'https://dvnlabs.ml
'Educational Purposes Only
Public Class pinjaman
    Dim con As OleDb.OleDbConnection
    Dim interest, growedInterest, yangDihutangin, saldo, totalHutang As Double
    Dim util As utility
    Dim datee As New datee
    Dim ktp, idPeminjam As String

    Private Sub pinjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = connect()
        util = New utility(con)
        oneSec.Start()
    End Sub
    Private Sub clearAll()
        interest = 0
        growedInterest = 0
        saldo = 0
        ktp = ""
        idPeminjam = ""
        inputKTPID.Text = ""
        lblNama.Text = ""
        inputSaldo.Text = ""
        inputNominal.Text = ""
        inputNote.Text = ""
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Console.WriteLine(TabControl1.SelectedIndex)
        If TabControl1.SelectedIndex = 2 Then
            refreshTabDataHutang()
        ElseIf TabControl1.SelectedIndex = 0 Then
            clearAll()
        ElseIf TabControl1.SelectedIndex = 1 Then
            refreshBayarHutang()
        End If
    End Sub

    Private Sub getNama()
        Try
            Dim getNamas = "SELECT namaPenghutang,noKTP,idPenghutang,totalHutang FROM peminjam WHERE idPenghutang =@1 OR noKTP =@2"
            Dim ole = con.CreateCommand
            ole.CommandText = getNamas
            ole.Parameters.Add(New OleDb.OleDbParameter("@1", inputKTPID.Text))
            ole.Parameters.Add(New OleDb.OleDbParameter("@2", inputKTPID.Text))
            Dim reader = ole.ExecuteReader
            If reader.Read Then
                lblNama.Text = reader(0)
                ktp = reader(1)
                idPeminjam = reader(2)
                totalHutang = reader(3)
                getSaldo()
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbFind_CheckedChanged(sender As Object, e As EventArgs) Handles cbFind.CheckedChanged
        If cbFind.Checked Then
            inputIDHPminjam.Enabled = True
            btnShow.Text = "Find"
            inputIDHPminjam.Text = ""
        Else
            inputIDHPminjam.Enabled = False
            btnShow.Text = "Refresh"
            inputIDHPminjam.Text = ""
        End If
    End Sub

    Private Sub getSaldo()
        Try
            Dim saldoS = "SELECT balance,interest,extraInterest,yangDihutangin FROM vault"
            Dim ole = con.CreateCommand
            ole.CommandText = saldoS
            Dim reader = ole.ExecuteReader
            If reader.Read Then
                saldo = Convert.ToDouble(reader(0))
                interest = Convert.ToDouble(reader(1))
                growedInterest = Convert.ToDouble(reader(2))
                yangDihutangin = Convert.ToDouble(reader(3))
                inputSaldo.Text = saldo.ToString("C", Globalization.CultureInfo.CreateSpecificCulture("id-ID"))
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub inputKTPID_KeyDown(sender As Object, e As KeyEventArgs) Handles inputKTPID.KeyDown
        If e.KeyCode = Keys.Enter Then
            getNama()
        End If
    End Sub

    Private Sub btnBuatHutang_Click(sender As Object, e As EventArgs) Handles btnBuatHutang.Click
        Try
            Dim idHutang = util.makeIDHutang
            Dim id = inputKTPID.Text
            Dim target = inputTarget.Value
            Dim nominal = Convert.ToDouble(inputNominal.Text)
            Dim note = inputNote.Text
            If nominal >= saldo Then
                MsgBox("Tidak ada uang untuk dipinjamkan!")
            Else

                Dim sqlBuatHutang = "INSERT INTO detailHutang(idHutang,statusHutang,nominalHutang,sisaHutang,[note],idPenghutang,tanggalTransaksi,tanggalHarusLunas,interest) VALUES(@1,@2,@3,@4,@5,@6,@7,@8,@9)"
                Dim ole = con.CreateCommand
                ole.CommandText = sqlBuatHutang
                ole.Parameters.Add(New OleDb.OleDbParameter("@1", idHutang))
                ole.Parameters.Add(New OleDb.OleDbParameter("@2", "Belum Lunas"))
                ole.Parameters.Add(New OleDb.OleDbParameter("@3", nominal))
                ole.Parameters.Add(New OleDb.OleDbParameter("@4", nominal))
                ole.Parameters.Add(New OleDb.OleDbParameter("@5", note))
                ole.Parameters.Add(New OleDb.OleDbParameter("@6", idPeminjam))
                ole.Parameters.Add(New OleDb.OleDbParameter("@7", Now.ToShortDateString))
                ole.Parameters.Add(New OleDb.OleDbParameter("@8", target.ToShortDateString))
                ole.Parameters.Add(New OleDb.OleDbParameter("@9", interest))
                If ole.ExecuteNonQuery Then
                    updateSaldo(idHutang)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub updateSaldo(idHutang As String)
        Try
            Dim saldoSQL = "UPDATE vault set balance = @1 , yangDihutangin = @2"
            Dim ole = con.CreateCommand
            ole.CommandText = saldoSQL
            Dim blanceAkhir = saldo - Convert.ToDouble(inputNominal.Text)
            Dim ygDihutanAkhir = yangDihutangin + Convert.ToDouble(inputNominal.Text)
            ole.Parameters.Add(New OleDb.OleDbParameter("@1", blanceAkhir))
            ole.Parameters.Add(New OleDb.OleDbParameter("@2", ygDihutanAkhir))
            If ole.ExecuteNonQuery Then
                ole = con.CreateCommand
                Dim toHutangAkhir = totalHutang + Convert.ToDouble(inputNominal.Text)
                saldoSQL = "UPDATE peminjam SET totalHutang = @1 WHERE idPenghutang = @2"
                ole.CommandText = saldoSQL
                ole.Parameters.Add(New OleDb.OleDbParameter("@1", toHutangAkhir))
                ole.Parameters.Add(New OleDb.OleDbParameter("@2", idPeminjam))
                If ole.ExecuteNonQuery Then
                    MsgBox("Success Inserted! dengan ID Hutang " + idHutang)
                    clearAll()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Function for() TAB Data Hutang
    Private Sub refreshTabDataHutang()
        cbFind.Checked = False
        inputIDHPminjam.Enabled = False
        btnShow.Text = "Refresh"
        inputIDHPminjam.Text = ""
        refreshDGVDataHutang()
    End Sub
    Private Sub initDGVDataHutang()
        dgvDataHutang.Columns.Clear()
        dgvDataHutang.Rows.Clear()
        dgvDataHutang.Columns.Add("id", "ID Peminjam")
        dgvDataHutang.Columns.Add("ktp", "KTP")
        dgvDataHutang.Columns.Add("nama", "Nama Peminjam")
        dgvDataHutang.Columns.Add("totalHutang", "Total Hutang")
        dgvDataHutang.Columns.Add("IDHutang", "ID Hutang")
        dgvDataHutang.Columns.Add("statusHutang", "Status Hutang")
        dgvDataHutang.Columns.Add("nominalHutang", "Nominal")
        dgvDataHutang.Columns.Add("sisa", "Sisa")
        dgvDataHutang.Columns.Add("tanggalTransaksi", "Tanggal Transaksi")
        dgvDataHutang.Columns.Add("tanggalHarusLunas", "Jatuh Tempo")
        dgvDataHutang.Columns.Add("tanggalLunas", "Tanggal Lunas")
    End Sub

    Private Sub refreshDGVDataHutang()
        Try
            initDGVDataHutang()
            Dim ds As New DataSet
            Dim sqlA As String
            Dim findDataHutangText = inputIDHPminjam.Text
            Dim ole = con.CreateCommand
            If findDataHutangText = "" Then
                sqlA = "SELECT peminjam.idPenghutang, peminjam.noKTP, peminjam.namaPenghutang, peminjam.totalHutang, detailHutang.idHutang, detailHutang.statusHutang, detailHutang.nominalHutang, detailHutang.sisaHutang, detailHutang.tanggalTransaksi, detailHutang.tanggalHarusLunas, detailHutang.tanggalLunas
FROM peminjam INNER JOIN detailHutang ON peminjam.idPenghutang = detailHutang.idPenghutang;"
            Else
                sqlA = "SELECT peminjam.idPenghutang, peminjam.noKTP, peminjam.namaPenghutang, peminjam.totalHutang, detailHutang.idHutang, detailHutang.statusHutang, detailHutang.nominalHutang, detailHutang.sisaHutang, detailHutang.tanggalTransaksi, detailHutang.tanggalHarusLunas, detailHutang.tanggalLunas
FROM peminjam INNER JOIN detailHutang ON peminjam.idPenghutang = detailHutang.idPenghutang
WHERE (((peminjam.idPenghutang)=@1) OR ((peminjam.noKTP)=@2) OR ((detailHutang.idHutang)=@3));
"
                ole.Parameters.Add(New OleDb.OleDbParameter("@1", findDataHutangText))
                ole.Parameters.Add(New OleDb.OleDbParameter("@2", findDataHutangText))
                ole.Parameters.Add(New OleDb.OleDbParameter("@3", findDataHutangText))
            End If
            ole.CommandText = sqlA
            Dim da As New OleDb.OleDbDataAdapter(ole)
            da.Fill(ds)
            For i = 0 To ds.Tables(0).Rows.Count - 1
                Dim id = ds.Tables(0).Rows(i).Item(0)
                Dim ktp = ds.Tables(0).Rows(i).Item(1)
                Dim nama = ds.Tables(0).Rows(i).Item(2)
                Dim totalH = Convert.ToDouble(ds.Tables(0).Rows(i).Item(3)).ToString("C", Globalization.CultureInfo.CreateSpecificCulture("id-ID"))
                Dim idH = ds.Tables(0).Rows(i).Item(4)
                Dim statusH = ds.Tables(0).Rows(i).Item(5)
                Dim nominalH = Convert.ToDouble(ds.Tables(0).Rows(i).Item(6)).ToString("C", Globalization.CultureInfo.CreateSpecificCulture("id-ID"))
                Dim sisaH = Convert.ToDouble(ds.Tables(0).Rows(i).Item(7)).ToString("C", Globalization.CultureInfo.CreateSpecificCulture("id-ID"))
                Dim tanggalTrans = ds.Tables(0).Rows(i).Item(8)
                Dim tanggalJatuh = ds.Tables(0).Rows(i).Item(9)
                Dim tanggalLunas = ds.Tables(0).Rows(i).Item(10)

                dgvDataHutang.Rows.Add(id, ktp, nama, totalH, idH, statusH, nominalH, sisaH, tanggalTrans, tanggalJatuh, tanggalLunas)
            Next
            dgvDataHutang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvDataHutang_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvDataHutang.CellFormatting
        For Each row As DataGridViewRow In dgvDataHutang.Rows
            row.DefaultCellStyle.Font = New Font("Arial", 15.0F, GraphicsUnit.Pixel)
            'Jika belum lunas maka berwarna merah
            If row.Cells("statusHutang").Value = "Belum Lunas" Then
                row.DefaultCellStyle.ForeColor = Color.White
                row.DefaultCellStyle.BackColor = Color.Red
                'Jika sudah lunas maka berwarna hijau
            ElseIf row.Cells("statusHutang").Value = "Lunas" Then
                row.DefaultCellStyle.ForeColor = Color.White
                row.DefaultCellStyle.BackColor = Color.Green
            End If
        Next
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        refreshDGVDataHutang()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim statusH = dgvDataHutang.CurrentRow.Cells(5).Value.ToString
            idPeminjam = dgvDataHutang.CurrentRow.Cells(0).Value.ToString
            Dim idH = dgvDataHutang.CurrentRow.Cells(4).Value.ToString
            Dim nominal = Double.Parse(dgvDataHutang.CurrentRow.Cells(6).Value, Globalization.NumberStyles.Currency, Globalization.CultureInfo.CreateSpecificCulture("id-ID"))

            If statusH = "Belum Lunas" Then
                Console.WriteLine("OOOO")
                Dim sqlS = "DELETE FROM detailHutang WHERE idHutang =@1 AND idPenghutang = @2"
                Dim ole = con.CreateCommand
                ole.CommandText = sqlS
                ole.Parameters.Add(New OleDb.OleDbParameter("@1", idH))
                ole.Parameters.Add(New OleDb.OleDbParameter("@2", idPeminjam))
                If ole.ExecuteNonQuery Then
                    getSaldo()
                    ole = con.CreateCommand
                    sqlS = "SELECT totalHutang FROM peminjam WHERE idPenghutang = @1"
                    ole.CommandText = sqlS
                    ole.Parameters.Add(New OleDb.OleDbParameter("@1", idPeminjam))
                    Dim reader = ole.ExecuteReader
                    If reader.Read Then
                        Dim lastTotH = Convert.ToDouble(reader(0)) - nominal
                        updateSaldoDataHutang(saldo, yangDihutangin, nominal, lastTotH)

                    End If
                End If
            Else
                MessageBox.Show("Action Forbidden!", "Dilarang menghapus data yang sudah lunas!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub updateSaldoDataHutang(saldo As Double, yangDihutangin As Double, nominal As Double, lastTotH As Double)
        Try
            Dim saldoSQL = "UPDATE vault set balance = @1 , yangDihutangin = @2"
            Dim ole = con.CreateCommand
            ole.CommandText = saldoSQL
            Dim blanceAkhir = saldo + nominal
            Dim ygDihutanAkhir = yangDihutangin - nominal
            ole.Parameters.Add(New OleDb.OleDbParameter("@1", blanceAkhir))
            ole.Parameters.Add(New OleDb.OleDbParameter("@2", ygDihutanAkhir))
            If ole.ExecuteNonQuery Then
                ole = con.CreateCommand
                saldoSQL = "UPDATE peminjam SET totalHutang = @1 WHERE idPenghutang = @2"
                ole.CommandText = saldoSQL
                ole.Parameters.Add(New OleDb.OleDbParameter("@1", lastTotH))
                ole.Parameters.Add(New OleDb.OleDbParameter("@2", idPeminjam))
                If ole.ExecuteNonQuery Then
                    MsgBox("Success Deleted! dengan ID Hutang " + dgvDataHutang.CurrentRow.Cells(4).Value)
                    clearAll()
                    refreshTabDataHutang()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    'ALL Function FOR tabpage 1 "Bayar Hutang"
    Dim idHutang, idPem, namas, KTPs, statusPembayaran, statusLunas, tanggalTransaksi, tanggalHarusLunas As String
    Dim totalTagihan, totalBunga, bungaBase, extraBunga, nominalPinjam, sisaHutang, bungs As Double

    Private Sub oneSec_Tick(sender As Object, e As EventArgs) Handles oneSec.Tick
        lblTimeNow.Text = Now
    End Sub

    Private Sub refreshBayarHutang()
        inputBayar.Enabled = False
        btnBayar.Enabled = False
        inputBayarIDH.Text = ""
        inputBayarNama.Text = ""
        inputBayarIDKTP.Text = ""
        inputBayar.Text = ""
        lblBayarTglHrsLunas.Text = ""
        lblBayarTglTransaksi.Text = ""
        lblStatusLunas.Text = ""
        lblStatusPembayaran.Text = ""
        lblBayarNominal.Text = ""
        lblBungaBase.Text = ""
        lblExtraBunga.Text = ""
        lblTotalBunga.Text = ""
        lblTotalTagihan.Text = ""

    End Sub

    Private Sub btnBayar_Click(sender As Object, e As EventArgs) Handles btnBayar.Click
        Dim inputBy = Convert.ToDouble(inputBayar.Text)
        If totalTagihan < inputBy Then
            MsgBox("Tidak diperkenankan membayar lebih dari yang ditagihkan!")
        End If
        Try
            Dim idc = util.makeIDCicilan
            Dim insertCicil = "INSERT INTO detailCicilan(idCicilan,idHutang,nominal,tanggalCicilan) VALUES(@1,@2,@3,@4)"
            Dim ole = con.CreateCommand
            ole.CommandText = insertCicil
            ole.Parameters.Add(New OleDb.OleDbParameter("@1", idc))
            ole.Parameters.Add(New OleDb.OleDbParameter("@2", idHutang))
            ole.Parameters.Add(New OleDb.OleDbParameter("@3", inputBy))
            ole.Parameters.Add(New OleDb.OleDbParameter("@4", Now.ToShortDateString))
            If ole.ExecuteNonQuery Then
                getSaldo()
                ole = con.CreateCommand
                Dim sqlS = "SELECT totalHutang FROM peminjam WHERE idPenghutang = @1"
                ole.CommandText = sqlS
                ole.Parameters.Add(New OleDb.OleDbParameter("@1", idPem))
                Dim reader = ole.ExecuteReader
                If reader.Read Then
                    Dim lastTotH = Convert.ToDouble(reader(0)) - inputBy
                    updateSaldos(idHutang, saldo, yangDihutangin, inputBy, lastTotH)
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub inputBayarIDH_KeyDown(sender As Object, e As KeyEventArgs) Handles inputBayarIDH.KeyDown
        If e.KeyCode = Keys.Enter Then
            idHutang = inputBayarIDH.Text
            getSaldo()
            getDetailHutang()
        End If
    End Sub

    Private Sub getDetailHutang()
        Try
            Dim detailHut = "SELECT statusHutang,nominalHutang,sisaHutang,idPenghutang,tanggalTransaksi,tanggalHarusLunas,interest FROM detailHutang WHERE idHutang =@1"
            Dim ole = con.CreateCommand
            ole.CommandText = detailHut
            ole.Parameters.Add(New OleDb.OleDbParameter("@1", idHutang))
            Dim reader = ole.ExecuteReader
            If reader.Read Then
                statusLunas = reader(0)
                nominalPinjam = Convert.ToDouble(reader(1))
                sisaHutang = Convert.ToDouble(reader(2))
                idPem = reader(3)
                tanggalTransaksi = reader(4)
                tanggalHarusLunas = reader(5)
                bungaBase = Convert.ToDouble(reader(6))
                getPeminjam()
            Else
                refreshBayarHutang()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub getPeminjam()
        Try
            Dim peminjamS = "SELECT namaPenghutang,noKTP,totalHutang FROM peminjam WHERE idPenghutang =@1"
            Dim ole = con.CreateCommand
            ole.CommandText = peminjamS
            ole.Parameters.Add(New OleDb.OleDbParameter("@1", idPem))
            Dim reader = ole.ExecuteReader
            If reader.Read Then
                namas = reader(0)
                KTPs = reader(1)
                totalHutang = reader(2)
                inputBayarNama.Text = namas
                inputBayarIDKTP.Text = String.Format("{0} / {1}", idPem, KTPs)
                lblBayarTglTransaksi.Text = tanggalTransaksi
                lblBayarTglHrsLunas.Text = tanggalHarusLunas
                lblStatusLunas.Text = statusLunas
                lblBayarNominal.Text = nominalPinjam.ToString("C", Globalization.CultureInfo.CreateSpecificCulture("id-ID"))
                lblBungaBase.Text = String.Format("{0}%", bungaBase)
                lblExtraBunga.Text = String.Format("{0}%", growedInterest)
                lblBayarSisa.Text = sisaHutang.ToString("C", Globalization.CultureInfo.CreateSpecificCulture("id-ID"))
                If datee.IsDateAfter(Now.ToShortDateString, tanggalHarusLunas) Then
                    lblStatusPembayaran.Text = "TELAT BAYAR"
                Else
                    lblStatusPembayaran.Text = "TEPAT WAKTU"
                End If
                Dim extraBung = growedInterest * datee.Countdifferent2date(tanggalHarusLunas, Now.ToShortDateString)
                If extraBung > 0 Then
                    totalBunga = extraBung + bungaBase
                Else
                    totalBunga = bungaBase
                End If
                bungs = totalBunga / 100 * sisaHutang
                Dim toBung = String.Format("{0}% / {1}", totalBunga, bungs.ToString("C", Globalization.CultureInfo.CreateSpecificCulture("id-ID")))
                lblTotalBunga.Text = toBung
                totalTagihan = sisaHutang + bungs
                lblTotalTagihan.Text = totalTagihan.ToString("C", Globalization.CultureInfo.CreateSpecificCulture("id-ID"))
                inputBayar.Enabled = True
                btnBayar.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub updateSaldos(idHutang As String, saldo As Double, yangDihutangin As Double, nominal As Double, lastTotH As Double)
        Try
            Dim saldoSQL = "UPDATE vault set balance = @1 , yangDihutangin = @2"
            Dim ole = con.CreateCommand
            ole.CommandText = saldoSQL
            Dim blanceAkhir = saldo + nominal
            Dim ygDihutanAkhir = yangDihutangin - nominal + bungs
            ole.Parameters.Add(New OleDb.OleDbParameter("@1", blanceAkhir))
            ole.Parameters.Add(New OleDb.OleDbParameter("@2", ygDihutanAkhir))
            If ole.ExecuteNonQuery Then
                ole = con.CreateCommand
                saldoSQL = "UPDATE peminjam SET totalHutang = @1 WHERE idPenghutang = @2"
                ole.CommandText = saldoSQL
                ole.Parameters.Add(New OleDb.OleDbParameter("@1", lastTotH + bungs))
                ole.Parameters.Add(New OleDb.OleDbParameter("@2", idPem))
                If ole.ExecuteNonQuery Then
                    ole = con.CreateCommand
                    If nominal >= sisaHutang Then
                        saldoSQL = "UPDATE detailHutang SET sisaHutang = @1 , statusHutang = @2,tanggalLunas = @3 WHERE idHutang = @4"
                        ole.Parameters.Add(New OleDb.OleDbParameter("@1", sisaHutang - nominal + bungs))
                        ole.Parameters.Add(New OleDb.OleDbParameter("@2", "Lunas"))
                        ole.Parameters.Add(New OleDb.OleDbParameter("@3", Now.ToShortDateString))
                        ole.Parameters.Add(New OleDb.OleDbParameter("@4", idHutang))

                    ElseIf nominal < sisaHutang Then
                        saldoSQL = "UPDATE detailHutang SET sisaHutang = @1 WHERE idHutang = @2"
                        ole.Parameters.Add(New OleDb.OleDbParameter("@1", sisaHutang - nominal + bungs))
                        ole.Parameters.Add(New OleDb.OleDbParameter("@2", idHutang))
                    End If

                    ole.CommandText = saldoSQL

                    If ole.ExecuteNonQuery Then
                        MsgBox("Success Bayar! dengan ID Hutang " + idHutang)
                        clearAll()
                        refreshBayarHutang()
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class