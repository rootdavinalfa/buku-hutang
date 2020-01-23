'Copyright 2020,Davin Alfarizky Putra Basudewa
'https://dvnlabs.ml
'Educational Purposes Only
'Custom ID Generator for this project
'By Davin Alfarizky Putra Basudewa
Public Class utility
    Dim con As OleDb.OleDbConnection
    Public Sub New(cons As OleDb.OleDbConnection)
        con = cons
    End Sub
    Public Function makeIDPeminjam() As String
        Try
            Dim ids = String.Format("{0}{1}{2}{3}", "P", make2DYear, make2DMonth, randomNum)
            Dim ds = New DataSet
            Dim checkID = "SELECT peminjam.idPenghutang
                        FROM peminjam
                        WHERE (((peminjam.idPenghutang)=@1));
                        "
            Dim ole = con.CreateCommand
            ole.CommandText = checkID
            ole.Parameters.Add(New OleDb.OleDbParameter("@1", ids))
            Dim reader = ole.ExecuteReader
            If reader.Read Then
                If reader.FieldCount <> 0 Then
                    makeIDPeminjam()
                End If
            Else
                Return ids
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Public Function makeIDHutang() As String
        Try
            Dim ids = String.Format("{0}{1}{2}{3}", "H", make2DYear, make2DMonth, randomNum)
            Dim ds = New DataSet
            Dim checkID = "SELECT peminjam.idPenghutang
                        FROM peminjam
                        WHERE (((peminjam.idPenghutang)=@1));
                        "
            Dim ole = con.CreateCommand
            ole.CommandText = checkID
            ole.Parameters.Add(New OleDb.OleDbParameter("@1", ids))
            Dim reader = ole.ExecuteReader
            If reader.Read Then
                If reader.FieldCount <> 0 Then
                    makeIDPeminjam()
                End If
            Else
                Return ids
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Public Function makeIDCicilan() As String
        Try
            Dim ids = String.Format("{0}{1}{2}{3}", "C", make2DYear, make2DMonth, randomNum)
            Dim ds = New DataSet
            Dim checkID = "SELECT peminjam.idPenghutang
                        FROM peminjam
                        WHERE (((peminjam.idPenghutang)=@1));
                        "
            Dim ole = con.CreateCommand
            ole.CommandText = checkID
            ole.Parameters.Add(New OleDb.OleDbParameter("@1", ids))
            Dim reader = ole.ExecuteReader
            If reader.Read Then
                If reader.FieldCount <> 0 Then
                    makeIDPeminjam()
                End If
            Else
                Return ids
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function


    Private Function make2DYear() As String
        Return Now.ToString("yy")
    End Function

    Private Function make2DMonth() As String
        Return Now.ToString("MM")
    End Function
    Private Function randomNum() As String
        Dim random = New System.Random
        Dim num = random.Next(1, 9999)
        Return num.ToString
    End Function
End Class
