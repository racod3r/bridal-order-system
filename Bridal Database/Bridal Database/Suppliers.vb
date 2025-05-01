Imports System.ComponentModel.Design
Imports System.Data.OleDb

Public Class Suppliers
    ' Declare the DataTable to hold data from the database
    Private dataTable As New DataTable()
    ' Declare the OleDbDataAdapter to facilitate database interactions
    Private adapter As OleDbDataAdapter
    ' Declare the OleDbCommandBuilder to automatically generate commands for database updates
    Private builder As OleDbCommandBuilder

    ' Counter to track the number of times the Edit button has been clicked
    Dim counter As Integer
    ' Flag to track whether changes have been saved
    Dim clickCheck As Integer

    ' Method to refresh the supplier data and reload it into the DataGridView
    Sub supplierrefresh()
        ' Clear any existing data in the DataTable
        dataTable.Clear()
        ' Fill the DataTable with new data from the database using the adapter
        adapter.Fill(dataTable)
        ' Set the DataGridView's DataSource to the refreshed DataTable
        dgvSupplier.DataSource = dataTable
    End Sub

    ' Method to load supplier data from the database and populate the DataGridView
    Sub LoadSupplierData()
        ' Establish a new OleDbConnection to the Access database
        Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\Bridal System Database1.accdb")
        ' Define the table name to query
        Dim tableName As String = "tblSupplier"
        ' Open the database connection
        connection.Open()

        ' Build the SQL query to select all records from the supplier table
        Dim query As String
        query = $"SELECT * FROM [{tableName}]"

        ' Initialize the OleDbDataAdapter and OleDbCommandBuilder with the query
        adapter = New OleDbDataAdapter(query, connection)
        builder = New OleDbCommandBuilder(adapter)

        ' Clear any existing data in the DataTable
        dataTable.Clear()
        ' Fill the DataTable with data from the database
        adapter.Fill(dataTable)
        ' Set the DataGridView's DataSource to the newly loaded data
        dgvSupplier.DataSource = dataTable

        ' Close the database connection
        connection.Close()
    End Sub

    ' Event handler for the Edit button click event
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        ' Increment the counter to track the number of clicks on the Edit button
        counter = counter + 1

        ' If the counter is even (i.e., the user clicked "Edit" twice), switch to read-only mode
        If counter Mod 2 = 0 Then
            ' If changes haven't been saved, show a message to the user
            If clickCheck = 0 Then
                MsgBox("Changes not saved")
            End If

            ' Disable the ability to delete rows from the DataGridView
            dgvSupplier.AllowUserToDeleteRows = False
            ' Change the background color of the Edit button to indicate it is in "view-only" mode
            btnEdit.BackColor = SystemColors.ControlLight
            ' Set the DataGridView to read-only mode
            dgvSupplier.ReadOnly = True
            ' Hide the Save button, as no changes are allowed
            btnSave.Visible = False

            ' Refresh the DataGridView to reflect the most recent data
            dataTable.Clear()
            adapter.Fill(dataTable)
        Else
            ' Reset the clickCheck flag to 0 (indicating no changes have been saved)
            clickCheck = 0

            ' Allow row deletions in the DataGridView again
            dgvSupplier.AllowUserToDeleteRows = True
            ' Change the background color of the Edit button to indicate editing mode
            btnEdit.BackColor = SystemColors.ControlDark
            ' Set the DataGridView to be editable
            dgvSupplier.ReadOnly = False
            ' Make the Save button visible to allow the user to save changes
            btnSave.Visible = True
        End If
    End Sub

    ' Event handler for the Save button click event
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Set clickCheck to 1 to indicate that changes have been saved
        clickCheck = 1

        ' Update the database with the changes made in the DataGridView
        adapter.Update(dataTable)

        ' Notify the user that the changes have been saved successfully
        MsgBox("Changes saved successfully.")
    End Sub

    ' Event handler for the Refresh button click event
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        ' Call the supplierrefresh method to reload data
        supplierrefresh()
    End Sub

    ' Event handler for the Add button click event
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Hide the current form and show the AddSupplier form for adding new supplier data
        Me.Hide()
        AddSupplier.Show()
    End Sub

    ' Event handler for the Home button click event
    Private Sub btnHome_Click_1(sender As Object, e As EventArgs) Handles btnHome.Click
        ' Hide the current form and show the Main_Menu form
        Me.Hide()
        Main_Menu.Show()
    End Sub

    ' Event handler for the Bride Details button click event
    Private Sub btnBrideDetails_Click_1(sender As Object, e As EventArgs) Handles btnBrideDetails.Click
        ' Hide the current form and show the BrideDetails form
        Me.Hide()
        BrideDetails.Show()
    End Sub

    ' Event handler for the Past Orders button click event
    Private Sub btnPastOrders_Click_1(sender As Object, e As EventArgs) Handles btnPastOrders.Click
        ' Hide the current form and show the PastOrders form
        Me.Hide()
        PastOrders.Show()
    End Sub

    ' Event handler for the Payment button click event
    Private Sub btnPayment_Click_1(sender As Object, e As EventArgs) Handles btnPayment.Click
        ' Hide the current form and show the Payment_History form
        Me.Hide()
        Payment_History.Show()
    End Sub


End Class