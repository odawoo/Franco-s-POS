<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProductCategory
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcatid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcategoryname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtdescription = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnback = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(376, 47)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PRODUCT CATEGORIES  "
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Location = New System.Drawing.Point(12, 195)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(447, 364)
        Me.DataGridView1.TabIndex = 8
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(143, 146)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(162, 30)
        Me.txtsearch.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 23)
        Me.Label2.TabIndex = 8
        '
        'txtcatid
        '
        Me.txtcatid.BackColor = System.Drawing.Color.White
        Me.txtcatid.Location = New System.Drawing.Point(718, 146)
        Me.txtcatid.Name = "txtcatid"
        Me.txtcatid.ReadOnly = True
        Me.txtcatid.Size = New System.Drawing.Size(157, 30)
        Me.txtcatid.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(510, 149)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 23)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Category ID"
        '
        'txtcategoryname
        '
        Me.txtcategoryname.Location = New System.Drawing.Point(718, 210)
        Me.txtcategoryname.Name = "txtcategoryname"
        Me.txtcategoryname.Size = New System.Drawing.Size(157, 30)
        Me.txtcategoryname.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(510, 213)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 23)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Category Name"
        '
        'txtdescription
        '
        Me.txtdescription.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescription.Location = New System.Drawing.Point(647, 272)
        Me.txtdescription.Multiline = True
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(228, 97)
        Me.txtdescription.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(510, 308)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 23)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Description"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Franco_s_POS.My.Resources.Resources.Capture5
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Location = New System.Drawing.Point(509, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(363, 91)
        Me.Panel1.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Image = Global.Franco_s_POS.My.Resources.Resources.if_icon_111_search_314478
        Me.Label6.Location = New System.Drawing.Point(66, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 23)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Search"
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.White
        Me.btnclear.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Image = Global.Franco_s_POS.My.Resources.Resources.if_Clear_2134648
        Me.btnclear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclear.Location = New System.Drawing.Point(624, 455)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(115, 35)
        Me.btnclear.TabIndex = 17
        Me.btnclear.Text = "CLEAR"
        Me.btnclear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.Color.White
        Me.btnback.BackgroundImage = Global.Franco_s_POS.My.Resources.Resources.icons8_go_back_50
        Me.btnback.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.ForeColor = System.Drawing.Color.Black
        Me.btnback.Location = New System.Drawing.Point(604, 515)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(155, 44)
        Me.btnback.TabIndex = 5
        Me.btnback.Text = "BACK"
        Me.btnback.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.White
        Me.btndelete.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Image = Global.Franco_s_POS.My.Resources.Resources.if_Streamline_70_185090__2_
        Me.btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndelete.Location = New System.Drawing.Point(760, 425)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(115, 34)
        Me.btndelete.TabIndex = 4
        Me.btndelete.Text = "DELETE"
        Me.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.White
        Me.btnupdate.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Image = Global.Franco_s_POS.My.Resources.Resources.if_update_172618
        Me.btnupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnupdate.Location = New System.Drawing.Point(483, 424)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(115, 35)
        Me.btnupdate.TabIndex = 3
        Me.btnupdate.Text = "UPDATE"
        Me.btnupdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.White
        Me.btnadd.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Image = Global.Franco_s_POS.My.Resources.Resources.if_basics_15_296819
        Me.btnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnadd.Location = New System.Drawing.Point(624, 397)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(115, 33)
        Me.btnadd.TabIndex = 2
        Me.btnadd.Text = "ADD"
        Me.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'ProductCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(884, 571)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.txtdescription)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtcatid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtcategoryname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ProductCategory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProductCategory"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnadd As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnback As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcatid As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtcategoryname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtdescription As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnclear As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
End Class
