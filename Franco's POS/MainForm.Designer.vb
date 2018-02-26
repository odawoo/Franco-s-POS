<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbllastname = New System.Windows.Forms.Label()
        Me.lblempid = New System.Windows.Forms.Label()
        Me.lblx = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnAllTransactions = New System.Windows.Forms.Button()
        Me.lblpossystem = New System.Windows.Forms.Label()
        Me.pPOSSystem = New System.Windows.Forms.PictureBox()
        Me.Brands = New System.Windows.Forms.Label()
        Me.Categories = New System.Windows.Forms.Label()
        Me.Products = New System.Windows.Forms.Label()
        Me.pBrands = New System.Windows.Forms.PictureBox()
        Me.pCategories = New System.Windows.Forms.PictureBox()
        Me.pProducts = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        CType(Me.pPOSSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pBrands, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbllastname
        '
        Me.lbllastname.AutoSize = True
        Me.lbllastname.BackColor = System.Drawing.Color.Transparent
        Me.lbllastname.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllastname.Location = New System.Drawing.Point(1158, 39)
        Me.lbllastname.Name = "lbllastname"
        Me.lbllastname.Size = New System.Drawing.Size(84, 28)
        Me.lbllastname.TabIndex = 0
        Me.lbllastname.Text = "lastname"
        '
        'lblempid
        '
        Me.lblempid.AutoSize = True
        Me.lblempid.BackColor = System.Drawing.Color.Transparent
        Me.lblempid.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblempid.Location = New System.Drawing.Point(1074, 39)
        Me.lblempid.Name = "lblempid"
        Me.lblempid.Size = New System.Drawing.Size(62, 28)
        Me.lblempid.TabIndex = 1
        Me.lblempid.Text = "empid"
        '
        'lblx
        '
        Me.lblx.AutoSize = True
        Me.lblx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblx.Location = New System.Drawing.Point(1341, 10)
        Me.lblx.Name = "lblx"
        Me.lblx.Size = New System.Drawing.Size(22, 25)
        Me.lblx.TabIndex = 2
        Me.lblx.Text = "X"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(1248, 39)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 28)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Logout"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtnAllTransactions)
        Me.Panel2.Controls.Add(Me.lblpossystem)
        Me.Panel2.Controls.Add(Me.pPOSSystem)
        Me.Panel2.Controls.Add(Me.Brands)
        Me.Panel2.Controls.Add(Me.Categories)
        Me.Panel2.Controls.Add(Me.Products)
        Me.Panel2.Controls.Add(Me.pBrands)
        Me.Panel2.Controls.Add(Me.pCategories)
        Me.Panel2.Controls.Add(Me.pProducts)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.lblx)
        Me.Panel2.Controls.Add(Me.lblempid)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.lbllastname)
        Me.Panel2.Location = New System.Drawing.Point(1, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1366, 100)
        Me.Panel2.TabIndex = 4
        '
        'BtnAllTransactions
        '
        Me.BtnAllTransactions.BackColor = System.Drawing.Color.White
        Me.BtnAllTransactions.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAllTransactions.Location = New System.Drawing.Point(999, 36)
        Me.BtnAllTransactions.Name = "BtnAllTransactions"
        Me.BtnAllTransactions.Size = New System.Drawing.Size(57, 28)
        Me.BtnAllTransactions.TabIndex = 12
        Me.BtnAllTransactions.Text = "A.T"
        Me.BtnAllTransactions.UseVisualStyleBackColor = False
        '
        'lblpossystem
        '
        Me.lblpossystem.AutoSize = True
        Me.lblpossystem.Location = New System.Drawing.Point(861, 42)
        Me.lblpossystem.Name = "lblpossystem"
        Me.lblpossystem.Size = New System.Drawing.Size(89, 23)
        Me.lblpossystem.TabIndex = 11
        Me.lblpossystem.Text = "POS System"
        '
        'pPOSSystem
        '
        Me.pPOSSystem.BackgroundImage = Global.Franco_s_POS.My.Resources.Resources.if_cart_1814095
        Me.pPOSSystem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pPOSSystem.Location = New System.Drawing.Point(790, 11)
        Me.pPOSSystem.Name = "pPOSSystem"
        Me.pPOSSystem.Size = New System.Drawing.Size(65, 65)
        Me.pPOSSystem.TabIndex = 10
        Me.pPOSSystem.TabStop = False
        '
        'Brands
        '
        Me.Brands.AutoSize = True
        Me.Brands.Location = New System.Drawing.Point(700, 42)
        Me.Brands.Name = "Brands"
        Me.Brands.Size = New System.Drawing.Size(58, 23)
        Me.Brands.TabIndex = 9
        Me.Brands.Text = "Brands"
        '
        'Categories
        '
        Me.Categories.AutoSize = True
        Me.Categories.Location = New System.Drawing.Point(529, 38)
        Me.Categories.Name = "Categories"
        Me.Categories.Size = New System.Drawing.Size(77, 23)
        Me.Categories.TabIndex = 8
        Me.Categories.Text = "Categories"
        '
        'Products
        '
        Me.Products.AutoSize = True
        Me.Products.Location = New System.Drawing.Point(360, 38)
        Me.Products.Name = "Products"
        Me.Products.Size = New System.Drawing.Size(68, 23)
        Me.Products.TabIndex = 7
        Me.Products.Text = "Products"
        '
        'pBrands
        '
        Me.pBrands.BackgroundImage = Global.Franco_s_POS.My.Resources.Resources.if_price_tag_172526
        Me.pBrands.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pBrands.Location = New System.Drawing.Point(629, 11)
        Me.pBrands.Name = "pBrands"
        Me.pBrands.Size = New System.Drawing.Size(65, 65)
        Me.pBrands.TabIndex = 6
        Me.pBrands.TabStop = False
        '
        'pCategories
        '
        Me.pCategories.BackgroundImage = Global.Franco_s_POS.My.Resources.Resources.icons8_categorize_filled_50
        Me.pCategories.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pCategories.Location = New System.Drawing.Point(458, 10)
        Me.pCategories.Name = "pCategories"
        Me.pCategories.Size = New System.Drawing.Size(65, 65)
        Me.pCategories.TabIndex = 5
        Me.pCategories.TabStop = False
        '
        'pProducts
        '
        Me.pProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pProducts.Image = Global.Franco_s_POS.My.Resources.Resources.if_categories_465051
        Me.pProducts.Location = New System.Drawing.Point(289, 10)
        Me.pProducts.Name = "pProducts"
        Me.pProducts.Size = New System.Drawing.Size(65, 65)
        Me.pProducts.TabIndex = 4
        Me.pProducts.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Franco_s_POS.My.Resources.Resources.Capture5
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(3, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(249, 87)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Franco_s_POS.My.Resources.Resources.Capture6
        Me.ClientSize = New System.Drawing.Size(1366, 735)
        Me.Controls.Add(Me.Panel2)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pPOSSystem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pBrands, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pCategories, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbllastname As Label
    Friend WithEvents lblempid As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lblx As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Brands As Label
    Friend WithEvents Categories As Label
    Friend WithEvents Products As Label
    Friend WithEvents pBrands As PictureBox
    Friend WithEvents pCategories As PictureBox
    Friend WithEvents pProducts As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblpossystem As Label
    Friend WithEvents pPOSSystem As PictureBox
    Friend WithEvents BtnAllTransactions As Button
End Class
