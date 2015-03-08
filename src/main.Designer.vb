<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Indoor")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Setups")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Projekt Erstellen")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Setup Erstellen")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Projekte", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4})
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Düngetabellen")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stromkostenrechner")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Basiswissen")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Licht & Beleuchtung")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bewässerung, Dünger & Erde")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Luft & Belüftung")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Samen & Stecklinge")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Wachstumsphase")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Blütephase")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ernte")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Probleme")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Hilfe", New System.Windows.Forms.TreeNode() {TreeNode8, TreeNode9, TreeNode10, TreeNode11, TreeNode12, TreeNode13, TreeNode14, TreeNode15, TreeNode16})
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("https://grower.ch/")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("http://forum.hanfburg.de/")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("http://opencannabis.net/")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Links", New System.Windows.Forms.TreeNode() {TreeNode18, TreeNode19, TreeNode20})
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Profil")
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("GrowPro", New System.Windows.Forms.TreeNode() {TreeNode22})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.ss_theme = New GrowPro.SubspaceTheme()
        Me.gbox_project = New GrowPro.Subspacegroupbox()
        Me.btn_nextp = New GrowPro.SubspaceButton()
        Me.btn_delete = New GrowPro.SubspaceButton()
        Me.btn_growreport = New GrowPro.SubspaceButton()
        Me.btn_edit = New GrowPro.SubspaceButton()
        Me.pbar_howfar = New GrowPro.SubspaceProgressbar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SubspaceSeperator1 = New GrowPro.SubspaceSeperator()
        Me.l_phase = New System.Windows.Forms.Label()
        Me.label_v_phase = New System.Windows.Forms.Label()
        Me.l_day = New System.Windows.Forms.Label()
        Me.label_v_day = New System.Windows.Forms.Label()
        Me.l_sdate = New System.Windows.Forms.Label()
        Me.label_v_startd = New System.Windows.Forms.Label()
        Me.l_setup = New System.Windows.Forms.Label()
        Me.label_v_setup = New System.Windows.Forms.Label()
        Me.l_count = New System.Windows.Forms.Label()
        Me.label_v_count = New System.Windows.Forms.Label()
        Me.l_earth = New System.Windows.Forms.Label()
        Me.label_v_earth = New System.Windows.Forms.Label()
        Me.l_gtype = New System.Windows.Forms.Label()
        Me.label_v_growth = New System.Windows.Forms.Label()
        Me.l_flower = New System.Windows.Forms.Label()
        Me.label_v_flower = New System.Windows.Forms.Label()
        Me.l_fem = New System.Windows.Forms.Label()
        Me.label_v_fem = New System.Windows.Forms.Label()
        Me.l_earning = New System.Windows.Forms.Label()
        Me.label_v_earning = New System.Windows.Forms.Label()
        Me.l_type = New System.Windows.Forms.Label()
        Me.label_v_genetic = New System.Windows.Forms.Label()
        Me.l_desc = New System.Windows.Forms.Label()
        Me.label_v_desc = New System.Windows.Forms.Label()
        Me.SubspaceSeperator2 = New GrowPro.SubspaceSeperator()
        Me.l5891796 = New System.Windows.Forms.Label()
        Me.tv_projects = New System.Windows.Forms.TreeView()
        Me.btn_mini = New GrowPro.SubspaceButton()
        Me.btn_close = New GrowPro.SubspaceButton()
        Me.ss_theme.SuspendLayout()
        Me.gbox_project.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ss_theme
        '
        Me.ss_theme.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ss_theme.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ss_theme.Colors = New GrowPro.Bloom(-1) {}
        Me.ss_theme.Controls.Add(Me.gbox_project)
        Me.ss_theme.Controls.Add(Me.l5891796)
        Me.ss_theme.Controls.Add(Me.tv_projects)
        Me.ss_theme.Controls.Add(Me.btn_mini)
        Me.ss_theme.Controls.Add(Me.btn_close)
        Me.ss_theme.Customization = ""
        Me.ss_theme.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ss_theme.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.ss_theme.Image = Nothing
        Me.ss_theme.Location = New System.Drawing.Point(0, 0)
        Me.ss_theme.Movable = True
        Me.ss_theme.Name = "ss_theme"
        Me.ss_theme.NoRounding = False
        Me.ss_theme.Sizable = False
        Me.ss_theme.Size = New System.Drawing.Size(1127, 565)
        Me.ss_theme.SmartBounds = True
        Me.ss_theme.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.ss_theme.TabIndex = 0
        Me.ss_theme.Text = "GrowPro - Main"
        Me.ss_theme.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ss_theme.Transparent = False
        '
        'gbox_project
        '
        Me.gbox_project.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.gbox_project.Colors = New GrowPro.Bloom(-1) {}
        Me.gbox_project.Controls.Add(Me.btn_nextp)
        Me.gbox_project.Controls.Add(Me.btn_delete)
        Me.gbox_project.Controls.Add(Me.btn_growreport)
        Me.gbox_project.Controls.Add(Me.btn_edit)
        Me.gbox_project.Controls.Add(Me.pbar_howfar)
        Me.gbox_project.Controls.Add(Me.PictureBox1)
        Me.gbox_project.Controls.Add(Me.SubspaceSeperator1)
        Me.gbox_project.Controls.Add(Me.l_phase)
        Me.gbox_project.Controls.Add(Me.label_v_phase)
        Me.gbox_project.Controls.Add(Me.l_day)
        Me.gbox_project.Controls.Add(Me.label_v_day)
        Me.gbox_project.Controls.Add(Me.l_sdate)
        Me.gbox_project.Controls.Add(Me.label_v_startd)
        Me.gbox_project.Controls.Add(Me.l_setup)
        Me.gbox_project.Controls.Add(Me.label_v_setup)
        Me.gbox_project.Controls.Add(Me.l_count)
        Me.gbox_project.Controls.Add(Me.label_v_count)
        Me.gbox_project.Controls.Add(Me.l_earth)
        Me.gbox_project.Controls.Add(Me.label_v_earth)
        Me.gbox_project.Controls.Add(Me.l_gtype)
        Me.gbox_project.Controls.Add(Me.label_v_growth)
        Me.gbox_project.Controls.Add(Me.l_flower)
        Me.gbox_project.Controls.Add(Me.label_v_flower)
        Me.gbox_project.Controls.Add(Me.l_fem)
        Me.gbox_project.Controls.Add(Me.label_v_fem)
        Me.gbox_project.Controls.Add(Me.l_earning)
        Me.gbox_project.Controls.Add(Me.label_v_earning)
        Me.gbox_project.Controls.Add(Me.l_type)
        Me.gbox_project.Controls.Add(Me.label_v_genetic)
        Me.gbox_project.Controls.Add(Me.l_desc)
        Me.gbox_project.Controls.Add(Me.label_v_desc)
        Me.gbox_project.Controls.Add(Me.SubspaceSeperator2)
        Me.gbox_project.Customization = ""
        Me.gbox_project.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.gbox_project.Image = Nothing
        Me.gbox_project.Location = New System.Drawing.Point(267, 38)
        Me.gbox_project.Movable = True
        Me.gbox_project.Name = "gbox_project"
        Me.gbox_project.NoRounding = False
        Me.gbox_project.Padding = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.gbox_project.Sizable = True
        Me.gbox_project.Size = New System.Drawing.Size(848, 508)
        Me.gbox_project.SmartBounds = True
        Me.gbox_project.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.gbox_project.TabIndex = 6
        Me.gbox_project.Text = "Projekt Übersicht"
        Me.gbox_project.TransparencyKey = System.Drawing.Color.Empty
        Me.gbox_project.Transparent = False
        '
        'btn_nextp
        '
        Me.btn_nextp.BackColor = System.Drawing.Color.Transparent
        Me.btn_nextp.Colors = New GrowPro.Bloom(-1) {}
        Me.btn_nextp.Customization = ""
        Me.btn_nextp.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn_nextp.Image = Nothing
        Me.btn_nextp.Location = New System.Drawing.Point(486, 464)
        Me.btn_nextp.Name = "btn_nextp"
        Me.btn_nextp.NoRounding = False
        Me.btn_nextp.Size = New System.Drawing.Size(227, 23)
        Me.btn_nextp.TabIndex = 39
        Me.btn_nextp.Text = "Nächste Phase"
        Me.btn_nextp.Transparent = True
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Transparent
        Me.btn_delete.Colors = New GrowPro.Bloom(-1) {}
        Me.btn_delete.Customization = ""
        Me.btn_delete.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn_delete.Image = Nothing
        Me.btn_delete.Location = New System.Drawing.Point(227, 464)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.NoRounding = False
        Me.btn_delete.Size = New System.Drawing.Size(121, 23)
        Me.btn_delete.TabIndex = 38
        Me.btn_delete.Text = "Löschen"
        Me.btn_delete.Transparent = True
        '
        'btn_growreport
        '
        Me.btn_growreport.BackColor = System.Drawing.Color.Transparent
        Me.btn_growreport.Colors = New GrowPro.Bloom(-1) {}
        Me.btn_growreport.Customization = ""
        Me.btn_growreport.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn_growreport.Image = Nothing
        Me.btn_growreport.Location = New System.Drawing.Point(354, 464)
        Me.btn_growreport.Name = "btn_growreport"
        Me.btn_growreport.NoRounding = False
        Me.btn_growreport.Size = New System.Drawing.Size(126, 23)
        Me.btn_growreport.TabIndex = 37
        Me.btn_growreport.Text = "Growreport"
        Me.btn_growreport.Transparent = True
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.Transparent
        Me.btn_edit.Colors = New GrowPro.Bloom(-1) {}
        Me.btn_edit.Customization = ""
        Me.btn_edit.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn_edit.Image = Nothing
        Me.btn_edit.Location = New System.Drawing.Point(100, 464)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.NoRounding = False
        Me.btn_edit.Size = New System.Drawing.Size(121, 23)
        Me.btn_edit.TabIndex = 36
        Me.btn_edit.Text = "Bearbeiten"
        Me.btn_edit.Transparent = True
        '
        'pbar_howfar
        '
        Me.pbar_howfar.Colors = New GrowPro.Bloom(-1) {}
        Me.pbar_howfar.Customization = ""
        Me.pbar_howfar.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.pbar_howfar.Image = Nothing
        Me.pbar_howfar.Location = New System.Drawing.Point(9, 96)
        Me.pbar_howfar.Maximum = 100
        Me.pbar_howfar.Name = "pbar_howfar"
        Me.pbar_howfar.NoRounding = False
        Me.pbar_howfar.Size = New System.Drawing.Size(831, 13)
        Me.pbar_howfar.TabIndex = 5
        Me.pbar_howfar.Transparent = False
        Me.pbar_howfar.Value = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GrowPro.My.Resources.Resources.growpro_phasen
        Me.PictureBox1.Location = New System.Drawing.Point(8, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(831, 60)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'SubspaceSeperator1
        '
        Me.SubspaceSeperator1.BackColor = System.Drawing.Color.Transparent
        Me.SubspaceSeperator1.Colors = New GrowPro.Bloom(-1) {}
        Me.SubspaceSeperator1.Customization = ""
        Me.SubspaceSeperator1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SubspaceSeperator1.Image = Nothing
        Me.SubspaceSeperator1.Location = New System.Drawing.Point(174, 40)
        Me.SubspaceSeperator1.Name = "SubspaceSeperator1"
        Me.SubspaceSeperator1.NoRounding = False
        Me.SubspaceSeperator1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.SubspaceSeperator1.Size = New System.Drawing.Size(14, 66)
        Me.SubspaceSeperator1.TabIndex = 34
        Me.SubspaceSeperator1.Text = "SubspaceSeperator1"
        Me.SubspaceSeperator1.Transparent = True
        '
        'l_phase
        '
        Me.l_phase.AutoSize = True
        Me.l_phase.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.l_phase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.l_phase.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_phase.ForeColor = System.Drawing.Color.White
        Me.l_phase.Location = New System.Drawing.Point(662, 323)
        Me.l_phase.Margin = New System.Windows.Forms.Padding(3)
        Me.l_phase.Name = "l_phase"
        Me.l_phase.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.l_phase.Size = New System.Drawing.Size(46, 20)
        Me.l_phase.TabIndex = 31
        Me.l_phase.Text = "(leer)"
        '
        'label_v_phase
        '
        Me.label_v_phase.AutoSize = True
        Me.label_v_phase.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_v_phase.ForeColor = System.Drawing.Color.White
        Me.label_v_phase.Location = New System.Drawing.Point(624, 295)
        Me.label_v_phase.Name = "label_v_phase"
        Me.label_v_phase.Size = New System.Drawing.Size(53, 16)
        Me.label_v_phase.TabIndex = 30
        Me.label_v_phase.Text = "Phase:"
        '
        'l_day
        '
        Me.l_day.AutoSize = True
        Me.l_day.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.l_day.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.l_day.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_day.ForeColor = System.Drawing.Color.White
        Me.l_day.Location = New System.Drawing.Point(662, 234)
        Me.l_day.Margin = New System.Windows.Forms.Padding(3)
        Me.l_day.Name = "l_day"
        Me.l_day.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.l_day.Size = New System.Drawing.Size(46, 20)
        Me.l_day.TabIndex = 29
        Me.l_day.Text = "(leer)"
        '
        'label_v_day
        '
        Me.label_v_day.AutoSize = True
        Me.label_v_day.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_v_day.ForeColor = System.Drawing.Color.White
        Me.label_v_day.Location = New System.Drawing.Point(624, 206)
        Me.label_v_day.Name = "label_v_day"
        Me.label_v_day.Size = New System.Drawing.Size(39, 16)
        Me.label_v_day.TabIndex = 28
        Me.label_v_day.Text = "Tag:"
        '
        'l_sdate
        '
        Me.l_sdate.AutoSize = True
        Me.l_sdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.l_sdate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.l_sdate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_sdate.ForeColor = System.Drawing.Color.White
        Me.l_sdate.Location = New System.Drawing.Point(662, 155)
        Me.l_sdate.Margin = New System.Windows.Forms.Padding(3)
        Me.l_sdate.Name = "l_sdate"
        Me.l_sdate.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.l_sdate.Size = New System.Drawing.Size(46, 20)
        Me.l_sdate.TabIndex = 27
        Me.l_sdate.Text = "(leer)"
        '
        'label_v_startd
        '
        Me.label_v_startd.AutoSize = True
        Me.label_v_startd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_v_startd.ForeColor = System.Drawing.Color.White
        Me.label_v_startd.Location = New System.Drawing.Point(624, 127)
        Me.label_v_startd.Name = "label_v_startd"
        Me.label_v_startd.Size = New System.Drawing.Size(89, 16)
        Me.label_v_startd.TabIndex = 26
        Me.label_v_startd.Text = "Startdatum:"
        '
        'l_setup
        '
        Me.l_setup.AutoSize = True
        Me.l_setup.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.l_setup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.l_setup.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_setup.ForeColor = System.Drawing.Color.White
        Me.l_setup.Location = New System.Drawing.Point(662, 406)
        Me.l_setup.Margin = New System.Windows.Forms.Padding(3)
        Me.l_setup.Name = "l_setup"
        Me.l_setup.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.l_setup.Size = New System.Drawing.Size(46, 20)
        Me.l_setup.TabIndex = 25
        Me.l_setup.Text = "(leer)"
        '
        'label_v_setup
        '
        Me.label_v_setup.AutoSize = True
        Me.label_v_setup.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_v_setup.ForeColor = System.Drawing.Color.White
        Me.label_v_setup.Location = New System.Drawing.Point(624, 378)
        Me.label_v_setup.Name = "label_v_setup"
        Me.label_v_setup.Size = New System.Drawing.Size(53, 16)
        Me.label_v_setup.TabIndex = 24
        Me.label_v_setup.Text = "Setup:"
        '
        'l_count
        '
        Me.l_count.AutoSize = True
        Me.l_count.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.l_count.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.l_count.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_count.ForeColor = System.Drawing.Color.White
        Me.l_count.Location = New System.Drawing.Point(386, 406)
        Me.l_count.Margin = New System.Windows.Forms.Padding(3)
        Me.l_count.Name = "l_count"
        Me.l_count.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.l_count.Size = New System.Drawing.Size(46, 20)
        Me.l_count.TabIndex = 23
        Me.l_count.Text = "(leer)"
        '
        'label_v_count
        '
        Me.label_v_count.AutoSize = True
        Me.label_v_count.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_v_count.ForeColor = System.Drawing.Color.White
        Me.label_v_count.Location = New System.Drawing.Point(348, 378)
        Me.label_v_count.Name = "label_v_count"
        Me.label_v_count.Size = New System.Drawing.Size(57, 16)
        Me.label_v_count.TabIndex = 22
        Me.label_v_count.Text = "Anzahl:"
        '
        'l_earth
        '
        Me.l_earth.AutoSize = True
        Me.l_earth.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.l_earth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.l_earth.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_earth.ForeColor = System.Drawing.Color.White
        Me.l_earth.Location = New System.Drawing.Point(386, 317)
        Me.l_earth.Margin = New System.Windows.Forms.Padding(3)
        Me.l_earth.Name = "l_earth"
        Me.l_earth.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.l_earth.Size = New System.Drawing.Size(46, 20)
        Me.l_earth.TabIndex = 21
        Me.l_earth.Text = "(leer)"
        '
        'label_v_earth
        '
        Me.label_v_earth.AutoSize = True
        Me.label_v_earth.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_v_earth.ForeColor = System.Drawing.Color.White
        Me.label_v_earth.Location = New System.Drawing.Point(348, 289)
        Me.label_v_earth.Name = "label_v_earth"
        Me.label_v_earth.Size = New System.Drawing.Size(43, 16)
        Me.label_v_earth.TabIndex = 20
        Me.label_v_earth.Text = "Erde:"
        '
        'l_gtype
        '
        Me.l_gtype.AutoSize = True
        Me.l_gtype.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.l_gtype.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.l_gtype.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_gtype.ForeColor = System.Drawing.Color.White
        Me.l_gtype.Location = New System.Drawing.Point(386, 238)
        Me.l_gtype.Margin = New System.Windows.Forms.Padding(3)
        Me.l_gtype.Name = "l_gtype"
        Me.l_gtype.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.l_gtype.Size = New System.Drawing.Size(46, 20)
        Me.l_gtype.TabIndex = 19
        Me.l_gtype.Text = "(leer)"
        '
        'label_v_growth
        '
        Me.label_v_growth.AutoSize = True
        Me.label_v_growth.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_v_growth.ForeColor = System.Drawing.Color.White
        Me.label_v_growth.Location = New System.Drawing.Point(348, 210)
        Me.label_v_growth.Name = "label_v_growth"
        Me.label_v_growth.Size = New System.Drawing.Size(73, 16)
        Me.label_v_growth.TabIndex = 18
        Me.label_v_growth.Text = "Aufzucht:"
        '
        'l_flower
        '
        Me.l_flower.AutoSize = True
        Me.l_flower.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.l_flower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.l_flower.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_flower.ForeColor = System.Drawing.Color.White
        Me.l_flower.Location = New System.Drawing.Point(130, 406)
        Me.l_flower.Margin = New System.Windows.Forms.Padding(3)
        Me.l_flower.Name = "l_flower"
        Me.l_flower.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.l_flower.Size = New System.Drawing.Size(46, 20)
        Me.l_flower.TabIndex = 17
        Me.l_flower.Text = "(leer)"
        '
        'label_v_flower
        '
        Me.label_v_flower.AutoSize = True
        Me.label_v_flower.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_v_flower.ForeColor = System.Drawing.Color.White
        Me.label_v_flower.Location = New System.Drawing.Point(92, 378)
        Me.label_v_flower.Name = "label_v_flower"
        Me.label_v_flower.Size = New System.Drawing.Size(47, 16)
        Me.label_v_flower.TabIndex = 16
        Me.label_v_flower.Text = "Blüte:"
        '
        'l_fem
        '
        Me.l_fem.AutoSize = True
        Me.l_fem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.l_fem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.l_fem.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_fem.ForeColor = System.Drawing.Color.White
        Me.l_fem.Location = New System.Drawing.Point(386, 155)
        Me.l_fem.Margin = New System.Windows.Forms.Padding(3)
        Me.l_fem.Name = "l_fem"
        Me.l_fem.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.l_fem.Size = New System.Drawing.Size(46, 20)
        Me.l_fem.TabIndex = 15
        Me.l_fem.Text = "(leer)"
        '
        'label_v_fem
        '
        Me.label_v_fem.AutoSize = True
        Me.label_v_fem.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_v_fem.ForeColor = System.Drawing.Color.White
        Me.label_v_fem.Location = New System.Drawing.Point(348, 127)
        Me.label_v_fem.Name = "label_v_fem"
        Me.label_v_fem.Size = New System.Drawing.Size(84, 16)
        Me.label_v_fem.TabIndex = 14
        Me.label_v_fem.Text = "Feminisiert:"
        '
        'l_earning
        '
        Me.l_earning.AutoSize = True
        Me.l_earning.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.l_earning.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.l_earning.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_earning.ForeColor = System.Drawing.Color.White
        Me.l_earning.Location = New System.Drawing.Point(130, 323)
        Me.l_earning.Margin = New System.Windows.Forms.Padding(3)
        Me.l_earning.Name = "l_earning"
        Me.l_earning.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.l_earning.Size = New System.Drawing.Size(46, 20)
        Me.l_earning.TabIndex = 13
        Me.l_earning.Text = "(leer)"
        '
        'label_v_earning
        '
        Me.label_v_earning.AutoSize = True
        Me.label_v_earning.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_v_earning.ForeColor = System.Drawing.Color.White
        Me.label_v_earning.Location = New System.Drawing.Point(92, 295)
        Me.label_v_earning.Name = "label_v_earning"
        Me.label_v_earning.Size = New System.Drawing.Size(54, 16)
        Me.label_v_earning.TabIndex = 12
        Me.label_v_earning.Text = "Ertrag:"
        '
        'l_type
        '
        Me.l_type.AutoSize = True
        Me.l_type.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.l_type.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.l_type.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_type.ForeColor = System.Drawing.Color.White
        Me.l_type.Location = New System.Drawing.Point(130, 234)
        Me.l_type.Margin = New System.Windows.Forms.Padding(3)
        Me.l_type.Name = "l_type"
        Me.l_type.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.l_type.Size = New System.Drawing.Size(46, 20)
        Me.l_type.TabIndex = 11
        Me.l_type.Text = "(leer)"
        '
        'label_v_genetic
        '
        Me.label_v_genetic.AutoSize = True
        Me.label_v_genetic.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_v_genetic.ForeColor = System.Drawing.Color.White
        Me.label_v_genetic.Location = New System.Drawing.Point(92, 206)
        Me.label_v_genetic.Name = "label_v_genetic"
        Me.label_v_genetic.Size = New System.Drawing.Size(47, 16)
        Me.label_v_genetic.TabIndex = 10
        Me.label_v_genetic.Text = "Gene:"
        '
        'l_desc
        '
        Me.l_desc.AutoSize = True
        Me.l_desc.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.l_desc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.l_desc.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_desc.ForeColor = System.Drawing.Color.White
        Me.l_desc.Location = New System.Drawing.Point(130, 155)
        Me.l_desc.Margin = New System.Windows.Forms.Padding(3)
        Me.l_desc.Name = "l_desc"
        Me.l_desc.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.l_desc.Size = New System.Drawing.Size(46, 20)
        Me.l_desc.TabIndex = 9
        Me.l_desc.Text = "(leer)"
        '
        'label_v_desc
        '
        Me.label_v_desc.AutoSize = True
        Me.label_v_desc.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_v_desc.ForeColor = System.Drawing.Color.White
        Me.label_v_desc.Location = New System.Drawing.Point(92, 127)
        Me.label_v_desc.Name = "label_v_desc"
        Me.label_v_desc.Size = New System.Drawing.Size(96, 16)
        Me.label_v_desc.TabIndex = 6
        Me.label_v_desc.Text = "Bezeichnung:"
        '
        'SubspaceSeperator2
        '
        Me.SubspaceSeperator2.BackColor = System.Drawing.Color.Transparent
        Me.SubspaceSeperator2.Colors = New GrowPro.Bloom(-1) {}
        Me.SubspaceSeperator2.Customization = ""
        Me.SubspaceSeperator2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SubspaceSeperator2.Image = Nothing
        Me.SubspaceSeperator2.Location = New System.Drawing.Point(415, 40)
        Me.SubspaceSeperator2.Name = "SubspaceSeperator2"
        Me.SubspaceSeperator2.NoRounding = False
        Me.SubspaceSeperator2.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.SubspaceSeperator2.Size = New System.Drawing.Size(14, 66)
        Me.SubspaceSeperator2.TabIndex = 35
        Me.SubspaceSeperator2.Text = "SubspaceSeperator2"
        Me.SubspaceSeperator2.Transparent = True
        '
        'l5891796
        '
        Me.l5891796.AutoSize = True
        Me.l5891796.BackColor = System.Drawing.Color.Transparent
        Me.l5891796.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l5891796.ForeColor = System.Drawing.SystemColors.Control
        Me.l5891796.Location = New System.Drawing.Point(967, 549)
        Me.l5891796.Name = "l5891796"
        Me.l5891796.Size = New System.Drawing.Size(148, 13)
        Me.l5891796.TabIndex = 5
        Me.l5891796.Text = "© SirSmokesAlot @grower.ch"
        '
        'tv_projects
        '
        Me.tv_projects.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.tv_projects.ForeColor = System.Drawing.Color.White
        Me.tv_projects.LineColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tv_projects.Location = New System.Drawing.Point(12, 38)
        Me.tv_projects.Name = "tv_projects"
        TreeNode1.Name = "k_indoor"
        TreeNode1.Text = "Indoor"
        TreeNode2.Name = "k_setups"
        TreeNode2.Text = "Setups"
        TreeNode3.Name = "k_create"
        TreeNode3.Text = "Projekt Erstellen"
        TreeNode4.Name = "k_screate"
        TreeNode4.Text = "Setup Erstellen"
        TreeNode5.Name = "k_projects"
        TreeNode5.Text = "Projekte"
        TreeNode6.Name = "k_dtabs"
        TreeNode6.Text = "Düngetabellen"
        TreeNode7.Name = "k_stromrech"
        TreeNode7.Text = "Stromkostenrechner"
        TreeNode8.Name = "k_basiswissen"
        TreeNode8.Text = "Basiswissen"
        TreeNode9.Name = "k_lundb"
        TreeNode9.Text = "Licht & Beleuchtung"
        TreeNode10.Name = "k_wasser"
        TreeNode10.Text = "Bewässerung, Dünger & Erde"
        TreeNode11.Name = "k_luft"
        TreeNode11.Text = "Luft & Belüftung"
        TreeNode12.Name = "k_samen"
        TreeNode12.Text = "Samen & Stecklinge"
        TreeNode13.Name = "k_vegi"
        TreeNode13.Text = "Wachstumsphase"
        TreeNode14.Name = "k_bluete"
        TreeNode14.Text = "Blütephase"
        TreeNode15.Name = "k_ernte"
        TreeNode15.Text = "Ernte"
        TreeNode16.Name = "k_prob"
        TreeNode16.Text = "Probleme"
        TreeNode17.Name = "k_tutorials"
        TreeNode17.Text = "Hilfe"
        TreeNode18.Name = "k_growerch"
        TreeNode18.Text = "https://grower.ch/"
        TreeNode19.Name = "k_hanfburgat"
        TreeNode19.Text = "http://forum.hanfburg.de/"
        TreeNode20.Name = "k_opencannabisnet"
        TreeNode20.Text = "http://opencannabis.net/"
        TreeNode21.Name = "k_links"
        TreeNode21.Text = "Links"
        TreeNode22.Name = "k_profile"
        TreeNode22.Text = "Profil"
        TreeNode23.Name = "k_growpro"
        TreeNode23.Text = "GrowPro"
        Me.tv_projects.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode6, TreeNode7, TreeNode17, TreeNode21, TreeNode23})
        Me.tv_projects.Size = New System.Drawing.Size(249, 508)
        Me.tv_projects.TabIndex = 2
        '
        'btn_mini
        '
        Me.btn_mini.BackColor = System.Drawing.Color.Transparent
        Me.btn_mini.Colors = New GrowPro.Bloom(-1) {}
        Me.btn_mini.Customization = ""
        Me.btn_mini.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn_mini.Image = Nothing
        Me.btn_mini.Location = New System.Drawing.Point(1063, 3)
        Me.btn_mini.Name = "btn_mini"
        Me.btn_mini.NoRounding = False
        Me.btn_mini.Size = New System.Drawing.Size(23, 23)
        Me.btn_mini.TabIndex = 1
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
        Me.btn_close.Location = New System.Drawing.Point(1092, 3)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.NoRounding = False
        Me.btn_close.Size = New System.Drawing.Size(23, 23)
        Me.btn_close.TabIndex = 0
        Me.btn_close.Text = "x"
        Me.btn_close.Transparent = True
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1127, 565)
        Me.Controls.Add(Me.ss_theme)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "main"
        Me.Text = "GrowPro - Main"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ss_theme.ResumeLayout(False)
        Me.ss_theme.PerformLayout()
        Me.gbox_project.ResumeLayout(False)
        Me.gbox_project.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ss_theme As GrowPro.SubspaceTheme
    Friend WithEvents btn_mini As GrowPro.SubspaceButton
    Friend WithEvents btn_close As GrowPro.SubspaceButton
    Friend WithEvents tv_projects As System.Windows.Forms.TreeView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbar_howfar As GrowPro.SubspaceProgressbar
    Friend WithEvents l5891796 As System.Windows.Forms.Label
    Friend WithEvents gbox_project As GrowPro.Subspacegroupbox
    Friend WithEvents l_desc As System.Windows.Forms.Label
    Friend WithEvents label_v_desc As System.Windows.Forms.Label
    Friend WithEvents l_phase As System.Windows.Forms.Label
    Friend WithEvents label_v_phase As System.Windows.Forms.Label
    Friend WithEvents l_day As System.Windows.Forms.Label
    Friend WithEvents label_v_day As System.Windows.Forms.Label
    Friend WithEvents l_sdate As System.Windows.Forms.Label
    Friend WithEvents label_v_startd As System.Windows.Forms.Label
    Friend WithEvents l_setup As System.Windows.Forms.Label
    Friend WithEvents label_v_setup As System.Windows.Forms.Label
    Friend WithEvents l_count As System.Windows.Forms.Label
    Friend WithEvents label_v_count As System.Windows.Forms.Label
    Friend WithEvents l_earth As System.Windows.Forms.Label
    Friend WithEvents label_v_earth As System.Windows.Forms.Label
    Friend WithEvents l_gtype As System.Windows.Forms.Label
    Friend WithEvents label_v_growth As System.Windows.Forms.Label
    Friend WithEvents l_flower As System.Windows.Forms.Label
    Friend WithEvents label_v_flower As System.Windows.Forms.Label
    Friend WithEvents l_fem As System.Windows.Forms.Label
    Friend WithEvents label_v_fem As System.Windows.Forms.Label
    Friend WithEvents l_earning As System.Windows.Forms.Label
    Friend WithEvents label_v_earning As System.Windows.Forms.Label
    Friend WithEvents l_type As System.Windows.Forms.Label
    Friend WithEvents label_v_genetic As System.Windows.Forms.Label
    Friend WithEvents SubspaceSeperator1 As GrowPro.SubspaceSeperator
    Friend WithEvents SubspaceSeperator2 As GrowPro.SubspaceSeperator
    Friend WithEvents btn_growreport As GrowPro.SubspaceButton
    Friend WithEvents btn_edit As GrowPro.SubspaceButton
    Friend WithEvents btn_nextp As GrowPro.SubspaceButton
    Friend WithEvents btn_delete As GrowPro.SubspaceButton
End Class
