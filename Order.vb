Imports MySql.Data.MySqlClient

Module Order

    Public Sub AddOrder(name As String, age As Integer)
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

End Module
