Imports System.Data.OleDb

Public Class Payment_History
    ' Declare a shared DataTable to store payment records
    Private dataTable As New DataTable()
    ' Declare a DataAdapter to fetch and update data
    Private adapter As OleDbDataAdapter
    ' Declare a CommandBuilder to automatically generate SQL commands 
    Private builder As OleDbCommandBuilder

    ' Used to track if a payment is being added
    Public addPayment As Integer
    ' Used to track how many times the Edit button has been clicked
    Dim counter As Integer
    ' Used to check if changes have been saved
    Dim clickCheck As Integer

    ' Refresh the Payment DataGridView by clearing and refilling the data
    Sub paymentRefresh()
        dataTable.Clear()
        adapter.Fill(dataTable)
        dgvPayment.DataSource = dataTable
    End Sub

    ' Load payment data from the database into the DataGridView
    Sub LoadPaymentData()
        Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\irfan\OneDrive - The Sixth Form Bolton\A level Computer Science\VB PROJECT\Bridal Database\Bridal Database\Bridal System Database1.accdb")
        Dim tableName As String = "tblPayment"

        connection.Open()

        ' Query to select all records from the payment table
        Dim query As String
        query = $"SELECT * FROM [{tableName}]"

        adapter = New OleDbDataAdapter(query, connection)
        builder = New OleDbCommandBuilder(adapter)

        dataTable.Clear()
        adapter.Fill(dataTable)
        dgvPayment.DataSource = dataTable

        connection.Close()
    End Sub

    ' Toggle between edit and view mode
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        ' Increment the counter to toggle the edit mode
        counter = counter + 1

        ' Check if the counter is even or odd
        If counter Mod 2 = 0 Then
            ' If counter is even, we are in view mode, so alert the user if changes are unsaved
            If clickCheck = 0 Then
                MsgBox("Changes not saved")
            End If
            ' Disable row deletion in the DataGridView, disable editing, and hide the Save button
            dgvPayment.AllowUserToDeleteRows = False
            btnEdit.BackColor = SystemColors.ControlLight
            dgvPayment.ReadOnly = True
            btnSave.Visible = False
            ' Refresh the DataGridView to reflect the non-editable state
            dataTable.Clear()
            adapter.Fill(dataTable)
        Else
            ' If counter is odd, we are in edit mode, so enable editing
            clickCheck = 0
            dgvPayment.AllowUserToDeleteRows = True
            btnEdit.BackColor = SystemColors.ControlDark
            dgvPayment.ReadOnly = False
            btnSave.Visible = True
        End If
    End Sub

    ' Event handler for the Save button click event
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Set clickCheck to 1, indicating changes are being saved
        clickCheck = 1
        ' Update the data table with any changes made in the DataGridView
        adapter.Update(dataTable)
        ' Inform the user that changes have been saved successfully
        MsgBox("Changes saved successfully.")
    End Sub

    ' Event handler for the Add button click event
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Hide some labels and buttons, showing the necessary ones for adding a new payment
        Payment.lblCustomer.Visible = False
        Payment.lblOrder.Visible = False
        Payment.btnBack.Visible = False
        Payment.lblCustomerID.Visible = True
        Payment.lblPaymentID.Visible = True
        Payment.txtCID.Visible = True
        Payment.txtPID.Visible = True

        ' Set addPayment flag to 1 to indicate an add operation
        addPayment = 1
        ' Hide current form and show the Payment form
        Me.Hide()
        Payment.Show()
    End Sub

    ' Event handler for the Refresh button click event
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        ' Refresh the payment data in the DataGridView
        paymentRefresh()
    End Sub

    ' Event handler for the Payment Search button click event
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Hide current form and show the Payment Search form
        Me.Hide()
        paymentSearch.Show()
    End Sub

    ' Event handler for the Home button click event
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        ' Hide current form and show the Main Menu form
        Me.Hide()
        Main_Menu.Show()
    End Sub

    ' Event handler for the Bride Details button click event
    Private Sub btnBrideDetails_Click(sender As Object, e As EventArgs) Handles btnBrideDetails.Click
        ' Hide current form and show the Bride Details form
        Me.Hide()
        BrideDetails.Show()
    End Sub

    ' Event handler for the Past Orders button click event
    Private Sub btnPastOrders_Click(sender As Object, e As EventArgs) Handles btnPastOrders.Click
        ' Hide current form and show the Past Orders form
        Me.Hide()
        PastOrders.Show()
    End Sub

    ' Event handler for the Suppliers button click event
    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        ' Hide current form and show the Suppliers form
        Me.Hide()
        Suppliers.Show()
    End Sub
End Class