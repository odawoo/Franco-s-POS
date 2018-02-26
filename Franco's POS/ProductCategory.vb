Imports MySql.Data.MySqlClient

Public Class ProductCategory

    Sub DataGridPC()

        Try

            sql = "SELECT * FROM productcategory"
            DbConn()

            cmd = New MySqlCommand(sql, conn)
            da = New MySqlDataAdapter
            dtable = New DataTable
            bsrc = New BindingSource

            da.SelectCommand = cmd
            da.Fill(dtable)
            bsrc.DataSource = dtable
            DataGridView1.DataSource = bsrc
            da.Update(dtable)

            cmd.Dispose()
            conn.Close()
            conn.Dispose()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click

        Me.Hide()

    End Sub

    Private Sub Btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click

        Dim CatAdd = New CategoryAdd
        CategoryAdd.Show()

    End Sub

    Private Sub ProductCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridPC()

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Dim row As DataGridViewRow = DataGridView1.CurrentRow

        Try

            txtcatid.Text = row.Cells(0).Value.ToString()
            txtcategoryname.Text = row.Cells(1).Value.ToString()
            txtdescription.Text = row.Cells(2).Value.ToString()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click

        txtcatid.Clear()
        txtcategoryname.Clear()
        txtdescription.Clear()

    End Sub

    Private Sub Btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click

        Try

            sql = "DELETE FROM `productcategory` WHERE categoryid=@catid"
            DbConn()

            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@catid", txtcatid.Text)

            Dim i As Integer

            i = cmd.ExecuteNonQuery()

            If (i > 0 = True) Then

                MsgBox("Successfully Deleted")
                txtcatid.Clear()
                txtcategoryname.Clear()
                txtdescription.Clear()
                DataGridPC()

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

    Private Sub Btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click

        Try

            sql = "UPDATE productcategory SET categoryname=@catname, categorydescription=@catdescription WHERE categoryid=@catid"
            DbConn()

            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@catid", txtcatid.Text)
            cmd.Parameters.AddWithValue("@catname", txtcategoryname.Text)
            cmd.Parameters.AddWithValue("@catdescription", txtdescription.Text)

            Dim i As Integer

            i = cmd.ExecuteNonQuery()

            If (i > 0 = True) Then

                MsgBox("Successfully Updated")
                DataGridPC()

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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged

        Try

            DbConn()
            da = New MySqlDataAdapter("SELECT * FROM `productcategory` WHERE categoryname LIKE '%" & txtsearch.Text & "%'", conn)
            ds = New DataSet
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            txtcatid.Clear()
            txtcategoryname.Clear()
            txtdescription.Clear()

            da.Dispose()
            ds.Dispose()
            conn.Close()
            conn.Dispose()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub DataGridViewProductCategories_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class