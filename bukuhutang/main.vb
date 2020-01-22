Public Class main
    Private con As OleDb.OleDbConnection
    Private Sub SettingBungaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingBungaToolStripMenuItem.Click
        bunga.ShowDialog()
    End Sub

    Private Sub PeminjamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PeminjamToolStripMenuItem.Click
        peminjam.ShowDialog()
    End Sub

    Private Sub HutangBaruToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HutangBaruToolStripMenuItem.Click
        pinjaman.ShowDialog()
    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = connect()
        danaDipinjam()
        'Dim util = New utility(con)
        'Console.WriteLine(util.makeIDPeminjam)
    End Sub

    Private Sub danaDipinjam()
        Try
            Dim sqlDipinjam = "SELECT vault.yangDihutangin
                                FROM vault;
                                "
            Dim ole As OleDb.OleDbCommand = con.CreateCommand
            ole.CommandText = sqlDipinjam
            Dim reader = ole.ExecuteReader
            If reader.Read Then
                Console.WriteLine(reader(0).ToString)
                Dim pjm = Convert.ToDouble(reader(0))
                lbl_total_dpinjam.Text = pjm.ToString("C", Globalization.CultureInfo.CreateSpecificCulture("id-ID"))
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub perkiraanKeuntungan()
        Try
            Dim sqlKeuntungan = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub saldoSaatIni()

    End Sub
    Private Sub besarHutang()

    End Sub
End Class
