<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class calculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(calculator))
        Me.ss_theme_calc = New GrowPro.SubspaceTheme()
        Me.gb_result = New GrowPro.Subspacegroupbox()
        Me.txt_result = New System.Windows.Forms.RichTextBox()
        Me.gb_others = New GrowPro.Subspacegroupbox()
        Me.label_v_o_watt = New System.Windows.Forms.Label()
        Me.txt_sv_power = New System.Windows.Forms.TextBox()
        Me.cb_sv_hours = New System.Windows.Forms.ComboBox()
        Me.label_v_o_p = New System.Windows.Forms.Label()
        Me.txt_sv_days = New System.Windows.Forms.TextBox()
        Me.label_v_o_h = New System.Windows.Forms.Label()
        Me.label_v_o_t = New System.Windows.Forms.Label()
        Me.btn_calc = New GrowPro.SubspaceButton()
        Me.gb_howmuch = New GrowPro.Subspacegroupbox()
        Me.label_v_kwh = New System.Windows.Forms.Label()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.label_v_cost = New System.Windows.Forms.Label()
        Me.gb_air = New GrowPro.Subspacegroupbox()
        Me.label_v_watt = New System.Windows.Forms.Label()
        Me.txt_a_power = New System.Windows.Forms.TextBox()
        Me.label_v_p = New System.Windows.Forms.Label()
        Me.btn_mini = New GrowPro.SubspaceButton()
        Me.gb_lamp_flower = New GrowPro.Subspacegroupbox()
        Me.label_v_f_watt = New System.Windows.Forms.Label()
        Me.txt_b_power = New System.Windows.Forms.TextBox()
        Me.cb_b_hours = New System.Windows.Forms.ComboBox()
        Me.label_v_f_p = New System.Windows.Forms.Label()
        Me.txt_b_days = New System.Windows.Forms.TextBox()
        Me.label_v_f_h = New System.Windows.Forms.Label()
        Me.label_v_f_t = New System.Windows.Forms.Label()
        Me.gb_lamp_grow = New GrowPro.Subspacegroupbox()
        Me.label_v_g_watt = New System.Windows.Forms.Label()
        Me.txt_w_power = New System.Windows.Forms.TextBox()
        Me.cb_w_hours = New System.Windows.Forms.ComboBox()
        Me.label_v_g_p = New System.Windows.Forms.Label()
        Me.txt_w_days = New System.Windows.Forms.TextBox()
        Me.label_v_g_h = New System.Windows.Forms.Label()
        Me.label_v_g_t = New System.Windows.Forms.Label()
        Me.btn_close = New GrowPro.SubspaceButton()
        Me.ss_theme_calc.SuspendLayout()
        Me.gb_result.SuspendLayout()
        Me.gb_others.SuspendLayout()
        Me.gb_howmuch.SuspendLayout()
        Me.gb_air.SuspendLayout()
        Me.gb_lamp_flower.SuspendLayout()
        Me.gb_lamp_grow.SuspendLayout()
        Me.SuspendLayout()
        '
        'ss_theme_calc
        '
        Me.ss_theme_calc.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ss_theme_calc.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ss_theme_calc.Colors = New GrowPro.Bloom(-1) {}
        Me.ss_theme_calc.Controls.Add(Me.gb_result)
        Me.ss_theme_calc.Controls.Add(Me.gb_others)
        Me.ss_theme_calc.Controls.Add(Me.btn_calc)
        Me.ss_theme_calc.Controls.Add(Me.gb_howmuch)
        Me.ss_theme_calc.Controls.Add(Me.gb_air)
        Me.ss_theme_calc.Controls.Add(Me.btn_mini)
        Me.ss_theme_calc.Controls.Add(Me.gb_lamp_flower)
        Me.ss_theme_calc.Controls.Add(Me.gb_lamp_grow)
        Me.ss_theme_calc.Controls.Add(Me.btn_close)
        Me.ss_theme_calc.Customization = ""
        Me.ss_theme_calc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ss_theme_calc.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.ss_theme_calc.Image = Nothing
        Me.ss_theme_calc.Location = New System.Drawing.Point(0, 0)
        Me.ss_theme_calc.Movable = True
        Me.ss_theme_calc.Name = "ss_theme_calc"
        Me.ss_theme_calc.NoRounding = False
        Me.ss_theme_calc.Sizable = False
        Me.ss_theme_calc.Size = New System.Drawing.Size(575, 516)
        Me.ss_theme_calc.SmartBounds = True
        Me.ss_theme_calc.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.ss_theme_calc.TabIndex = 0
        Me.ss_theme_calc.Text = "Stromkostenrechner"
        Me.ss_theme_calc.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ss_theme_calc.Transparent = False
        '
        'gb_result
        '
        Me.gb_result.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.gb_result.Colors = New GrowPro.Bloom(-1) {}
        Me.gb_result.Controls.Add(Me.txt_result)
        Me.gb_result.Customization = ""
        Me.gb_result.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.gb_result.Image = Nothing
        Me.gb_result.Location = New System.Drawing.Point(12, 302)
        Me.gb_result.Movable = True
        Me.gb_result.Name = "gb_result"
        Me.gb_result.NoRounding = False
        Me.gb_result.Sizable = True
        Me.gb_result.Size = New System.Drawing.Size(550, 180)
        Me.gb_result.SmartBounds = True
        Me.gb_result.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.gb_result.TabIndex = 17
        Me.gb_result.Text = "Kosten und Verbrauch"
        Me.gb_result.TransparencyKey = System.Drawing.Color.Empty
        Me.gb_result.Transparent = False
        '
        'txt_result
        '
        Me.txt_result.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txt_result.ForeColor = System.Drawing.Color.White
        Me.txt_result.Location = New System.Drawing.Point(12, 26)
        Me.txt_result.Name = "txt_result"
        Me.txt_result.Size = New System.Drawing.Size(526, 140)
        Me.txt_result.TabIndex = 16
        Me.txt_result.Text = ""
        '
        'gb_others
        '
        Me.gb_others.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.gb_others.Colors = New GrowPro.Bloom(-1) {}
        Me.gb_others.Controls.Add(Me.label_v_o_watt)
        Me.gb_others.Controls.Add(Me.txt_sv_power)
        Me.gb_others.Controls.Add(Me.cb_sv_hours)
        Me.gb_others.Controls.Add(Me.label_v_o_p)
        Me.gb_others.Controls.Add(Me.txt_sv_days)
        Me.gb_others.Controls.Add(Me.label_v_o_h)
        Me.gb_others.Controls.Add(Me.label_v_o_t)
        Me.gb_others.Customization = ""
        Me.gb_others.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.gb_others.Image = Nothing
        Me.gb_others.Location = New System.Drawing.Point(12, 170)
        Me.gb_others.Movable = True
        Me.gb_others.Name = "gb_others"
        Me.gb_others.NoRounding = False
        Me.gb_others.Sizable = True
        Me.gb_others.Size = New System.Drawing.Size(272, 126)
        Me.gb_others.SmartBounds = True
        Me.gb_others.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.gb_others.TabIndex = 14
        Me.gb_others.Text = "Sonstiger Verbraucher"
        Me.gb_others.TransparencyKey = System.Drawing.Color.Empty
        Me.gb_others.Transparent = False
        '
        'label_v_o_watt
        '
        Me.label_v_o_watt.AutoSize = True
        Me.label_v_o_watt.ForeColor = System.Drawing.Color.White
        Me.label_v_o_watt.Location = New System.Drawing.Point(218, 93)
        Me.label_v_o_watt.Name = "label_v_o_watt"
        Me.label_v_o_watt.Size = New System.Drawing.Size(33, 13)
        Me.label_v_o_watt.TabIndex = 13
        Me.label_v_o_watt.Text = "Watt"
        '
        'txt_sv_power
        '
        Me.txt_sv_power.Location = New System.Drawing.Point(177, 86)
        Me.txt_sv_power.Name = "txt_sv_power"
        Me.txt_sv_power.Size = New System.Drawing.Size(35, 20)
        Me.txt_sv_power.TabIndex = 12
        '
        'cb_sv_hours
        '
        Me.cb_sv_hours.FormattingEnabled = True
        Me.cb_sv_hours.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24"})
        Me.cb_sv_hours.Location = New System.Drawing.Point(177, 59)
        Me.cb_sv_hours.Name = "cb_sv_hours"
        Me.cb_sv_hours.Size = New System.Drawing.Size(35, 21)
        Me.cb_sv_hours.TabIndex = 11
        Me.cb_sv_hours.Text = "--"
        '
        'label_v_o_p
        '
        Me.label_v_o_p.AutoSize = True
        Me.label_v_o_p.ForeColor = System.Drawing.Color.White
        Me.label_v_o_p.Location = New System.Drawing.Point(19, 89)
        Me.label_v_o_p.Name = "label_v_o_p"
        Me.label_v_o_p.Size = New System.Drawing.Size(59, 13)
        Me.label_v_o_p.TabIndex = 8
        Me.label_v_o_p.Text = "Leistung:"
        '
        'txt_sv_days
        '
        Me.txt_sv_days.Location = New System.Drawing.Point(177, 33)
        Me.txt_sv_days.Name = "txt_sv_days"
        Me.txt_sv_days.Size = New System.Drawing.Size(35, 20)
        Me.txt_sv_days.TabIndex = 10
        '
        'label_v_o_h
        '
        Me.label_v_o_h.AutoSize = True
        Me.label_v_o_h.ForeColor = System.Drawing.Color.White
        Me.label_v_o_h.Location = New System.Drawing.Point(19, 62)
        Me.label_v_o_h.Name = "label_v_o_h"
        Me.label_v_o_h.Size = New System.Drawing.Size(124, 13)
        Me.label_v_o_h.TabIndex = 9
        Me.label_v_o_h.Text = "Anzahl der Stunden:"
        '
        'label_v_o_t
        '
        Me.label_v_o_t.AutoSize = True
        Me.label_v_o_t.ForeColor = System.Drawing.Color.White
        Me.label_v_o_t.Location = New System.Drawing.Point(19, 36)
        Me.label_v_o_t.Name = "label_v_o_t"
        Me.label_v_o_t.Size = New System.Drawing.Size(105, 13)
        Me.label_v_o_t.TabIndex = 7
        Me.label_v_o_t.Text = "Anzahl der Tage:"
        '
        'btn_calc
        '
        Me.btn_calc.BackColor = System.Drawing.Color.Transparent
        Me.btn_calc.Colors = New GrowPro.Bloom(-1) {}
        Me.btn_calc.Customization = ""
        Me.btn_calc.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn_calc.Image = Nothing
        Me.btn_calc.Location = New System.Drawing.Point(12, 488)
        Me.btn_calc.Name = "btn_calc"
        Me.btn_calc.NoRounding = False
        Me.btn_calc.Size = New System.Drawing.Size(550, 23)
        Me.btn_calc.TabIndex = 15
        Me.btn_calc.Text = "Stromkosten Berechnen"
        Me.btn_calc.Transparent = True
        '
        'gb_howmuch
        '
        Me.gb_howmuch.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.gb_howmuch.Colors = New GrowPro.Bloom(-1) {}
        Me.gb_howmuch.Controls.Add(Me.label_v_kwh)
        Me.gb_howmuch.Controls.Add(Me.txt_price)
        Me.gb_howmuch.Controls.Add(Me.label_v_cost)
        Me.gb_howmuch.Customization = ""
        Me.gb_howmuch.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.gb_howmuch.Image = Nothing
        Me.gb_howmuch.Location = New System.Drawing.Point(290, 238)
        Me.gb_howmuch.Movable = True
        Me.gb_howmuch.Name = "gb_howmuch"
        Me.gb_howmuch.NoRounding = False
        Me.gb_howmuch.Sizable = True
        Me.gb_howmuch.Size = New System.Drawing.Size(272, 57)
        Me.gb_howmuch.SmartBounds = True
        Me.gb_howmuch.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.gb_howmuch.TabIndex = 8
        Me.gb_howmuch.Text = "Stromkosten"
        Me.gb_howmuch.TransparencyKey = System.Drawing.Color.Empty
        Me.gb_howmuch.Transparent = False
        '
        'label_v_kwh
        '
        Me.label_v_kwh.AutoSize = True
        Me.label_v_kwh.ForeColor = System.Drawing.Color.White
        Me.label_v_kwh.Location = New System.Drawing.Point(216, 29)
        Me.label_v_kwh.Name = "label_v_kwh"
        Me.label_v_kwh.Size = New System.Drawing.Size(44, 13)
        Me.label_v_kwh.TabIndex = 6
        Me.label_v_kwh.Text = "€/kWh"
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(177, 22)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(35, 20)
        Me.txt_price.TabIndex = 5
        Me.txt_price.Text = "0,25"
        '
        'label_v_cost
        '
        Me.label_v_cost.AutoSize = True
        Me.label_v_cost.ForeColor = System.Drawing.Color.White
        Me.label_v_cost.Location = New System.Drawing.Point(19, 25)
        Me.label_v_cost.Name = "label_v_cost"
        Me.label_v_cost.Size = New System.Drawing.Size(85, 13)
        Me.label_v_cost.TabIndex = 1
        Me.label_v_cost.Text = "Stromkosten:"
        '
        'gb_air
        '
        Me.gb_air.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.gb_air.Colors = New GrowPro.Bloom(-1) {}
        Me.gb_air.Controls.Add(Me.label_v_watt)
        Me.gb_air.Controls.Add(Me.txt_a_power)
        Me.gb_air.Controls.Add(Me.label_v_p)
        Me.gb_air.Customization = ""
        Me.gb_air.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.gb_air.Image = Nothing
        Me.gb_air.Location = New System.Drawing.Point(290, 170)
        Me.gb_air.Movable = True
        Me.gb_air.Name = "gb_air"
        Me.gb_air.NoRounding = False
        Me.gb_air.Sizable = True
        Me.gb_air.Size = New System.Drawing.Size(272, 62)
        Me.gb_air.SmartBounds = True
        Me.gb_air.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.gb_air.TabIndex = 14
        Me.gb_air.Text = "Belüftung (Zu- und Abluft)"
        Me.gb_air.TransparencyKey = System.Drawing.Color.Empty
        Me.gb_air.Transparent = False
        '
        'label_v_watt
        '
        Me.label_v_watt.AutoSize = True
        Me.label_v_watt.ForeColor = System.Drawing.Color.White
        Me.label_v_watt.Location = New System.Drawing.Point(218, 34)
        Me.label_v_watt.Name = "label_v_watt"
        Me.label_v_watt.Size = New System.Drawing.Size(33, 13)
        Me.label_v_watt.TabIndex = 13
        Me.label_v_watt.Text = "Watt"
        '
        'txt_a_power
        '
        Me.txt_a_power.Location = New System.Drawing.Point(177, 27)
        Me.txt_a_power.Name = "txt_a_power"
        Me.txt_a_power.Size = New System.Drawing.Size(35, 20)
        Me.txt_a_power.TabIndex = 12
        '
        'label_v_p
        '
        Me.label_v_p.AutoSize = True
        Me.label_v_p.ForeColor = System.Drawing.Color.White
        Me.label_v_p.Location = New System.Drawing.Point(19, 30)
        Me.label_v_p.Name = "label_v_p"
        Me.label_v_p.Size = New System.Drawing.Size(59, 13)
        Me.label_v_p.TabIndex = 8
        Me.label_v_p.Text = "Leistung:"
        '
        'btn_mini
        '
        Me.btn_mini.BackColor = System.Drawing.Color.Transparent
        Me.btn_mini.Colors = New GrowPro.Bloom(-1) {}
        Me.btn_mini.Customization = ""
        Me.btn_mini.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn_mini.Image = Nothing
        Me.btn_mini.Location = New System.Drawing.Point(520, 3)
        Me.btn_mini.Name = "btn_mini"
        Me.btn_mini.NoRounding = False
        Me.btn_mini.Size = New System.Drawing.Size(23, 23)
        Me.btn_mini.TabIndex = 6
        Me.btn_mini.Text = "_"
        Me.btn_mini.Transparent = True
        '
        'gb_lamp_flower
        '
        Me.gb_lamp_flower.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.gb_lamp_flower.Colors = New GrowPro.Bloom(-1) {}
        Me.gb_lamp_flower.Controls.Add(Me.label_v_f_watt)
        Me.gb_lamp_flower.Controls.Add(Me.txt_b_power)
        Me.gb_lamp_flower.Controls.Add(Me.cb_b_hours)
        Me.gb_lamp_flower.Controls.Add(Me.label_v_f_p)
        Me.gb_lamp_flower.Controls.Add(Me.txt_b_days)
        Me.gb_lamp_flower.Controls.Add(Me.label_v_f_h)
        Me.gb_lamp_flower.Controls.Add(Me.label_v_f_t)
        Me.gb_lamp_flower.Customization = ""
        Me.gb_lamp_flower.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.gb_lamp_flower.Image = Nothing
        Me.gb_lamp_flower.Location = New System.Drawing.Point(290, 38)
        Me.gb_lamp_flower.Movable = True
        Me.gb_lamp_flower.Name = "gb_lamp_flower"
        Me.gb_lamp_flower.NoRounding = False
        Me.gb_lamp_flower.Sizable = True
        Me.gb_lamp_flower.Size = New System.Drawing.Size(272, 126)
        Me.gb_lamp_flower.SmartBounds = True
        Me.gb_lamp_flower.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.gb_lamp_flower.TabIndex = 8
        Me.gb_lamp_flower.Text = "Blütesphase"
        Me.gb_lamp_flower.TransparencyKey = System.Drawing.Color.Empty
        Me.gb_lamp_flower.Transparent = False
        '
        'label_v_f_watt
        '
        Me.label_v_f_watt.AutoSize = True
        Me.label_v_f_watt.ForeColor = System.Drawing.Color.White
        Me.label_v_f_watt.Location = New System.Drawing.Point(218, 93)
        Me.label_v_f_watt.Name = "label_v_f_watt"
        Me.label_v_f_watt.Size = New System.Drawing.Size(33, 13)
        Me.label_v_f_watt.TabIndex = 13
        Me.label_v_f_watt.Text = "Watt"
        '
        'txt_b_power
        '
        Me.txt_b_power.Location = New System.Drawing.Point(177, 86)
        Me.txt_b_power.Name = "txt_b_power"
        Me.txt_b_power.Size = New System.Drawing.Size(35, 20)
        Me.txt_b_power.TabIndex = 12
        '
        'cb_b_hours
        '
        Me.cb_b_hours.FormattingEnabled = True
        Me.cb_b_hours.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24"})
        Me.cb_b_hours.Location = New System.Drawing.Point(177, 59)
        Me.cb_b_hours.Name = "cb_b_hours"
        Me.cb_b_hours.Size = New System.Drawing.Size(35, 21)
        Me.cb_b_hours.TabIndex = 11
        Me.cb_b_hours.Text = "--"
        '
        'label_v_f_p
        '
        Me.label_v_f_p.AutoSize = True
        Me.label_v_f_p.ForeColor = System.Drawing.Color.White
        Me.label_v_f_p.Location = New System.Drawing.Point(19, 89)
        Me.label_v_f_p.Name = "label_v_f_p"
        Me.label_v_f_p.Size = New System.Drawing.Size(59, 13)
        Me.label_v_f_p.TabIndex = 8
        Me.label_v_f_p.Text = "Leistung:"
        '
        'txt_b_days
        '
        Me.txt_b_days.Location = New System.Drawing.Point(177, 33)
        Me.txt_b_days.Name = "txt_b_days"
        Me.txt_b_days.Size = New System.Drawing.Size(35, 20)
        Me.txt_b_days.TabIndex = 10
        '
        'label_v_f_h
        '
        Me.label_v_f_h.AutoSize = True
        Me.label_v_f_h.ForeColor = System.Drawing.Color.White
        Me.label_v_f_h.Location = New System.Drawing.Point(19, 62)
        Me.label_v_f_h.Name = "label_v_f_h"
        Me.label_v_f_h.Size = New System.Drawing.Size(124, 13)
        Me.label_v_f_h.TabIndex = 9
        Me.label_v_f_h.Text = "Anzahl der Stunden:"
        '
        'label_v_f_t
        '
        Me.label_v_f_t.AutoSize = True
        Me.label_v_f_t.ForeColor = System.Drawing.Color.White
        Me.label_v_f_t.Location = New System.Drawing.Point(19, 36)
        Me.label_v_f_t.Name = "label_v_f_t"
        Me.label_v_f_t.Size = New System.Drawing.Size(105, 13)
        Me.label_v_f_t.TabIndex = 7
        Me.label_v_f_t.Text = "Anzahl der Tage:"
        '
        'gb_lamp_grow
        '
        Me.gb_lamp_grow.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.gb_lamp_grow.Colors = New GrowPro.Bloom(-1) {}
        Me.gb_lamp_grow.Controls.Add(Me.label_v_g_watt)
        Me.gb_lamp_grow.Controls.Add(Me.txt_w_power)
        Me.gb_lamp_grow.Controls.Add(Me.cb_w_hours)
        Me.gb_lamp_grow.Controls.Add(Me.label_v_g_p)
        Me.gb_lamp_grow.Controls.Add(Me.txt_w_days)
        Me.gb_lamp_grow.Controls.Add(Me.label_v_g_h)
        Me.gb_lamp_grow.Controls.Add(Me.label_v_g_t)
        Me.gb_lamp_grow.Customization = ""
        Me.gb_lamp_grow.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.gb_lamp_grow.Image = Nothing
        Me.gb_lamp_grow.Location = New System.Drawing.Point(12, 38)
        Me.gb_lamp_grow.Movable = True
        Me.gb_lamp_grow.Name = "gb_lamp_grow"
        Me.gb_lamp_grow.NoRounding = False
        Me.gb_lamp_grow.Sizable = True
        Me.gb_lamp_grow.Size = New System.Drawing.Size(272, 126)
        Me.gb_lamp_grow.SmartBounds = True
        Me.gb_lamp_grow.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.gb_lamp_grow.TabIndex = 7
        Me.gb_lamp_grow.Text = "Wachstumsphase"
        Me.gb_lamp_grow.TransparencyKey = System.Drawing.Color.Empty
        Me.gb_lamp_grow.Transparent = False
        '
        'label_v_g_watt
        '
        Me.label_v_g_watt.AutoSize = True
        Me.label_v_g_watt.ForeColor = System.Drawing.Color.White
        Me.label_v_g_watt.Location = New System.Drawing.Point(218, 95)
        Me.label_v_g_watt.Name = "label_v_g_watt"
        Me.label_v_g_watt.Size = New System.Drawing.Size(33, 13)
        Me.label_v_g_watt.TabIndex = 6
        Me.label_v_g_watt.Text = "Watt"
        '
        'txt_w_power
        '
        Me.txt_w_power.Location = New System.Drawing.Point(177, 88)
        Me.txt_w_power.Name = "txt_w_power"
        Me.txt_w_power.Size = New System.Drawing.Size(35, 20)
        Me.txt_w_power.TabIndex = 5
        '
        'cb_w_hours
        '
        Me.cb_w_hours.FormattingEnabled = True
        Me.cb_w_hours.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24"})
        Me.cb_w_hours.Location = New System.Drawing.Point(177, 61)
        Me.cb_w_hours.Name = "cb_w_hours"
        Me.cb_w_hours.Size = New System.Drawing.Size(35, 21)
        Me.cb_w_hours.TabIndex = 4
        Me.cb_w_hours.Text = "--"
        '
        'label_v_g_p
        '
        Me.label_v_g_p.AutoSize = True
        Me.label_v_g_p.ForeColor = System.Drawing.Color.White
        Me.label_v_g_p.Location = New System.Drawing.Point(19, 91)
        Me.label_v_g_p.Name = "label_v_g_p"
        Me.label_v_g_p.Size = New System.Drawing.Size(59, 13)
        Me.label_v_g_p.TabIndex = 1
        Me.label_v_g_p.Text = "Leistung:"
        '
        'txt_w_days
        '
        Me.txt_w_days.Location = New System.Drawing.Point(177, 35)
        Me.txt_w_days.Name = "txt_w_days"
        Me.txt_w_days.Size = New System.Drawing.Size(35, 20)
        Me.txt_w_days.TabIndex = 3
        '
        'label_v_g_h
        '
        Me.label_v_g_h.AutoSize = True
        Me.label_v_g_h.ForeColor = System.Drawing.Color.White
        Me.label_v_g_h.Location = New System.Drawing.Point(19, 64)
        Me.label_v_g_h.Name = "label_v_g_h"
        Me.label_v_g_h.Size = New System.Drawing.Size(124, 13)
        Me.label_v_g_h.TabIndex = 2
        Me.label_v_g_h.Text = "Anzahl der Stunden:"
        '
        'label_v_g_t
        '
        Me.label_v_g_t.AutoSize = True
        Me.label_v_g_t.ForeColor = System.Drawing.Color.White
        Me.label_v_g_t.Location = New System.Drawing.Point(19, 38)
        Me.label_v_g_t.Name = "label_v_g_t"
        Me.label_v_g_t.Size = New System.Drawing.Size(105, 13)
        Me.label_v_g_t.TabIndex = 0
        Me.label_v_g_t.Text = "Anzahl der Tage:"
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.Transparent
        Me.btn_close.Colors = New GrowPro.Bloom(-1) {}
        Me.btn_close.Customization = ""
        Me.btn_close.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn_close.Image = Nothing
        Me.btn_close.Location = New System.Drawing.Point(549, 3)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.NoRounding = False
        Me.btn_close.Size = New System.Drawing.Size(23, 23)
        Me.btn_close.TabIndex = 5
        Me.btn_close.Text = "x"
        Me.btn_close.Transparent = True
        '
        'calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 516)
        Me.Controls.Add(Me.ss_theme_calc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "calculator"
        Me.Text = "Stromkostenrechner"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ss_theme_calc.ResumeLayout(False)
        Me.gb_result.ResumeLayout(False)
        Me.gb_others.ResumeLayout(False)
        Me.gb_others.PerformLayout()
        Me.gb_howmuch.ResumeLayout(False)
        Me.gb_howmuch.PerformLayout()
        Me.gb_air.ResumeLayout(False)
        Me.gb_air.PerformLayout()
        Me.gb_lamp_flower.ResumeLayout(False)
        Me.gb_lamp_flower.PerformLayout()
        Me.gb_lamp_grow.ResumeLayout(False)
        Me.gb_lamp_grow.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ss_theme_calc As GrowPro.SubspaceTheme
    Friend WithEvents btn_mini As GrowPro.SubspaceButton
    Friend WithEvents btn_close As GrowPro.SubspaceButton
    Friend WithEvents gb_lamp_grow As GrowPro.Subspacegroupbox
    Friend WithEvents gb_lamp_flower As GrowPro.Subspacegroupbox
    Friend WithEvents txt_result As System.Windows.Forms.RichTextBox
    Friend WithEvents btn_calc As GrowPro.SubspaceButton
    Friend WithEvents gb_howmuch As GrowPro.Subspacegroupbox
    Friend WithEvents label_v_kwh As System.Windows.Forms.Label
    Friend WithEvents txt_price As System.Windows.Forms.TextBox
    Friend WithEvents label_v_cost As System.Windows.Forms.Label
    Friend WithEvents gb_air As GrowPro.Subspacegroupbox
    Friend WithEvents label_v_watt As System.Windows.Forms.Label
    Friend WithEvents txt_a_power As System.Windows.Forms.TextBox
    Friend WithEvents label_v_p As System.Windows.Forms.Label
    Friend WithEvents label_v_f_watt As System.Windows.Forms.Label
    Friend WithEvents txt_b_power As System.Windows.Forms.TextBox
    Friend WithEvents cb_b_hours As System.Windows.Forms.ComboBox
    Friend WithEvents label_v_f_p As System.Windows.Forms.Label
    Friend WithEvents txt_b_days As System.Windows.Forms.TextBox
    Friend WithEvents label_v_f_h As System.Windows.Forms.Label
    Friend WithEvents label_v_f_t As System.Windows.Forms.Label
    Friend WithEvents label_v_g_watt As System.Windows.Forms.Label
    Friend WithEvents txt_w_power As System.Windows.Forms.TextBox
    Friend WithEvents cb_w_hours As System.Windows.Forms.ComboBox
    Friend WithEvents label_v_g_p As System.Windows.Forms.Label
    Friend WithEvents txt_w_days As System.Windows.Forms.TextBox
    Friend WithEvents label_v_g_h As System.Windows.Forms.Label
    Friend WithEvents label_v_g_t As System.Windows.Forms.Label
    Friend WithEvents gb_result As GrowPro.Subspacegroupbox
    Friend WithEvents gb_others As GrowPro.Subspacegroupbox
    Friend WithEvents label_v_o_watt As System.Windows.Forms.Label
    Friend WithEvents txt_sv_power As System.Windows.Forms.TextBox
    Friend WithEvents cb_sv_hours As System.Windows.Forms.ComboBox
    Friend WithEvents label_v_o_p As System.Windows.Forms.Label
    Friend WithEvents txt_sv_days As System.Windows.Forms.TextBox
    Friend WithEvents label_v_o_h As System.Windows.Forms.Label
    Friend WithEvents label_v_o_t As System.Windows.Forms.Label
End Class
