Imports MySql.Data.MySqlClient

Public Class CategoryAdd

    Public Sub GetCatID()

        Try

            sql = "SELECT `categoryid` FROM `productcategory` ORDER BY categoryid desc"
            DbConn()
            cmd = New MySqlCommand(sql, conn)

            Dim number As Integer
            If IsDBNull(cmd.ExecuteScalar) Then

                number = 1000
                txtcatid.Text = number

            Else

                number = cmd.ExecuteScalar + 1
                txtcatid.Text = number

            End If
            cmd.Dispose()
            conn.Close()
            conn.Dispose()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub CategoryAdd_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs)

        Me.Dispose()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click

        If (txtcategoryname.Text = "") Then

            star.Text = "*"
            MsgBox("Category Name Cannot Be Empty")

        Else

            Try

                sql = "INSERT INTO `productcategory`(`categoryid`, `categoryname`, `categorydescription`) VALUES (@catid, @catname, @catdescription)"
                DbConn()
                cmd = New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@catid", txtcatid.Text)
                cmd.Parameters.AddWithValue("@catname", txtcategoryname.Text)
                cmd.Parameters.AddWithValue("@catdescription", txtdescription.Text)

                Dim i As Integer

                i = cmd.ExecuteNonQuery()

                If (i > 0 = True) Then

                    ProductCategory.Refresh()
                    MsgBox("Item Added Successfully")
                    Me.Hide()
                    ProductCategory.Hide()
                    ProductCategory.Show()

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

    Private Sub CategoryAdd_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

        GetCatID()

    End Sub

    Private Sub txtcategoryname_TextChanged(sender As Object, e As EventArgs) Handles txtcategoryname.TextChanged

    End Sub

    Private Sub btnback_Click_1(sender As Object, e As EventArgs) Handles btnback.Click

        Me.Hide()

    End Sub

    Private Sub txtcatid_TextChanged(sender As Object, e As EventArgs) Handles txtcatid.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub star_Click(sender As Object, e As EventArgs) Handles star.Click

    End Sub

    Private Sub txtdescription_TextChanged(sender As Object, e As EventArgs) Handles txtdescription.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class