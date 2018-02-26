Imports MySql.Data.MySqlClient

Public Class BrandAdd

    Public Sub GetBrandID()

        Try

            sql = "SELECT `brandid` FROM `productbrand` ORDER BY brandid desc"
            DbConn()
            cmd = New MySqlCommand(sql, conn)

            Dim number As Integer
            If IsDBNull(cmd.ExecuteScalar) Then

                number = 1000
                txtbrandid.Text = number

            Else

                number = cmd.ExecuteScalar + 1
                txtbrandid.Text = number

            End If
            cmd.Dispose()
            conn.Close()
            conn.Dispose()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click

        If (txtbrandname.Text = "") Then

            star.Text = "*"
            MsgBox("Brand Name Cannot Be Empty")

        Else

            Try

                sql = "INSERT INTO `productbrand`(`brandid`, `brandname`, `branddescription`) VALUES (@bid, @bname, @bdescription)"
                DbConn()
                cmd = New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@bid", txtbrandid.Text)
                cmd.Parameters.AddWithValue("@bname", txtbrandname.Text)
                cmd.Parameters.AddWithValue("@bdescription", txtdescription.Text)

                Dim i As Integer

                i = cmd.ExecuteNonQuery()

                If (i > 0 = True) Then

                    MsgBox("Item Added Successfully")
                    Me.Hide()
                    ProductBrand.Hide()
                    ProductBrand.Show()


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

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click

        Me.Dispose()

    End Sub

    Private Sub BrandAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetBrandID()

    End Sub

    Private Sub txtbrandid_TextChanged(sender As Object, e As EventArgs) Handles txtbrandid.TextChanged

    End Sub
End Class