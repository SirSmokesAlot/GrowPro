<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class register
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ss_theme_reg = New GrowPro.SubspaceTheme()
        Me.btn_cancel = New GrowPro.SubspaceButton()
        Me.btn_save = New GrowPro.SubspaceButton()
        Me.l_link = New System.Windows.Forms.Label()
        Me.txt_link = New System.Windows.Forms.TextBox()
        Me.l_nick = New System.Windows.Forms.Label()
        Me.txt_nick = New System.Windows.Forms.TextBox()
        Me.ss_theme_reg.SuspendLayout()
        Me.SuspendLayout()
        '
        'ss_theme_reg
        '
        Me.ss_theme_reg.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ss_theme_reg.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ss_theme_reg.Colors = New GrowPro.Bloom(-1) {}
        Me.ss_theme_reg.Controls.Add(Me.btn_cancel)
        Me.ss_theme_reg.Controls.Add(Me.btn_save)
        Me.ss_theme_reg.Controls.Add(Me.l_link)
        Me.ss_theme_reg.Controls.Add(Me.txt_link)
        Me.ss_theme_reg.Controls.Add(Me.l_nick)
        Me.ss_theme_reg.Controls.Add(Me.txt_nick)
        Me.ss_theme_reg.Customization = ""
        Me.ss_theme_reg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ss_theme_reg.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.ss_theme_reg.Image = Nothing
        Me.ss_theme_reg.Location = New System.Drawing.Point(0, 0)
        Me.ss_theme_reg.Movable = True
        Me.ss_theme_reg.Name = "ss_theme_reg"
        Me.ss_theme_reg.NoRounding = False
        Me.ss_theme_reg.Sizable = False
        Me.ss_theme_reg.Size = New System.Drawing.Size(558, 295)
        Me.ss_theme_reg.SmartBounds = True
        Me.ss_theme_reg.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.ss_theme_reg.TabIndex = 0
        Me.ss_theme_reg.Text = "Forum Account - grower.ch"
        Me.ss_theme_reg.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ss_theme_reg.Transparent = False
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.Transparent
        Me.btn_cancel.Colors = New GrowPro.Bloom(-1) {}
        Me.btn_cancel.Customization = ""
        Me.btn_cancel.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn_cancel.Image = Nothing
        Me.btn_cancel.Location = New System.Drawing.Point(288, 234)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.NoRounding = False
        Me.btn_cancel.Size = New System.Drawing.Size(117, 30)
        Me.btn_cancel.TabIndex = 5
        Me.btn_cancel.Text = "Abbrechen"
        Me.btn_cancel.Transparent = True
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.Transparent
        Me.btn_save.Colors = New GrowPro.Bloom(-1) {}
        Me.btn_save.Customization = ""
        Me.btn_save.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn_save.Image = Nothing
        Me.btn_save.Location = New System.Drawing.Point(411, 234)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.NoRounding = False
        Me.btn_save.Size = New System.Drawing.Size(117, 30)
        Me.btn_save.TabIndex = 4
        Me.btn_save.Text = "Speichern"
        Me.btn_save.Transparent = True
        '
        'l_link
        '
        Me.l_link.AutoSize = True
        Me.l_link.ForeColor = System.Drawing.Color.White
        Me.l_link.Location = New System.Drawing.Point(25, 151)
        Me.l_link.Name = "l_link"
        Me.l_link.Size = New System.Drawing.Size(68, 13)
        Me.l_link.TabIndex = 3
        Me.l_link.Text = "Profil Link:"
        '
        'txt_link
        '
        Me.txt_link.Location = New System.Drawing.Point(38, 167)
        Me.txt_link.Name = "txt_link"
        Me.txt_link.Size = New System.Drawing.Size(490, 20)
        Me.txt_link.TabIndex = 2
        '
        'l_nick
        '
        Me.l_nick.AutoSize = True
        Me.l_nick.ForeColor = System.Drawing.Color.White
        Me.l_nick.Location = New System.Drawing.Point(25, 92)
        Me.l_nick.Name = "l_nick"
        Me.l_nick.Size = New System.Drawing.Size(68, 13)
        Me.l_nick.TabIndex = 1
        Me.l_nick.Text = "Nickname:"
        '
        'txt_nick
        '
        Me.txt_nick.Location = New System.Drawing.Point(38, 108)
        Me.txt_nick.Name = "txt_nick"
        Me.txt_nick.Size = New System.Drawing.Size(122, 20)
        Me.txt_nick.TabIndex = 0
        '
        'register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 295)
        Me.Controls.Add(Me.ss_theme_reg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "register"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Info"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ss_theme_reg.ResumeLayout(False)
        Me.ss_theme_reg.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ss_theme_reg As GrowPro.SubspaceTheme
    Friend WithEvents btn_cancel As GrowPro.SubspaceButton
    Friend WithEvents btn_save As GrowPro.SubspaceButton
    Friend WithEvents l_link As System.Windows.Forms.Label
    Friend WithEvents txt_link As System.Windows.Forms.TextBox
    Friend WithEvents l_nick As System.Windows.Forms.Label
    Friend WithEvents txt_nick As System.Windows.Forms.TextBox
End Class
