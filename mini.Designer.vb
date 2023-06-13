<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mini
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
        Me.components = New System.ComponentModel.Container()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1_mini = New System.Windows.Forms.Timer(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Mistral", 55.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Lime
        Me.Label5.Location = New System.Drawing.Point(623, 282)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(334, 110)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Inventory"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Mistral", 55.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(306, 284)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(879, 110)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Sales and               System"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Mistral", 55.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(120, 284)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 110)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Mini"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Mistral", 22.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(918, 404)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(374, 46)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "AUTO MOBILES SPAREPARTS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Copperplate Gothic Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(87, 642)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 26)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Loading.........."
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.Color.White
        Me.ProgressBar1.Location = New System.Drawing.Point(73, 674)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(1207, 23)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 16
        '
        'Timer1_mini
        '
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Copperplate Gothic Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(1233, 639)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 26)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "0"
        '
        'mini
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.BackgroundImage = Global.mini_sale_and_inventroy__system.My.Resources.Resources._1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1344, 790)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "mini"
        Me.Text = "mini"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1_mini As Timer
    Friend WithEvents Label6 As Label
End Class
