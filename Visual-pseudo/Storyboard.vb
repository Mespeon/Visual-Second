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

    Private Sub btnChoiceA_Click(sender As Object, e As EventArgs) Handles btnChoiceA.Click

    End Sub

    Private Sub btnChoiceB_Click(sender As Object, e As EventArgs) Handles btnChoiceB.Click

    End Sub

    Private Sub pnlControls_Paint(sender As Object, e As PaintEventArgs) Handles pnlControls.Paint

    End Sub

    Private Sub Storyboard_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
End Class