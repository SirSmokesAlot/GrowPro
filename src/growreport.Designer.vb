<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class growreport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(growreport))
        Me.color_dialog = New System.Windows.Forms.ColorDialog()
        Me.ss_theme_grep = New GrowPro.SubspaceTheme()
        Me.txt_dry = New System.Windows.Forms.TextBox()
        Me.label_v_t4 = New System.Windows.Forms.Label()
        Me.label_v_dye = New System.Windows.Forms.Label()
        Me.txt_flower = New System.Windows.Forms.TextBox()
        Me.label_v_t3 = New System.Windows.Forms.Label()
        Me.label_v_flower = New System.Windows.Forms.Label()
        Me.txt_grow = New System.Windows.Forms.TextBox()
        Me.label_v_t2 = New System.Windows.Forms.Label()
        Me.label_v_grow = New System.Windows.Forms.Label()
        Me.txt_begin = New System.Windows.Forms.TextBox()
        Me.label_v_t1 = New System.Windows.Forms.Label()
        Me.label_v_growth = New System.Windows.Forms.Label()
        Me.btn_crossed = New GrowPro.SubspaceButton()
        Me.btn_underline = New GrowPro.SubspaceButton()
        Me.btn_italian = New GrowPro.SubspaceButton()
        Me.btn_bold = New GrowPro.SubspaceButton()
        Me.btn_color = New GrowPro.SubspaceButton()
        Me.btn_mini = New GrowPro.SubspaceButton()
        Me.btn_close = New GrowPro.SubspaceButton()
        Me.btn_gen = New GrowPro.SubspaceButton()
        Me.bb_code = New System.Windows.Forms.RichTextBox()
        Me.ss_theme_grep.SuspendLayout()
        Me.SuspendLayout()
        '
        'ss_theme_grep
        '
        Me.ss_theme_grep.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ss_theme_grep.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ss_theme_grep.Colors = New GrowPro.Bloom(-1) {}
        Me.ss_theme_grep.Controls.Add(Me.txt_dry)
        Me.ss_theme_grep.Controls.Add(Me.label_v_t4)
        Me.ss_theme_grep.Controls.Add(Me.label_v_dye)
        Me.ss_theme_grep.Controls.Add(Me.txt_flower)
        Me.ss_theme_grep.Controls.Add(Me.label_v_t3)
        Me.ss_theme_grep.Controls.Add(Me.label_v_flower)
        Me.ss_theme_grep.Controls.Add(Me.txt_grow)
        Me.ss_theme_grep.Controls.Add(Me.label_v_t2)
        Me.ss_theme_grep.Controls.Add(Me.label_v_grow)
        Me.ss_theme_grep.Controls.Add(Me.txt_begin)
        Me.ss_theme_grep.Controls.Add(Me.label_v_t1)
        Me.ss_theme_grep.Controls.Add(Me.label_v_growth)
        Me.ss_theme_grep.Controls.Add(Me.btn_crossed)
        Me.ss_theme_grep.Controls.Add(Me.btn_underline)
        Me.ss_theme_grep.Controls.Add(Me.btn_italian)
        Me.ss_theme_grep.Controls.Add(Me.btn_bold)
        Me.ss_theme_grep.Controls.Add(Me.btn_color)
        Me.ss_theme_grep.Controls.Add(Me.btn_mini)
        Me.ss_theme_grep.Controls.Add(Me.btn_close)
        Me.ss_theme_grep.Controls.Add(Me.btn_gen)
        Me.ss_theme_grep.Controls.Add(Me.bb_code)
        Me.ss_theme_grep.Customization = ""
        Me.ss_theme_grep.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ss_theme_grep.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.ss_theme_grep.Image = Nothing
        Me.ss_theme_grep.Location = New System.Drawing.Point(0, 0)
        Me.ss_theme_grep.Movable = True
        Me.ss_theme_grep.Name = "ss_theme_grep"
        Me.ss_theme_grep.NoRounding = False
        Me.ss_theme_grep.Sizable = False
        Me.ss_theme_grep.Size = New System.Drawing.Size(660, 297)
        Me.ss_theme_grep.SmartBounds = True
        Me.ss_theme_grep.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.ss_theme_grep.TabIndex = 0
        Me.ss_theme_grep.Text = "Growreport - BB Code Generator"
        Me.ss_theme_grep.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ss_theme_grep.Transparent = False
        '
        'txt_dry
        '
        Me.txt_dry.Location = New System.Drawing.Point(561, 40)
        Me.txt_dry.Name = "txt_dry"
        Me.txt_dry.Size = New System.Drawing.Size(42, 20)
        Me.txt_dry.TabIndex = 21
        '
        'label_v_t4
        '
        Me.label_v_t4.AutoSize = True
        Me.label_v_t4.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.label_v_t4.ForeColor = System.Drawing.Color.White
        Me.label_v_t4.Location = New System.Drawing.Point(606, 44)
        Me.label_v_t4.Name = "label_v_t4"
        Me.label_v_t4.Size = New System.Drawing.Size(12, 12)
        Me.label_v_t4.TabIndex = 20
        Me.label_v_t4.Text = "T"
        '
        'label_v_dye
        '
        Me.label_v_dye.AutoSize = True
        Me.label_v_dye.ForeColor = System.Drawing.Color.White
        Me.label_v_dye.Location = New System.Drawing.Point(483, 43)
        Me.label_v_dye.Name = "label_v_dye"
        Me.label_v_dye.Size = New System.Drawing.Size(72, 13)
        Me.label_v_dye.TabIndex = 19
        Me.label_v_dye.Text = "Trocknung:"
        '
        'txt_flower
        '
        Me.txt_flower.Location = New System.Drawing.Point(384, 40)
        Me.txt_flower.Name = "txt_flower"
        Me.txt_flower.Size = New System.Drawing.Size(42, 20)
        Me.txt_flower.TabIndex = 18
        '
        'label_v_t3
        '
        Me.label_v_t3.AutoSize = True
        Me.label_v_t3.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.label_v_t3.ForeColor = System.Drawing.Color.White
        Me.label_v_t3.Location = New System.Drawing.Point(429, 44)
        Me.label_v_t3.Name = "label_v_t3"
        Me.label_v_t3.Size = New System.Drawing.Size(12, 12)
        Me.label_v_t3.TabIndex = 17
        Me.label_v_t3.Text = "T"
        '
        'label_v_flower
        '
        Me.label_v_flower.AutoSize = True
        Me.label_v_flower.ForeColor = System.Drawing.Color.White
        Me.label_v_flower.Location = New System.Drawing.Point(340, 43)
        Me.label_v_flower.Name = "label_v_flower"
        Me.label_v_flower.Size = New System.Drawing.Size(41, 13)
        Me.label_v_flower.TabIndex = 16
        Me.label_v_flower.Text = "Blüte:"
        '
        'txt_grow
        '
        Me.txt_grow.Location = New System.Drawing.Point(240, 40)
        Me.txt_grow.Name = "txt_grow"
        Me.txt_grow.Size = New System.Drawing.Size(42, 20)
        Me.txt_grow.TabIndex = 15
        '
        'label_v_t2
        '
        Me.label_v_t2.AutoSize = True
        Me.label_v_t2.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.label_v_t2.ForeColor = System.Drawing.Color.White
        Me.label_v_t2.Location = New System.Drawing.Point(285, 44)
        Me.label_v_t2.Name = "label_v_t2"
        Me.label_v_t2.Size = New System.Drawing.Size(12, 12)
        Me.label_v_t2.TabIndex = 14
        Me.label_v_t2.Text = "T"
        '
        'label_v_grow
        '
        Me.label_v_grow.AutoSize = True
        Me.label_v_grow.ForeColor = System.Drawing.Color.White
        Me.label_v_grow.Location = New System.Drawing.Point(163, 43)
        Me.label_v_grow.Name = "label_v_grow"
        Me.label_v_grow.Size = New System.Drawing.Size(71, 13)
        Me.label_v_grow.TabIndex = 13
        Me.label_v_grow.Text = "Wachstum:"
        '
        'txt_begin
        '
        Me.txt_begin.Location = New System.Drawing.Point(79, 40)
        Me.txt_begin.Name = "txt_begin"
        Me.txt_begin.Size = New System.Drawing.Size(42, 20)
        Me.txt_begin.TabIndex = 12
        '
        'label_v_t1
        '
        Me.label_v_t1.AutoSize = True
        Me.label_v_t1.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.label_v_t1.ForeColor = System.Drawing.Color.White
        Me.label_v_t1.Location = New System.Drawing.Point(124, 44)
        Me.label_v_t1.Name = "label_v_t1"
        Me.label_v_t1.Size = New System.Drawing.Size(12, 12)
        Me.label_v_t1.TabIndex = 11
        Me.label_v_t1.Text = "T"
        '
        'label_v_growth
        '
        Me.label_v_growth.AutoSize = True
        Me.label_v_growth.ForeColor = System.Drawing.Color.White
        Me.label_v_growth.Location = New System.Drawing.Point(12, 43)
        Me.label_v_growth.Name = "label_v_growth"
        Me.label_v_growth.Size = New System.Drawing.Size(61, 13)
        Me.label_v_growth.TabIndex = 10
        Me.label_v_growth.Text = "Aufzucht:"
        '
        'btn_crossed
        '
        Me.btn_crossed.BackColor = System.Drawing.Color.Transparent
        Me.btn_crossed.Colors = New GrowPro.Bloom(-1) {}
        Me.btn_crossed.Customization = ""
        Me.btn_crossed.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_crossed.Image = Nothing
        Me.btn_crossed.Location = New System.Drawing.Point(617, 256)
        Me.btn_crossed.Name = "btn_crossed"
        Me.btn_crossed.NoRounding = False
        Me.btn_crossed.Size = New System.Drawing.Size(27, 23)
        Me.btn_crossed.TabIndex = 9
        Me.btn_crossed.Text = "S"
        Me.btn_crossed.Transparent = True
        '
        'btn_underline
        '
        Me.btn_underline.BackColor = System.Drawing.Color.Transparent
        Me.btn_underline.Colors = New GrowPro.Bloom(-1) {}
        Me.btn_underline.Customization = ""
        Me.btn_underline.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_underline.Image = Nothing
        Me.btn_underline.Location = New System.Drawing.Point(584, 256)
        Me.btn_underline.Name = "btn_underline"
        Me.btn_underline.NoRounding = False
        Me.btn_underline.Size = New System.Drawing.Size(27, 23)
        Me.btn_underline.TabIndex = 8
        Me.btn_underline.Text = "U"
        Me.btn_underline.Transparent = True
        '
        'btn_italian
        '
        Me.btn_italian.BackColor = System.Drawing.Color.Transparent
        Me.btn_italian.Colors = New GrowPro.Bloom(-1) {}
        Me.btn_italian.Customization = ""
        Me.btn_italian.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_italian.Image = Nothing
        Me.btn_italian.Location = New System.Drawing.Point(551, 256)
        Me.btn_italian.Name = "btn_italian"
        Me.btn_italian.NoRounding = False
        Me.btn_italian.Size = New System.Drawing.Size(27, 23)
        Me.btn_italian.TabIndex = 7
        Me.btn_italian.Text = "I"
        Me.btn_italian.Transparent = True
        '
        'btn_bold
        '
        Me.btn_bold.BackColor = System.Drawing.Color.Transparent
        Me.btn_bold.Colors = New GrowPro.Bloom(-1) {}
        Me.btn_bold.Customization = ""
        Me.btn_bold.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_bold.Image = Nothing
        Me.btn_bold.Location = New System.Drawing.Point(518, 256)
        Me.btn_bold.Name = "btn_bold"
        Me.btn_bold.NoRounding = False
        Me.btn_bold.Size = New System.Drawing.Size(27, 23)
        Me.btn_bold.TabIndex = 6
        Me.btn_bold.Text = "B"
        Me.btn_bold.Transparent = True
        '
        'btn_color
        '
        Me.btn_color.BackColor = System.Drawing.Color.Transparent
        Me.btn_color.Colors = New GrowPro.Bloom(-1) {}
        Me.btn_color.Customization = ""
        Me.btn_color.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn_color.Image = Nothing
        Me.btn_color.Location = New System.Drawing.Point(452, 256)
        Me.btn_color.Name = "btn_color"
        Me.btn_color.NoRounding = False
        Me.btn_color.Size = New System.Drawing.Size(60, 23)
        Me.btn_color.TabIndex = 5
        Me.btn_color.Text = "Farbe"
        Me.btn_color.Transparent = True
        '
        'btn_mini
        '
        Me.btn_mini.BackColor = System.Drawing.Color.Transparent
        Me.btn_mini.Colors = New GrowPro.Bloom(-1) {}
        Me.btn_mini.Customization = ""
        Me.btn_mini.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn_mini.Image = Nothing
        Me.btn_mini.Location = New System.Drawing.Point(605, 3)
        Me.btn_mini.Name = "btn_mini"
        Me.btn_mini.NoRounding = False
        Me.btn_mini.Size = New System.Drawing.Size(23, 23)
        Me.btn_mini.TabIndex = 4
        Me.btn_mini.Text = "_"
        Me.btn_mini.Transparent = True
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.Transparent
        Me.btn_close.Colors = New GrowPro.Bloom(-1) {}
        Me.btn_close.Customization = ""
        Me.btn_close.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn_close.Image = Nothing
        Me.btn_close.Location = New System.Drawing.Point(634, 3)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.NoRounding = False
        Me.btn_close.Size = New System.Drawing.Size(23, 23)
        Me.btn_close.TabIndex = 3
        Me.btn_close.Text = "x"
        Me.btn_close.Transparent = True
        '
        'btn_gen
        '
        Me.btn_gen.BackColor = System.Drawing.Color.Transparent
        Me.btn_gen.Colors = New GrowPro.Bloom(-1) {}
        Me.btn_gen.Customization = ""
        Me.btn_gen.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn_gen.Image = Nothing
        Me.btn_gen.Location = New System.Drawing.Point(14, 256)
        Me.btn_gen.Name = "btn_gen"
        Me.btn_gen.NoRounding = False
        Me.btn_gen.Size = New System.Drawing.Size(432, 23)
        Me.btn_gen.TabIndex = 1
        Me.btn_gen.Text = "BB Code Erstellen"
        Me.btn_gen.Transparent = True
        '
        'bb_code
        '
        Me.bb_code.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.bb_code.Location = New System.Drawing.Point(14, 68)
        Me.bb_code.Name = "bb_code"
        Me.bb_code.Size = New System.Drawing.Size(630, 182)
        Me.bb_code.TabIndex = 0
        Me.bb_code.Text = ""
        '
        'growreport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 297)
        Me.Controls.Add(Me.ss_theme_grep)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "growreport"
        Me.Text = "Growreport"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ss_theme_grep.ResumeLayout(False)
        Me.ss_theme_grep.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ss_theme_grep As GrowPro.SubspaceTheme
    Friend WithEvents btn_gen As GrowPro.SubspaceButton
    Friend WithEvents bb_code As System.Windows.Forms.RichTextBox
    Friend WithEvents color_dialog As System.Windows.Forms.ColorDialog
    Friend WithEvents btn_mini As GrowPro.SubspaceButton
    Friend WithEvents btn_close As GrowPro.SubspaceButton
    Friend WithEvents btn_crossed As GrowPro.SubspaceButton
    Friend WithEvents btn_underline As GrowPro.SubspaceButton
    Friend WithEvents btn_italian As GrowPro.SubspaceButton
    Friend WithEvents btn_bold As GrowPro.SubspaceButton
    Friend WithEvents btn_color As GrowPro.SubspaceButton
    Friend WithEvents txt_dry As System.Windows.Forms.TextBox
    Friend WithEvents label_v_t4 As System.Windows.Forms.Label
    Friend WithEvents label_v_dye As System.Windows.Forms.Label
    Friend WithEvents txt_flower As System.Windows.Forms.TextBox
    Friend WithEvents label_v_t3 As System.Windows.Forms.Label
    Friend WithEvents label_v_flower As System.Windows.Forms.Label
    Friend WithEvents txt_grow As System.Windows.Forms.TextBox
    Friend WithEvents label_v_t2 As System.Windows.Forms.Label
    Friend WithEvents label_v_grow As System.Windows.Forms.Label
    Friend WithEvents txt_begin As System.Windows.Forms.TextBox
    Friend WithEvents label_v_t1 As System.Windows.Forms.Label
    Friend WithEvents label_v_growth As System.Windows.Forms.Label
End Class
