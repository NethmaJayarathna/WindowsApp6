Imports MySql.Data.MySqlClient

Module DBconnection

    Private ReadOnly connString As String = "Server=localhost;Database=DBAPP;User Id=root;Password=;"

    Public Function GetConnection() As MySqlConnection
        Dim conn As New MySqlConnection(connString)
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("Database Connection Failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return conn
    End Function


End Module
