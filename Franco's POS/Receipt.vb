Imports MySql.Data.MySqlClient

Public Class Receipt

    Sub DataGridR()

        Try

            sql = "SELECT * FROM receipt"
            DbConn()

            cmd = New MySqlCommand(sql, conn)
            da = New MySqlDataAdapter
            dtable = New DataTable
            bsrc = New BindingSource

            da.SelectCommand = cmd
            da.Fill(dtable)
            bsrc.DataSource = dtable
            DataGridView7.DataSource = bsrc
            da.Update(dtable)

            cmd.Dispose()
            conn.Close()
            conn.Dispose()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Receipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridR()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

        Me.Close()

    End Sub
End Class