Imports MySql.Data.MySqlClient

Public Class Form2
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim OrderDateAndTime As String
        Dim OrderCusName As String
        Dim OrderCusId As Integer
        Dim OrderPaid As String
        Dim OrderAmount As Double

        OrderDateAndTime = OrderDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss")
        OrderCusName = currentCusName
        OrderCusId = currentCustomerID
        OrderPaid = cmbPaid.SelectItem.Tosting()
        OrderAmount = txtamount.Text()

        Try
            AddOrder()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnselect_Click(sender As Object, e As EventArgs) Handles btnselect.Click
        Dim ClientForm As New Form1()
        ClientForm.ShowDialog()

    End Sub


End Class