Imports MySql.Data.MySqlClient

Public Class AddProduct

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

    Public Sub GetProductID()

        Try

            sql = "SELECT `productid` FROM `products` ORDER BY productid desc"
            DbConn()
            cmd = New MySqlCommand(sql, conn)

            Dim number As Integer
            If IsDBNull(cmd.ExecuteScalar) Then

                number = 1000
                txtproductid.Text = number

            Else

                number = cmd.ExecuteScalar + 1
                txtproductid.Text = number

            End If
            cmd.Dispose()
            conn.Close()
            conn.Dispose()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub AddProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetProductID()
        GetCategory()
        GetBrand()

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

        If (txtproductname.Text = "") Then
            Star2.Text = "*"
            MsgBox("Product Name Cannot Be Empty")
        ElseIf (txtbuyingprice.Text = "") Then
            Star3.Text = "*"
            MsgBox("Buying Price Cannot Be Empty")
        ElseIf (txtsellingprice.Text = "") Then
            Star4.Text = "*"
            MsgBox("Selling Price Cannot Be Empty")
        ElseIf (txtquantity.Text = "") Then
            Star5.Text = "*"
            MsgBox("Quantity Cannot Be Empty")
        Else

            Try

                sql = "INSERT INTO `products`(`productid`, `productname`, `productdescription`, `brandname`, `categoryname`, `buyingprice`, `sellingprice`, `quantity`) VALUES (@pid, @pname, @pdescription, @bname, @cname, @bprice, @sprice, @quantity)"
                DbConn()
                cmd = New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@pid", txtproductid.Text)
                cmd.Parameters.AddWithValue("@pname", txtproductname.Text)
                cmd.Parameters.AddWithValue("@pdescription", txtproductdescription.Text)
                cmd.Parameters.AddWithValue("@bname", cbobrandname.SelectedItem)
                cmd.Parameters.AddWithValue("@cname", cbocategoryname.SelectedItem)
                cmd.Parameters.AddWithValue("@bprice", txtbuyingprice.Text)
                cmd.Parameters.AddWithValue("@sprice", txtsellingprice.Text)
                cmd.Parameters.AddWithValue("@quantity", txtquantity.Text)

                Dim i As Integer

                i = cmd.ExecuteNonQuery()

                If (i > 0 = True) Then

                    MsgBox("Item Added Successfully")
                    Me.Hide()
                    Products.Hide()
                    Products.Show()

                Else

                    MsgBox("Unfortunately the item could not be added.Please try again.")

                End If
                cmd.Dispose()
                conn.Close()
                conn.Dispose()

            Catch ex As Exception

                MsgBox(ex.Message)

            End Try

        End If

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click

        Dim products = New Products
        products.Show()
        Me.Hide()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class