Imports MySql.Data.MySqlClient

Public Class AllTransactions

    Sub DataGridAT()

        Try

            sql = "SELECT * FROM alltransactions"
            DbConn()

            cmd = New MySqlCommand(sql, conn)
            da = New MySqlDataAdapter
            dtable = New DataTable
            bsrc = New BindingSource

            da.SelectCommand = cmd
            da.Fill(dtable)
            bsrc.DataSource = dtable
            DataGridView6.DataSource = bsrc
            da.Update(dtable)

            cmd.Dispose()
            conn.Close()
            conn.Dispose()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub AllTransactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridAT()

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click

        Me.Hide()
        Dim M = New MainForm
        M.Show()

    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged

        Try

            DbConn()
            da = New MySqlDataAdapter("SELECT * FROM `alltransactions` WHERE transactionid LIKE '%" & txtsearch.Text & "%'", conn)
            ds = New DataSet
            da.Fill(ds)
            DataGridView6.DataSource = ds.Tables(0)

            da.Dispose()
            ds.Dispose()
            conn.Close()
            conn.Dispose()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub DataGridView6_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView6.CellClick

        Dim row As DataGridViewRow = DataGridView6.CurrentRow

        Try

            txttransactionid.Text = row.Cells(1).Value.ToString
            txtproductid.Text = row.Cells(2).Value.ToString()
            txtproductname.Text = row.Cells(3).Value.ToString()
            txtbrandname.Text = row.Cells(4).Value.ToString()
            txtcategoryname.Text = row.Cells(5).Value.ToString()
            txtprice.Text = row.Cells(6).Value.ToString()
            txtqty.Text = row.Cells(7).Value.ToString()
            txtsubtotal.Text = row.Cells(8).Value.ToString()
            txtvat.Text = row.Cells(9).Value.ToString()
            txttotal.Text = row.Cells(10).Value.ToString()
            txtar.Text = row.Cells(11).Value.ToString()
            txtchange.Text = row.Cells(12).Value.ToString()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub
End Class