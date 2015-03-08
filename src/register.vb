Imports GrowPro.Profile
Imports GrowPro.Config
Public Class register

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        loading.Close()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Profile.INI_File.WriteString("Profile", "name", txt_nick.Text)
        Profile.INI_File.WriteString("Profile", "url", txt_link.Text)
        Config.INI_File.WriteString("FirstStart", "reg_event", "0")
        Me.Close()
        loading.checkRegEvent()
    End Sub

    Private Sub register_Load(sender As Object, e As EventArgs) Handles Me.Load
        txt_nick.Text = PROFILE_NAME
        txt_link.Text = PROFILE_URL
    End Sub
End Class