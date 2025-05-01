Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Warning
    'Clears all fields on the new sale (customer) form
    Sub clearNewCustomerFields()
        NewSaleCustomer.txtFirstName.Clear() 'Clears first name
        NewSaleCustomer.txtSurname.Clear() 'Clears surname
        NewSaleCustomer.txtAddress.Clear() 'Clears address
        NewSaleCustomer.txtPostcode.Clear() 'Clears postcode
        NewSaleCustomer.txtCity.Clear() 'Clears city
        NewSaleCustomer.dtpDate.Value = DateTime.Now.Date 'Resets date
        NewSaleCustomer.txtBust.Clear() 'Clears bust
        NewSaleCustomer.txtWaist.Clear() 'Clears waist
        NewSaleCustomer.txtHips.Clear() 'Clears hips
        NewSaleCustomer.txtTel1.Clear() 'Clears tel 1
        NewSaleCustomer.txtTel2.Clear() 'Clears tel 2
        NewSaleCustomer.txtMail.Clear() 'Clears mail
    End Sub

    'Clears all fields on the new sale (order) form
    Sub clearNewOrderFields()
        OrderPage.cmbItemType.SelectedIndex = -1 'Clears item type
        OrderPage.cmbDesigner.SelectedIndex = -1 'Clears designer
        OrderPage.cmbItemName.SelectedIndex = -1 'Clears item name
        OrderPage.txtColour.Clear() 'Clears colour
        OrderPage.txtPrice.Clear() 'Clears price
        OrderPage.cmbSize.SelectedIndex = -1 'Clears size
        OrderPage.txtQuantity.Clear() 'Clears quantity
        OrderPage.txtDiscount.Clear() 'Clears discount
        OrderPage.radHire.Checked = False 'Clears status hire 
        OrderPage.radNot.Checked = False 'Clears status not hire 
        OrderPage.radStock.Checked = False 'Clears status stock
        OrderPage.chkItem1.Text = "" 'Clears item 1 in the list
        OrderPage.chkItem1.Checked = False 'Unchecks item 1 in the list
        OrderPage.chkItem1.Visible = False 'Makes item 1 in the list invisible
        OrderPage.chkItem2.Text = "" 'Clears item 2 in the list
        OrderPage.chkItem2.Checked = False 'Unchecks item 2 in the list
        OrderPage.chkItem2.Visible = False 'Makes item 2 in the list invisible
        OrderPage.chkItem3.Text = "" 'Clears item 3 in the list
        OrderPage.chkItem3.Checked = False 'Unchecks item 3 in the list
        OrderPage.chkItem3.Visible = False 'Makes item 3 in the list invisible
        OrderPage.chkItem4.Text = "" 'Clears item 4 in the list
        OrderPage.chkItem4.Checked = False 'Unchecks item 4 in the list
        OrderPage.chkItem4.Visible = False 'Makes item 4 in the list invisible
        OrderPage.chkItem5.Text = "" 'Clears item 5 in the list
        OrderPage.chkItem5.Checked = False 'Unchecks item 5 in the list
        OrderPage.chkItem5.Visible = False 'Makes item 5 in the list invisible
        OrderPage.chkItem6.Text = "" 'Clears item 6 in the list
        OrderPage.chkItem6.Checked = False 'Unchecks item 6 in the list
        OrderPage.chkItem6.Visible = False 'Makes item 6 in the list invisible
        OrderPage.lblTotalCost.Text = "" 'Clears total cost
    End Sub

    'Clears all fields on the new sale (payment) form
    Sub clearNewPaymentFields()
        Payment.cmbPaymentMethod.SelectedIndex = -1 'Clears payment method
        Payment.txtAuthorisation.Clear() 'Clears authorisation code
        Payment.txtOrderTotal.Clear() 'Clears order total 
        Payment.txtPaid.Clear() 'Clears paid amount 
        Payment.txtRemaining.Clear() 'Clears remaining balance field
        Payment.lblItem1.Text = "" 'Clears item 1 label
        Payment.lblItem2.Text = "" 'Clears item 2 label
        Payment.lblItem3.Text = "" 'Clears item 3 label
        Payment.lblItem4.Text = "" 'Clears item 4 label
        Payment.lblItem5.Text = "" 'Clears item 5 label
        Payment.lblItem6.Text = "" 'Clears item 6 label
        Payment.lblTotal.Text = "" 'Clears total label
        Payment.dtpDate.Value = DateTime.Now.Date 'Resets payment date
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Checks if the user was on the remove user form or on either of the sale forms
        If LoginPage.RemoveCheck = 1 Then
            'Shows remove user form
            Me.Hide()
            RemoveUser.Show()
        ElseIf Main_Menu.newSaleCheck = 1 Then
            'Shows new sale (customer) form
            Me.Hide()
            NewSaleCustomer.Show()
        ElseIf NewSaleCustomer.orderPageCheck = 1 Then
            'Shows new sale (order) form
            Me.Hide()
            OrderPage.Show()
        ElseIf OrderPage.paymentPageCheck = 1 Then
            'Shows new sale (payment) form
            Me.Hide()
            Payment.Show()
        End If

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        ' Check if the user is trying to remove an existing user
        If LoginPage.RemoveCheck = 1 Then

            ' Create a connection to the database
            Dim connection As OleDbConnection = connectDatabase()

            ' Open the database connection
            connection.Open()

            ' SQL query to delete the user from the tblLogin table based on the existing username
            Dim deleteQuery As String = "DELETE FROM tblLogin WHERE Username = ?"
            ' Create a command to execute the delete query
            Dim newcommand As New OleDbCommand(deleteQuery, connection)

            ' Add the existing username as a parameter to the delete query
            newcommand.Parameters.AddWithValue("?", RemoveUser.ExistingUsername)

            ' Execute the delete query
            newcommand.ExecuteNonQuery()

            ' Clear the username text box on the RemoveUser form
            RemoveUser.txtUsernameRemove.Text = ""

            ' Show a message box confirming the user has been successfully removed
            MsgBox("User successfully removed")

            ' Hide the current form and show the LoginPage
            Me.Hide()
            LoginPage.Show()

            ' Check if the user is in the process of creating a new sale
        ElseIf Main_Menu.newSaleCheck = 1 Or NewSaleCustomer.orderPageCheck Or OrderPage.paymentPageCheck Then
            ' Clear all the fields on the new customer, order, and payment forms
            clearNewCustomerFields()
            clearNewOrderFields()
            clearNewPaymentFields()

            ' Shows the main menu form
            Me.Hide()
            Main_Menu.Show()
        End If

    End Sub

End Class