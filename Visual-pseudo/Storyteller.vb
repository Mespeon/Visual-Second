Imports System.Xml
Imports System.IO

Module Storyteller
    Public storyProgress As String
    Public xmlReader As XmlTextReader

    Public Sub progressCheck()
        'Check if the save directory exists
        If (Directory.Exists("C:/Documents/Progress")) Then
            'If (File.Exists("save_data.xml")) Then
            'TODO: Read from save file
            'End If
            Storyboard.Show()
        Else
            MessageBox.Show("Nope")
            Storyboard.Show()
        End If
    End Sub

    Public Sub progressWrite()

    End Sub

    Public Sub progressLoad()

    End Sub
End Module
