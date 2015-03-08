Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions

Public Class growreport

    Private Sub Growreport_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim ConfigFile As String = My.Application.Info.DirectoryPath + "/res/project/indoor/" + main.pFile + ".ini"
        Dim INI_File As New IniFile(ConfigFile)
        txt_begin.Text = INI_File.GetString("Data", "d1", "X")
        txt_grow.Text = INI_File.GetString("Data", "d2", "X")
        txt_flower.Text = INI_File.GetString("Data", "d3", "X")
        txt_dry.Text = INI_File.GetString("Data", "d4", "X")
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btn_mini_Click(sender As Object, e As EventArgs) Handles btn_mini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_color_Click(sender As Object, e As EventArgs)
        color_dialog.ShowDialog()
        bb_code.ForeColor = color_dialog.Color
    End Sub

    Private Sub btn_color_Click_1(sender As Object, e As EventArgs) Handles btn_color.Click
        color_dialog.ShowDialog()
        Dim colord As String = color_dialog.Color.Name
        Dim stext As String = bb_code.SelectedText
        Dim AnfangsTag As String = " [COLOR=#" & colord & "]"
        Dim EndTag As String = "[/COLOR]"
        stext = AnfangsTag & stext & EndTag
        bb_code.SelectedText = stext
    End Sub

    Private Sub btn_bold_Click(sender As Object, e As EventArgs) Handles btn_bold.Click
        Dim stext As String = bb_code.SelectedText
        Dim AnfangsTag As String = "[B]"
        Dim EndTag As String = "[/B]"
        stext = AnfangsTag & stext & EndTag
        bb_code.SelectedText = stext
    End Sub

    Private Sub btn_italian_Click(sender As Object, e As EventArgs) Handles btn_italian.Click
        Dim stext As String = bb_code.SelectedText
        Dim AnfangsTag As String = "[I]"
        Dim EndTag As String = "[/I]"
        stext = AnfangsTag & stext & EndTag
        bb_code.SelectedText = stext
    End Sub

    Private Sub btn_underline_Click(sender As Object, e As EventArgs) Handles btn_underline.Click
        Dim stext As String = bb_code.SelectedText
        Dim AnfangsTag As String = "[U]"
        Dim EndTag As String = "[/U]"
        stext = AnfangsTag & stext & EndTag
        bb_code.SelectedText = stext
    End Sub

    Private Sub btn_crossed_Click(sender As Object, e As EventArgs) Handles btn_crossed.Click
        Dim stext As String = bb_code.SelectedText
        Dim AnfangsTag As String = "[S]"
        Dim EndTag As String = "[/S]"
        stext = AnfangsTag & stext & EndTag
        bb_code.SelectedText = stext
    End Sub

    Private Sub btn_gen_Click(sender As Object, e As EventArgs) Handles btn_gen.Click
        Dim Code As String
        Using sr As New StreamReader(Application.StartupPath & "\res\bbcode.dat", ASCIIEncoding.Default)
            Code = sr.ReadToEnd()
        End Using

        Try
            bb_code.Text = Regex.Replace(Code, "{REPLACE_DAYS_BEGIN}", txt_begin.Text)
            bb_code.Text = Regex.Replace(bb_code.Text, "{REPLACE_DAYS_GROW}", txt_grow.Text)
            bb_code.Text = Regex.Replace(bb_code.Text, "{REPLACE_DAYS_FLOWER}", txt_flower.Text)
            bb_code.Text = Regex.Replace(bb_code.Text, "{REPLACE_DAYS_DRY}", txt_dry.Text)
            bb_code.Text = Regex.Replace(bb_code.Text, "{REPLACE_PROFILE_URL}", Profile.PROFILE_URL)
            bb_code.Text = Regex.Replace(bb_code.Text, "{REPLACE_PROFILE_NAME}", Profile.PROFILE_NAME)
        Catch ex As Exception
            MsgBox("Bitte füllen sie alle Felder aus.", MsgBoxStyle.Critical, "Fehler")
        End Try
    End Sub
End Class