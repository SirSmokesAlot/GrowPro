<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loading
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loading))
        Me.l_loading = New System.Windows.Forms.Label()
        Me.loadMainFrame = New System.Windows.Forms.Timer(Me.components)
        Me.l5891796 = New System.Windows.Forms.Label()
        Me.license = New System.Windows.Forms.Label()
        Me.linklabel = New System.Windows.Forms.LinkLabel()
        Me.pbar_loading = New GrowPro.SubspaceProgressbar()
        Me.btn_emergency = New GrowPro.SubspaceButton()
        Me.SuspendLayout()
        '
        'l_loading
        '
        Me.l_loading.AutoSize = True
        Me.l_loading.BackColor = System.Drawing.Color.Transparent
        Me.l_loading.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_loading.ForeColor = System.Drawing.Color.White
        Me.l_loading.Location = New System.Drawing.Point(244, 453)
        Me.l_loading.Name = "l_loading"
        Me.l_loading.Size = New System.Drawing.Size(48, 16)
        Me.l_loading.TabIndex = 1
        Me.l_loading.Text = "Lade..."
        '
        'loadMainFrame
        '
        Me.loadMainFrame.Interval = 50
        '
        'l5891796
        '
        Me.l5891796.AutoSize = True
        Me.l5891796.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.l5891796.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l5891796.ForeColor = System.Drawing.Color.White
        Me.l5891796.Location = New System.Drawing.Point(447, 536)
        Me.l5891796.Name = "l5891796"
        Me.l5891796.Size = New System.Drawing.Size(148, 13)
        Me.l5891796.TabIndex = 2
        Me.l5891796.Text = "© SirSmokesAlot @grower.ch"
        '
        'license
        '
        Me.license.AutoSize = True
        Me.license.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.license.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.license.ForeColor = System.Drawing.Color.White
        Me.license.Location = New System.Drawing.Point(197, 251)
        Me.license.Name = "license"
        Me.license.Size = New System.Drawing.Size(80, 16)
        Me.license.TabIndex = 3
        Me.license.Text = "Lizenziert für"
        Me.license.Visible = False
        '
        'linklabel
        '
        Me.linklabel.AutoSize = True
        Me.linklabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.linklabel.LinkColor = System.Drawing.Color.Aqua
        Me.linklabel.Location = New System.Drawing.Point(197, 267)
        Me.linklabel.Name = "linklabel"
        Me.linklabel.Size = New System.Drawing.Size(90, 13)
        Me.linklabel.TabIndex = 5
        Me.linklabel.TabStop = True
        Me.linklabel.Text = "http://grower.ch/"
        '
        'pbar_loading
        '
        Me.pbar_loading.Colors = New GrowPro.Bloom(-1) {}
        Me.pbar_loading.Customization = ""
        Me.pbar_loading.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.pbar_loading.Image = Nothing
        Me.pbar_loading.Location = New System.Drawing.Point(247, 475)
        Me.pbar_loading.Maximum = 100
        Me.pbar_loading.Name = "pbar_loading"
        Me.pbar_loading.NoRounding = False
        Me.pbar_loading.Size = New System.Drawing.Size(286, 23)
        Me.pbar_loading.TabIndex = 0
        Me.pbar_loading.Transparent = False
        Me.pbar_loading.Value = 0
        '
        'btn_emergency
        '
        Me.btn_emergency.BackColor = System.Drawing.Color.Transparent
        Me.btn_emergency.Colors = New GrowPro.Bloom(-1) {}
        Me.btn_emergency.Customization = ""
        Me.btn_emergency.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn_emergency.Image = Nothing
        Me.btn_emergency.Location = New System.Drawing.Point(572, 125)
        Me.btn_emergency.Name = "btn_emergency"
        Me.btn_emergency.NoRounding = False
        Me.btn_emergency.Size = New System.Drawing.Size(23, 23)
        Me.btn_emergency.TabIndex = 6
        Me.btn_emergency.Text = "x"
        Me.btn_emergency.Transparent = True
        Me.btn_emergency.Visible = False
        '
        'loading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.GrowPro.My.Resources.Resources.growpro_loading_screen
        Me.ClientSize = New System.Drawing.Size(800, 800)
        Me.Controls.Add(Me.btn_emergency)
        Me.Controls.Add(Me.linklabel)
        Me.Controls.Add(Me.license)
        Me.Controls.Add(Me.l5891796)
        Me.Controls.Add(Me.l_loading)
        Me.Controls.Add(Me.pbar_loading)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "loading"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loading..."
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbar_loading As GrowPro.SubspaceProgressbar
    Friend WithEvents l_loading As System.Windows.Forms.Label
    Friend WithEvents loadMainFrame As System.Windows.Forms.Timer
    Friend WithEvents l5891796 As System.Windows.Forms.Label
    Friend WithEvents license As System.Windows.Forms.Label
    Friend WithEvents linklabel As System.Windows.Forms.LinkLabel
    Friend WithEvents btn_emergency As GrowPro.SubspaceButton

End Class
