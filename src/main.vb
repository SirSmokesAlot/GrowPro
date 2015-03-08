Imports System.IO
Imports System.Net

Public Class main
    Public Shared pFile As String
    Public Shared sFile As String
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        loading.Close()
    End Sub

    Private Sub btn_mini_Click(sender As Object, e As EventArgs) Handles btn_mini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            loadProjects()
            loadSetups()
            tv_projects.ExpandAll()
        Catch ex As Exception
            MsgBox("Fehler-Code: 0x000000", MsgBoxStyle.Critical, "Kritischer Fehler")
        End Try
    End Sub

    Public Sub loadProjects()
        Try
            Dim pdir As New DirectoryInfo(My.Application.Info.DirectoryPath + "/res/project/indoor/")
            Dim flist As FileInfo() = pdir.GetFiles("*.ini")
            Dim finfo As FileInfo

            For Each finfo In flist
                Dim p_ConfigFile As String = My.Application.Info.DirectoryPath + "/res/project/indoor/" + finfo.ToString
                Dim p_INI_File As New IniFile(p_ConfigFile)

                tv_projects.Nodes(0).Nodes(0).Nodes.Add(p_INI_File.GetString("Data", "name", "(leer)") + " (" + p_INI_File.GetString("Data", "sdate", "(leer)") + ")")
            Next
        Catch ex As Exception
            MsgBox("Fehler-Code: 0x000310", MsgBoxStyle.Critical, "Kritischer Fehler")
        End Try
    End Sub

    Public Sub loadSetups()
        Try
            Dim pdir As New DirectoryInfo(My.Application.Info.DirectoryPath + "/res/setup/")
            Dim flist As FileInfo() = pdir.GetFiles("*.ini")
            Dim finfo As FileInfo

            For Each finfo In flist
                Dim p_ConfigFile As String = My.Application.Info.DirectoryPath + "/res/setup/" + finfo.ToString
                Dim p_INI_File As New IniFile(p_ConfigFile)

                tv_projects.Nodes(0).Nodes(1).Nodes.Add(p_INI_File.GetString("Data", "name", "(leer)"))
            Next
        Catch ex As Exception
            MsgBox("Fehler-Code: 0x000311", MsgBoxStyle.Critical, "Kritischer Fehler")
        End Try
    End Sub

    Public Sub loadProjectFile(ByVal filename As String)
        Try
            Dim p_ConfigFile As String = My.Application.Info.DirectoryPath + "/res/project/indoor/" + filename + ".ini"
            Dim p_INI_File As New IniFile(p_ConfigFile)
            l_sdate.Text = p_INI_File.GetString("Data", "sdate", "[fehler]")
            Dim firstDate As String
            Dim secondDate As Date
            If p_INI_File.GetString("Data", "p", "0") = "1" Then
                firstDate = p_INI_File.GetString("Data", "sdate", "[fehler]")
                secondDate = CDate(firstDate)
                l_day.Text = DateDiff(DateInterval.Day, secondDate, Now.Date)
                l_day.Text = l_day.Text + +1
            Else
                firstDate = p_INI_File.GetString("Data", "ndate", "[fehler]")
                secondDate = CDate(firstDate)
                l_day.Text = DateDiff(DateInterval.Day, secondDate, Now.Date)
                l_day.Text = l_day.Text + +1
            End If

            l_desc.Text = p_INI_File.GetString("Data", "name", "[fehler]")
            l_type.Text = p_INI_File.GetString("Data", "type", "[fehler]")
            Dim e As String = p_INI_File.GetString("Data", "earning", "[fehler]")
            If e = "+" Then
                l_earning.Text = "Kleiner Ertrag"
            ElseIf e = "++" Then
                l_earning.Text = "Mittlerer Ertrag"
            ElseIf e = "+++" Then
                l_earning.Text = "Großer Ertrag"
            ElseIf e = "++++" Then
                l_earning.Text = "Sehr Großer Ertrag"
            End If
            If p_INI_File.GetString("Data", "fem", "[fehler]") = "true" Then
                l_fem.Text = "Ja"
            Else
                l_fem.Text = "Nein"
            End If
            l_flower.Text = "ca. " & p_INI_File.GetString("Data", "flowering", "[fehler]") & " Tage"
            If p_INI_File.GetString("Data", "kind", "[fehler]") = "1" Then
                l_gtype.Text = "Steckling"
            Else
                l_gtype.Text = "Samen"
            End If
            l_earth.Text = p_INI_File.GetString("Data", "earth", "[fehler]")
            l_count.Text = p_INI_File.GetString("Data", "count", "[fehler]")
            Dim p As String = p_INI_File.GetString("Data", "p", "[fehler]")
            If p = "1" Then
                l_phase.ForeColor = Color.OrangeRed
                l_phase.Text = "Keimling/Steckling"
                If l_day.Text > 7 Then
                    pbar_howfar.Value = 21
                Else
                    pbar_howfar.Value = l_day.Text * 3
                End If
            ElseIf p = "2" Then
                l_phase.ForeColor = Color.LightGreen
                l_phase.Text = "Wachstumsphase"
                If l_day.Text > 30 Then
                    pbar_howfar.Value = 50
                Else
                    pbar_howfar.Value = l_day.Text * 0.96 + 21
                End If
            ElseIf p = "3" Then
                l_phase.ForeColor = Color.MediumPurple
                l_phase.Text = "Blüte"
                If l_day.Text > 80 Then
                    pbar_howfar.Value = 100
                Else
                    pbar_howfar.Value = l_day.Text * 0.3625 + 50
                End If
            ElseIf p = "4" Then
                pbar_howfar.Value = 100
                l_phase.ForeColor = Color.Gray
                l_phase.Text = "Trocknen"
            ElseIf p = "5" Then
                pbar_howfar.Value = 100
                l_phase.ForeColor = Color.White
                l_phase.Text = "Fertig"
            End If
            l_setup.Text = p_INI_File.GetString("Data", "setup", "[fehler]")
        Catch ex As Exception
            MsgBox("Fehler-Code: 0x000312", MsgBoxStyle.Critical, "Kritischer Fehler")
        End Try
    End Sub

    Sub tv_projects_NodeMouseDoubleClick(ByVal sender As Object, ByVal e As TreeNodeMouseClickEventArgs) Handles tv_projects.NodeMouseDoubleClick
        Try
            tv_projects.ExpandAll()
            If tv_projects.SelectedNode.Parent Is Nothing = False Then
                If tv_projects.SelectedNode.Parent.Text = "Indoor" Then
                    loadProjectFile(tv_projects.SelectedNode.Text.ToString())
                    If l_phase.Text = "Fertig" Then
                        btn_nextp.Enabled = False
                        btn_nextp.Visible = False
                    End If
                    pFile = l_desc.Text + " (" + l_sdate.Text + ")"
                ElseIf tv_projects.SelectedNode.Parent.Text = "Setups" Then
                    sFile = tv_projects.SelectedNode.Text.ToString()
                    viewSetup.Show()
                ElseIf tv_projects.SelectedNode.Parent.Text = "Links" Then
                    Process.Start(tv_projects.SelectedNode.Text)
                ElseIf tv_projects.SelectedNode.Parent.Text = "Hilfe" Then
                    If tv_projects.SelectedNode.Text = "Basiswissen" Then
                        Process.Start("http://opencannabis.net/growguide-start.html")
                    ElseIf tv_projects.SelectedNode.Text = "Licht & Beleuchtung" Then
                        Process.Start("http://opencannabis.net/growguide-licht.html")
                    ElseIf tv_projects.SelectedNode.Text = "Bewässerung, Dünger & Erde" Then
                        Process.Start("http://opencannabis.net/growguide-wasser-boden.html")
                    ElseIf tv_projects.SelectedNode.Text = "Luft & Belüftung" Then
                        Process.Start("http://opencannabis.net/growguide-luft.html")
                    ElseIf tv_projects.SelectedNode.Text = "Samen und Stecklinge" Then
                        Process.Start("http://opencannabis.net/growguide-keimling.html")
                    ElseIf tv_projects.SelectedNode.Text = "Wachstumsphase" Then
                        Process.Start("http://opencannabis.net/growguide-wachstum.html")
                    ElseIf tv_projects.SelectedNode.Text = "Blütephase" Then
                        Process.Start("http://opencannabis.net/growguide-bluete.html")
                    ElseIf tv_projects.SelectedNode.Text = "Ernte" Then
                        Process.Start("http://opencannabis.net/growguide-ernte.html")
                    ElseIf tv_projects.SelectedNode.Text = "Probleme" Then
                        Process.Start("http://opencannabis.net/growguide-probleme.html")
                    End If
                End If
            End If
            If tv_projects.SelectedNode.Text = "Projekt Erstellen" Then
                addProject.Show()
            ElseIf tv_projects.SelectedNode.Text = "Setup Erstellen" Then
                addSetup.Show()
            ElseIf tv_projects.SelectedNode.Text = "Profil" Then
                register.Show()
            ElseIf tv_projects.SelectedNode.Text = "Stromkostenrechner" Then
                calculator.Show()
            ElseIf tv_projects.SelectedNode.Text = "Düngetabellen" Then
                Process.Start("http://www.growmart.de/PDFs/Duengeschemata.html")
            End If
        Catch ex As Exception
            MsgBox("Fehler-Code: 0x000313", MsgBoxStyle.Critical, "Kritischer Fehler")
        End Try
    End Sub

    Private Sub btn_nextp_Click(sender As Object, e As EventArgs) Handles btn_nextp.Click
        Try
            pFile = l_desc.Text + " (" + l_sdate.Text + ")"
            Dim p_ConfigFile As String = My.Application.Info.DirectoryPath + "/res/project/indoor/" + pFile + ".ini"
            Dim p_INI_File As New IniFile(p_ConfigFile)

            If l_phase.Text = "Keimling/Steckling" Then
                p_INI_File.WriteString("Data", "d1", l_day.Text)
            ElseIf l_phase.Text = "Wachstumsphase" Then
                p_INI_File.WriteString("Data", "d2", l_day.Text)
            ElseIf l_phase.Text = "Blüte" Then
                p_INI_File.WriteString("Data", "d3", l_day.Text)
            ElseIf l_phase.Text = "Trocknen" Then
                p_INI_File.WriteString("Data", "d4", l_day.Text)
            End If

            If l_desc.Text = "(leer)" Then
                MsgBox("Bitte laden sie zuerst ein Projekt!", MsgBoxStyle.Critical, "GrowPro")
            Else
                If l_phase.Text = "Fertig" Then
                    btn_nextp.Enabled = False
                    btn_nextp.Visible = False
                Else
                    Dim nextP As String = p_INI_File.GetString("Data", "p", "0") + +1
                    p_INI_File.WriteString("Data", "p", nextP)
                    p_INI_File.WriteString("Data", "ndate", Now.Date)
                    loadProjectFile(pFile)
                End If
            End If
        Catch ex As Exception
            MsgBox("Fehler-Code: 0x000314", MsgBoxStyle.Critical, "Kritischer Fehler")
        End Try
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Try
            If l_desc.Text = "(leer)" Then
                MsgBox("Bitte laden sie zuerst ein Projekt!", MsgBoxStyle.Critical, "GrowPro")
            Else
                If MsgBox("Möchtest du das Projekt `" + l_desc.Text + "` wirklich löschen?", MsgBoxStyle.OkCancel) = vbOK Then
                    File.Delete(My.Application.Info.DirectoryPath + "/res/project/indoor/" + pFile + ".ini")
                    tv_projects.Nodes(0).Nodes(0).Nodes.Clear()
                    loadProjects()
                    pbar_howfar.Value = 0
                    l_flower.Text = "(leer)"
                    l_count.Text = "(leer)"
                    l_day.Text = "(leer)"
                    l_desc.Text = "(leer)"
                    l_earning.Text = "(leer)"
                    l_earth.Text = "(leer)"
                    l_fem.Text = "(leer)"
                    l_gtype.Text = "(leer)"
                    l_phase.Text = "(leer)"
                    l_sdate.Text = "(leer)"
                    l_setup.Text = "(leer)"
                    l_type.Text = "(leer)"
                    MsgBox("Projekt wurde erfolgreich gelöscht!", MsgBoxStyle.Information, "GrowPro")
                End If
            End If
        Catch ex As Exception
            MsgBox("Fehler-Code: 0x000314", MsgBoxStyle.Critical, "Kritischer Fehler")
        End Try
    End Sub

    Private Sub btn_growreport_Click(sender As Object, e As EventArgs) Handles btn_growreport.Click
        growreport.Show()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Try
            If l_desc.Text = "(leer)" Then
                MsgBox("Bitte laden sie zuerst ein Projekt!", MsgBoxStyle.Critical, "GrowPro")
            Else
                editProject.Show()
            End If
        Catch ex As Exception
            MsgBox("Fehler-Code: 0x000315", MsgBoxStyle.Critical, "Kritischer Fehler")
        End Try
    End Sub
End Class