Imports MySql.Data.MySqlClient

Module DbConnection

    Public sql As String
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public dtable As DataTable
    Public bsrc As BindingSource
    Public ds As DataSet


    Public Sub DbConn()

        Try

            conn = New MySqlConnection("server=localhost; database=franco's; username=root; password=;")
            conn.Open()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

End Module
