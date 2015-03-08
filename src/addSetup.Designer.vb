<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addSetup
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
        Me.ss_theme_adds = New GrowPro.SubspaceTheme()
        Me.cb_stealth = New System.Windows.Forms.ComboBox()
        Me.txt_water = New System.Windows.Forms.ComboBox()
        Me.label_v_noise = New System.Windows.Forms.Label()
        Me.label_v_water = New System.Windows.Forms.Label()
        Me.txt_vsg = New System.Windows.Forms.TextBox()
        Me.txt_refl = New System.Windows.Forms.TextBox()
        Me.label_v_cm = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.label_v_x2 = New System.Windows.Forms.Label()
        Me.label_v_x = New System.Windows.Forms.Label()
        Me.txt_z = New System.Windows.Forms.TextBox()
        Me.txt_y = New System.Windows.Forms.TextBox()
        Me.txt_x = New System.Windows.Forms.TextBox()
        Me.cb_glocation = New System.Windows.Forms.ComboBox()
        Me.txt_airin = New System.Windows.Forms.TextBox()
        Me.txt_airout = New System.Windows.Forms.TextBox()
        Me.txt_akf = New System.Windows.Forms.TextBox()
        Me.txt_flowerspectre = New System.Windows.Forms.TextBox()
        Me.txt_growspectre = New System.Windows.Forms.TextBox()
        Me.label_v_flower = New System.Windows.Forms.Label()
        Me.btn_cancel = New GrowPro.SubspaceButton()
        Me.btn_add = New GrowPro.SubspaceButton()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.label_v_vsg = New System.Windows.Forms.Label()
        Me.label_v_refl = New System.Windows.Forms.Label()
        Me.label_v_place = New System.Windows.Forms.Label()
        Me.label_v_loc = New System.Windows.Forms.Label()
        Me.label_v_airout = New System.Windows.Forms.Label()
        Me.label_v_vent = New System.Windows.Forms.Label()
        Me.label_v_akf = New System.Windows.Forms.Label()
        Me.label_v_lamp_grow = New System.Windows.Forms.Label()
        Me.label_v_name = New System.Windows.Forms.Label()
        Me.ss_theme_adds.SuspendLayout()
        Me.SuspendLayout()
        '
        'ss_theme_adds
        '
        Me.ss_theme_adds.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ss_theme_adds.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ss_theme_adds.Colors = New GrowPro.Bloom(-1) {}
        Me.ss_theme_adds.Controls.Add(Me.cb_stealth)
        Me.ss_theme_adds.Controls.Add(Me.txt_water)
        Me.ss_theme_adds.Controls.Add(Me.label_v_noise)
        Me.ss_theme_adds.Controls.Add(Me.label_v_water)
        Me.ss_theme_adds.Controls.Add(Me.txt_vsg)
        Me.ss_theme_adds.Controls.Add(Me.txt_refl)
        Me.ss_theme_adds.Controls.Add(Me.label_v_cm)
        Me.ss_theme_adds.Controls.Add(Me.Label6)
        Me.ss_theme_adds.Controls.Add(Me.label_v_x2)
        Me.ss_theme_adds.Controls.Add(Me.label_v_x)
        Me.ss_theme_adds.Controls.Add(Me.txt_z)
        Me.ss_theme_adds.Controls.Add(Me.txt_y)
        Me.ss_theme_adds.Controls.Add(Me.txt_x)
        Me.ss_theme_adds.Controls.Add(Me.cb_glocation)
        Me.ss_theme_adds.Controls.Add(Me.txt_airin)
        Me.ss_theme_adds.Controls.Add(Me.txt_airout)
        Me.ss_theme_adds.Controls.Add(Me.txt_akf)
        Me.ss_theme_adds.Controls.Add(Me.txt_flowerspectre)
        Me.ss_theme_adds.Controls.Add(Me.txt_growspectre)
        Me.ss_theme_adds.Controls.Add(Me.label_v_flower)
        Me.ss_theme_adds.Controls.Add(Me.btn_cancel)
        Me.ss_theme_adds.Controls.Add(Me.btn_add)
        Me.ss_theme_adds.Controls.Add(Me.txt_name)
        Me.ss_theme_adds.Controls.Add(Me.label_v_vsg)
        Me.ss_theme_adds.Controls.Add(Me.label_v_refl)
        Me.ss_theme_adds.Controls.Add(Me.label_v_place)
        Me.ss_theme_adds.Controls.Add(Me.label_v_loc)
        Me.ss_theme_adds.Controls.Add(Me.label_v_airout)
        Me.ss_theme_adds.Controls.Add(Me.label_v_vent)
        Me.ss_theme_adds.Controls.Add(Me.label_v_akf)
        Me.ss_theme_adds.Controls.Add(Me.label_v_lamp_grow)
        Me.ss_theme_adds.Controls.Add(Me.label_v_name)
        Me.ss_theme_adds.Customization = ""
        Me.ss_theme_adds.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ss_theme_adds.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.ss_theme_adds.Image = Nothing
        Me.ss_theme_adds.Location = New System.Drawing.Point(0, 0)
        Me.ss_theme_adds.Movable = True
        Me.ss_theme_adds.Name = "ss_theme_adds"
        Me.ss_theme_adds.NoRounding = False
        Me.ss_theme_adds.Sizable = False
        Me.ss_theme_adds.Size = New System.Drawing.Size(473, 507)
        Me.ss_theme_adds.SmartBounds = True
        Me.ss_theme_adds.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ss_theme_adds.TabIndex = 0
        Me.ss_theme_adds.Text = "Setup Erstellen"
        Me.ss_theme_adds.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ss_theme_adds.Transparent = False
        '
        'cb_stealth
        '
        Me.cb_stealth.FormattingEnabled = True
        Me.cb_stealth.Items.AddRange(New Object() {"Ja", "Nein"})
        Me.cb_stealth.Location = New System.Drawing.Point(277, 398)
        Me.cb_stealth.Name = "cb_stealth"
        Me.cb_stealth.Size = New System.Drawing.Size(74, 21)
        Me.cb_stealth.TabIndex = 93
        '
        'txt_water
        '
        Me.txt_water.FormattingEnabled = True
        Me.txt_water.Items.AddRange(New Object() {"Manuell", "Automatisch"})
        Me.txt_water.Location = New System.Drawing.Point(277, 338)
        Me.txt_water.Name = "txt_water"
        Me.txt_water.Size = New System.Drawing.Size(121, 21)
        Me.txt_water.TabIndex = 92
        '
        'label_v_noise
        '
        Me.label_v_noise.AutoSize = True
        Me.label_v_noise.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_v_noise.ForeColor = System.Drawing.Color.White
        Me.label_v_noise.Location = New System.Drawing.Point(265, 380)
        Me.label_v_noise.Name = "label_v_noise"
        Me.label_v_noise.Size = New System.Drawing.Size(106, 16)
        Me.label_v_noise.TabIndex = 91
        Me.label_v_noise.Text = "Schalldämpfer:"
        '
        'label_v_water
        '
        Me.label_v_water.AutoSize = True
        Me.label_v_water.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_v_water.ForeColor = System.Drawing.Color.White
        Me.label_v_water.Location = New System.Drawing.Point(265, 319)
        Me.label_v_water.Name = "label_v_water"
        Me.label_v_water.Size = New System.Drawing.Size(100, 16)
        Me.label_v_water.TabIndex = 89
        Me.label_v_water.Text = "Bewässerung:"
        '
        'txt_vsg
        '
        Me.txt_vsg.Location = New System.Drawing.Point(277, 274)
        Me.txt_vsg.Name = "txt_vsg"
        Me.txt_vsg.Size = New System.Drawing.Size(169, 20)
        Me.txt_vsg.TabIndex = 88
        '
        'txt_refl
        '
        Me.txt_refl.Location = New System.Drawing.Point(37, 399)
        Me.txt_refl.Name = "txt_refl"
        Me.txt_refl.Size = New System.Drawing.Size(169, 20)
        Me.txt_refl.TabIndex = 87
        '
        'label_v_cm
        '
        Me.label_v_cm.AutoSize = True
        Me.label_v_cm.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_v_cm.ForeColor = System.Drawing.Color.White
        Me.label_v_cm.Location = New System.Drawing.Point(187, 207)
        Me.label_v_cm.Name = "label_v_cm"
        Me.label_v_cm.Size = New System.Drawing.Size(27, 16)
        Me.label_v_cm.TabIndex = 86
        Me.label_v_cm.Text = "cm"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(387, 380)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 16)
        Me.Label6.TabIndex = 85
        '
        'label_v_x2
        '
        Me.label_v_x2.AutoSize = True
        Me.label_v_x2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_v_x2.ForeColor = System.Drawing.Color.White
        Me.label_v_x2.Location = New System.Drawing.Point(128, 205)
        Me.label_v_x2.Name = "label_v_x2"
        Me.label_v_x2.Size = New System.Drawing.Size(15, 16)
        Me.label_v_x2.TabIndex = 81
        Me.label_v_x2.Text = "x"
        '
        'label_v_x
        '
        Me.label_v_x.AutoSize = True
        Me.label_v_x.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_v_x.ForeColor = System.Drawing.Color.White
        Me.label_v_x.Location = New System.Drawing.Point(73, 205)
        Me.label_v_x.Name = "label_v_x"
        Me.label_v_x.Size = New System.Drawing.Size(15, 16)
        Me.label_v_x.TabIndex = 80
        Me.label_v_x.Text = "x"
        '
        'txt_z
        '
        Me.txt_z.Location = New System.Drawing.Point(147, 203)
        Me.txt_z.Name = "txt_z"
        Me.txt_z.Size = New System.Drawing.Size(34, 20)
        Me.txt_z.TabIndex = 79
        Me.txt_z.Text = "120"
        '
        'txt_y
        '
        Me.txt_y.Location = New System.Drawing.Point(91, 203)
        Me.txt_y.Name = "txt_y"
        Me.txt_y.Size = New System.Drawing.Size(34, 20)
        Me.txt_y.TabIndex = 78
        Me.txt_y.Text = "60"
        '
        'txt_x
        '
        Me.txt_x.Location = New System.Drawing.Point(36, 203)
        Me.txt_x.Name = "txt_x"
        Me.txt_x.Size = New System.Drawing.Size(34, 20)
        Me.txt_x.TabIndex = 77
        Me.txt_x.Text = "60"
        '
        'cb_glocation
        '
        Me.cb_glocation.FormattingEnabled = True
        Me.cb_glocation.Items.AddRange(New Object() {"Growbox", "Zimmer", "Dachboden", "Keller", "Andere"})
        Me.cb_glocation.Location = New System.Drawing.Point(36, 142)
        Me.cb_glocation.Name = "cb_glocation"
        Me.cb_glocation.Size = New System.Drawing.Size(169, 21)
        Me.cb_glocation.TabIndex = 76
        '
        'txt_airin
        '
        Me.txt_airin.Location = New System.Drawing.Point(277, 142)
        Me.txt_airin.Name = "txt_airin"
        Me.txt_airin.Size = New System.Drawing.Size(169, 20)
        Me.txt_airin.TabIndex = 75
        '
        'txt_airout
        '
        Me.txt_airout.Location = New System.Drawing.Point(277, 78)
        Me.txt_airout.Name = "txt_airout"
        Me.txt_airout.Size = New System.Drawing.Size(169, 20)
        Me.txt_airout.TabIndex = 74
        '
        'txt_akf
        '
        Me.txt_akf.Location = New System.Drawing.Point(277, 203)
        Me.txt_akf.Name = "txt_akf"
        Me.txt_akf.Size = New System.Drawing.Size(169, 20)
        Me.txt_akf.TabIndex = 73
        '
        'txt_flowerspectre
        '
        Me.txt_flowerspectre.Location = New System.Drawing.Point(37, 339)
        Me.txt_flowerspectre.Name = "txt_flowerspectre"
        Me.txt_flowerspectre.Size = New System.Drawing.Size(169, 20)
        Me.txt_flowerspectre.TabIndex = 72
        '
        'txt_growspectre
        '
        Me.txt_growspectre.Location = New System.Drawing.Point(37, 274)
        Me.txt_growspectre.Name = "txt_growspectre"
        Me.txt_growspectre.Size = New System.Drawing.Size(169, 20)
        Me.txt_growspectre.TabIndex = 71
        '
        'label_v_flower
        '
        Me.label_v_flower.AutoSize = True
        Me.label_v_flower.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_v_flower.ForeColor = System.Drawing.Color.White
        Me.label_v_flower.Location = New System.Drawing.Point(24, 320)
        Me.label_v_flower.Name = "label_v_flower"
        Me.label_v_flower.Size = New System.Drawing.Size(134, 16)
        Me.label_v_flower.TabIndex = 70
        Me.label_v_flower.Text = "Leuchtmittel Blüte:"
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.Transparent
        Me.btn_cancel.Colors = New GrowPro.Bloom(-1) {}
        Me.btn_cancel.Customization = ""
        Me.btn_cancel.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn_cancel.Image = Nothing
        Me.btn_cancel.Location = New System.Drawing.Point(190, 453)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.NoRounding = False
        Me.btn_cancel.Size = New System.Drawing.Size(93, 23)
        Me.btn_cancel.TabIndex = 69
        Me.btn_cancel.Text = "Abbrechen"
        Me.btn_cancel.Transparent = True
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.Transparent
        Me.btn_add.Colors = New GrowPro.Bloom(-1) {}
        Me.btn_add.Customization = ""
        Me.btn_add.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn_add.Image = Nothing
        Me.btn_add.Location = New System.Drawing.Point(286, 453)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.NoRounding = False
        Me.btn_add.Size = New System.Drawing.Size(160, 23)
        Me.btn_add.TabIndex = 68
        Me.btn_add.Text = "Erstellen"
        Me.btn_add.Transparent = True
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(37, 78)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(169, 20)
        Me.txt_name.TabIndex = 64
        '
        'label_v_vsg
        '
        Me.label_v_vsg.AutoSize = True
        Me.label_v_vsg.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_v_vsg.ForeColor = System.Drawing.Color.White
        Me.label_v_vsg.Location = New System.Drawing.Point(265, 255)
        Me.label_v_vsg.Name = "label_v_vsg"
        Me.label_v_vsg.Size = New System.Drawing.Size(111, 16)
        Me.label_v_vsg.TabIndex = 50
        Me.label_v_vsg.Text = "Vorschaltgerät:"
        '
        'label_v_refl
        '
        Me.label_v_refl.AutoSize = True
        Me.label_v_refl.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_v_refl.ForeColor = System.Drawing.Color.White
        Me.label_v_refl.Location = New System.Drawing.Point(25, 380)
        Me.label_v_refl.Name = "label_v_refl"
        Me.label_v_refl.Size = New System.Drawing.Size(72, 16)
        Me.label_v_refl.TabIndex = 46
        Me.label_v_refl.Text = "Reflektor:"
        '
        'label_v_place
        '
        Me.label_v_place.AutoSize = True
        Me.label_v_place.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_v_place.ForeColor = System.Drawing.Color.White
        Me.label_v_place.Location = New System.Drawing.Point(24, 184)
        Me.label_v_place.Name = "label_v_place"
        Me.label_v_place.Size = New System.Drawing.Size(46, 16)
        Me.label_v_place.TabIndex = 44
        Me.label_v_place.Text = "Platz:"
        '
        'label_v_loc
        '
        Me.label_v_loc.AutoSize = True
        Me.label_v_loc.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_v_loc.ForeColor = System.Drawing.Color.White
        Me.label_v_loc.Location = New System.Drawing.Point(24, 123)
        Me.label_v_loc.Name = "label_v_loc"
        Me.label_v_loc.Size = New System.Drawing.Size(99, 16)
        Me.label_v_loc.TabIndex = 42
        Me.label_v_loc.Text = "Growlocation:"
        '
        'label_v_airout
        '
        Me.label_v_airout.AutoSize = True
        Me.label_v_airout.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_v_airout.ForeColor = System.Drawing.Color.White
        Me.label_v_airout.Location = New System.Drawing.Point(265, 59)
        Me.label_v_airout.Name = "label_v_airout"
        Me.label_v_airout.Size = New System.Drawing.Size(122, 16)
        Me.label_v_airout.TabIndex = 40
        Me.label_v_airout.Text = "Abluft Ventilator:"
        '
        'label_v_vent
        '
        Me.label_v_vent.AutoSize = True
        Me.label_v_vent.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_v_vent.ForeColor = System.Drawing.Color.White
        Me.label_v_vent.Location = New System.Drawing.Point(265, 123)
        Me.label_v_vent.Name = "label_v_vent"
        Me.label_v_vent.Size = New System.Drawing.Size(78, 16)
        Me.label_v_vent.TabIndex = 38
        Me.label_v_vent.Text = "Ventilator:"
        '
        'label_v_akf
        '
        Me.label_v_akf.AutoSize = True
        Me.label_v_akf.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_v_akf.ForeColor = System.Drawing.Color.White
        Me.label_v_akf.Location = New System.Drawing.Point(265, 184)
        Me.label_v_akf.Name = "label_v_akf"
        Me.label_v_akf.Size = New System.Drawing.Size(111, 16)
        Me.label_v_akf.TabIndex = 36
        Me.label_v_akf.Text = "Akitvkohlefilter:"
        '
        'label_v_lamp_grow
        '
        Me.label_v_lamp_grow.AutoSize = True
        Me.label_v_lamp_grow.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_v_lamp_grow.ForeColor = System.Drawing.Color.White
        Me.label_v_lamp_grow.Location = New System.Drawing.Point(24, 255)
        Me.label_v_lamp_grow.Name = "label_v_lamp_grow"
        Me.label_v_lamp_grow.Size = New System.Drawing.Size(170, 16)
        Me.label_v_lamp_grow.TabIndex = 34
        Me.label_v_lamp_grow.Text = "Leuchtmittel Wachstum:"
        '
        'label_v_name
        '
        Me.label_v_name.AutoSize = True
        Me.label_v_name.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_v_name.ForeColor = System.Drawing.Color.White
        Me.label_v_name.Location = New System.Drawing.Point(24, 59)
        Me.label_v_name.Name = "label_v_name"
        Me.label_v_name.Size = New System.Drawing.Size(50, 16)
        Me.label_v_name.TabIndex = 32
        Me.label_v_name.Text = "Name:"
        '
        'addSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 507)
        Me.Controls.Add(Me.ss_theme_adds)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addSetup"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Projekt Erstellen"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ss_theme_adds.ResumeLayout(False)
        Me.ss_theme_adds.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ss_theme_adds As GrowPro.SubspaceTheme
    Friend WithEvents label_v_vsg As System.Windows.Forms.Label
    Friend WithEvents label_v_refl As System.Windows.Forms.Label
    Friend WithEvents label_v_place As System.Windows.Forms.Label
    Friend WithEvents label_v_loc As System.Windows.Forms.Label
    Friend WithEvents label_v_airout As System.Windows.Forms.Label
    Friend WithEvents label_v_vent As System.Windows.Forms.Label
    Friend WithEvents label_v_akf As System.Windows.Forms.Label
    Friend WithEvents label_v_lamp_grow As System.Windows.Forms.Label
    Friend WithEvents label_v_name As System.Windows.Forms.Label
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents btn_cancel As GrowPro.SubspaceButton
    Friend WithEvents btn_add As GrowPro.SubspaceButton
    Friend WithEvents label_v_x2 As System.Windows.Forms.Label
    Friend WithEvents label_v_x As System.Windows.Forms.Label
    Friend WithEvents txt_z As System.Windows.Forms.TextBox
    Friend WithEvents txt_y As System.Windows.Forms.TextBox
    Friend WithEvents txt_x As System.Windows.Forms.TextBox
    Friend WithEvents cb_glocation As System.Windows.Forms.ComboBox
    Friend WithEvents txt_airin As System.Windows.Forms.TextBox
    Friend WithEvents txt_airout As System.Windows.Forms.TextBox
    Friend WithEvents txt_akf As System.Windows.Forms.TextBox
    Friend WithEvents txt_flowerspectre As System.Windows.Forms.TextBox
    Friend WithEvents txt_growspectre As System.Windows.Forms.TextBox
    Friend WithEvents label_v_flower As System.Windows.Forms.Label
    Friend WithEvents label_v_cm As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_vsg As System.Windows.Forms.TextBox
    Friend WithEvents txt_refl As System.Windows.Forms.TextBox
    Friend WithEvents cb_stealth As System.Windows.Forms.ComboBox
    Friend WithEvents txt_water As System.Windows.Forms.ComboBox
    Friend WithEvents label_v_noise As System.Windows.Forms.Label
    Friend WithEvents label_v_water As System.Windows.Forms.Label
End Class
