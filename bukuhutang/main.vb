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
            Dim sqlDipinjam = "SELECT vault.yangDihutangin,vault.balance,vault.interest,vault.extraInterest
                                FROM vault;
                                "
            Dim ole As OleDb.OleDbCommand = con.CreateCommand
            ole.CommandText = sqlDipinjam
            Dim reader = ole.ExecuteReader
            If reader.Read Then
                Console.WriteLine(reader(0).ToString)
                Dim pjm = Convert.ToDouble(reader(0))
                Dim sald = Convert.ToDouble(reader(1))
                Dim lbl2 = String.Format("Perkiraan Keuntungan dari bunga {0}% 
Dengan pertumbuhan {1}% jika tidak lunas saat jatuh tempo!", reader(2), reader(3))
                Label2.Text = lbl2
                lbl_total_dpinjam.Text = pjm.ToString("C", Globalization.CultureInfo.CreateSpecificCulture("id-ID"))
                lbl_saldo_now.Text = sald.ToString("C", Globalization.CultureInfo.CreateSpecificCulture("id-ID"))
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
    Private Sub TigasbesarHutang()

    End Sub
End Class
