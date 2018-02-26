Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Login = New Login
        Login.Show()
        Me.Hide()

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub lblx_Click(sender As Object, e As EventArgs) Handles lblx.Click

        Application.Exit()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles pPOSSystem.Click

        Dim possystem = New POS_System With {.MdiParent = Me}
        POS_System.Show()
        Panel2.Hide()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblpossystem.Click

        Dim possystem = New POS_System With {.MdiParent = Me}
        POS_System.Show()
        Panel2.Hide()

    End Sub

    Private Sub pProducts_Click(sender As Object, e As EventArgs) Handles pProducts.Click

        Dim Products = New Products With {.MdiParent = Me}
        Products.Show()
        Panel2.Hide()

    End Sub

    Private Sub Products_Click(sender As Object, e As EventArgs) Handles Products.Click

        Dim Products = New Products With {.MdiParent = Me}
        Products.Show()
        Panel2.Hide()

    End Sub

    Private Sub pCategories_Click(sender As Object, e As EventArgs) Handles pCategories.Click

        Dim ProductCategory = New ProductCategory With {.MdiParent = Me}
        ProductCategory.Show()

    End Sub

    Private Sub Categories_Click(sender As Object, e As EventArgs) Handles Categories.Click

        Dim ProductCategory = New ProductCategory With {.MdiParent = Me}
        ProductCategory.Show()

    End Sub

    Private Sub pBrands_Click(sender As Object, e As EventArgs) Handles pBrands.Click

        Dim PBrand = New ProductBrand With {.MdiParent = Me}
        PBrand.Show()

    End Sub

    Private Sub Brands_Click(sender As Object, e As EventArgs) Handles Brands.Click

        Dim ProductBrand = New ProductBrand With {.MdiParent = Me}
        ProductBrand.Show()

    End Sub

    Private Sub BtnAllTransactions_Click(sender As Object, e As EventArgs) Handles BtnAllTransactions.Click

        Dim AT = New AllTransactions With {.MdiParent = Me}
        AT.Show()

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)



    End Sub
End Class