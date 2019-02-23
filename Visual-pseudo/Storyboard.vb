Public Class Storyboard
    Dim menuOn As Boolean = False

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If menuOn = False Then
            menuOn = True
            btnReturn.Visible = True
            btnSave.Visible = True
        Else
            menuOn = False
            btnReturn.Visible = False
            btnSave.Visible = False
        End If
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Main.Show()
        Me.Close()
    End Sub

End Class