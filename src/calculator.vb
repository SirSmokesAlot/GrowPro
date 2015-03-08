Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions

Public Class calculator
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btn_mini_Click(sender As Object, e As EventArgs) Handles btn_mini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_calc_Click(sender As Object, e As EventArgs) Handles btn_calc.Click
        Try

            txt_result.Text = ""

            Dim flower_cost As Double = 0
            Dim flower_usage As Double = 0
            Dim grow_cost As Double = 0
            Dim grow_usage As Double = 0
            Dim air_cost As Double = 0
            Dim air_usage As Double = 0
            Dim other_cost As Double = 0
            Dim other_usage As Double = 0
            Dim cost As Double = 0
            Dim usage As Double = 0

            If Not txt_w_days.Text = "" And Not txt_w_power.Text = "" And Not cb_w_hours.Text = "--" Then
                grow_cost = Math.Round((txt_w_power.Text * cb_w_hours.SelectedItem.ToString * txt_w_days.Text * txt_price.Text * 0.001) * 100) / 100
                grow_usage = Math.Round((txt_w_power.Text * cb_w_hours.SelectedItem.ToString * txt_w_days.Text * 0.001) * 100) / 100
                txt_result.Text = txt_result.Text & vbNewLine & "Vegitation: " & System.Convert.ToString(grow_cost) & "€ (" & System.Convert.ToString(grow_usage) & " kWh)"
            End If

            If Not txt_b_days.Text = "" And Not txt_b_power.Text = "" And Not cb_b_hours.Text = "--" Then
                flower_cost = Math.Round((txt_b_power.Text * cb_b_hours.SelectedItem.ToString * txt_b_days.Text * txt_price.Text * 0.001) * 100) / 100
                flower_usage = Math.Round((txt_b_power.Text * cb_b_hours.SelectedItem.ToString * txt_b_days.Text * 0.001) * 100) / 100
                txt_result.Text = txt_result.Text & vbNewLine & "Blütephase: " & System.Convert.ToString(flower_cost) & "€ (" & System.Convert.ToString(flower_usage) & " kWh)"
            End If

            If Not txt_a_power.Text = "" Then
                If Not txt_w_days.Text = "" And Not txt_w_power.Text = "" And Not cb_w_hours.Text = "--" And txt_b_days.Text = "" And txt_b_power.Text = "" And cb_b_hours.Text = "--" Then
                    air_cost = Math.Round((txt_a_power.Text * cb_w_hours.SelectedItem.ToString * txt_w_days.Text * txt_price.Text * 0.001) * 100) / 100
                    air_usage = Math.Round((txt_a_power.Text * cb_w_hours.SelectedItem.ToString * txt_w_days.Text * 0.001) * 100) / 100
                    txt_result.Text = txt_result.Text & vbNewLine & "Belüftung: " & System.Convert.ToString(air_cost) & "€ (" & System.Convert.ToString(air_usage) & " kWh)"
                    MsgBox("a")
                ElseIf Not txt_b_days.Text = "" And Not txt_b_power.Text = "" And Not cb_b_hours.Text = "--" And txt_w_days.Text = "" And txt_w_power.Text = "" And cb_w_hours.Text = "--" Then
                    air_cost = Math.Round((txt_a_power.Text * cb_b_hours.SelectedItem.ToString * txt_b_days.Text * txt_price.Text * 0.001) * 100) / 100
                    air_usage = Math.Round((txt_a_power.Text * cb_b_hours.SelectedItem.ToString * txt_b_days.Text * 0.001) * 100) / 100
                    txt_result.Text = txt_result.Text & vbNewLine & "Belüftung: " & System.Convert.ToString(air_cost) & "€ (" & System.Convert.ToString(air_usage) & " kWh)"
                    MsgBox("x")
                ElseIf Not txt_w_days.Text = "" And Not txt_w_power.Text = "" And Not cb_w_hours.Text = "--" And Not txt_b_days.Text = "" And Not txt_b_power.Text = "" And Not cb_b_hours.Text = "--" Then
                    Dim gc As String
                    Dim gu As String
                    gc = Math.Round((txt_a_power.Text * cb_w_hours.SelectedItem.ToString * txt_w_days.Text * txt_price.Text * 0.001) * 100) / 100 + Math.Round((txt_a_power.Text * cb_b_hours.SelectedItem.ToString * txt_b_days.Text * txt_price.Text * 0.001) * 100) / 100
                    gu = Math.Round((txt_a_power.Text * cb_w_hours.SelectedItem.ToString * txt_w_days.Text * 0.001) * 100) / 100 + Math.Round((txt_a_power.Text * cb_b_hours.SelectedItem.ToString * txt_b_days.Text * 0.001) * 100) / 100
                    air_cost = gc
                    air_usage = gu
                    txt_result.Text = txt_result.Text & vbNewLine & "Belüftung: " & System.Convert.ToString(air_cost) & "€ (" & System.Convert.ToString(air_usage) & " kWh)"
                End If
            End If

            If Not txt_sv_days.Text = "" And Not txt_sv_power.Text = "" And Not cb_sv_hours.Text = "--" Then
                other_cost = Math.Round((txt_sv_power.Text * cb_sv_hours.SelectedItem.ToString * txt_sv_days.Text * txt_price.Text * 0.001) * 100) / 100
                other_usage = Math.Round((txt_sv_power.Text * cb_sv_hours.SelectedItem.ToString * txt_sv_days.Text * 0.001) * 100) / 100
                txt_result.Text = txt_result.Text & vbNewLine & "Andere: " & System.Convert.ToString(other_cost) & "€ (" & System.Convert.ToString(other_usage) & " kWh)"
            End If

            cost = grow_cost + flower_cost + air_cost + other_cost
            usage = grow_usage + flower_usage + air_usage + other_usage

            txt_result.Text =
                txt_result.Text &
                vbNewLine & "----------------------------" &
                vbNewLine & "Gesamt: " & System.Convert.ToString(cost) & "€" &
                vbNewLine & "Verbrauch: " & System.Convert.ToString(usage) & "kWh"
            txt_result.Text = Replace(txt_result.Text, vbLf & vbCr, "")

        Catch ex As Exception
            MsgBox("Unbekannter Fehler", MsgBoxStyle.Critical, "Fehler")
        End Try
    End Sub
End Class