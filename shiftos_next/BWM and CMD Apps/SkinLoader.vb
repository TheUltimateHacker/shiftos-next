﻿Public Class SkinLoader

    Public skintoload As String

    Public Sub readfile(file As String)
        Dim filinf As New IO.FileInfo(file)
        If filinf.Extension = ".bsk" Then
            Dim loadlines() As String = IO.File.ReadAllLines(file)
            prev_titlebar.BackColor = Color.FromArgb(loadlines(0))
            prev_titlebar.ForeColor = Color.FromArgb(loadlines(1))
            prev_desktop.BackColor = Color.FromArgb(loadlines(2))
            prev_newterminal.BackColor = Color.FromArgb(loadlines(3))
            prev_newterminal.ForeColor = Color.FromArgb(loadlines(4))
        Else
            basicwm_infobox.showinfo("Unsupported file", "The skin file provided cannot be read.")
        End If

    End Sub

    Private Sub btnload_Click(sender As Object, e As EventArgs) Handles btnload.Click
        file_skimmer.mode = "open"
        file_skimmer.application = "skin_loader"
        file_skimmer.Show()
    End Sub

    Private Sub btnapply_Click(sender As Object, e As EventArgs) Handles btnapply.Click
        If Not skintoload = "" Then
            loadskin(skintoload)
        Else
            basicwm_infobox.showinfo("Can't apply skin!", "Cannot apply the skin, as there is currently no skin file loaded.")
        End If
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        file_skimmer.mode = "save"
        file_skimmer.application = "skin_loader"
        file_skimmer.Show()
    End Sub
End Class