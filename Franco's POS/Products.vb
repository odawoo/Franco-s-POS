Imports MySql.Data.MySqlClient

Public Class Products

    Sub DataGridP()

        Try

            sql = "SELECT * FROM products"
            DbConn()

            cmd = New MySqlCommand(sql, conn)
            da = New MySqlDataAdapter
            dtable = New DataTable
            bsrc = New BindingSource

            da.SelectCommand = cmd
            da.Fill(dtable)
            bsrc.DataSource = dtable
            DataGridView3.DataSource = bsrc
            da.Update(dtable)

            cmd.Dispose()
            conn.Close()
            conn.Dispose()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub GetBrand()

        Try

            sql = "SELECT * FROM `productbrand`"
            DbConn()
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader

            While dr.Read

                cbobrandname.Items.Add(dr(1).ToString)

            End While
            cmd.Dispose()
            conn.Close()
            conn.Dispose()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub GetCategory()

        Try

            sql = "SELECT * FROM `productcategory`"
            DbConn()
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader

            While dr.Read

                cbocategoryname.Items.Add(dr(1).ToString)


            End While
            cmd.Dispose()
            conn.Close()
            conn.Dispose()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridP()
        GetBrand()
        GetCategory()

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click

        Me.Dispose()
        Dim Main = New MainForm
        Main.Show()

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

        Dim addp = New AddProduct
        addp.Show()

    End Sub

    Private Sub DataGridView3_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellClick

        Dim row As DataGridViewRow = DataGridView3.CurrentRow

        Try

            txtproductid.Text = row.Cells(0).Value.ToString()
            txtproductname.Text = row.Cells(1).Value.ToString()
            txtproductdescription.Text = row.Cells(2).Value.ToString()
            cbobrandname.Text = row.Cells(3).Value.ToString()
            cbocategoryname.Text = row.Cells(4).Value.ToString()
            txtbuyingprice.Text = row.Cells(5).Value.ToString()
            txtsellingprice.Text = row.Cells(6).Value.ToString()
            txtquantity.Text = row.Cells(7).Value.ToString()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click

        txtproductid.Clear()
        txtproductname.Clear()
        txtproductdescription.Clear()
        cbobrandname.ResetText()
        cbocategoryname.ResetText()
        txtbuyingprice.Clear()
        txtsellingprice.Clear()
        txtquantity.Clear()

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click

        Try

            sql = "DELETE FROM `products` WHERE productid=@pid"
            DbConn()

            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@pid", txtproductid.Text)

            Dim i As Integer

            i = cmd.ExecuteNonQuery()

            If (i > 0 = True) Then

                MsgBox("Successfully Deleted")
                txtproductid.Clear()
                txtproductname.Clear()
                txtproductdescription.Clear()
                cbobrandname.ResetText()
                cbocategoryname.ResetText()
                txtbuyingprice.Clear()
                txtsellingprice.Clear()
                txtquantity.Clear()
                DataGridP()

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

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click

        Try

            sql = "UPDATE `products` SET productid=@pid, productname=@pname, productdescription=@pdescription, brandname=@bname, categoryname=@cname, buyingprice=@bprice, sellingprice=@sprice, quantity=@qty WHERE productid=@pid"
            DbConn()
            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@pid", txtproductid.Text)
            cmd.Parameters.AddWithValue("@pname", txtproductname.Text)
            cmd.Parameters.AddWithValue("@pdescription", txtproductdescription.Text)
            cmd.Parameters.AddWithValue("@bname", cbobrandname.SelectedItem)
            cmd.Parameters.AddWithValue("@cname", cbocategoryname.SelectedItem)
            cmd.Parameters.AddWithValue("@bprice", txtbuyingprice.Text)
            cmd.Parameters.AddWithValue("@sprice", txtsellingprice.Text)
            cmd.Parameters.AddWithValue("@qty", txtquantity.Text)

            Dim i As Integer

            i = cmd.ExecuteNonQuery()

            If (i > 0 = True) Then

                Dim POS = New POS_System
                MsgBox("Successfully Updated")
                DataGridP()
                POS.DataGridView4.Update()

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

    Private Sub Txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged

        Try

            DbConn()
            da = New MySqlDataAdapter("SELECT * FROM `products` WHERE productname LIKE '%" & txtsearch.Text & "%'", conn)
            ds = New DataSet
            da.Fill(ds)
            DataGridView3.DataSource = ds.Tables(0)
            txtproductid.Clear()
            txtproductname.Clear()
            txtproductdescription.Clear()
            cbobrandname.ResetText()
            cbocategoryname.ResetText()
            txtbuyingprice.Clear()
            txtsellingprice.Clear()
            txtquantity.Clear()
            DataGridP()

            da.Dispose()
            ds.Dispose()
            conn.Close()
            conn.Dispose()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub
End Class