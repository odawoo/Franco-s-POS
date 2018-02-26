<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProductBrand
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
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.txtdescription = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtbrandid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtbrandname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnback = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(13, 154)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(447, 351)
        Me.DataGridView2.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 47)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Product Brands  "
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(176, 106)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(162, 30)
        Me.txtsearch.TabIndex = 19
        '
        'txtdescription
        '
        Me.txtdescription.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescription.Location = New System.Drawing.Point(628, 264)
        Me.txtdescription.Multiline = True
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(228, 97)
        Me.txtdescription.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(491, 300)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 26)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Description"
        '
        'txtbrandid
        '
        Me.txtbrandid.BackColor = System.Drawing.Color.White
        Me.txtbrandid.Location = New System.Drawing.Point(699, 138)
        Me.txtbrandid.Name = "txtbrandid"
        Me.txtbrandid.ReadOnly = True
        Me.txtbrandid.Size = New System.Drawing.Size(157, 30)
        Me.txtbrandid.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(491, 141)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 26)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Brand ID"
        '
        'txtbrandname
        '
        Me.txtbrandname.Location = New System.Drawing.Point(699, 202)
        Me.txtbrandname.Name = "txtbrandname"
        Me.txtbrandname.Size = New System.Drawing.Size(157, 30)
        Me.txtbrandname.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(491, 205)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 26)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Brand Name"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Franco_s_POS.My.Resources.Resources.Capture5
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Location = New System.Drawing.Point(496, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(363, 91)
        Me.Panel1.TabIndex = 32
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.White
        Me.btnclear.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Image = Global.Franco_s_POS.My.Resources.Resources.if_Clear_2134648
        Me.btnclear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclear.Location = New System.Drawing.Point(604, 422)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(115, 35)
        Me.btnclear.TabIndex = 31
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
        Me.btnback.Location = New System.Drawing.Point(574, 463)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(167, 44)
        Me.btnback.TabIndex = 24
        Me.btnback.Text = "BACK"
        Me.btnback.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.White
        Me.btndelete.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Image = Global.Franco_s_POS.My.Resources.Resources.if_Streamline_70_185090__2_
        Me.btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndelete.Location = New System.Drawing.Point(741, 393)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(115, 34)
        Me.btndelete.TabIndex = 23
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
        Me.btnupdate.Location = New System.Drawing.Point(473, 393)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(115, 35)
        Me.btnupdate.TabIndex = 22
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
        Me.btnadd.Location = New System.Drawing.Point(604, 367)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(115, 34)
        Me.btnadd.TabIndex = 21
        Me.btnadd.Text = "ADD"
        Me.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Image = Global.Franco_s_POS.My.Resources.Resources.if_icon_111_search_314478
        Me.Label6.Location = New System.Drawing.Point(99, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 23)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Search"
        '
        'ProductBrand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(868, 519)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.txtdescription)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtbrandid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtbrandname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ProductBrand"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProductBrand"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents btnclear As Button
    Friend WithEvents txtdescription As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtbrandid As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtbrandname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnback As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents Panel1 As Panel
End Class
