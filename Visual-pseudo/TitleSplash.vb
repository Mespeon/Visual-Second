Public Class TitleSplash
    Dim ctr
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Opacity += 0.01
        If Me.Opacity = 1 Then
            Timer1.Interval = 1000
            ctr += 1
            If ctr = 3 Then
                Main.Show()
                Timer1.Stop()
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub TitleSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        Timer1.Start()
    End Sub
End Class