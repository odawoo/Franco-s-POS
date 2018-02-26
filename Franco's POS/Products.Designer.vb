<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Products
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.txtproductname = New System.Windows.Forms.TextBox()
        Me.txtproductid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtproductdescription = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbocategoryname = New System.Windows.Forms.ComboBox()
        Me.cbobrandname = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtquantity = New System.Windows.Forms.TextBox()
        Me.txtsellingprice = New System.Windows.Forms.TextBox()
        Me.txtbuyingprice = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe Print", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(12, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(151, 51)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Products"
        '
        'DataGridView3
        '
        Me.DataGridView3.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(277, 348)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(1046, 375)
        Me.DataGridView3.TabIndex = 25
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(20, 478)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(213, 30)
        Me.txtsearch.TabIndex = 28
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Image = Global.Franco_s_POS.My.Resources.Resources.if_icon_111_search_314478
        Me.Label11.Location = New System.Drawing.Point(97, 442)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 23)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Search"
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.White
        Me.btnclear.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Image = Global.Franco_s_POS.My.Resources.Resources.if_Clear_2134648
        Me.btnclear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclear.Location = New System.Drawing.Point(1236, 192)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(119, 35)
        Me.btnclear.TabIndex = 27
        Me.btnclear.Text = "CLEAR"
        Me.btnclear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.Color.White
        Me.BtnBack.BackgroundImage = Global.Franco_s_POS.My.Resources.Resources.icons8_go_back_50
        Me.BtnBack.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBack.Location = New System.Drawing.Point(1204, 9)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(151, 51)
        Me.BtnBack.TabIndex = 26
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.White
        Me.BtnDelete.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.Image = Global.Franco_s_POS.My.Resources.Resources.if_Streamline_70_185090__2_
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(1102, 241)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(119, 37)
        Me.BtnDelete.TabIndex = 23
        Me.BtnDelete.Text = "DELETE"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.White
        Me.BtnUpdate.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.Image = Global.Franco_s_POS.My.Resources.Resources.if_update_172618
        Me.BtnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUpdate.Location = New System.Drawing.Point(1102, 139)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(119, 37)
        Me.BtnUpdate.TabIndex = 22
        Me.BtnUpdate.Text = "UPDATE"
        Me.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.White
        Me.BtnAdd.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.Image = Global.Franco_s_POS.My.Resources.Resources.if_basics_15_296819
        Me.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdd.Location = New System.Drawing.Point(974, 191)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(119, 37)
        Me.BtnAdd.TabIndex = 21
        Me.BtnAdd.Text = "ADD"
        Me.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'txtproductname
        '
        Me.txtproductname.Location = New System.Drawing.Point(210, 177)
        Me.txtproductname.Name = "txtproductname"
        Me.txtproductname.Size = New System.Drawing.Size(194, 30)
        Me.txtproductname.TabIndex = 35
        '
        'txtproductid
        '
        Me.txtproductid.BackColor = System.Drawing.Color.White
        Me.txtproductid.Location = New System.Drawing.Point(210, 103)
        Me.txtproductid.Name = "txtproductid"
        Me.txtproductid.ReadOnly = True
        Me.txtproductid.Size = New System.Drawing.Size(194, 30)
        Me.txtproductid.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 179)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 26)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Product Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 104)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 26)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Product ID"
        '
        'txtproductdescription
        '
        Me.txtproductdescription.Location = New System.Drawing.Point(210, 235)
        Me.txtproductdescription.Multiline = True
        Me.txtproductdescription.Name = "txtproductdescription"
        Me.txtproductdescription.Size = New System.Drawing.Size(194, 78)
        Me.txtproductdescription.TabIndex = 37
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 265)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 26)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Product Description"
        '
        'cbocategoryname
        '
        Me.cbocategoryname.FormattingEnabled = True
        Me.cbocategoryname.Location = New System.Drawing.Point(701, 142)
        Me.cbocategoryname.Name = "cbocategoryname"
        Me.cbocategoryname.Size = New System.Drawing.Size(194, 31)
        Me.cbocategoryname.TabIndex = 42
        '
        'cbobrandname
        '
        Me.cbobrandname.FormattingEnabled = True
        Me.cbobrandname.Location = New System.Drawing.Point(701, 97)
        Me.cbobrandname.Name = "cbobrandname"
        Me.cbobrandname.Size = New System.Drawing.Size(194, 31)
        Me.cbobrandname.TabIndex = 41
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(506, 143)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 26)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Category Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(506, 97)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 26)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Brand Name"
        '
        'txtquantity
        '
        Me.txtquantity.Location = New System.Drawing.Point(701, 283)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Size = New System.Drawing.Size(194, 30)
        Me.txtquantity.TabIndex = 43
        '
        'txtsellingprice
        '
        Me.txtsellingprice.Location = New System.Drawing.Point(701, 237)
        Me.txtsellingprice.Name = "txtsellingprice"
        Me.txtsellingprice.Size = New System.Drawing.Size(194, 30)
        Me.txtsellingprice.TabIndex = 42
        '
        'txtbuyingprice
        '
        Me.txtbuyingprice.Location = New System.Drawing.Point(701, 189)
        Me.txtbuyingprice.Name = "txtbuyingprice"
        Me.txtbuyingprice.Size = New System.Drawing.Size(194, 30)
        Me.txtbuyingprice.TabIndex = 41
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(503, 283)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 26)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Quantity"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(506, 239)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 26)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Selling Price"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(503, 190)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 26)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Buying Price"
        '
        'Products
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = Global.Franco_s_POS.My.Resources.Resources.Capture6
        Me.ClientSize = New System.Drawing.Size(1366, 735)
        Me.Controls.Add(Me.cbocategoryname)
        Me.Controls.Add(Me.txtquantity)
        Me.Controls.Add(Me.cbobrandname)
        Me.Controls.Add(Me.txtsellingprice)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtbuyingprice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtproductdescription)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtproductname)
        Me.Controls.Add(Me.txtproductid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnAdd)
        Me.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Products"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Products"
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents BtnBack As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents txtproductname As TextBox
    Friend WithEvents txtproductid As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtproductdescription As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbocategoryname As ComboBox
    Friend WithEvents cbobrandname As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtquantity As TextBox
    Friend WithEvents txtsellingprice As TextBox
    Friend WithEvents txtbuyingprice As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
End Class
