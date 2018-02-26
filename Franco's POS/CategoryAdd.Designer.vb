<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CategoryAdd
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcategoryname = New System.Windows.Forms.TextBox()
        Me.txtdescription = New System.Windows.Forms.TextBox()
        Me.btnback = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcatid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.star = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(65, 170)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Category Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(65, 264)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Description"
        '
        'txtcategoryname
        '
        Me.txtcategoryname.Location = New System.Drawing.Point(337, 167)
        Me.txtcategoryname.Name = "txtcategoryname"
        Me.txtcategoryname.Size = New System.Drawing.Size(157, 34)
        Me.txtcategoryname.TabIndex = 2
        '
        'txtdescription
        '
        Me.txtdescription.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescription.Location = New System.Drawing.Point(266, 212)
        Me.txtdescription.Multiline = True
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(228, 97)
        Me.txtdescription.TabIndex = 3
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.Color.White
        Me.btnback.BackgroundImage = Global.Franco_s_POS.My.Resources.Resources.icons8_go_back_50
        Me.btnback.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.ForeColor = System.Drawing.Color.Black
        Me.btnback.Location = New System.Drawing.Point(286, 332)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(102, 44)
        Me.btnback.TabIndex = 6
        Me.btnback.Text = "BACK"
        Me.btnback.UseVisualStyleBackColor = False
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.White
        Me.btnadd.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Image = Global.Franco_s_POS.My.Resources.Resources.if_basics_15_296819
        Me.btnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnadd.Location = New System.Drawing.Point(101, 332)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(102, 44)
        Me.btnadd.TabIndex = 7
        Me.btnadd.Text = "ADD"
        Me.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 37)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Add Category"
        '
        'txtcatid
        '
        Me.txtcatid.BackColor = System.Drawing.Color.White
        Me.txtcatid.Location = New System.Drawing.Point(337, 103)
        Me.txtcatid.Name = "txtcatid"
        Me.txtcatid.ReadOnly = True
        Me.txtcatid.Size = New System.Drawing.Size(157, 34)
        Me.txtcatid.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(65, 106)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 26)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Category ID"
        '
        'star
        '
        Me.star.AutoSize = True
        Me.star.Location = New System.Drawing.Point(500, 147)
        Me.star.Name = "star"
        Me.star.Size = New System.Drawing.Size(0, 26)
        Me.star.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Franco_s_POS.My.Resources.Resources.Capture5
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Location = New System.Drawing.Point(171, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(355, 91)
        Me.Panel1.TabIndex = 23
        '
        'CategoryAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(526, 388)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.star)
        Me.Controls.Add(Me.txtcatid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.txtdescription)
        Me.Controls.Add(Me.txtcategoryname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "CategoryAdd"
        Me.Text = "CategoryAdd"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcategoryname As TextBox
    Friend WithEvents txtdescription As TextBox
    Friend WithEvents btnback As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcatid As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents star As Label
    Friend WithEvents Panel1 As Panel
End Class
