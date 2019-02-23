Public Class Introductory
    Public dialogue(5)
    Public ctr2 = 0
    Private Sub Introductory_Load(sender As Object, e As EventArgs) Handles Me.Load
        dialogue(0) = "hello!"
        dialogue(1) = "Your name is betlog."
        dialogue(2) = "You are about to experience"
        dialogue(3) = "Things you haven't experienced before."
        dialogue(4) = "So behold!"
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class