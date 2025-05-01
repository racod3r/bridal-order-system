Imports System.Data.OleDb

Public Class PastOrders
    ' Declare a DataTable to hold the orders data temporarily
    Private dataTable As New DataTable()
    ' Declare an adapter to fetch data from the database
    Private adapter As OleDbDataAdapter
    ' Declare a builder to automatically generate SQL commands for updating
    Private builder As OleDbCommandBuilder

    ' Variable to check if a new order is being added
    Public addOrder As Integer
    ' Counter to track the number of times Edit is clicked
    Dim counter As Integer
    ' Variable to check if changes were saved 
    Dim clickCheck As Integer

    ' Refresh the order data by clearing and refilling the table
    Sub orderRefresh()
        dataTable.Clear() ' Clear existing data
        adapter.Fill(dataTable) ' Refill with updated database data
        dgvOrders.DataSource = dataTable ' Rebind to DataGridView
    End Sub

    ' Load the order data when the form opens
    Sub LoadOrderData()
        ' Set up the database connection string
        Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\Bridal System Database1.accdb")
        ' Table name to pull data from
        Dim tableName As String = "tblOrder"
        connection.Open() ' Open database connection

        ' SQL query to select all records from the table
        Dim query As String
        query = $"SELECT * FROM [{tableName}]"

        ' Set up adapter and builder
        adapter = New OleDbDataAdapter(query, connection)
        builder = New OleDbCommandBuilder(adapter) ' Allow automatic generation of UPDATE, INSERT, DELETE commands

        ' Load data into DataTable
        dataTable.Clear()
        adapter.Fill(dataTable)

        ' Bind the data to the DataGridView
        dgvOrders.DataSource = dataTable

        connection.Close() ' Close database connection
    End Sub

    ' Handle Edit button click to toggle edit mode
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        counter = counter + 1 ' Increase click counter each time button is pressed

        ' If counter is even (clicked twice), switch back to view mode
        If counter Mod 2 = 0 Then
            If clickCheck = 0 Then
                ' If no save has been done, warn the user
                MsgBox("Changes not saved")
            End If

            ' Disable delete and editing
            dgvOrders.AllowUserToDeleteRows = False
            btnEdit.BackColor = SystemColors.ControlLight ' Change button color to lighter shade
            dgvOrders.ReadOnly = True ' Make DataGridView read-only
            btnSave.Visible = False ' Hide Save button

            ' Reload fresh data from database (cancel any changes)
            dataTable.Clear()
            adapter.Fill(dataTable)
        Else
            ' If counter is odd (first click), enable editing mode
            clickCheck = 0 ' Reset save status
            dgvOrders.AllowUserToDeleteRows = True ' Allow deleting rows
            btnEdit.BackColor = SystemColors.ControlDark ' Change button color to darker shade
            dgvOrders.ReadOnly = False ' Allow editing in DataGridView
            btnSave.Visible = True ' Show Save button
        End If
    End Sub

    ' Save any changes made in edit mode to the database
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        clickCheck = 1 ' Mark that changes have been saved
        adapter.Update(dataTable) ' Push changes from DataTable back to database
        MsgBox("Changes saved successfully.") ' Notify user
    End Sub

    'Prepare the OrderPage to add a new order
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Hide fields not needed for adding an order
        OrderPage.lblCustomer.Visible = False
        OrderPage.lblPayment.Visible = False
        OrderPage.btnBack.Visible = False

        ' Show the ID fields needed for adding
        OrderPage.lblID.Visible = True
        OrderPage.txtID.Visible = True

        addOrder = 1 ' Set flag to indicate a new order is being added
        Main_Menu.newSaleCheck = 0 ' Reset new sale check in Main Menu

        Me.Hide() ' Hide current form
        OrderPage.Show() ' Show the OrderPage form
    End Sub

    ' Reload the latest data
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        orderRefresh() ' Call refresh method
    End Sub

    ' Open the order search form
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide() ' Hide current form
        orderSearch.Show() ' Show orderSearch form
    End Sub

    ' Return to main menu
    Private Sub btnHome_Click_1(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide() ' Hide current form
        Main_Menu.Show() ' Show main menu form
    End Sub

    ' Open bride details
    Private Sub btnBrideDetails_Click_1(sender As Object, e As EventArgs) Handles btnBrideDetails.Click
        Me.Hide() ' Hide current form
        BrideDetails.Show() ' Show bride details form
    End Sub

    ' Open payment history
    Private Sub btnPayment_Click_1(sender As Object, e As EventArgs) Handles btnPayment.Click
        Me.Hide() ' Hide current form
        Payment_History.Show() ' Show payment history form
    End Sub

    ' Open suppliers form
    Private Sub btnSupplier_Click_1(sender As Object, e As EventArgs) Handles btnSupplier.Click
        Me.Hide() ' Hide current form
        Suppliers.Show() ' Show suppliers form
    End Sub


End Class