Public Class peminjam
    Dim con As OleDb.OleDbConnection
    Dim util As utility
    Private Sub peminjam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = connect()
        util = New utility(con)
        refreshField()
    End Sub

    Private Sub refreshField()
        inputKTP.Text = ""
        inputNama.Text = ""
        inputAlamat.Text = ""
        inputTelepon.Text = ""
        inputFind.Text = ""
        lblIDPeminjam.Text = util.makeIDPeminjam
        findData()
    End Sub

    Private Sub initDGV()
        dgvDataPeminjam.Columns.Clear()
        dgvDataPeminjam.Rows.Clear()
        dgvDataPeminjam.Columns.Add("id", "ID")
        dgvDataPeminjam.Columns.Add("ktp", "KTP")
        dgvDataPeminjam.Columns.Add("nama", "Nama Peminjam")
    End Sub
    Private Sub findData()
        Try
            initDGV()
            Dim ds = New DataSet
            Dim findText = inputFind.Text
            Dim showData As String
            Dim ole = con.CreateCommand
            If findText = "" Then
                showData = "SELECT peminjam.idPenghutang, peminjam.noKTP, peminjam.namaPenghutang
                        FROM peminjam
                        "
            Else
                showData = "SELECT peminjam.idPenghutang, peminjam.noKTP, peminjam.namaPenghutang
                        FROM peminjam
                        WHERE (((peminjam.idPenghutang)=@1) OR ((peminjam.noKTP)=@2));
                        "
                ole.Parameters.Add(New OleDb.OleDbParameter("@1", findText))
                ole.Parameters.Add(New OleDb.OleDbParameter("@2", findText))
            End If


            ole.CommandText = showData
            Dim da As New OleDb.OleDbDataAdapter(ole)
            da.Fill(ds)
            For i = 0 To ds.Tables(0).Rows.Count - 1
                Dim id = ds.Tables(0).Rows(i).Item(0)
                Dim ktp = ds.Tables(0).Rows(i).Item(1)
                Dim nama = ds.Tables(0).Rows(i).Item(2)

                dgvDataPeminjam.Rows.Add(id, ktp, nama)
            Next
            dgvDataPeminjam.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnBuat_Click(sender As Object, e As EventArgs) Handles btnBuat.Click
        Dim id = lblIDPeminjam.Text
        Dim nama = inputNama.Text
        Dim ktp = inputKTP.Text
        Dim alamat = inputAlamat.Text
        Dim telepon = inputTelepon.Text
        If nama = "" Or ktp = "" Or alamat = "" Or telepon = "" Then
            MsgBox("Isi Field!")
        Else
            Try
                Dim createPeminjam = "INSERT INTO peminjam(idPenghutang,namaPenghutang,noKTP,alamat,nomorTelepon) 
                                   VALUES(@1,@2,@3,@4,@5)"
                Dim ole = con.CreateCommand
                ole.CommandText = createPeminjam
                ole.Parameters.Add(New OleDb.OleDbParameter("@1", id))
                ole.Parameters.Add(New OleDb.OleDbParameter("@2", nama))
                ole.Parameters.Add(New OleDb.OleDbParameter("@3", ktp))
                ole.Parameters.Add(New OleDb.OleDbParameter("@4", alamat))
                ole.Parameters.Add(New OleDb.OleDbParameter("@5", telepon))
                If ole.ExecuteNonQuery Then
                    MsgBox("Success!")
                    refreshField()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        findData()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            For Each dgr As DataGridViewRow In dgvDataPeminjam.Rows
                If Not dgr.IsNewRow Then
                    'This query is fast fix bug for 1909 Office 2016 Access bug.Please consider to changing back
                    'to default query when bugs is fixed
                    Dim sql = "UPDATE peminjam SET namaPenghutang=@1,noKTP = @2 WHERE idPenghutang = @3 OR noKTP = @4;"
                    Dim ole = con.CreateCommand()
                    ole.CommandText = sql
                    ole.Parameters.Add(New OleDb.OleDbParameter("@1", dgr.Cells(2).Value.ToString))
                    ole.Parameters.Add(New OleDb.OleDbParameter("@2", dgr.Cells(1).Value.ToString))
                    ole.Parameters.Add(New OleDb.OleDbParameter("@3", dgr.Cells(0).Value.ToString))
                    ole.Parameters.Add(New OleDb.OleDbParameter("@4", dgr.Cells(1).Value.ToString))
                    ole.ExecuteNonQuery()
                End If
            Next
            MessageBox.Show("Data Updated!")
            refreshField()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim sql = "DELETE FROM peminjam WHERE idPenghutang = @1 AND noKTP=@2"
            Dim ole = con.CreateCommand
            ole.CommandText = sql
            ole.Parameters.Add(New OleDb.OleDbParameter("@1", dgvDataPeminjam.CurrentRow.Cells(0).Value))
            ole.Parameters.Add(New OleDb.OleDbParameter("@1", dgvDataPeminjam.CurrentRow.Cells(1).Value))
            If ole.ExecuteNonQuery Then
                MsgBox("Berhasil Delete")
                refreshField()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class