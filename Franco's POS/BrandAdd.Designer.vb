<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BrandAdd
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
        Me.star = New System.Windows.Forms.Label()
        Me.txtbrandid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtdescription = New System.Windows.Forms.TextBox()
        Me.txtbrandname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnback = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'star
        '
        Me.star.AutoSize = True
        Me.star.Location = New System.Drawing.Point(507, 144)
        Me.star.Name = "star"
        Me.star.Size = New System.Drawing.Size(0, 26)
        Me.star.TabIndex = 21
        '
        'txtbrandid
        '
        Me.txtbrandid.BackColor = System.Drawing.Color.White
        Me.txtbrandid.Location = New System.Drawing.Point(343, 100)
        Me.txtbrandid.Name = "txtbrandid"
        Me.txtbrandid.ReadOnly = True
        Me.txtbrandid.Size = New System.Drawing.Size(157, 34)
        Me.txtbrandid.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(71, 103)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 26)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Brand ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 37)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Add Brand"
        '
        'txtdescription
        '
        Me.txtdescription.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescription.Location = New System.Drawing.Point(272, 209)
        Me.txtdescription.Multiline = True
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(228, 97)
        Me.txtdescription.TabIndex = 15
        '
        'txtbrandname
        '
        Me.txtbrandname.Location = New System.Drawing.Point(343, 164)
        Me.txtbrandname.Name = "txtbrandname"
        Me.txtbrandname.Size = New System.Drawing.Size(157, 34)
        Me.txtbrandname.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(71, 249)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 26)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Description"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(71, 167)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 26)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Brand Name"
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.White
        Me.btnadd.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Image = Global.Franco_s_POS.My.Resources.Resources.if_basics_15_296819
        Me.btnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnadd.Location = New System.Drawing.Point(107, 329)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(102, 44)
        Me.btnadd.TabIndex = 17
        Me.btnadd.Text = "ADD"
        Me.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.Color.White
        Me.btnback.BackgroundImage = Global.Franco_s_POS.My.Resources.Resources.icons8_go_back_50
        Me.btnback.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.ForeColor = System.Drawing.Color.Black
        Me.btnback.Location = New System.Drawing.Point(292, 329)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(102, 44)
        Me.btnback.TabIndex = 16
        Me.btnback.Text = "BACK"
        Me.btnback.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Franco_s_POS.My.Resources.Resources.Capture5
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Location = New System.Drawing.Point(160, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(363, 91)
        Me.Panel1.TabIndex = 22
        '
        'BrandAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(526, 385)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.star)
        Me.Controls.Add(Me.txtbrandid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.txtdescription)
        Me.Controls.Add(Me.txtbrandname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "BrandAdd"
        Me.Text = "BrandAdd"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents star As Label
    Friend WithEvents txtbrandid As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnadd As Button
    Friend WithEvents btnback As Button
    Friend WithEvents txtdescription As TextBox
    Friend WithEvents txtbrandname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
End Class
