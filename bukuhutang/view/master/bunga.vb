'Copyright 2020,Davin Alfarizky Putra Basudewa
'https://dvnlabs.ml
'Educational Purposes Only
Public Class bunga
    Dim con As OleDb.OleDbConnection
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim saveOption = "UPDATE vault SET vault.interest = @1, vault.extraInterest = @2"
            Dim ole As OleDb.OleDbCommand = con.CreateCommand
            ole.CommandText = saveOption
            ole.Parameters.Add(New OleDb.OleDbParameter("@1", Convert.ToDouble(inputBungaAwal.Text)))
            ole.Parameters.Add(New OleDb.OleDbParameter("@2", Convert.ToDouble(inputPertumbuhanBunga.Text)))
            If ole.ExecuteNonQuery() Then
                MsgBox("Update Successfully!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub loadData()
        Try
            Dim load = "SELECT vault.interest,vault.extraInterest FROM vault"
            Dim ole As OleDb.OleDbCommand = con.CreateCommand
            ole.CommandText = load
            Dim reader = ole.ExecuteReader
            If reader.Read Then
                inputBungaAwal.Text = reader(0)
                inputPertumbuhanBunga.Text = reader(1)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub bunga_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = connect()
        loadData()
    End Sub
End Class