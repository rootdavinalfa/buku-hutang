'Copyright 2020,Davin Alfarizky Putra Basudewa
'https://dvnlabs.ml
'Educational Purposes Only
'Global database connection!
Module dbs
    Public Function connect() As OleDb.OleDbConnection
        Try
            Dim con As OleDb.OleDbConnection = New OleDb.OleDbConnection With {
                .ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\bks.accdb;
Persist Security Info=False;"
            }
            con.Open()
            Return con

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error coy !")
            Application.Exit()
        End Try
        Return Nothing
    End Function

End Module
