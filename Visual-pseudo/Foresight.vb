Imports MySql.Data.MySqlClient

Module Foresight
    'Connection variables
    Public sqlConnection As New MySqlConnection
    Public sqlCommand As New MySqlCommand
    Public sqlDataReader As MySqlDataReader

    'For data grids, just in case
    Public sqlDataAdapter As New MySqlDataAdapter
    Public sqlDataTable As New DataTable

    'For queries
    Public sqlQuery As String

    Public Sub connect()
        If sqlConnection.State = ConnectionState.Closed Then
            Try
                sqlConnection.ConnectionString = "SERVER = localhost; DATABASE = visual; UID = root; PWD="
                sqlConnection.Open()
            Catch ex As Exception
                Dim errorPrompt = MessageBox.Show("The attempt to connect to the database failed.\nError:\n" & ex.ToString & "\nRetry to connect?", "Connection Failed", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
                If errorPrompt = MsgBoxResult.Yes Then
                    connect()
                Else
                    End
                End If
            End Try
        End If
    End Sub

    Public Sub disconnect()
        If sqlConnection.State = ConnectionState.Open Then
            Try
                sqlConnection.Close()
            Catch ex As Exception
                MessageBox.Show("Disconnection failed.\n" & ex.ToString, "Disconnection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Module
