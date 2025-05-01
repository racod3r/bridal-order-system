Imports System.Data.OleDb

Public Class CustomerSearch
    ' Clears all fields in the customer search form
    Sub clearCustomerSearch()
        ' Reset all text fields to blank
        txtID.Clear()
        txtSurname.Clear()
        txtFirstName.Clear()
        txtAddress.Clear()
        txtPostcode.Clear()
        txtCity.Clear()
        txtBust.Clear()
        txtWaist.Clear()
        txtHips.Clear()
        txtTel1.Clear()
        txtTel2.Clear()
        txtMail.Clear()
        ' Reset the date picker back to today's date
        dtpDate.Value = DateTime.Now.Date
    End Sub

    ' Searches the database for customers based on filled search fields
    Sub customerFinder()
        ' Start the SQL query with a condition that's always true
        Dim query As String = "SELECT * FROM tblDetails WHERE 1=1"
        Dim parameters As New List(Of OleDbParameter)

        ' If CustomerID textbox is filled, add a filter for CustomerID
        If Not String.IsNullOrEmpty(txtID.Text) Then
            query &= " AND CustomerID LIKE ?"
            parameters.Add(New OleDbParameter("?", "%" & txtID.Text & "%"))
        End If

        ' If FirstName textbox is filled, add a filter for FirstName
        If Not String.IsNullOrEmpty(txtFirstName.Text) Then
            query &= " AND FirstName LIKE ?"
            parameters.Add(New OleDbParameter("?", "%" & txtFirstName.Text & "%"))
        End If

        ' If Surname textbox is filled, add a filter for Surname
        If Not String.IsNullOrEmpty(txtSurname.Text) Then
            query &= " AND Surname LIKE ?"
            parameters.Add(New OleDbParameter("?", "%" & txtSurname.Text & "%"))
        End If

        ' If Postcode textbox is filled, add a filter for Postcode
        If Not String.IsNullOrEmpty(txtPostcode.Text) Then
            query &= " AND Postcode LIKE ?"
            parameters.Add(New OleDbParameter("?", "%" & txtPostcode.Text & "%"))
        End If

        ' If City textbox is filled, add a filter for City
        If Not String.IsNullOrEmpty(txtCity.Text) Then
            query &= " AND City LIKE ?"
            parameters.Add(New OleDbParameter("?", "%" & txtCity.Text & "%"))
        End If

        ' If Address textbox is filled, add a filter for Address
        If Not String.IsNullOrEmpty(txtAddress.Text) Then
            query &= " AND Address LIKE ?"
            parameters.Add(New OleDbParameter("?", "%" & txtAddress.Text & "%"))
        End If

        ' If the selected date is different from today's date, add a filter for Wedding Date
        If dtpDate.Value.Date <> DateTime.Now.Date Then
            query &= " AND WedDate = ?"
            parameters.Add(New OleDbParameter("?", dtpDate.Value.Date))
        End If

        ' If Telephone 1 textbox is filled, add a filter for Tel1
        If Not String.IsNullOrEmpty(txtTel1.Text) Then
            query &= " AND Tel1 LIKE ?"
            parameters.Add(New OleDbParameter("?", "%" & txtTel1.Text & "%"))
        End If

        ' If Telephone 2 textbox is filled, add a filter for Tel2
        If Not String.IsNullOrEmpty(txtTel2.Text) Then
            query &= " AND Tel2 LIKE ?"
            parameters.Add(New OleDbParameter("?", "%" & txtTel2.Text & "%"))
        End If

        ' If Email textbox is filled, add a filter for Mail
        If Not String.IsNullOrEmpty(txtMail.Text) Then
            query &= " AND Mail LIKE ?"
            parameters.Add(New OleDbParameter("?", "%" & txtMail.Text & "%"))
        End If

        ' If Bust textbox is filled, add a filter for Bust
        If Not String.IsNullOrEmpty(txtBust.Text) Then
            query &= " AND Bust LIKE ?"
            parameters.Add(New OleDbParameter("?", "%" & txtBust.Text & "%"))
        End If

        ' If Waist textbox is filled, add a filter for Waist
        If Not String.IsNullOrEmpty(txtWaist.Text) Then
            query &= " AND Waist LIKE ?"
            parameters.Add(New OleDbParameter("?", "%" & txtWaist.Text & "%"))
        End If

        ' If Hips textbox is filled, add a filter for Hips
        If Not String.IsNullOrEmpty(txtHips.Text) Then
            query &= " AND Hips LIKE ?"
            parameters.Add(New OleDbParameter("?", "%" & txtHips.Text & "%"))
        End If

        ' Open the database connection
        Dim connection As OleDbConnection = connectDatabase()
        connection.Open()

        ' Create the command and attach the parameters
        Dim command As New OleDbCommand(query, connection)
        command.Parameters.AddRange(parameters.ToArray())

        ' Execute the query and load the results into a DataTable
        Dim adapter As New OleDbDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        ' Display the results in the DataGridView on the BrideDetails form
        BrideDetails.dgvBrideDetails.DataSource = table
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide() ' Hide the CustomerSearch form
        BrideDetails.Show() ' Reopen the BrideDetails form
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearCustomerSearch() ' Reset all fields to default/empty
    End Sub

    Private Sub btnCustomerSearch_Click(sender As Object, e As EventArgs) Handles btnCustomerSearch.Click
        customerFinder() ' Build and run the search query
        Me.Hide() ' Hide the search form after searching
        BrideDetails.Show() ' Show the BrideDetails form with the results
    End Sub
End Class