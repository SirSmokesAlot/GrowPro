Imports System.IO

Public Class addSetup

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Try
            Dim file_name As String = txt_name.Text + ".ini"
            If File.Exists(Application.StartupPath & "\" & file_name) Then
                MsgBox("Ein Setup mit dem selben Namen exestiert bereits!", MsgBoxStyle.Critical, "GrowPro")
            Else
                Dim fs As FileStream = New FileStream(Application.StartupPath & "\res\setup\" + file_name, FileMode.Create, FileAccess.ReadWrite)
                Dim s As StreamWriter = New StreamWriter(fs)
                s.Close()
                fs.Close()
                loading.pbar_loading.Value = 50
                Dim fs1 As FileStream = New FileStream(Application.StartupPath &
                "\res\setup\" + file_name, FileMode.Append, FileAccess.Write)
                Dim s1 As StreamWriter = New StreamWriter(fs1)
                loading.pbar_loading.Value = 70
                s1.Write("[Data]" & vbCrLf)
                s1.Write("name=" + txt_name.Text & vbCrLf)
                s1.Write("loc=" + cb_glocation.SelectedItem.ToString & vbCrLf)
                s1.Write("x=" + txt_x.Text & vbCrLf)
                s1.Write("y=" + txt_y.Text & vbCrLf)
                s1.Write("z=" + txt_z.Text & vbCrLf)
                s1.Write("grow_lamp=" + txt_growspectre.Text & vbCrLf)
                s1.Write("flow_lamp=" + txt_flowerspectre.Text & vbCrLf)
                s1.Write("refl=" + txt_refl.Text & vbCrLf)
                s1.Write("airout=" + txt_airout.Text & vbCrLf)
                s1.Write("airin=" + txt_airin.Text & vbCrLf)
                s1.Write("akf=" + txt_akf.Text & vbCrLf)
                s1.Write("vsg=" + txt_vsg.Text & vbCrLf)
                s1.Write("water=" + txt_water.Text & vbCrLf)
                s1.Write("silencer=" + cb_stealth.SelectedItem.ToString & vbCrLf)
                s1.Close()
                fs1.Close()
                main.tv_projects.Nodes(0).Nodes(1).Nodes.Clear()
                main.loadSetups()
                MsgBox("Setup erfolgreich erstellt!", MsgBoxStyle.Information, "GrowPro")
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Bitte füllen sie alle Felder aus!", MsgBoxStyle.Critical, "Fehler")
        End Try
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles label_v_x.Click

    End Sub
End Class