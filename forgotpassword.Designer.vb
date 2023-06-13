<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class forgotpassword
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
        Me.Label18 = New System.Windows.Forms.Label()
        Me.textbox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Login = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Forte", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Lime
        Me.Label18.Location = New System.Drawing.Point(162, 26)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(280, 32)
        Me.Label18.TabIndex = 54
        Me.Label18.Text = "FORGOT PASSWORD"
        '
        'textbox2
        '
        Me.textbox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox2.Location = New System.Drawing.Point(122, 166)
        Me.textbox2.Name = "textbox2"
        Me.textbox2.Size = New System.Drawing.Size(360, 30)
        Me.textbox2.TabIndex = 55
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(122, 237)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox1.Size = New System.Drawing.Size(360, 30)
        Me.TextBox1.TabIndex = 56
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Copperplate Gothic Bold", 10.8!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(122, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 21)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Re-Set Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 10.8!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(118, 214)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 21)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Confrim Password"
        '
        'Login
        '
        Me.Login.BackColor = System.Drawing.Color.Lime
        Me.Login.Font = New System.Drawing.Font("Copperplate Gothic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login.Location = New System.Drawing.Point(142, 317)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(159, 37)
        Me.Login.TabIndex = 59
        Me.Login.Text = "Save"
        Me.Login.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(120, 274)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(164, 24)
        Me.CheckBox1.TabIndex = 60
        Me.CheckBox1.Text = "Show Password"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Copperplate Gothic Bold", 10.8!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(224, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(216, 21)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Confrim Password"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(307, 317)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 37)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = "EXIT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'forgotpassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.mini_sale_and_inventroy__system.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(664, 371)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Login)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.textbox2)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "forgotpassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "forgotpassword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label18 As Label
    Friend WithEvents textbox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Login As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
End Class
