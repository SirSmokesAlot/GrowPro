Imports GrowPro.Config
Imports GrowPro.Profile
Imports System.IO

Public Class loading
    Dim AppPath As String = My.Application.Info.DirectoryPath
    Dim c As Boolean = True

    Public Sub checkFileList()
        Try
            l_loading.Text = "Lade Dateien..."
            Dim lineCount As Integer = File.ReadAllLines(AppPath + "\res\flist.dat").Length
            Dim adjVolume As Integer = 100 / lineCount
            For Each line As String In System.IO.File.ReadAllLines(AppPath + "\res\flist.dat")
                If Not File.Exists(AppPath + "\" + line) Then
                    c = False
                Else
                    pbar_loading.Value = pbar_loading.Value + adjVolume
                End If
            Next
        Catch ex As Exception
            MsgBox("Die Datei 'res/flist.dat' konnte nicht gefunden werden." + vbNewLine + "Bitte laden Sie die Anwendung erneut runter.", MsgBoxStyle.Critical, "Fehler")
            Application.Exit()
        End Try
    End Sub

    Public Sub checkRegEvent()

        Dim INI_File As New IniFile(Config.ConfigFile)
        Dim REG_V As String = INI_File.GetString("FirstStart", "reg_event", "(not found)")

        If REG_V = "1" Then
            l_loading.Text = "Profil wird angelegt..."
            register.Show()
            pbar_loading.Value = 50
        Else
            l_loading.Text = "Wird gestartet..."
            pbar_loading.Value = 0
            loadMainFrame.Start()
        End If
    End Sub

    Private Sub loading_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        l_loading.Text = "Lade Dateien..."""
        checkFileList()

        If c = False Then
            pbar_loading.Value = 0
            l_loading.Text = "Fehler! Es fehlen Dateien..."
            btn_emergency.Visible = True
        Else
            pbar_loading.Value = 0
            l_loading.Text = "Informationen werden geladen..."

            pbar_loading.Value = 0
            l_loading.Text = "Lade Profil..."
            checkRegEvent()
            license.Visible = True
            license.Text = "Lizensiert für " + PROFILE_NAME
            linklabel.Text = PROFILE_URL
        End If
    End Sub

    Private Sub loadMainFrame_Tick(sender As Object, e As EventArgs) Handles loadMainFrame.Tick
        pbar_loading.Value = pbar_loading.Value + 2
        If pbar_loading.Value = 100 Then
            loadMainFrame.Stop()
            Me.Hide()
            main.Show()
        End If
    End Sub

    Private Sub btn_emergency_Click(sender As Object, e As EventArgs) Handles btn_emergency.Click
        Me.Close()
    End Sub
End Class
