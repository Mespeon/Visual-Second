Module Arceus
    Public ctr1
    Public wordarr(250)
    'Swap overlays
    Public Sub swapOverlays(button, mode)
        If button = "btnStart" Then
            If mode = "enter" Then
                Main.btnStart.BackgroundImage = My.Resources.scrim_w
            Else
                Main.btnStart.BackgroundImage = Nothing
            End If
        ElseIf button = "btnLoad" Then
            If mode = "enter" Then
                Main.btnLoad.BackgroundImage = My.Resources.scrim_w
            Else
                Main.btnLoad.BackgroundImage = Nothing
            End If
        ElseIf button = "btnPreferences" Then
            If mode = "enter" Then
                Main.btnPreferences.BackgroundImage = My.Resources.scrim_w
            Else
                Main.btnPreferences.BackgroundImage = Nothing
            End If
        ElseIf button = "btnLoadClose" Then
            If mode = "enter" Then
                Main.btnLoadClose.BackgroundImage = My.Resources.scrim_w
            Else
                Main.btnLoadClose.BackgroundImage = Nothing
            End If
        Else
            If mode = "enter" Then
                Main.btnQuit.BackgroundImage = My.Resources.scrim_w
            Else
                Main.btnQuit.BackgroundImage = Nothing
            End If
        End If
    End Sub

    'En/disable control panel
    Public Sub ctrlPanelToggle(mode)
        If mode = 1 Then
            Main.pnlControls.Enabled = True
        Else
            Main.pnlControls.Enabled = False
        End If
    End Sub

    'View load menu
    Public Sub load()
        'Set background to scrimmed and show load menu
        Main.pnlLeftScrim.BackgroundImage = My.Resources.scrim
        Main.pnlLoadData.Enabled = True
        Main.pnlLoadData.Visible = True

        'Disable control panel
        ctrlPanelToggle(0)

        'Pull saved data from file
    End Sub

    'Close load menu
    Public Sub closeLoad()
        'Reset backgrounds
        Main.pnlLeftScrim.BackgroundImage = Nothing
        Main.pnlLoadData.Enabled = False
        Main.pnlLoadData.Visible = False

        'Reenable control panel
        ctrlPanelToggle(1)
    End Sub

    'Progress story
    Public Sub forwardStory()

    End Sub

    'Save progress

    Public Sub wordorganizer()
        Dim s As String
        s = "SWAP FOR REAL DIALOGUES"
        Storyboard.lblStory.Text = Nothing
        Dim words
        words = Split(s)
        For i = 0 To UBound(words)
            wordarr(ctr1) = words(i)
            ctr1 += 1
        Next
        ctr1 = 0
        Storyboard.worddisplayer.Start()
        Storyboard.worddisplayer.Interval = Len(wordarr(ctr1)) * 100
    End Sub

    Public Sub worddisplay()
        Storyboard.lblStory.Text += wordarr(ctr1) & " "
        ctr1 += 1
        If ctr1 >= wordarr.Count - 2 = False Then
            If Len(wordarr(ctr1)) * 100 > 0 Then
                Storyboard.worddisplayer.Interval = Len(wordarr(ctr1)) * 100
            Else
                Storyboard.worddisplayer.Stop()
            End If
        Else
            Storyboard.worddisplayer.Stop()
        End If
    End Sub
End Module
