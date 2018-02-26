Imports MySql.Data.MySqlClient

Public Class ProductBrand

    Sub DataGridB()

        Try

            sql = "SELECT * FROM productbrand"
            DbConn()

            cmd = New MySqlCommand(sql, conn)
            da = New MySqlDataAdapter
            dtable = New DataTable
            bsrc = New BindingSource

            da.SelectCommand = cmd
            da.Fill(dtable)
            bsrc.DataSource = dtable
            DataGridView2.DataSource = bsrc
            da.Update(dtable)

            cmd.Dispose()
            conn.Close()
            conn.Dispose()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub ProductBrand_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridB()

    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick

        Dim row As DataGridViewRow = DataGridView2.CurrentRow

        Try

            txtbrandid.Text = row.Cells(0).Value.ToString()
            txtbrandname.Text = row.Cells(1).Value.ToString()
            txtdescription.Text = row.Cells(2).Value.ToString()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click

        Dim BrandAdd = New BrandAdd
        BrandAdd.Show()

    End Sub

    Private Sub Btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click

        Try

            sql = "UPDATE productbrand SET brandname=@bname, branddescription=@bdescription WHERE brandid=@bid"
            DbConn()

            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@bid", txtbrandid.Text)
            cmd.Parameters.AddWithValue("@bname", txtbrandname.Text)
            cmd.Parameters.AddWithValue("@bdescription", txtdescription.Text)

            Dim i As Integer

            i = cmd.ExecuteNonQuery()

            If (i > 0 = True) Then

                MsgBox("Successfully Updated")
                DataGridB()


            Else

                MsgBox("Unfortunately the item could not be updated.Please try again.")

            End If
            cmd.Dispose()
            conn.Close()
            conn.Dispose()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click

        txtbrandid.Clear()
        txtbrandname.Clear()
        txtdescription.Clear()

    End Sub

    Private Sub Btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click

        Try

            sql = "DELETE FROM `productbrand` WHERE brandid=@bid"
            DbConn()

            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@bid", txtbrandid.Text)

            Dim i As Integer

            i = cmd.ExecuteNonQuery()

            If (i > 0 = True) Then

                MsgBox("Successfully Deleted")
                txtbrandid.Clear()
                txtbrandname.Clear()
                txtdescription.Clear()
                DataGridB()

            Else

                MsgBox("Unfortunately the item could not be deleted.Please try again.")

            End If
            cmd.Dispose()
            conn.Close()
            conn.Dispose()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged

        Try

            DbConn()
            da = New MySqlDataAdapter("SELECT * FROM `productbrand` WHERE brandname LIKE '%" & txtsearch.Text & "%'", conn)
            ds = New DataSet
            da.Fill(ds)
            DataGridView2.DataSource = ds.Tables(0)
            txtbrandid.Clear()
            txtbrandname.Clear()
            txtdescription.Clear()

            da.Dispose()
            ds.Dispose()
            conn.Close()
            conn.Dispose()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click

        Me.Close()

    End Sub
End Class