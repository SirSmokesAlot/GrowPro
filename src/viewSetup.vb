Imports System.IO

Public Class viewSetup

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub viewSetup_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            ss_theme_vsetup.Text = "Setup: " & main.sFile

            Dim ConfigFile As String = My.Application.Info.DirectoryPath + "/res/setup/" + main.sFile + ".ini"
            Dim INI_File As New IniFile(ConfigFile)

            l_name.Text = INI_File.GetString("Data", "name", "(leer)")
            l_growloc.Text = INI_File.GetString("Data", "loc", "(leer)")
            l_xyz.Text = INI_File.GetString("Data", "x", "(leer)") & "x" & INI_File.GetString("Data", "y", "(leer)") & "x" & INI_File.GetString("Data", "z", "(leer)") & "cm"
            l_growspec.Text = INI_File.GetString("Data", "grow_lamp", "(leer)")
            l_flowspec.Text = INI_File.GetString("Data", "flow_lamp", "(leer)")
            l_refl.Text = INI_File.GetString("Data", "refl", "(leer)")
            l_airout.Text = INI_File.GetString("Data", "airout", "(leer)")
            l_airin.Text = INI_File.GetString("Data", "airin", "(leer)")
            l_akf.Text = INI_File.GetString("Data", "akf", "(leer)")
            l_vsg.Text = INI_File.GetString("Data", "vsg", "(leer)")
            l_water.Text = INI_File.GetString("Data", "water", "(leer)")
            l_silencer.Text = INI_File.GetString("Data", "silencer", "(leer)")
        Catch ex As Exception
            MsgBox("Setup wurde fehlerhaft geladen!", MsgBoxStyle.Critical, "Fehler")
        End Try
    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        Try
            If l_name.Text = "(leer)" Then
                MsgBox("Setup wurde fehlerhaft geladen", MsgBoxStyle.Critical, "GrowPro")
            Else
                If MsgBox("Möchtest du das Setup `" + l_name.Text + "` wirklich löschen?", MsgBoxStyle.OkCancel) = vbOK Then
                    File.Delete(My.Application.Info.DirectoryPath + "/res/setup/" + main.sFile + ".ini")
                    main.tv_projects.Nodes(0).Nodes(1).Nodes.Clear()
                    main.loadSetups()
                    MsgBox("Setup wurde erfolgreich gelöscht!", MsgBoxStyle.Information, "GrowPro")
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox("Fehler-Code: 0x000314", MsgBoxStyle.Critical, "Kritischer Fehler")
        End Try
    End Sub
End Class