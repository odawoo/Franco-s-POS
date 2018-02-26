<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AllTransactions
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
        Me.DataGridView6 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.txtproductname = New System.Windows.Forms.TextBox()
        Me.txtproductid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcategoryname = New System.Windows.Forms.TextBox()
        Me.txtbrandname = New System.Windows.Forms.TextBox()
        Me.txttransactionid = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtsubtotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtchange = New System.Windows.Forms.TextBox()
        Me.txtar = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txtvat = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView6
        '
        Me.DataGridView6.AllowUserToAddRows = False
        Me.DataGridView6.AllowUserToDeleteRows = False
        Me.DataGridView6.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView6.Location = New System.Drawing.Point(14, 353)
        Me.DataGridView6.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.DataGridView6.Name = "DataGridView6"
        Me.DataGridView6.ReadOnly = True
        Me.DataGridView6.Size = New System.Drawing.Size(1338, 367)
        Me.DataGridView6.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImage = Global.Franco_s_POS.My.Resources.Resources.Capture5
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Location = New System.Drawing.Point(913, 4)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(451, 99)
        Me.Panel1.TabIndex = 51
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.Color.White
        Me.BtnBack.Location = New System.Drawing.Point(22, 26)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(125, 46)
        Me.BtnBack.TabIndex = 52
        Me.BtnBack.Text = "BACK"
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Image = Global.Franco_s_POS.My.Resources.Resources.if_icon_111_search_314478
        Me.Label6.Location = New System.Drawing.Point(328, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 26)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Search"
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(409, 38)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(197, 34)
        Me.txtsearch.TabIndex = 53
        '
        'txtproductname
        '
        Me.txtproductname.Location = New System.Drawing.Point(209, 263)
        Me.txtproductname.Name = "txtproductname"
        Me.txtproductname.Size = New System.Drawing.Size(194, 34)
        Me.txtproductname.TabIndex = 58
        '
        'txtproductid
        '
        Me.txtproductid.BackColor = System.Drawing.Color.White
        Me.txtproductid.Location = New System.Drawing.Point(209, 217)
        Me.txtproductid.Name = "txtproductid"
        Me.txtproductid.ReadOnly = True
        Me.txtproductid.Size = New System.Drawing.Size(194, 34)
        Me.txtproductid.TabIndex = 57
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 265)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 26)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Product Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 218)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 26)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Product ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(515, 171)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 26)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Category Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 309)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 26)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Brand Name"
        '
        'txtcategoryname
        '
        Me.txtcategoryname.BackColor = System.Drawing.Color.White
        Me.txtcategoryname.Location = New System.Drawing.Point(694, 168)
        Me.txtcategoryname.Name = "txtcategoryname"
        Me.txtcategoryname.ReadOnly = True
        Me.txtcategoryname.Size = New System.Drawing.Size(194, 34)
        Me.txtcategoryname.TabIndex = 68
        '
        'txtbrandname
        '
        Me.txtbrandname.BackColor = System.Drawing.Color.White
        Me.txtbrandname.Location = New System.Drawing.Point(209, 306)
        Me.txtbrandname.Name = "txtbrandname"
        Me.txtbrandname.ReadOnly = True
        Me.txtbrandname.Size = New System.Drawing.Size(194, 34)
        Me.txtbrandname.TabIndex = 67
        '
        'txttransactionid
        '
        Me.txttransactionid.BackColor = System.Drawing.Color.White
        Me.txttransactionid.Location = New System.Drawing.Point(209, 166)
        Me.txttransactionid.Name = "txttransactionid"
        Me.txttransactionid.ReadOnly = True
        Me.txttransactionid.Size = New System.Drawing.Size(194, 34)
        Me.txttransactionid.TabIndex = 70
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 167)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 26)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "Transaction ID"
        '
        'txtprice
        '
        Me.txtprice.BackColor = System.Drawing.Color.White
        Me.txtprice.Location = New System.Drawing.Point(694, 215)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.ReadOnly = True
        Me.txtprice.Size = New System.Drawing.Size(194, 34)
        Me.txtprice.TabIndex = 72
        Me.txtprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(515, 217)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 28)
        Me.Label12.TabIndex = 71
        Me.Label12.Text = "Price"
        '
        'txtqty
        '
        Me.txtqty.BackColor = System.Drawing.Color.White
        Me.txtqty.Location = New System.Drawing.Point(694, 266)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.ReadOnly = True
        Me.txtqty.Size = New System.Drawing.Size(194, 34)
        Me.txtqty.TabIndex = 74
        Me.txtqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(515, 268)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 28)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Quantity"
        '
        'txtsubtotal
        '
        Me.txtsubtotal.BackColor = System.Drawing.Color.White
        Me.txtsubtotal.Location = New System.Drawing.Point(694, 310)
        Me.txtsubtotal.Multiline = True
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.ReadOnly = True
        Me.txtsubtotal.Size = New System.Drawing.Size(194, 34)
        Me.txtsubtotal.TabIndex = 76
        Me.txtsubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(515, 313)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 26)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "Sub Total"
        '
        'txtchange
        '
        Me.txtchange.BackColor = System.Drawing.Color.White
        Me.txtchange.Location = New System.Drawing.Point(1145, 306)
        Me.txtchange.Multiline = True
        Me.txtchange.Name = "txtchange"
        Me.txtchange.ReadOnly = True
        Me.txtchange.Size = New System.Drawing.Size(194, 34)
        Me.txtchange.TabIndex = 84
        Me.txtchange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtar
        '
        Me.txtar.BackColor = System.Drawing.Color.White
        Me.txtar.Location = New System.Drawing.Point(1145, 262)
        Me.txtar.Multiline = True
        Me.txtar.Name = "txtar"
        Me.txtar.Size = New System.Drawing.Size(194, 33)
        Me.txtar.TabIndex = 83
        Me.txtar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(1043, 314)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 26)
        Me.Label9.TabIndex = 82
        Me.Label9.Text = "Change"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(1043, 253)
        Me.Label16.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(77, 52)
        Me.Label16.TabIndex = 81
        Me.Label16.Text = "Amount" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Received"
        '
        'txttotal
        '
        Me.txttotal.BackColor = System.Drawing.Color.White
        Me.txttotal.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.Location = New System.Drawing.Point(1145, 212)
        Me.txttotal.Multiline = True
        Me.txttotal.Name = "txttotal"
        Me.txttotal.ReadOnly = True
        Me.txttotal.Size = New System.Drawing.Size(194, 34)
        Me.txttotal.TabIndex = 80
        Me.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtvat
        '
        Me.txtvat.BackColor = System.Drawing.Color.White
        Me.txtvat.Location = New System.Drawing.Point(1145, 164)
        Me.txtvat.Multiline = True
        Me.txtvat.Name = "txtvat"
        Me.txtvat.ReadOnly = True
        Me.txtvat.Size = New System.Drawing.Size(194, 34)
        Me.txtvat.TabIndex = 79
        Me.txtvat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(1042, 215)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 28)
        Me.Label10.TabIndex = 78
        Me.Label10.Text = "Total"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(1043, 169)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 26)
        Me.Label11.TabIndex = 77
        Me.Label11.Text = "V.A.T"
        '
        'AllTransactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1366, 735)
        Me.Controls.Add(Me.txtchange)
        Me.Controls.Add(Me.txtar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtvat)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtsubtotal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtqty)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtprice)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txttransactionid)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtcategoryname)
        Me.Controls.Add(Me.txtbrandname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtproductname)
        Me.Controls.Add(Me.txtproductid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView6)
        Me.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "AllTransactions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AllTransactions"
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView6 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnBack As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents txtproductname As TextBox
    Friend WithEvents txtproductid As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtcategoryname As TextBox
    Friend WithEvents txtbrandname As TextBox
    Friend WithEvents txttransactionid As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtprice As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtqty As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtsubtotal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtchange As TextBox
    Friend WithEvents txtar As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txttotal As TextBox
    Friend WithEvents txtvat As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
