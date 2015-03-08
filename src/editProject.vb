Imports System.IO

Public Class editProject
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub editProject_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Dim ConfigFile As String = My.Application.Info.DirectoryPath + "/res/project/indoor/" + main.pFile + ".ini"
            Dim INI_File As New IniFile(ConfigFile)

            txt_name.Text = INI_File.GetString("Data", "name", "(empty)")
            cb_g.SelectedIndex = INI_File.GetString("Data", "type_id", "4")
            cb_indica.SelectedIndex = INI_File.GetString("Data", "indica", "1")
            cb_sativa.SelectedIndex = INI_File.GetString("Data", "sativa", "1")
            cb_rud.SelectedIndex = INI_File.GetString("Data", "ruderalis", "1")
            If cb_g.SelectedItem.ToString = "Indica" Then
                cb_sativa.Enabled = False
                cb_rud.Enabled = False
            ElseIf cb_g.SelectedItem.ToString = "Sativa" Then
                cb_indica.Enabled = False
                cb_rud.Enabled = False
            ElseIf cb_g.SelectedItem.ToString = "Ruderalis" Then
                cb_indica.Enabled = False
                cb_sativa.Enabled = False
            ElseIf cb_g.SelectedItem.ToString = "Indica/Ruderalis" Then
                cb_sativa.Enabled = False
            ElseIf cb_g.SelectedItem.ToString = "Sativa/Ruderalis" Then
                cb_indica.Enabled = False
            End If

            If INI_File.GetString("Data", "earning", "fehler") = "+" Then
                cb_earning.SelectedItem = "Kleiner Ertrag"
            ElseIf INI_File.GetString("Data", "earning", "fehler") = "++" Then
                cb_earning.SelectedItem = "Mittlerer Ertrag"
            ElseIf INI_File.GetString("Data", "earning", "fehler") = "+++" Then
                cb_earning.SelectedItem = "Großer Ertrag"
            ElseIf INI_File.GetString("Data", "earning", "fehler") = "++++" Then
                cb_earning.SelectedItem = "Sehr Großer Ertrag"
            End If
            txt_flower.Text = INI_File.GetString("Data", "flowering", "(leer)")
            If INI_File.GetString("Data", "fem", "false") = "true" Then
                cb_fem.SelectedIndex = 0
            Else
                cb_fem.SelectedIndex = 1
            End If
            cb_growtype.SelectedItem = INI_File.GetString("Data", "kind", "(leer)")
            txt_earth.Text = INI_File.GetString("Data", "earth", "(leer)")
            txt_count.Text = INI_File.GetString("Data", "count", "(leer)")
            datetime_choice.Value = INI_File.GetString("Data", "sdate", "(leer)")
            datetime_phase.Value = INI_File.GetString("Data", "ndate", "(leer)")
            Dim cPhase As String = INI_File.GetString("Data", "p", "(leer)")


            If cPhase = "1" Then
                cb_phase.SelectedItem = "Keimling/Steckling"
            ElseIf cPhase = "2" Then
                cb_phase.SelectedItem = "Wachstumsphase"
            ElseIf cPhase = "3" Then
                cb_phase.SelectedItem = "Blütephase"
            ElseIf cPhase = "4" Then
                cb_phase.SelectedItem = "Trocknen"
            ElseIf cPhase = "5" Then
                cb_phase.SelectedItem = "Fertig"
            End If

            Dim pdir As New DirectoryInfo(My.Application.Info.DirectoryPath + "/res/setup/")
            Dim flist As FileInfo() = pdir.GetFiles("*.ini")
            Dim finfo As FileInfo

            For Each finfo In flist
                Dim p_ConfigFile As String = My.Application.Info.DirectoryPath + "/res/setup/" + finfo.ToString
                Dim p_INI_File As New IniFile(p_ConfigFile)
                cb_setup.Items.Add(p_INI_File.GetString("Data", "name", "(leer)"))
            Next

            cb_setup.SelectedItem = INI_File.GetString("Data", "setup", "(leer)")
        Catch ex As Exception
            MsgBox("Projekt wurde fehlerhaft geladen!", MsgBoxStyle.Critical, "Fehler")
        End Try
    End Sub

    Private Sub cb_g_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_g.SelectedIndexChanged
        cb_sativa.Enabled = True
        cb_rud.Enabled = True
        cb_indica.Enabled = True
        If cb_g.SelectedItem.ToString = "Indica" Then
            cb_sativa.Enabled = False
            cb_rud.Enabled = False
        ElseIf cb_g.SelectedItem.ToString = "Sativa" Then
            cb_indica.Enabled = False
            cb_rud.Enabled = False
        ElseIf cb_g.SelectedItem.ToString = "Ruderalis" Then
            cb_indica.Enabled = False
            cb_sativa.Enabled = False
        ElseIf cb_g.SelectedItem.ToString = "Indica/Ruderalis" Then
            cb_sativa.Enabled = False
        ElseIf cb_g.SelectedItem.ToString = "Sativa/Ruderalis" Then
            cb_indica.Enabled = False
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            Dim c_ConfigFile As String = My.Application.Info.DirectoryPath + "/res/project/indoor/" + main.pFile + ".ini"
            Dim c_INI_File As New IniFile(c_ConfigFile)

            Dim d1 As String = c_INI_File.GetString("Data", "d1", "0")
            Dim d2 As String = c_INI_File.GetString("Data", "d2", "0")
            Dim d3 As String = c_INI_File.GetString("Data", "d3", "0")
            Dim d4 As String = c_INI_File.GetString("Data", "d4", "0")

            Dim gFinal As String = "none"
            If cb_g.SelectedItem.ToString = "Indica" Then
                gFinal = cb_indica.SelectedItem.ToString + "% Indica"
            ElseIf cb_g.SelectedItem.ToString = "Sativa" Then
                gFinal = cb_sativa.SelectedItem.ToString + "% Sativa"
            ElseIf cb_g.SelectedItem.ToString = "Indica/Sativa" Then
                gFinal = cb_indica.SelectedItem.ToString + "% Indica" + " / " + cb_sativa.SelectedItem.ToString + "% Sativa"

            ElseIf cb_g.SelectedItem.ToString = "Ruderalis" Then
                gFinal = cb_rud.SelectedItem.ToString + "% Ruderalis"
            ElseIf cb_g.SelectedItem.ToString = "Indica/Ruderalis" Then
                gFinal = cb_indica.SelectedItem.ToString + "% Indica" + " / " + cb_rud.SelectedItem.ToString + "% Ruderalis"
            ElseIf cb_g.SelectedItem.ToString = "Sativa/Ruderalis" Then
                gFinal = cb_sativa.SelectedItem.ToString + "% Sativa" + " / " + cb_rud.SelectedItem.ToString + "% Ruderalis"
            ElseIf cb_g.SelectedItem.ToString = "Indica/Sativa/Ruderalis" Then
                gFinal = cb_indica.SelectedItem.ToString + "% Indica" + " / " + cb_sativa.SelectedItem.ToString + "% Sativa" + " / " + cb_rud.SelectedItem.ToString + "% Ruderalis"
            End If
            Dim NowD As String = Format(datetime_choice.Value, "dd.MM.yyyy")
            Dim NowP As String = Format(datetime_phase.Value, "dd.MM.yyyy")
            Dim cPhase As String = "0"
            Dim EarningPoints As String = "+"
            If cb_phase.SelectedItem.ToString = "Keimling/Steckling" Then
                cPhase = "1"
            ElseIf cb_phase.SelectedItem.ToString = "Wachstumsphase" Then
                cPhase = "2"
            ElseIf cb_phase.SelectedItem.ToString = "Blütephase" Then
                cPhase = "3"
            ElseIf cb_phase.SelectedItem.ToString = "Trocknen" Then
                cPhase = "4"
            ElseIf cb_phase.SelectedItem.ToString = "Fertig" Then
                cPhase = "5"
            End If

            Dim firstDate As String
            Dim secondDate As Date
            Dim newDays As String

            If cb_phase.SelectedItem.ToString = "Keimling/Steckling" Then
                firstDate = c_INI_File.GetString("Data", "sdate", "[fehler]")
                secondDate = CDate(firstDate)
                newDays = DateDiff(DateInterval.Day, secondDate, Now.Date)
                newDays = newDays + +1
                d1 = newDays
            ElseIf cb_phase.SelectedItem.ToString = "Wachstumsphase" Then
                firstDate = NowP
                secondDate = CDate(firstDate)
                newDays = DateDiff(DateInterval.Day, secondDate, Now.Date)
                newDays = newDays + +1
                d2 = newDays
            ElseIf cb_phase.SelectedItem.ToString = "Blütephase" Then
                firstDate = NowP
                secondDate = CDate(firstDate)
                newDays = DateDiff(DateInterval.Day, secondDate, Now.Date)
                newDays = newDays + +1
                d3 = newDays
            ElseIf cb_phase.SelectedItem.ToString = "Trocknen" Then
                firstDate = NowP
                secondDate = CDate(firstDate)
                newDays = DateDiff(DateInterval.Day, secondDate, Now.Date)
                newDays = newDays + +1
                d4 = newDays
            End If

            If cb_earning.SelectedItem.ToString = "Kleiner Ertrag" Then
                EarningPoints = "+"
            ElseIf cb_earning.SelectedItem.ToString = "Mittlerer Ertrag" Then
                EarningPoints = "++"
            ElseIf cb_earning.SelectedItem.ToString = "Großer Ertrag" Then
                EarningPoints = "+++"
            ElseIf cb_earning.SelectedItem.ToString = "Sehr Großer Ertrag" Then
                EarningPoints = "++++"
            End If

            Dim cFem As String
            If cb_fem.SelectedItem = "Ja" Then
                cFem = "true"
            Else
                cFem = "false"
            End If

            File.Delete(Application.StartupPath &
            "\res\project\indoor\" & main.pFile & ".ini")

            Dim file_name2 As String = txt_name.Text + " (" + NowD + ").ini"
            If File.Exists(Application.StartupPath & "\" & file_name2) Then
                MsgBox("Ein Projekt mit dem selben Namen exestiert bereits!", MsgBoxStyle.Critical, "GrowPro")
            Else
                Dim file_name As String = txt_name.Text + " (" + NowD + ").ini"
                Dim fs As FileStream = New FileStream(Application.StartupPath &
                "\res\project\indoor\" + file_name, FileMode.Create, FileAccess.ReadWrite)
                Dim s As StreamWriter = New StreamWriter(fs)
                s.Close()
                fs.Close()
                loading.pbar_loading.Value = 50
                Dim fs1 As FileStream = New FileStream(Application.StartupPath &
                "\res\project\indoor\" + file_name, FileMode.Append, FileAccess.Write)
                Dim s1 As StreamWriter = New StreamWriter(fs1)
                loading.pbar_loading.Value = 70
                s1.Write("[Data]" & vbCrLf)
                s1.Write("name=" + txt_name.Text & vbCrLf)
                s1.Write("type=" + gFinal & vbCrLf)
                s1.Write("earning=" + EarningPoints & vbCrLf)
                s1.Write("flowering=" + txt_flower.Text & vbCrLf)
                s1.Write("count=" + txt_count.Text & vbCrLf)
                s1.Write("fem=" + cFem & vbCrLf)
                s1.Write("kind=" + cb_growtype.SelectedItem.ToString & vbCrLf)
                Try
                    s1.Write("setup=" + cb_setup.SelectedItem.ToString & vbCrLf)
                Catch ex As Exception

                End Try
                s1.Write("sdate=" + NowD & vbCrLf)
                s1.Write("ndate=" + NowP & vbCrLf)
                s1.Write("earth=" + txt_earth.Text & vbCrLf)
                s1.Write("p=" + cPhase & vbCrLf)
                s1.Write("d1=" + d1 & vbCrLf)
                s1.Write("d2=" + d2 & vbCrLf)
                s1.Write("d3=" + d3 & vbCrLf)
                s1.Write("d4=" + d4 & vbCrLf)
                s1.Write("sativa=" + cb_sativa.SelectedItem.ToString & vbCrLf)
                s1.Write("indica=" + cb_indica.SelectedItem.ToString & vbCrLf)
                s1.Write("ruderalis=" + cb_rud.SelectedItem.ToString & vbCrLf)
                s1.Write("type_id=" + cb_g.SelectedIndex.ToString & vbCrLf)
                s1.Close()
                fs1.Close()
                main.tv_projects.Nodes(0).Nodes(0).Nodes.Clear()
                main.loadProjects()
                main.loadProjectFile(txt_name.Text + " (" + NowD + ")")
            End If
        Catch ex As Exception
            MsgBox("Bitte füllen sie alle Felder aus!", MsgBoxStyle.Critical, "Fehler")
        End Try
    End Sub

    Private Sub cb_phase_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_phase.SelectedIndexChanged
        If cb_phase.SelectedIndex = 0 Then
            datetime_phase.Visible = False
        Else
            datetime_phase.Visible = True
        End If
    End Sub
End Class