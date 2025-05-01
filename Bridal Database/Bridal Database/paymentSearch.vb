Imports System.Data.OleDb

Public Class paymentSearch
    ' Clears all input fields and resets the form
    Sub clearFields()
        ' Clears the text in the Customer ID text box
        txtID.Clear()
        ' Resets the Payment Method combo box to the default (no selection)
        cmbPaymentMethod.SelectedIndex = -1
        ' Resets the date picker to the current date
        dtpDate.Value = DateTime.Now.Date
        ' Clears the text in the Authorisation Code text box
        txtAuthorisation.Clear()
        ' Clears the minimum and maximum total cost text boxes
        txtMinTotal.Clear()
        txtMaxTotal.Clear()
        ' Clears the minimum and maximum paid amount text boxes
        txtMinPaid.Clear()
        txtMaxPaid.Clear()
        ' Clears the minimum and maximum remaining balance text boxes
        txtMinRemaining.Clear()
        txtMaxRemaining.Clear()
    End Sub

    ' Searches for payment records based on the provided criteria
    Sub orderFinder()
        ' Initial query to select all payment records from the tblPayment table
        Dim query As String = "SELECT * FROM tblPayment WHERE 1=1"
        ' List to hold the parameters that will be used in the query
        Dim parameters As New List(Of OleDbParameter)

        ' Check if Customer ID is entered, and add it to the query if so
        If Not String.IsNullOrEmpty(txtID.Text) Then
            query &= " AND CustomerID LIKE ?"
            parameters.Add(New OleDbParameter("?", "%" & txtID.Text & "%"))
        End If

        ' Check if Payment Method is selected, and add it to the query if so
        If cmbPaymentMethod.SelectedIndex <> -1 Then
            query &= " AND Method = ?"
            parameters.Add(New OleDbParameter("?", cmbPaymentMethod.SelectedItem.ToString()))
        End If

        ' Check if a specific payment date is selected, and add it to the query if not the current date
        If dtpDate.Value.Date <> DateTime.Now.Date Then
            query &= " AND PaymentDate = ?"
            parameters.Add(New OleDbParameter("?", dtpDate.Value.Date))
        End If

        ' Check if an Authorisation Code is entered, and add it to the query if so
        If Not String.IsNullOrEmpty(txtAuthorisation.Text) Then
            query &= " AND Code LIKE ?"
            parameters.Add(New OleDbParameter("?", "%" & txtAuthorisation.Text & "%"))
        End If

        ' Check if a total cost range is provided, and add it to the query if so
        If Not String.IsNullOrEmpty(txtMinTotal.Text) AndAlso Not String.IsNullOrEmpty(txtMaxTotal.Text) Then
            query &= " AND TotalCost BETWEEN ? AND ?"
            parameters.Add(New OleDbParameter("?", Convert.ToDecimal(txtMinTotal.Text)))
            parameters.Add(New OleDbParameter("?", Convert.ToDecimal(txtMaxTotal.Text)))
        ElseIf Not String.IsNullOrEmpty(txtMinTotal.Text) Then
            query &= " AND TotalCost >= ?"
            parameters.Add(New OleDbParameter("?", Convert.ToDecimal(txtMinTotal.Text)))
        ElseIf Not String.IsNullOrEmpty(txtMaxTotal.Text) Then
            query &= " AND TotalCost <= ?"
            parameters.Add(New OleDbParameter("?", Convert.ToDecimal(txtMaxTotal.Text)))
        End If

        ' Check if a paid amount range is provided, and add it to the query if so
        If Not String.IsNullOrEmpty(txtMinPaid.Text) AndAlso Not String.IsNullOrEmpty(txtMaxPaid.Text) Then
            query &= " AND AmountPaid BETWEEN ? AND ?"
            parameters.Add(New OleDbParameter("?", Convert.ToDecimal(txtMinPaid.Text)))
            parameters.Add(New OleDbParameter("?", Convert.ToDecimal(txtMaxPaid.Text)))
        ElseIf Not String.IsNullOrEmpty(txtMinPaid.Text) Then
            query &= " AND AmountPaid >= ?"
            parameters.Add(New OleDbParameter("?", Convert.ToDecimal(txtMinPaid.Text)))
        ElseIf Not String.IsNullOrEmpty(txtMaxPaid.Text) Then
            query &= " AND AmountPaid <= ?"
            parameters.Add(New OleDbParameter("?", Convert.ToDecimal(txtMaxPaid.Text)))
        End If

        ' Check if a remaining balance range is provided, and add it to the query if so
        If Not String.IsNullOrEmpty(txtMinRemaining.Text) AndAlso Not String.IsNullOrEmpty(txtMaxRemaining.Text) Then
            query &= " AND Balance BETWEEN ? AND ?"
            parameters.Add(New OleDbParameter("?", Convert.ToInt32(txtMinRemaining.Text)))
            parameters.Add(New OleDbParameter("?", Convert.ToInt32(txtMaxRemaining.Text)))
        ElseIf Not String.IsNullOrEmpty(txtMinRemaining.Text) Then
            query &= " AND Balance >= ?"
            parameters.Add(New OleDbParameter("?", Convert.ToInt32(txtMinRemaining.Text)))
        ElseIf Not String.IsNullOrEmpty(txtMaxRemaining.Text) Then
            query &= " AND Balance <= ?"
            parameters.Add(New OleDbParameter("?", Convert.ToInt32(txtMaxRemaining.Text)))
        End If

        ' Establish a connection to the database
        Dim connection As OleDbConnection = connectDatabase()
        connection.Open()

        ' Create the command to execute the query with the parameters
        Dim command As New OleDbCommand(query, connection)
        command.Parameters.AddRange(parameters.ToArray())

        ' Use the adapter to execute the command and fill the DataTable
        Dim adapter As New OleDbDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        ' Set the DataGridView's data source to the result table
        Payment_History.dgvPayment.DataSource = table
    End Sub

    ' Event handler for the Cancel button click event
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ' Hide the current form and show the Payment History form
        Me.Hide()
        Payment_History.Show()
    End Sub

    ' Event handler for the Customer Search button click event
    Private Sub btnCustomerSearch_Click(sender As Object, e As EventArgs) Handles btnCustomerSearch.Click
        ' Call the orderFinder method to execute the search query
        orderFinder()

        ' Hide the current form and show the Payment History form
        Me.Hide()
        Payment_History.Show()
    End Sub

    ' Event handler for the Clear Fields button click event
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Call the clearFields method to reset the input fields
        clearFields()
    End Sub
End Class