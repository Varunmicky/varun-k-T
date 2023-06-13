<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class reg
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
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.txtcpass = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Login = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(81, 379)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(360, 30)
        Me.txtname.TabIndex = 1
        '
        'txtpass
        '
        Me.txtpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.Location = New System.Drawing.Point(81, 457)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(360, 30)
        Me.txtpass.TabIndex = 2
        '
        'txtcpass
        '
        Me.txtcpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcpass.Location = New System.Drawing.Point(81, 532)
        Me.txtcpass.Name = "txtcpass"
        Me.txtcpass.Size = New System.Drawing.Size(360, 30)
        Me.txtcpass.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Font = New System.Drawing.Font("Copperplate Gothic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(282, 591)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(159, 37)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.Login.BackColor = System.Drawing.Color.Lime
        Me.Login.Font = New System.Drawing.Font("Copperplate Gothic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login.Location = New System.Drawing.Point(80, 591)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(159, 37)
        Me.Login.TabIndex = 8
        Me.Login.Text = "Create"
        Me.Login.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.mini_sale_and_inventroy__system.My.Resources.Resources.Admin
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(168, 131)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(198, 181)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Copperplate Gothic Bold", 10.8!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(80, 430)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 21)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 10.8!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(77, 353)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 21)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = " Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Copperplate Gothic Bold", 10.8!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(76, 508)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(221, 21)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = " Confirm Password"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Forte", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Lime
        Me.Label18.Location = New System.Drawing.Point(199, 43)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(154, 32)
        Me.Label18.TabIndex = 55
        Me.Label18.Text = "REGISTER"
        '
        'reg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.mini_sale_and_inventroy__system.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(525, 792)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Login)
        Me.Controls.Add(Me.txtcpass)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "reg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "reg"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtname As TextBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents txtcpass As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Login As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label18 As Label
End Class
