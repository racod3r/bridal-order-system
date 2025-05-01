Imports System.Data.OleDb

Public Class BrideDetails
    Private dataTable As New DataTable() ' Stores the data from the database
    Private adapter As OleDbDataAdapter ' Used to fetch and update data
    Private builder As OleDbCommandBuilder ' Automatically generates SQL commands for updates


    Public addBride As Integer ' Flag to indicate when adding a new bride
    Dim counter As Integer ' Used to track edit mode toggling
    Dim clickCheck As Integer ' Used to check if changes were saved

    ' Refreshes the DataGridView with the latest data from the database
    Sub bridesrefresh()
        dataTable.Clear()
        adapter.Fill(dataTable)
        dgvBrideDetails.DataSource = dataTable
    End Sub

    ' Loads the bride data from the database 
    Sub LoadBrideData()
        ' Set up database connection
        Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\irfan\OneDrive - The Sixth Form Bolton\A level Computer Science\VB PROJECT\Bridal Database\Bridal Database\Bridal System Database1.accdb")
        Dim tableName As String = "tblDetails"

        connection.Open()

        ' Query to select all records from the table
        Dim query As String
        query = $"SELECT * FROM [{tableName}]"

        ' Set up adapter and builder for automatic command generation
        adapter = New OleDbDataAdapter(query, connection)
        builder = New OleDbCommandBuilder(adapter)

        ' Fill the DataTable and bind it to the DataGridView
        dataTable.Clear()
        adapter.Fill(dataTable)
        dgvBrideDetails.DataSource = dataTable

        connection.Close()

    End Sub


    ' Handles the Edit button click
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        counter = counter + 1

        ' Increment the counter each time the button is clicked

        If counter Mod 2 = 0 Then ' If even number (Exit edit mode)
            If clickCheck = 0 Then
                MsgBox("Changes not saved") ' Warn if changes were not saved
            End If
            ' Disable editing
            dgvBrideDetails.AllowUserToDeleteRows = False
            btnEdit.BackColor = SystemColors.ControlLight
            dgvBrideDetails.ReadOnly = True
            btnSave.Visible = False

            ' Refresh the data to discard unsaved changes
            dataTable.Clear()
            adapter.Fill(dataTable)
        Else ' If odd number (Enter edit mode)
            clickCheck = 0 ' Reset save check
            dgvBrideDetails.AllowUserToDeleteRows = True
            btnEdit.BackColor = SystemColors.ControlDark
            dgvBrideDetails.ReadOnly = False
            btnSave.Visible = True ' Show Save button
        End If
    End Sub

    ' Handles the Save button click
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Save changes made in the DataGridView back to the database
        clickCheck = 1
        adapter.Update(dataTable)
        MsgBox("Changes saved successfully.")
    End Sub

    ' Handles the Add button click
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Hide unnecessary labels in the NewSaleCustomer form
        NewSaleCustomer.lblOrder.Visible = False
        NewSaleCustomer.lblPayment.Visible = False

        addBride = 1 ' Set flag indicating that a bride is being added
        Main_Menu.newSaleCheck = 0

        ' Navigate to the NewSaleCustomer form
        Me.Hide()
        NewSaleCustomer.Show()
    End Sub

    ' Handles the Refresh button click
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnRefresh.Click
        ' Refresh the bride details
        bridesrefresh()
    End Sub

    ' Handles a button click to navigate to the Customer Search page
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Me.Hide()
        CustomerSearch.Show()
    End Sub

    ' Handles the Home button click
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        ' Return to the main menu
        Me.Hide()
        Main_Menu.Show()
    End Sub

    ' Handles Past Orders button click
    Private Sub btnPastOrders_Click(sender As Object, e As EventArgs) Handles btnPastOrders.Click
        Me.Hide()
        PastOrders.Show()
    End Sub

    ' Handles Payment History button click
    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        Me.Hide()
        Payment_History.Show()
    End Sub

    ' Handles Suppliers button click
    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        Me.Hide()
        Suppliers.Show()
    End Sub
End Class