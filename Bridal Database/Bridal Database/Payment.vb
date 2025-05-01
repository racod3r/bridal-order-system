Imports System.ComponentModel.Design
Imports System.Data.OleDb
Imports System.Security.Policy

Public Class Payment
    ' Declaring variables for balance and customer ID
    Public OrderTotal As Decimal
    Public balance As Decimal
    Public customerID As Integer
    Public paymentID As Integer


    'Boolean flags for authorization checks
    Dim codeCheck As Boolean = True
    Dim codeCharCheck As Boolean = True
    Dim needsAuth As Boolean = False
    Dim Customerfound As Boolean = False
    Dim Paymentfound As Boolean = False
    Public retrieved As Boolean = False
    'Retrieve balance based on selected customer and previous payment
    Sub retrieveBalance()

        ' Establish a connection to the database
        Dim connection As OleDbConnection = connectDatabase()
            connection.Open()

        ' Query to retrieve the customer's balance from tblPayment
        Dim findCustomerIDQuery As String = "SELECT Balance FROM tblPayment WHERE PaymentID = ? AND CustomerID = ?"
        Dim fithcommand As New OleDbCommand(findCustomerIDQuery, connection)
        fithcommand.Parameters.AddWithValue("?", OleDbType.Integer).Value = paymentID ' Pass PaymentID as an integer parameter
        fithcommand.Parameters.AddWithValue("?", OleDbType.Integer).Value = customerID ' Pass CustomerID again as an integer parameter

        ' Execute the query to retrieve the balance
        Dim reader2 As OleDbDataReader = fithcommand.ExecuteReader()
        If reader2.Read() Then

            ' Convert the retrieved balance value to a decimal
            OrderTotal = Convert.ToDecimal(reader2("Balance"))
            'Display it in order total and remaining balance
            txtOrderTotal.Text = OrderTotal

            If Not String.IsNullOrEmpty(txtPaid.Text) AndAlso IsNumeric(txtPaid.Text) Then
                txtRemaining.Text = balance
            Else
                txtRemaining.Text = OrderTotal
            End If

            retrieved = True

        End If

    End Sub

    ' Runs when the Payment form loads, starts a timer with an interval of 1 second 
    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Start()
    End Sub
    Private Sub cmbPaymentMethod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPaymentMethod.SelectedIndexChanged
        ' Check if the selected payment method is "Debit Card" or "Credit Card"
        If cmbPaymentMethod.Text = "Debit Card" Or cmbPaymentMethod.Text = "Credit Card" Then
            ' Enable the authorisation text box for card payments
            txtAuthorisation.ReadOnly = False
            needsAuth = True ' Flag indicating authorisation is required
            txtAuthorisation.Text = "" ' Set a default value for card payments
            codeCheck = False ' Set flag as authorisation needed for non-card payments
            codeCharCheck = False ' Set flag as authorisation needed for non-card payments
        Else
            ' Disable the authorisation text box for other payment methods
            txtAuthorisation.ReadOnly = True
            txtAuthorisation.Text = "N/A" ' Set a default value for non-card payments
            codeCheck = True ' Set flag as no authorisation needed for non-card payments
            codeCharCheck = True ' Set flag as no authorisation needed for non-card payments
            needsAuth = False ' No authorisation needed for non-card payments
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If OrderPage.paymentPageCheck = 1 Then
            ' Set flag to indicate that the order page was visited
            NewSaleCustomer.orderPageCheck = 1
            ' Reset payment page flag
            OrderPage.paymentPageCheck = 0
        End If


        ' Hide the current form (payment page) and show the order page
        Me.Hide()
        OrderPage.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' If no amount has been entered in txtPaid, set txtRemaining to the total order amount
        If OrderPage.paymentPageCheck = 1 Or PastOrders.addOrder = 1 Then
            txtOrderTotal.Text = OrderPage.lblTotalCost.Text
            If txtPaid.Text = "" Then
                txtRemaining.Text = txtOrderTotal.Text
            Else
                ' Otherwise, update txtRemaining with the calculated balance
                txtRemaining.Text = balance
            End If
        End If

        If retrieved = False Then
            If Paymentfound And Customerfound Then
                retrieveBalance()
            End If
        End If

    End Sub

    Private Sub txtPaid_TextChanged(sender As Object, e As EventArgs) Handles txtPaid.TextChanged
        ' Check if txtPaid and txtOrderTotal are not empty and contain numeric values
        If Not String.IsNullOrEmpty(txtPaid.Text) AndAlso IsNumeric(txtPaid.Text) AndAlso Not String.IsNullOrEmpty(txtOrderTotal.Text) AndAlso IsNumeric(txtOrderTotal.Text) Then

            ' Ensure that the paid amount does not exceed the order total
            If (CDec(txtOrderTotal.Text) - CDec(txtPaid.Text)) >= 0 Then
                ' Calculate and store the remaining balance
                balance = CDec(txtOrderTotal.Text) - CDec(txtPaid.Text)
                txtRemaining.Text = balance
            ElseIf (CDec(txtOrderTotal.Text) - CDec(txtPaid.Text)) < 0 Then
                ' Display an error message if the paid amount exceeds the total due
                MsgBox("Amount paid can't exceed amount due")
            End If
        Else
            ' If the input is invalid, reset the remaining amount to the order total
            txtRemaining.Text = txtOrderTotal.Text
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ' Check if a new sale is being created
        If OrderPage.paymentPageCheck = 1 Then
            'Show the warning page
            Me.Hide()
            Warning.Show()
            'Check if a the user is adding a payment
        ElseIf Payment_History.addPayment = 1 Then
            'Clears the fields and show the payment history page
            txtPID.Clear()
            txtCID.Clear()
            Warning.clearNewPaymentFields()
            Me.Hide()
            Payment_History.Show()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ' Boolean flags for authorisation code and payment validation checks
        Dim payMethodCheck As Boolean = True
        Dim codeLengthCheck As Boolean = True
        Dim paidCheck As Boolean = True
        Dim paidNumCheck As Boolean = True
        codeCheck = True
        codeCharCheck = True
        Dim AmountPaid As Decimal ' Variable to store the amount paid

        ' Validate the Paid amount
        If Not String.IsNullOrEmpty(txtPaid.Text) AndAlso IsNumeric(txtPaid.Text) Then
            AmountPaid = txtPaid.Text ' Store the valid numeric amount
        Else
            paidNumCheck = False ' Set flag to indicate invalid input
            MsgBox("Enter valid price") ' Show an error message
        End If

        ' Validate if a payment method is selected
        If cmbPaymentMethod.Text = "" Then
            payMethodCheck = False ' Set flag to indicate no selection
            MsgBox("Select payment method") ' Show an error message
        Else
            payMethodCheck = True
        End If

        ' Validate authorisation code if required
        If needsAuth Then
            ' Check if the authorisation code length is within the valid range
            If txtAuthorisation.Text.Length < 6 Or txtAuthorisation.Text.Length > 8 Then
                codeCheck = False
                MsgBox("Authorisation code is empty or of invalid length")
            Else
                ' Check if the authorisation code contains only letters and digits
                For Each ch As Char In txtAuthorisation.Text
                    If Not (Char.IsDigit(ch) Or Char.IsLetter(ch)) Then
                        codeCharCheck = False ' Set flag to indicate invalid characters
                    End If
                Next
            End If
        End If

        ' Show error message if the authorisation code contains special characters
        If codeCharCheck = False Then
            MsgBox("Authorisation code must not contain special characters")
        End If





        ' Check if paidNumCheck is True and both txtPaid and txtOrderTotal contain numeric values
        If paidNumCheck And Not String.IsNullOrEmpty(txtPaid.Text) AndAlso IsNumeric(txtPaid.Text) AndAlso Not String.IsNullOrEmpty(txtOrderTotal.Text) AndAlso IsNumeric(txtOrderTotal.Text) Then
            ' Ensure the paid amount does not exceed the order total
            If (CDec(txtOrderTotal.Text) - CDec(txtPaid.Text)) < 0 Then
                MsgBox("Amount paid can't exceed amount due") ' Show an error message
                paidCheck = False ' Set flag to indicate an invalid payment amount
            End If
        End If

        ' Check if all validation flags are True before proceeding with the order process
        If paidCheck And paidNumCheck And codeCharCheck And codeCheck And payMethodCheck Then

            ' Check if the user is making a new sale
            If OrderPage.paymentPageCheck = 1 Then

                ' Establish a database connection
                Dim connection As OleDbConnection = connectDatabase()
                connection.Open()

                ' Insert customer details into tblDetails
                Dim insertDetailsQuery As String = "INSERT INTO tblDetails (FirstName, Surname, Postcode, City, Address, WedDate, Tel1, Tel2, Mail, Bust, Waist, Hips) VALUES (@FirstName, @Surname, @Postcode, @City, @Address, @WedDate, @Tel1, @Tel2, @Mail, @Bust, @Waist, @Hips)"
                Dim newcommand As New OleDbCommand(insertDetailsQuery, connection)

                ' Assign customer details from NewSaleCustomer object
                newcommand.Parameters.AddWithValue("@FirstName", OleDbType.VarChar).Value = NewSaleCustomer.firstName
                newcommand.Parameters.AddWithValue("@Surname", OleDbType.VarChar).Value = NewSaleCustomer.surname
                newcommand.Parameters.AddWithValue("@Postcode", OleDbType.VarChar).Value = NewSaleCustomer.postcode
                newcommand.Parameters.AddWithValue("@City", OleDbType.VarChar).Value = NewSaleCustomer.city
                newcommand.Parameters.AddWithValue("@Address", OleDbType.VarChar).Value = NewSaleCustomer.address
                newcommand.Parameters.AddWithValue("@WedDate", OleDbType.Date).Value = NewSaleCustomer.wedDate
                newcommand.Parameters.AddWithValue("@Tel1", OleDbType.VarChar).Value = NewSaleCustomer.tel1
                newcommand.Parameters.AddWithValue("@Tel2", OleDbType.VarChar).Value = NewSaleCustomer.tel2
                newcommand.Parameters.AddWithValue("@Mail", OleDbType.VarChar).Value = NewSaleCustomer.mail
                newcommand.Parameters.AddWithValue("@Bust", OleDbType.Integer).Value = NewSaleCustomer.bust
                newcommand.Parameters.AddWithValue("@Waist", OleDbType.Integer).Value = NewSaleCustomer.waist
                newcommand.Parameters.AddWithValue("@Hips", OleDbType.Integer).Value = NewSaleCustomer.hips
                newcommand.ExecuteNonQuery() ' Execute the query

                ' Retrieve the newly inserted CustomerID
                Dim findCustomerIDQuery As String = $"SELECT CustomerID FROM tblDetails WHERE FirstName = '{NewSaleCustomer.firstName}' AND Surname = '{NewSaleCustomer.surname}' AND Tel1 = '{NewSaleCustomer.tel1}'"
                Dim secondcommand As New OleDbCommand(findCustomerIDQuery, connection)
                Dim reader As OleDbDataReader = secondcommand.ExecuteReader()

                ' Store CustomerID if found
                If reader.Read() Then
                    customerID = reader("CustomerID")
                End If

                ' Prepare order insertion query
                Dim insertOrderQuery As String = "INSERT INTO tblOrder (CustomerID, ItemType, Designer, ItemName, ItemSize, Colour, Quantity, Discount, ItemPriceAD, TotalCost, StockStatus) VALUES (@CustomerID, @ItemType, @Designer, @ItemName, @ItemSize, @Colour, @Quantity, @Discount, @ItemPriceAD, @TotalCost, @StockStatus)"
                Dim thirdcommand As New OleDbCommand(insertOrderQuery, connection)

                ' Process each item (item1 to item6) if it exists
                If OrderPage.item1full Then
                    thirdcommand.Parameters.Clear()
                    thirdcommand.Parameters.AddWithValue("@CustomerID", OleDbType.Integer).Value = customerID
                    thirdcommand.Parameters.AddWithValue("@ItemType", OleDbType.VarChar).Value = OrderPage.item1type
                    thirdcommand.Parameters.AddWithValue("@Designer", OleDbType.VarChar).Value = OrderPage.designer1
                    thirdcommand.Parameters.AddWithValue("@ItemName", OleDbType.VarChar).Value = OrderPage.item1name
                    thirdcommand.Parameters.AddWithValue("@ItemSize", OleDbType.VarChar).Value = OrderPage.size1
                    thirdcommand.Parameters.AddWithValue("@Colour", OleDbType.VarChar).Value = OrderPage.colour1
                    thirdcommand.Parameters.AddWithValue("@Quantity", OleDbType.Integer).Value = OrderPage.quantity1
                    thirdcommand.Parameters.AddWithValue("@Discount", OleDbType.Single).Value = OrderPage.discount1
                    thirdcommand.Parameters.AddWithValue("@ItemPriceAD", OleDbType.Single).Value = OrderPage.item1price
                    thirdcommand.Parameters.AddWithValue("@TotalCost", OleDbType.Single).Value = OrderPage.totalCost
                    thirdcommand.Parameters.AddWithValue("@StockStatus", OleDbType.VarChar).Value = OrderPage.stock1
                    thirdcommand.ExecuteNonQuery()
                End If

                ' Repeat the same process for item2 to item6
                If OrderPage.item2full Then
                    thirdcommand.Parameters.Clear()
                    thirdcommand.Parameters.AddWithValue("@CustomerID", OleDbType.Integer).Value = customerID
                    thirdcommand.Parameters.AddWithValue("@ItemType", OleDbType.VarChar).Value = OrderPage.item2type
                    thirdcommand.Parameters.AddWithValue("@Designer", OleDbType.VarChar).Value = OrderPage.designer2
                    thirdcommand.Parameters.AddWithValue("@ItemName", OleDbType.VarChar).Value = OrderPage.item2name
                    thirdcommand.Parameters.AddWithValue("@ItemSize", OleDbType.VarChar).Value = OrderPage.size2
                    thirdcommand.Parameters.AddWithValue("@Colour", OleDbType.VarChar).Value = OrderPage.colour2
                    thirdcommand.Parameters.AddWithValue("@Quantity", OleDbType.Integer).Value = OrderPage.quantity2
                    thirdcommand.Parameters.AddWithValue("@Discount", OleDbType.Single).Value = OrderPage.discount2
                    thirdcommand.Parameters.AddWithValue("@ItemPriceAD", OleDbType.Single).Value = OrderPage.item2price
                    thirdcommand.Parameters.AddWithValue("@TotalCost", OleDbType.Single).Value = OrderPage.totalCost
                    thirdcommand.Parameters.AddWithValue("@StockStatus", OleDbType.VarChar).Value = OrderPage.stock2
                    thirdcommand.ExecuteNonQuery()
                End If

                If OrderPage.item3full Then
                    thirdcommand.Parameters.Clear()
                    thirdcommand.Parameters.AddWithValue("@CustomerID", OleDbType.Integer).Value = customerID
                    thirdcommand.Parameters.AddWithValue("@ItemType", OleDbType.VarChar).Value = OrderPage.item3type
                    thirdcommand.Parameters.AddWithValue("@Designer", OleDbType.VarChar).Value = OrderPage.designer3
                    thirdcommand.Parameters.AddWithValue("@ItemName", OleDbType.VarChar).Value = OrderPage.item3name
                    thirdcommand.Parameters.AddWithValue("@ItemSize", OleDbType.VarChar).Value = OrderPage.size3
                    thirdcommand.Parameters.AddWithValue("@Colour", OleDbType.VarChar).Value = OrderPage.colour3
                    thirdcommand.Parameters.AddWithValue("@Quantity", OleDbType.Integer).Value = OrderPage.quantity3
                    thirdcommand.Parameters.AddWithValue("@Discount", OleDbType.Single).Value = OrderPage.discount3
                    thirdcommand.Parameters.AddWithValue("@ItemPriceAD", OleDbType.Single).Value = OrderPage.item3price
                    thirdcommand.Parameters.AddWithValue("@TotalCost", OleDbType.Single).Value = OrderPage.totalCost
                    thirdcommand.Parameters.AddWithValue("@StockStatus", OleDbType.VarChar).Value = OrderPage.stock3
                    thirdcommand.ExecuteNonQuery()
                End If

                If OrderPage.item4full Then
                    thirdcommand.Parameters.Clear()
                    thirdcommand.Parameters.AddWithValue("@CustomerID", OleDbType.Integer).Value = customerID
                    thirdcommand.Parameters.AddWithValue("@ItemType", OleDbType.VarChar).Value = OrderPage.item4type
                    thirdcommand.Parameters.AddWithValue("@Designer", OleDbType.VarChar).Value = OrderPage.designer4
                    thirdcommand.Parameters.AddWithValue("@ItemName", OleDbType.VarChar).Value = OrderPage.item4name
                    thirdcommand.Parameters.AddWithValue("@ItemSize", OleDbType.VarChar).Value = OrderPage.size4
                    thirdcommand.Parameters.AddWithValue("@Colour", OleDbType.VarChar).Value = OrderPage.colour4
                    thirdcommand.Parameters.AddWithValue("@Quantity", OleDbType.Integer).Value = OrderPage.quantity4
                    thirdcommand.Parameters.AddWithValue("@Discount", OleDbType.Single).Value = OrderPage.discount4
                    thirdcommand.Parameters.AddWithValue("@ItemPriceAD", OleDbType.Single).Value = OrderPage.item4price
                    thirdcommand.Parameters.AddWithValue("@TotalCost", OleDbType.Single).Value = OrderPage.totalCost
                    thirdcommand.Parameters.AddWithValue("@StockStatus", OleDbType.VarChar).Value = OrderPage.stock4
                    thirdcommand.ExecuteNonQuery()
                End If

                If OrderPage.item5full Then
                    thirdcommand.Parameters.Clear()
                    thirdcommand.Parameters.AddWithValue("@CustomerID", OleDbType.Integer).Value = customerID
                    thirdcommand.Parameters.AddWithValue("@ItemType", OleDbType.VarChar).Value = OrderPage.item5type
                    thirdcommand.Parameters.AddWithValue("@Designer", OleDbType.VarChar).Value = OrderPage.designer5
                    thirdcommand.Parameters.AddWithValue("@ItemName", OleDbType.VarChar).Value = OrderPage.item5name
                    thirdcommand.Parameters.AddWithValue("@ItemSize", OleDbType.VarChar).Value = OrderPage.size5
                    thirdcommand.Parameters.AddWithValue("@Colour", OleDbType.VarChar).Value = OrderPage.colour5
                    thirdcommand.Parameters.AddWithValue("@Quantity", OleDbType.Integer).Value = OrderPage.quantity5
                    thirdcommand.Parameters.AddWithValue("@Discount", OleDbType.Single).Value = OrderPage.discount5
                    thirdcommand.Parameters.AddWithValue("@ItemPriceAD", OleDbType.Single).Value = OrderPage.item5price
                    thirdcommand.Parameters.AddWithValue("@TotalCost", OleDbType.Single).Value = OrderPage.totalCost
                    thirdcommand.Parameters.AddWithValue("@StockStatus", OleDbType.VarChar).Value = OrderPage.stock5
                    thirdcommand.ExecuteNonQuery()
                End If

                If OrderPage.item6full Then
                    thirdcommand.Parameters.Clear()
                    thirdcommand.Parameters.AddWithValue("@CustomerID", OleDbType.Integer).Value = customerID
                    thirdcommand.Parameters.AddWithValue("@ItemType", OleDbType.VarChar).Value = OrderPage.item6type
                    thirdcommand.Parameters.AddWithValue("@Designer", OleDbType.VarChar).Value = OrderPage.designer6
                    thirdcommand.Parameters.AddWithValue("@ItemName", OleDbType.VarChar).Value = OrderPage.item6name
                    thirdcommand.Parameters.AddWithValue("@ItemSize", OleDbType.VarChar).Value = OrderPage.size6
                    thirdcommand.Parameters.AddWithValue("@Colour", OleDbType.VarChar).Value = OrderPage.colour6
                    thirdcommand.Parameters.AddWithValue("@Quantity", OleDbType.Integer).Value = OrderPage.quantity6
                    thirdcommand.Parameters.AddWithValue("@Discount", OleDbType.Single).Value = OrderPage.discount6
                    thirdcommand.Parameters.AddWithValue("@ItemPriceAD", OleDbType.Single).Value = OrderPage.item6price
                    thirdcommand.Parameters.AddWithValue("@TotalCost", OleDbType.Single).Value = OrderPage.totalCost
                    thirdcommand.Parameters.AddWithValue("@StockStatus", OleDbType.VarChar).Value = OrderPage.stock6
                    thirdcommand.ExecuteNonQuery()
                End If

                ' Define SQL query to insert payment details into the database
                Dim insertPaymentQuery As String = "INSERT INTO tblPayment (CustomerID, PaymentDate, Method, Code, TotalCost, AmountPaid, Balance) VALUES (?, ?, ?, ?, ?, ?, ?)"
                Dim fourthcommand As New OleDbCommand(insertPaymentQuery, connection)

                ' Add parameters to the query 
                fourthcommand.Parameters.Add("CustomerID", OleDbType.Integer).Value = customerID
                fourthcommand.Parameters.Add("PaymentDate", OleDbType.Date).Value = dtpDate.Value.Date
                fourthcommand.Parameters.Add("Method", OleDbType.VarChar).Value = cmbPaymentMethod.Text
                fourthcommand.Parameters.Add("Code", OleDbType.VarChar).Value = txtAuthorisation.Text

                ' Add remaining payment details
                fourthcommand.Parameters.Add("TotalCost", OleDbType.Decimal).Value = OrderPage.totalCost
                fourthcommand.Parameters.Add("AmountPaid", OleDbType.Decimal).Value = AmountPaid
                fourthcommand.Parameters.Add("Balance", OleDbType.Decimal).Value = balance

                ' Execute the SQL command to insert data
                fourthcommand.ExecuteNonQuery()

                ' Clear input fields after transaction is complete
                Warning.clearNewCustomerFields()
                Warning.clearNewOrderFields()
                Warning.clearNewPaymentFields()

                ' Notify user of successful transaction
                MsgBox("Sale Complete!")

                BrideDetails.bridesrefresh()
                PastOrders.orderRefresh()
                Payment_History.paymentRefresh()


                OrderPage.paymentPageCheck = 0
                balance = 0
                ' Close current form and return to main menu
                Me.Hide()
                Main_Menu.Show()

                ' If user is making payment from payment history page
            ElseIf Payment_History.addPayment = 1 Then


                ' Open a new database connection
                Dim connection As OleDbConnection = connectDatabase()
                connection.Open()

                If Customerfound And Paymentfound Then

                    ' Define SQL query to insert payment details into the database
                    Dim insertPaymentQuery As String = "INSERT INTO tblPayment (CustomerID, PaymentDate, Method, Code, TotalCost, AmountPaid, Balance) VALUES (?, ?, ?, ?, ?, ?, ?)"
                    Dim sixthcommand As New OleDbCommand(insertPaymentQuery, connection)


                    ' Add parameters to the query 
                    sixthcommand.Parameters.AddWithValue("?", CInt(txtCID.Text))
                    sixthcommand.Parameters.AddWithValue("?", dtpDate.Value.Date)
                    sixthcommand.Parameters.AddWithValue("?", cmbPaymentMethod.Text)
                    sixthcommand.Parameters.AddWithValue("?", txtAuthorisation.Text)
                    sixthcommand.Parameters.AddWithValue("?", CDec(txtOrderTotal.Text))
                    sixthcommand.Parameters.AddWithValue("?", CDec(txtPaid.Text))
                    sixthcommand.Parameters.AddWithValue("?", CDec(txtRemaining.Text))

                    ' Execute the SQL command
                    sixthcommand.ExecuteNonQuery()

                    txtPID.Clear()
                    txtCID.Clear()
                    txtPID.Visible = False
                    txtCID.Visible = False
                    lblPaymentID.Visible = False
                    lblCustomerID.Visible = False
                    Warning.clearNewPaymentFields()
                    Payment_History.paymentRefresh()

                    Customerfound = False
                    Paymentfound = False
                    retrieved = False
                    balance = 0
                    Me.Hide()
                    Payment_History.Show()


                Else
                    MsgBox("Customer not found")
                End If

            ElseIf PastOrders.addOrder = 1 Then

                ' Open a new database connection
                Dim connection As OleDbConnection = connectDatabase()
                connection.Open()

                ' SQL query to insert a new order into the database
                Dim insertOrderQuery As String = "INSERT INTO tblOrder (CustomerID, ItemType, Designer, ItemName, ItemSize, Colour, Quantity, Discount, ItemPriceAD, TotalCost, StockStatus) VALUES (@CustomerID, @ItemType, @Designer, @ItemName, @ItemSize, @Colour, @Quantity, @Discount, @ItemPriceAD, @TotalCost, @StockStatus)"
                Dim thirdcommand As New OleDbCommand(insertOrderQuery, connection)

                ' Insert the details for item 1 if it is selected
                If OrderPage.item1full Then
                    thirdcommand.Parameters.AddWithValue("@CustomerID", OleDbType.Integer).Value = OrderPage.CustomerID
                    thirdcommand.Parameters.AddWithValue("@ItemType", OleDbType.VarChar).Value = OrderPage.item1type
                    thirdcommand.Parameters.AddWithValue("@Designer", OleDbType.VarChar).Value = OrderPage.designer1
                    thirdcommand.Parameters.AddWithValue("@ItemName", OleDbType.VarChar).Value = OrderPage.item1name
                    thirdcommand.Parameters.AddWithValue("@ItemSize", OleDbType.VarChar).Value = OrderPage.size1
                    thirdcommand.Parameters.AddWithValue("@Colour", OleDbType.VarChar).Value = OrderPage.colour1
                    thirdcommand.Parameters.AddWithValue("@Quantity", OleDbType.Integer).Value = OrderPage.quantity1
                    thirdcommand.Parameters.AddWithValue("@Discount", OleDbType.Single).Value = OrderPage.discount1
                    thirdcommand.Parameters.AddWithValue("@ItemPriceAD", OleDbType.Single).Value = OrderPage.item1price
                    thirdcommand.Parameters.AddWithValue("@TotalCost", OleDbType.Single).Value = OrderPage.totalCost
                    thirdcommand.Parameters.AddWithValue("@StockStatus", OleDbType.VarChar).Value = OrderPage.stock1
                    thirdcommand.ExecuteNonQuery()
                End If

                ' Insert the details for item 2 if it is selected
                If OrderPage.item2full Then
                    thirdcommand.Parameters.AddWithValue("@CustomerID", OleDbType.Integer).Value = OrderPage.CustomerID
                    thirdcommand.Parameters.AddWithValue("@ItemType", OleDbType.VarChar).Value = OrderPage.item2type
                    thirdcommand.Parameters.AddWithValue("@Designer", OleDbType.VarChar).Value = OrderPage.designer2
                    thirdcommand.Parameters.AddWithValue("@ItemName", OleDbType.VarChar).Value = OrderPage.item2name
                    thirdcommand.Parameters.AddWithValue("@ItemSize", OleDbType.VarChar).Value = OrderPage.size2
                    thirdcommand.Parameters.AddWithValue("@Colour", OleDbType.VarChar).Value = OrderPage.colour2
                    thirdcommand.Parameters.AddWithValue("@Quantity", OleDbType.Integer).Value = OrderPage.quantity2
                    thirdcommand.Parameters.AddWithValue("@Discount", OleDbType.Single).Value = OrderPage.discount2
                    thirdcommand.Parameters.AddWithValue("@ItemPriceAD", OleDbType.Single).Value = OrderPage.item2price
                    thirdcommand.Parameters.AddWithValue("@TotalCost", OleDbType.Single).Value = OrderPage.totalCost
                    thirdcommand.Parameters.AddWithValue("@StockStatus", OleDbType.VarChar).Value = OrderPage.stock2
                    thirdcommand.ExecuteNonQuery()
                End If

                ' Insert the details for item 3 if it is selected
                If OrderPage.item3full Then
                    thirdcommand.Parameters.AddWithValue("@CustomerID", OleDbType.Integer).Value = OrderPage.CustomerID
                    thirdcommand.Parameters.AddWithValue("@ItemType", OleDbType.VarChar).Value = OrderPage.item3type
                    thirdcommand.Parameters.AddWithValue("@Designer", OleDbType.VarChar).Value = OrderPage.designer3
                    thirdcommand.Parameters.AddWithValue("@ItemName", OleDbType.VarChar).Value = OrderPage.item3name
                    thirdcommand.Parameters.AddWithValue("@ItemSize", OleDbType.VarChar).Value = OrderPage.size3
                    thirdcommand.Parameters.AddWithValue("@Colour", OleDbType.VarChar).Value = OrderPage.colour3
                    thirdcommand.Parameters.AddWithValue("@Quantity", OleDbType.Integer).Value = OrderPage.quantity3
                    thirdcommand.Parameters.AddWithValue("@Discount", OleDbType.Single).Value = OrderPage.discount3
                    thirdcommand.Parameters.AddWithValue("@ItemPriceAD", OleDbType.Single).Value = OrderPage.item3price
                    thirdcommand.Parameters.AddWithValue("@TotalCost", OleDbType.Single).Value = OrderPage.totalCost
                    thirdcommand.Parameters.AddWithValue("@StockStatus", OleDbType.VarChar).Value = OrderPage.stock3
                    thirdcommand.ExecuteNonQuery()
                End If

                ' Insert the details for item 4 if it is selected
                If OrderPage.item4full Then
                    thirdcommand.Parameters.AddWithValue("@CustomerID", OleDbType.Integer).Value = OrderPage.CustomerID
                    thirdcommand.Parameters.AddWithValue("@ItemType", OleDbType.VarChar).Value = OrderPage.item4type
                    thirdcommand.Parameters.AddWithValue("@Designer", OleDbType.VarChar).Value = OrderPage.designer4
                    thirdcommand.Parameters.AddWithValue("@ItemName", OleDbType.VarChar).Value = OrderPage.item4name
                    thirdcommand.Parameters.AddWithValue("@ItemSize", OleDbType.VarChar).Value = OrderPage.size4
                    thirdcommand.Parameters.AddWithValue("@Colour", OleDbType.VarChar).Value = OrderPage.colour4
                    thirdcommand.Parameters.AddWithValue("@Quantity", OleDbType.Integer).Value = OrderPage.quantity4
                    thirdcommand.Parameters.AddWithValue("@Discount", OleDbType.Single).Value = OrderPage.discount4
                    thirdcommand.Parameters.AddWithValue("@ItemPriceAD", OleDbType.Single).Value = OrderPage.item4price
                    thirdcommand.Parameters.AddWithValue("@TotalCost", OleDbType.Single).Value = OrderPage.totalCost
                    thirdcommand.Parameters.AddWithValue("@StockStatus", OleDbType.VarChar).Value = OrderPage.stock4
                    thirdcommand.ExecuteNonQuery()
                End If

                ' Insert the details for item 5 if it is selected
                If OrderPage.item5full Then
                    thirdcommand.Parameters.AddWithValue("@CustomerID", OleDbType.Integer).Value = OrderPage.CustomerID
                    thirdcommand.Parameters.AddWithValue("@ItemType", OleDbType.VarChar).Value = OrderPage.item5type
                    thirdcommand.Parameters.AddWithValue("@Designer", OleDbType.VarChar).Value = OrderPage.designer5
                    thirdcommand.Parameters.AddWithValue("@ItemName", OleDbType.VarChar).Value = OrderPage.item5name
                    thirdcommand.Parameters.AddWithValue("@ItemSize", OleDbType.VarChar).Value = OrderPage.size5
                    thirdcommand.Parameters.AddWithValue("@Colour", OleDbType.VarChar).Value = OrderPage.colour5
                    thirdcommand.Parameters.AddWithValue("@Quantity", OleDbType.Integer).Value = OrderPage.quantity5
                    thirdcommand.Parameters.AddWithValue("@Discount", OleDbType.Single).Value = OrderPage.discount5
                    thirdcommand.Parameters.AddWithValue("@ItemPriceAD", OleDbType.Single).Value = OrderPage.item5price
                    thirdcommand.Parameters.AddWithValue("@TotalCost", OleDbType.Single).Value = OrderPage.totalCost
                    thirdcommand.Parameters.AddWithValue("@StockStatus", OleDbType.VarChar).Value = OrderPage.stock5
                    thirdcommand.ExecuteNonQuery()
                End If

                ' Insert the details for item 6 if it is selected
                If OrderPage.item6full Then
                    thirdcommand.Parameters.AddWithValue("@CustomerID", OleDbType.Integer).Value = OrderPage.CustomerID
                    thirdcommand.Parameters.AddWithValue("@ItemType", OleDbType.VarChar).Value = OrderPage.item6type
                    thirdcommand.Parameters.AddWithValue("@Designer", OleDbType.VarChar).Value = OrderPage.designer6
                    thirdcommand.Parameters.AddWithValue("@ItemName", OleDbType.VarChar).Value = OrderPage.item6name
                    thirdcommand.Parameters.AddWithValue("@ItemSize", OleDbType.VarChar).Value = OrderPage.size6
                    thirdcommand.Parameters.AddWithValue("@Colour", OleDbType.VarChar).Value = OrderPage.colour6
                    thirdcommand.Parameters.AddWithValue("@Quantity", OleDbType.Integer).Value = OrderPage.quantity6
                    thirdcommand.Parameters.AddWithValue("@Discount", OleDbType.Single).Value = OrderPage.discount6
                    thirdcommand.Parameters.AddWithValue("@ItemPriceAD", OleDbType.Single).Value = OrderPage.item6price
                    thirdcommand.Parameters.AddWithValue("@TotalCost", OleDbType.Single).Value = OrderPage.totalCost
                    thirdcommand.Parameters.AddWithValue("@StockStatus", OleDbType.VarChar).Value = OrderPage.stock6
                    thirdcommand.ExecuteNonQuery()
                End If

                ' Define SQL query to insert payment details into the database
                Dim insertPaymentQuery As String = "INSERT INTO tblPayment (CustomerID, PaymentDate, Method, Code, TotalCost, AmountPaid, Balance) VALUES (?, ?, ?, ?, ?, ?, ?)"
                Dim fourthcommand As New OleDbCommand(insertPaymentQuery, connection)

                ' Add parameters to the query 
                fourthcommand.Parameters.Add("CustomerID", OleDbType.Integer).Value = OrderPage.CustomerID
                fourthcommand.Parameters.Add("PaymentDate", OleDbType.Date).Value = dtpDate.Value.Date
                fourthcommand.Parameters.Add("Method", OleDbType.VarChar).Value = cmbPaymentMethod.Text
                fourthcommand.Parameters.Add("Code", OleDbType.VarChar).Value = txtAuthorisation.Text

                ' Add remaining payment details
                fourthcommand.Parameters.Add("TotalCost", OleDbType.Decimal).Value = OrderPage.totalCost
                fourthcommand.Parameters.Add("AmountPaid", OleDbType.Decimal).Value = AmountPaid
                fourthcommand.Parameters.Add("Balance", OleDbType.Decimal).Value = balance

                ' Execute the SQL command to insert data
                fourthcommand.ExecuteNonQuery()

                ' Clear input fields after transaction is complete
                Warning.clearNewOrderFields()
                Warning.clearNewPaymentFields()

                PastOrders.addOrder = 0
                balance = 0

                ' Clear all the details after the order is processed
                OrderPage.clearEverything()
                'Display a message to indicate the order was successful
                MsgBox("Order/s successfully added")

                ' Hide current form and show the Past Orders form
                Me.Hide()
                PastOrders.Show()

            End If
        End If
    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtCID.TextChanged
        retrieved = False

        ' Check if txtID is not empty and contains a numeric value
        If Not String.IsNullOrEmpty(txtCID.Text) AndAlso IsNumeric(txtCID.Text) Then
            ' Convert the text input into an integer
            customerID = CInt(txtCID.Text)

            ' Establish a connection to the database
            Dim connection As OleDbConnection = connectDatabase()
            connection.Open()

            ' Query to check if a customer exists in tblPayment using a parameterized query
            Dim findCustomerQuery As String = "SELECT CustomerID FROM tblPayment WHERE CustomerID = ?"
            Dim findCustomerCommand As New OleDbCommand(findCustomerQuery, connection)
            findCustomerCommand.Parameters.AddWithValue("?", OleDbType.Integer).Value = customerID ' Pass CustomerID as an integer parameter

            ' Execute the query to check if the customer exists
            Dim reader1 As OleDbDataReader = findCustomerCommand.ExecuteReader()
            If reader1.Read() Then ' If a record is found
                Customerfound = True
            Else
                Customerfound = False
                txtOrderTotal.Text = ""
                txtRemaining.Text = ""
            End If
        Else
            txtOrderTotal.Text = ""
            txtRemaining.Text = ""
        End If
    End Sub

    Private Sub txtPID_TextChanged(sender As Object, e As EventArgs) Handles txtPID.TextChanged
        retrieved = False

        ' Check if txtPID is not empty and contains a numeric value
        If Not String.IsNullOrEmpty(txtPID.Text) AndAlso IsNumeric(txtPID.Text) Then
            ' Convert the text input into an integer

            paymentID = CInt(txtPID.Text)

            ' Establish a connection to the database
            Dim connection As OleDbConnection = connectDatabase()
            connection.Open()

            ' Query to check if a payment exists in tblPayment using a parameterized query
            Dim findCustomerQuery As String = "SELECT PaymentID FROM tblPayment WHERE PaymentID = ?"
            Dim findCustomerCommand As New OleDbCommand(findCustomerQuery, connection)
            findCustomerCommand.Parameters.AddWithValue("?", OleDbType.Integer).Value = paymentID ' Pass paymentID as an integer parameter

            ' Execute the query to check if the payment exists
            Dim reader1 As OleDbDataReader = findCustomerCommand.ExecuteReader()
            If reader1.Read() Then ' If a record is found
                Paymentfound = True
            Else
                Paymentfound = False
                txtOrderTotal.Text = ""
                txtRemaining.Text = ""
            End If
        Else
            txtOrderTotal.Text = ""
            txtRemaining.Text = ""
        End If
    End Sub
End Class