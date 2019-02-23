Public Class TitleSplash
    Public ctr
    Public ending = 0
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ending = 0 Then
            Me.Opacity += 0.01
            If Me.Opacity = 1 Then
                Timer1.Interval = 1000
                ctr += 1
                If ctr = 3 Then
                    Main.Show()
                    Timer1.Stop()
                    Me.Close()
                End If
            End If
        Else
            ctr -= 1
            If ctr <= 0 Then
                Me.Opacity -= 0.01
                If Me.Opacity <= 0 Then
                    Timer1.Stop()
                    End
                End If
            End If

        End If

    End Sub

    Private Sub TitleSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ending = 0 Then
            Me.Opacity = 0
        Else

            Me.Opacity = 1
        End If

        Timer1.Start()
    End Sub
End Class