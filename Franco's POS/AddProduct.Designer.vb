<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProduct
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbocategoryname = New System.Windows.Forms.ComboBox()
        Me.cbobrandname = New System.Windows.Forms.ComboBox()
        Me.txtproductdescription = New System.Windows.Forms.TextBox()
        Me.txtproductname = New System.Windows.Forms.TextBox()
        Me.txtproductid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtquantity = New System.Windows.Forms.TextBox()
        Me.txtsellingprice = New System.Windows.Forms.TextBox()
        Me.txtbuyingprice = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Star2 = New System.Windows.Forms.Label()
        Me.Star3 = New System.Windows.Forms.Label()
        Me.Star4 = New System.Windows.Forms.Label()
        Me.Star5 = New System.Windows.Forms.Label()
        Me.Star6 = New System.Windows.Forms.Label()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ADD PRODUCT"
        '
        'cbocategoryname
        '
        Me.cbocategoryname.FormattingEnabled = True
        Me.cbocategoryname.Location = New System.Drawing.Point(211, 375)
        Me.cbocategoryname.Name = "cbocategoryname"
        Me.cbocategoryname.Size = New System.Drawing.Size(194, 34)
        Me.cbocategoryname.TabIndex = 30
        '
        'cbobrandname
        '
        Me.cbobrandname.FormattingEnabled = True
        Me.cbobrandname.Location = New System.Drawing.Point(211, 320)
        Me.cbobrandname.Name = "cbobrandname"
        Me.cbobrandname.Size = New System.Drawing.Size(194, 34)
        Me.cbobrandname.TabIndex = 29
        '
        'txtproductdescription
        '
        Me.txtproductdescription.Location = New System.Drawing.Point(211, 226)
        Me.txtproductdescription.Multiline = True
        Me.txtproductdescription.Name = "txtproductdescription"
        Me.txtproductdescription.Size = New System.Drawing.Size(194, 79)
        Me.txtproductdescription.TabIndex = 28
        '
        'txtproductname
        '
        Me.txtproductname.Location = New System.Drawing.Point(211, 179)
        Me.txtproductname.Name = "txtproductname"
        Me.txtproductname.Size = New System.Drawing.Size(194, 34)
        Me.txtproductname.TabIndex = 27
        '
        'txtproductid
        '
        Me.txtproductid.BackColor = System.Drawing.Color.White
        Me.txtproductid.Location = New System.Drawing.Point(211, 120)
        Me.txtproductid.Name = "txtproductid"
        Me.txtproductid.ReadOnly = True
        Me.txtproductid.Size = New System.Drawing.Size(194, 34)
        Me.txtproductid.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 376)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 26)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Category Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 321)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 26)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Brand Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 255)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 26)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Product Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 180)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 26)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Product Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 121)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 26)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Product ID"
        '
        'txtquantity
        '
        Me.txtquantity.Location = New System.Drawing.Point(649, 278)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Size = New System.Drawing.Size(194, 34)
        Me.txtquantity.TabIndex = 37
        '
        'txtsellingprice
        '
        Me.txtsellingprice.Location = New System.Drawing.Point(649, 221)
        Me.txtsellingprice.Name = "txtsellingprice"
        Me.txtsellingprice.Size = New System.Drawing.Size(194, 34)
        Me.txtsellingprice.TabIndex = 36
        '
        'txtbuyingprice
        '
        Me.txtbuyingprice.Location = New System.Drawing.Point(649, 167)
        Me.txtbuyingprice.Name = "txtbuyingprice"
        Me.txtbuyingprice.Size = New System.Drawing.Size(194, 34)
        Me.txtbuyingprice.TabIndex = 35
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(457, 281)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 26)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Quantity"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(457, 224)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 26)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Selling Price"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(457, 170)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 26)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Buying Price"
        '
        'Star2
        '
        Me.Star2.AutoSize = True
        Me.Star2.ForeColor = System.Drawing.Color.Red
        Me.Star2.Location = New System.Drawing.Point(411, 187)
        Me.Star2.Name = "Star2"
        Me.Star2.Size = New System.Drawing.Size(0, 26)
        Me.Star2.TabIndex = 43
        '
        'Star3
        '
        Me.Star3.AutoSize = True
        Me.Star3.ForeColor = System.Drawing.Color.Red
        Me.Star3.Location = New System.Drawing.Point(843, 118)
        Me.Star3.Name = "Star3"
        Me.Star3.Size = New System.Drawing.Size(0, 26)
        Me.Star3.TabIndex = 44
        '
        'Star4
        '
        Me.Star4.AutoSize = True
        Me.Star4.ForeColor = System.Drawing.Color.Red
        Me.Star4.Location = New System.Drawing.Point(843, 172)
        Me.Star4.Name = "Star4"
        Me.Star4.Size = New System.Drawing.Size(0, 26)
        Me.Star4.TabIndex = 45
        '
        'Star5
        '
        Me.Star5.AutoSize = True
        Me.Star5.ForeColor = System.Drawing.Color.Red
        Me.Star5.Location = New System.Drawing.Point(843, 232)
        Me.Star5.Name = "Star5"
        Me.Star5.Size = New System.Drawing.Size(0, 26)
        Me.Star5.TabIndex = 46
        '
        'Star6
        '
        Me.Star6.AutoSize = True
        Me.Star6.ForeColor = System.Drawing.Color.Red
        Me.Star6.Location = New System.Drawing.Point(843, 281)
        Me.Star6.Name = "Star6"
        Me.Star6.Size = New System.Drawing.Size(0, 26)
        Me.Star6.TabIndex = 47
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.White
        Me.BtnAdd.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.Image = Global.Franco_s_POS.My.Resources.Resources.if_basics_15_296819
        Me.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdd.Location = New System.Drawing.Point(558, 386)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(119, 37)
        Me.BtnAdd.TabIndex = 40
        Me.BtnAdd.Text = "ADD"
        Me.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.Color.White
        Me.BtnBack.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBack.Location = New System.Drawing.Point(724, 386)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(119, 37)
        Me.BtnBack.TabIndex = 39
        Me.BtnBack.Text = "BACK"
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Franco_s_POS.My.Resources.Resources.Capture5
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Location = New System.Drawing.Point(543, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(363, 91)
        Me.Panel1.TabIndex = 50
        '
        'AddProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(918, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Star6)
        Me.Controls.Add(Me.Star5)
        Me.Controls.Add(Me.Star4)
        Me.Controls.Add(Me.Star3)
        Me.Controls.Add(Me.Star2)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.txtquantity)
        Me.Controls.Add(Me.txtsellingprice)
        Me.Controls.Add(Me.txtbuyingprice)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbocategoryname)
        Me.Controls.Add(Me.cbobrandname)
        Me.Controls.Add(Me.txtproductdescription)
        Me.Controls.Add(Me.txtproductname)
        Me.Controls.Add(Me.txtproductid)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "AddProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddProduct"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbocategoryname As ComboBox
    Friend WithEvents cbobrandname As ComboBox
    Friend WithEvents txtproductdescription As TextBox
    Friend WithEvents txtproductname As TextBox
    Friend WithEvents txtproductid As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtquantity As TextBox
    Friend WithEvents txtsellingprice As TextBox
    Friend WithEvents txtbuyingprice As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents Star2 As Label
    Friend WithEvents Star3 As Label
    Friend WithEvents Star4 As Label
    Friend WithEvents Star5 As Label
    Friend WithEvents Star6 As Label
    Friend WithEvents Panel1 As Panel
End Class
