Imports System.Data.OleDb
Imports System.Diagnostics.Eventing

Public Class Main_Menu
    ' Global variable to track if a new sale is being made
    Public newSaleCheck = 0


    ' Clears the order search fields
    Sub ordersFieldClear()
        cmbStatus.SelectedIndex = -1
        cmbItemName.SelectedIndex = -1
        cmbItemType.SelectedIndex = -1
        cmbDesigner.SelectedIndex = -1
        txtMinCost.Clear()
        txtMaxCost.Clear()
        txtOID.Clear()
    End Sub

    ' Clears the customer search fields
    Sub bridesFieldClear()
        txtPhone.Clear()
        txtFirstName.Clear()
        txtSurname.Clear()
        txtPostcode.Clear()
        txtCID.Clear()
    End Sub


    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Returns the user to the login page
        ordersFieldClear()
        bridesFieldClear()
        Me.Hide()
        LoginPage.Show()
    End Sub

    Private Sub btnNewSale_Click(sender As Object, e As EventArgs) Handles btnNewSale.Click
        ' Sets the newSaleCheck flag and resets other related flags
        newSaleCheck = 1
        BrideDetails.addBride = 0
        PastOrders.addOrder = 0
        Payment_History.addPayment = 0
        LoginPage.AddCheck = 0
        LoginPage.EditCheck = 0
        LoginPage.RemoveCheck = 0


        ' Ensures/restores visibility of UI elements on all sale forms as they may be made invisible on other forms

        NewSaleCustomer.lblOrder.Visible = True  'Makes the Order header visible on new sale customer form
        NewSaleCustomer.lblPayment.Visible = True 'Makes the Payment header visible on new sale customer form
        OrderPage.lblCustomer.Visible = True  'Makes the Customer header visible on new sale order form
        OrderPage.lblPayment.Visible = True 'Makes the Payment header visible on new sale order form
        OrderPage.btnBack.Visible = True 'Makes the back button visible on new sale order form
        OrderPage.lblID.Visible = False 'Makes the Customer ID label visible on new sale order form
        OrderPage.txtID.Visible = False 'Makes the Customer ID text box visible on new sale order form
        Payment.lblCustomer.Visible = True 'Makes the Customer header visible on new sale payment form
        Payment.lblOrder.Visible = True 'Makes the Order header visible on new sale payment form
        Payment.btnBack.Visible = True 'Makes the back button visible on new sale payment form
        Payment.lblCustomerID.Visible = False 'Makes the Customer ID label visible on new sale payment form
        Payment.txtCID.Visible = False 'Makes the Customer ID text box visible on new sale payment form
        Payment.lblPaymentID.Visible = False 'Makes the Payment ID label visible on new sale payment form
        Payment.txtPID.Visible = False 'Makes the Payment ID text box visible on new sale payment form
        ' Opens the new sale (customer) form
        Me.Hide()
        NewSaleCustomer.Show()
    End Sub


    ' Handles order search based on selected filters
    Private Sub btnOrderSearch_Click(sender As Object, e As EventArgs) Handles btnOrderSearch.Click
        ' Initialize the base SQL query to select all records from the tblOrder table
        Dim query As String = "SELECT * FROM tblOrder WHERE 1=1"
        ' Create a list to store query parameters
        Dim parameters As New List(Of OleDbParameter)

        ' Check each field and add to query if filled

        'Filtering by customerID
        'Checks that the text box isnt empty first
        If Not String.IsNullOrEmpty(txtOID.Text) Then
            'Adds the new parameter and uses LIKE to allow for partial matches
            query &= " AND CustomerID LIKE ?"
            parameters.Add(New OleDbParameter("?", "%" & txtOID.Text & "%"))
        End If

        ' Filtering by item type
        'Checks that the combo box isnt empty first
        If cmbItemType.SelectedIndex <> -1 Then
            'Adds the new parameter and uses LIKE to allow for partial matches
            query &= " AND ItemType = ?"
            parameters.Add(New OleDbParameter("?", cmbItemType.SelectedItem.ToString()))
        End If

        ' Filtering by designer
        'Checks that the combo box isnt empty first
        If cmbDesigner.SelectedIndex <> -1 Then
            'Adds the new parameter and uses LIKE to allow for partial matches
            query &= " AND Designer = ?"
            parameters.Add(New OleDbParameter("?", cmbDesigner.SelectedItem.ToString()))
        End If

        ' Filtering by item name
        'Checks that the combo box isnt empty first
        If cmbItemName.SelectedIndex <> -1 Then
            'Adds the new parameter and uses LIKE to allow for partial matches
            query &= " AND ItemName = ?"
            parameters.Add(New OleDbParameter("?", cmbItemName.SelectedItem.ToString()))
        End If

        ' Filtering by stock status
        'Checks that the combo box isnt empty first
        If cmbStatus.SelectedIndex <> -1 Then
            'Adds the new parameter and uses LIKE to allow for partial matches
            query &= " AND StockStatus = ?"
            parameters.Add(New OleDbParameter("?", cmbStatus.SelectedItem.ToString()))
        End If

        ' Filtering by cost
        If Not String.IsNullOrEmpty(txtMinCost.Text) AndAlso Not String.IsNullOrEmpty(txtMaxCost.Text) Then
            'Adds the new parameters and uses BETWEEN to ensure total cost is between the minimunm and maximum value
            query &= " AND TotalCost BETWEEN ? AND ?"
            parameters.Add(New OleDbParameter("?", Convert.ToDecimal(txtMinCost.Text)))
            parameters.Add(New OleDbParameter("?", Convert.ToDecimal(txtMaxCost.Text)))
        ElseIf Not String.IsNullOrEmpty(txtMinCost.Text) Then
            'Adds the new parameters and uses >= to ensure total cost is greater than the minimunm value
            query &= " AND TotalCost >= ?"
            parameters.Add(New OleDbParameter("?", Convert.ToDecimal(txtMinCost.Text)))
        ElseIf Not String.IsNullOrEmpty(txtMaxCost.Text) Then
            'Adds the new parameters and uses <= to ensure total cost is less than the maximum value
            query &= " AND TotalCost <= ?"
            parameters.Add(New OleDbParameter("?", Convert.ToDecimal(txtMaxCost.Text)))
        End If

        ' Connects to the database 
        Dim connection As OleDbConnection = connectDatabase()
        ' Opens the database connection
        connection.Open()
        ' Executes the search query using the provided parameters
        Dim command As New OleDbCommand(query, connection)
        ' Adds the parameters to the command
        command.Parameters.AddRange(parameters.ToArray())

        ' Executes the query and retrieves results
        Dim adapter As New OleDbDataAdapter(command)
        ' Creates a new DataTable to store the retrieved data
        Dim table As New DataTable()
        ' Fills the DataTable with query results
        adapter.Fill(table)
        ' Displays the results in the DataGridView on the PastOrders form
        PastOrders.dgvOrders.DataSource = table

        ' Matches the Order Search form fields with the quick search fields
        orderSearch.txtID.Text = txtOID.Text ' Copies over Customer ID
        orderSearch.cmbItemName.Text = cmbItemType.Text ' Copies over Item Name
        orderSearch.cmbDesigner.Text = cmbDesigner.Text ' Copies over Designer name
        orderSearch.cmbItemType.Text = cmbItemType.Text ' Copies over Item Type
        orderSearch.txtMinTotal.Text = txtMinCost.Text ' Copies over Minimum Total Cost
        orderSearch.txtMaxTotal.Text = txtMaxCost.Text ' Copies over Maximum Total Cost

        ' Matches the radio buttons on the Order Search form by checking the status selected
        If cmbStatus.Text = "Hire" Then
            ' Selects "Hire" option
            orderSearch.radHire.Checked = True
        ElseIf cmbStatus.Text = "Stock" Then
            ' Selects "Stock" option
            orderSearch.radStock.Checked = True
        ElseIf cmbStatus.Text = "Not Stock" Then
            ' Selects "Not Stock" option
            orderSearch.radNot.Checked = True
        End If

        ' Closes the database connection after the operation is complete
        connection.Close()

        ' Takes the user to the past orders page
        Me.Hide()
        PastOrders.Show()

    End Sub

    ' Handles customer search based on selected filters
    Private Sub btnCustomerSearch_Click(sender As Object, e As EventArgs) Handles btnCustomerSearch.Click
        'Boolean flags used to check for phone number matches
        Dim foundInTel1 As Boolean = False
        Dim foundInTel2 As Boolean = False

        ' Initialize the base SQL query to select all records from the tblDetails table
        Dim query As String = "SELECT * FROM tblDetails WHERE 1=1"
        ' Create a list to store query parameters
        Dim parameters As New List(Of OleDbParameter)

        'Filtering by customerID
        'Checks that the text box isnt empty first
        If Not String.IsNullOrEmpty(txtCID.Text) Then
            query &= " AND CustomerID LIKE ?"
            parameters.Add(New OleDbParameter("?", "%" & txtCID.Text & "%"))
        End If

        'Filtering by first name
        'Checks that the text box isnt empty first
        If Not String.IsNullOrEmpty(txtFirstName.Text) Then
            query &= " AND FirstName LIKE ?"
            parameters.Add(New OleDbParameter("?", "%" & txtFirstName.Text & "%"))
        End If

        'Filtering by surname
        'Checks that the text box isnt empty first
        If Not String.IsNullOrEmpty(txtSurname.Text) Then
            query &= " AND Surname LIKE ?"
            parameters.Add(New OleDbParameter("?", "%" & txtSurname.Text & "%"))
        End If

        'Filtering by postcode
        'Checks that the text box isnt empty first
        If Not String.IsNullOrEmpty(txtPostcode.Text) Then
            query &= " AND Postcode LIKE ?"
            parameters.Add(New OleDbParameter("?", "%" & txtPostcode.Text & "%"))
        End If

        ' Connects to the database 
        Dim connection As OleDbConnection = connectDatabase()
        connection.Open()

        'Filtering by telephone
        If Not String.IsNullOrEmpty(txtPhone.Text) Then
            ' Checks if phone number exists in the database
            query &= " AND (Tel1 LIKE ? OR Tel2 LIKE ?)"
            parameters.Add(New OleDbParameter("?", "%" & txtPhone.Text & "%"))
            parameters.Add(New OleDbParameter("?", "%" & txtPhone.Text & "%"))

            Dim phoneParameters As New List(Of OleDbParameter) From {
            New OleDbParameter("?", "%" & txtPhone.Text & "%"),
            New OleDbParameter("?", "%" & txtPhone.Text & "%")
            }

            ' Query to check if the phone number exists in Tel1 or Tel2 of the tblDetails table
            Dim checkQuery As String = "SELECT Tel1, Tel2 FROM tblDetails WHERE Tel1 LIKE ? OR Tel2 LIKE ?"
            Dim checkCommand As New OleDbCommand(checkQuery, connection)

            ' Add the phone parameters to the command
            checkCommand.Parameters.AddRange(phoneParameters.ToArray())


            ' Execute the query and read results
            Dim reader As OleDbDataReader = checkCommand.ExecuteReader()

            ' Loop through the results to check if the phone number exists in Tel1 or Tel2
            While reader.Read()

                If reader("Tel1").Contains(txtPhone.Text) Then
                    foundInTel1 = True
                End If

                If reader("Tel2").Contains(txtPhone.Text) Then
                    foundInTel2 = True
                End If
            End While


            ' Close the reader after use
            reader.Close()
        End If


        ' Create a new SQL command with the built query and parameters
        Dim command As New OleDbCommand(query, connection)
        command.Parameters.AddRange(parameters.ToArray())

        ' Execute the query and store the results in a DataTable
        Dim adapter As New OleDbDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        ' Display the retrieved customer details in the DataGridView
        BrideDetails.dgvBrideDetails.DataSource = table


        ' Populate the search fields on the main customer search form based on the filled in fields
        If foundInTel1 Then
            CustomerSearch.txtTel1.Text = txtPhone.Text
        ElseIf foundInTel2 Then
            CustomerSearch.txtTel2.Text = txtPhone.Text
        End If
        CustomerSearch.txtFirstName.Text = txtFirstName.Text
        CustomerSearch.txtSurname.Text = txtSurname.Text
        CustomerSearch.txtPostcode.Text = txtPostcode.Text
        CustomerSearch.txtID.Text = txtCID.Text

        ' Close the database connection after the query is executed
        connection.Close()

        ' Hide the current form and show the BrideDetails form
        Me.Hide()
        BrideDetails.Show()
    End Sub

    Private Sub Main_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load all of the dataGridViews 
        BrideDetails.LoadBrideData()
        PastOrders.LoadOrderData()
        Payment_History.LoadPaymentData()
        Suppliers.LoadSupplierData()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnClearC.Click
        'Clear all fields on the Customer Quick Search
        bridesFieldClear()
    End Sub

    Private Sub btnClearO_Click_1(sender As Object, e As EventArgs) Handles btnClearO.Click
        'Clear all fields on the Order Quick Search
        ordersFieldClear()
    End Sub


    ' Opens the Bride Details page
    Private Sub btnBrideDetails_Click_1(sender As Object, e As EventArgs) Handles btnBrideDetails.Click
        Me.Hide()
        BrideDetails.Show()
    End Sub

    ' Opens the Past Orders page
    Private Sub btnPastOrders_Click_1(sender As Object, e As EventArgs) Handles btnPastOrders.Click
        Me.Hide()
        PastOrders.Show()
    End Sub

    ' Opens the Payment History page
    Private Sub btnPayment_Click_1(sender As Object, e As EventArgs) Handles btnPayment.Click
        Me.Hide()
        Payment_History.Show()
    End Sub

    ' Opens the Supplier page
    Private Sub btnSupplier_Click_1(sender As Object, e As EventArgs) Handles btnSupplier.Click
        Me.Hide()
        Suppliers.Show()
    End Sub
End Class