Public Class Main
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub btnQuit_MouseEnter(sender As Object, e As EventArgs) Handles btnQuit.MouseEnter
        swapOverlays("btnQuit", "enter")
    End Sub

    Private Sub btnQuit_MouseLeave(sender As Object, e As EventArgs) Handles btnQuit.MouseLeave
        swapOverlays("btnQuit", "leave")
    End Sub

    Private Sub btnStart_MouseEnter(sender As Object, e As EventArgs) Handles btnStart.MouseEnter
        swapOverlays("btnStart", "enter")
    End Sub

    Private Sub btnStart_MouseLeave(sender As Object, e As EventArgs) Handles btnStart.MouseLeave
        swapOverlays("btnStart", "leave")
    End Sub

    Private Sub btnLoad_MouseEnter(sender As Object, e As EventArgs) Handles btnLoad.MouseEnter
        swapOverlays("btnLoad", "enter")
    End Sub

    Private Sub btnLoad_MouseLeave(sender As Object, e As EventArgs) Handles btnLoad.MouseLeave
        swapOverlays("btnLoad", "leave")
    End Sub

    Private Sub btnPreferences_MouseLeave(sender As Object, e As EventArgs) Handles btnPreferences.MouseEnter
        swapOverlays("btnPreferences", "enter")
    End Sub

    Private Sub btnPreferences_MouseEnter(sender As Object, e As EventArgs) Handles btnPreferences.MouseLeave
        swapOverlays("btnPreferences", "leave")
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Arceus.load()
    End Sub

    Private Sub btnLoadClose_Click(sender As Object, e As EventArgs) Handles btnLoadClose.Click
        closeLoad()
    End Sub

    Private Sub btnLoadClose_MouseEnter(sender As Object, e As EventArgs) Handles btnLoadClose.MouseEnter
        swapOverlays("btnLoadClose", "enter")
    End Sub

    Private Sub btnLoadClose_MouseLeave(sender As Object, e As EventArgs) Handles btnLoadClose.MouseLeave
        swapOverlays("btnLoadClose", "leave")
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Me.Hide()
        Storyboard.Show()
    End Sub
End Class
