Imports System.Data.SqlClient
Imports Mysqlx.XDevAPI

Public Class Form1

    Public Property isPikerMode As Boolean = False
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim clientName As String = txtname.Text
        Dim clientAge As Integer = txtage.Text

        If Integer.TryParse(txtage.Text, clientAge) Then
            AddClient(clientName, clientAge)
            MessageBox.Show("Client Added Successfully!")
            ClientDataGridView.DataSource = GetClients()
        Else
            MessageBox.Show("Please enter a valid age.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clientselect2.Visible = False

        If isPikerMode Then
            txtname.Enabled = False
            txtage.Enabled = False
            Button1.Visible = False
            clientselect2.Visible = True



        End If


    End Sub

    Private Sub clientselect2_Click(sender As Object, e As EventArgs) Handles clientselect2.Click
        currentCustomerID = ClientID
        currentCusName = clientselect2.Text
        Me.Close()
        Dim form2 As Mysqlx.Crud.Order()
        Mysqlx.Crud.Order.txtname.text = txtname.Text

    End Sub
End Class
