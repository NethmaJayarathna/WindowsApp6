Imports MySql.Data.MySqlClient
Module ClientCRUD
    Public Sub AddClient(name As String, age As Integer)
        Using conn As MySqlConnection = GetConnection()
            'conn.Open()
            Dim query As String = "INSERT INTO TblClients (ClientName, ClientAge) VALUES (@name, @age)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@name", name)
                cmd.Parameters.AddWithValue("@age", age)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Function GetClients() As DataTable 'Returns a value thats why not sub, but function
        Dim table As New DataTable()

        Using conn As MySqlConnection = GetConnection()
            'conn.Open()
            Dim query As String = "SELECT ClientID, ClientName, ClientAge FROM TblClients"
            Using cmd As New MySqlCommand(query, conn)
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(table)
                End Using
            End Using
        End Using
        Return table
    End Function
End Module
