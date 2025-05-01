Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles

Public Class OrderPage
    ' Public variable to track if the payment page is accessed
    Public paymentPageCheck = 0

    'Variables used to hold CustomerID and track if it exists
    Public CustomerID As Integer
    Dim Customerfound As Boolean = False

    ' Clears input fields related to a single item selection
    Sub clearTextbox()
        cmbItemType.SelectedIndex = -1 ' Reset item type dropdown
        cmbDesigner.SelectedIndex = -1 ' Reset designer dropdown
        cmbItemName.SelectedIndex = -1 ' Reset item name dropdown
        cmbItemName.Text = ""
        txtColour.Clear() ' Clear color input field
        txtPrice.Clear() ' Clear price field
        cmbSize.SelectedIndex = -1 ' Reset size dropdown
        txtQuantity.Clear() ' Clear quantity field
        txtDiscount.Clear() ' Clear discount field
        radHire.Checked = False ' Uncheck "Hire" radio button
        radNot.Checked = False ' Uncheck "Not Stock" radio button
        radStock.Checked = False ' Uncheck "Stock" radio button
    End Sub

    ' Subroutine to clear all input fields 
    Sub clearEverything()
        ' Clear Customer ID field
        txtID.Clear()
        ' Reset item selection dropdowns and text fields
        cmbItemType.SelectedIndex = -1
        cmbDesigner.SelectedIndex = -1
        cmbItemName.SelectedIndex = -1
        cmbItemName.Text = "" ' Ensures no text is left in the combo box
        ' Clear color and price fields
        txtColour.Clear()
        txtPrice.Clear()
        ' Reset size selection
        cmbSize.SelectedIndex = -1
        ' Clear quantity and discount fields
        txtQuantity.Clear()
        txtDiscount.Clear()
        ' Uncheck all stock-related radio buttons
        radHire.Checked = False
        radNot.Checked = False
        radStock.Checked = False
        ' Reset all six item slots
        ' Item 1
        chkItem1.Checked = False  ' Uncheck checkbox
        chkItem1.Text = ""        ' Clear text
        chkItem1.Visible = False  ' Hide checkbox
        item1full = False         ' Reset full item flag
        item1type = ""            ' Clear item type
        designer1 = ""            ' Clear designer
        item1name = ""            ' Clear item name
        size1 = ""                ' Clear size
        colour1 = ""              ' Clear colour
        stock1 = ""               ' Clear stock status
        item1price = 0            ' Reset price
        discount1 = 0             ' Reset discount
        quantity1 = 0             ' Reset quantity
        ' Item 2
        chkItem2.Checked = False
        chkItem2.Text = ""
        chkItem2.Visible = False
        item2full = False
        item2type = ""
        designer2 = ""
        item2name = ""
        size2 = ""
        colour2 = ""
        stock2 = ""
        item2price = 0
        discount2 = 0
        quantity2 = 0
        ' Item 3
        chkItem3.Checked = False
        chkItem3.Text = ""
        chkItem3.Visible = False
        item3full = False
        item3type = ""
        designer3 = ""
        item3name = ""
        size3 = ""
        colour3 = ""
        stock3 = ""
        item3price = 0
        discount3 = 0
        quantity3 = 0
        ' Item 4
        chkItem4.Checked = False
        chkItem4.Text = ""
        chkItem4.Visible = False
        item4full = False
        item4type = ""
        designer4 = ""
        item4name = ""
        size4 = ""
        colour4 = ""
        stock4 = ""
        item4price = 0
        discount4 = 0
        quantity4 = 0
        ' Item 5
        chkItem5.Checked = False
        chkItem5.Text = ""
        chkItem5.Visible = False
        item5full = False
        item5type = ""
        designer5 = ""
        item5name = ""
        size5 = ""
        colour5 = ""
        stock5 = ""
        item5price = 0
        discount5 = 0
        quantity5 = 0
        ' Item 6
        chkItem6.Checked = False
        chkItem6.Text = ""
        chkItem6.Visible = False
        item6full = False
        item6type = ""
        designer6 = ""
        item6name = ""
        size6 = ""
        colour6 = ""
        stock6 = ""
        item6price = 0
        discount6 = 0
        quantity6 = 0
    End Sub

    ' Boolean flags indicating whether each item slot (1-6) is filled
    Public item1full As Boolean = False
    Public item2full As Boolean = False
    Public item3full As Boolean = False
    Public item4full As Boolean = False
    Public item5full As Boolean = False
    Public item6full As Boolean = False
    ' Total cost of all selected items
    Public totalCost As Decimal = 0
    ' General stock status
    Public stock As String = ""
    ' General attributes for item selection
    Public quantity As Integer    ' Stores the quantity of an item
    Public discount As Single     ' Stores the discount amount applied
    Public price As Single        ' Stores the price of an item
    ' Strings to store the type/category of each item 
    Public item1type As String
    Public item2type As String
    Public item3type As String
    Public item4type As String
    Public item5type As String
    Public item6type As String
    ' Strings to store the designer brand of each item
    Public designer1 As String
    Public designer2 As String
    Public designer3 As String
    Public designer4 As String
    Public designer5 As String
    Public designer6 As String
    ' Strings to store the name of each selected item
    Public item1name As String
    Public item2name As String
    Public item3name As String
    Public item4name As String
    Public item5name As String
    Public item6name As String
    ' Strings to store the size of each item 
    Public size1 As String
    Public size2 As String
    Public size3 As String
    Public size4 As String
    Public size5 As String
    Public size6 As String
    ' Strings to store the color of each item
    Public colour1 As String
    Public colour2 As String
    Public colour3 As String
    Public colour4 As String
    Public colour5 As String
    Public colour6 As String
    ' Strings to store stock status for each item 
    Public stock1 As String
    Public stock2 As String
    Public stock3 As String
    Public stock4 As String
    Public stock5 As String
    Public stock6 As String
    ' Stores the price of each individual item
    Public item1price As Single
    Public item2price As Single
    Public item3price As Single
    Public item4price As Single
    Public item5price As Single
    Public item6price As Single
    ' Stores the discount applied to each item
    Public discount1 As Single
    Public discount2 As Single
    Public discount3 As Single
    Public discount4 As Single
    Public discount5 As Single
    Public discount6 As Single
    ' Stores the quantity of each item selected
    Public quantity1 As Integer
    Public quantity2 As Integer
    Public quantity3 As Integer
    Public quantity4 As Integer
    Public quantity5 As Integer
    Public quantity6 As Integer


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ' Check if the user is adding a new order
        If PastOrders.addOrder = 1 Then
            ' Clears all fields and resets variables to their default values
            clearEverything()

            ' Hide the current form
            Me.Hide()

            ' Show the PastOrders form
            PastOrders.Show()

            ' Check if the user is making a new sale
        ElseIf NewSaleCustomer.orderPageCheck = 1 Then
            ' Hide the current form
            Me.Hide()

            ' Show the Warning form
            Warning.Show()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Set newSaleCheck flag to indicate the user is on the new sale (customer) form
        Main_Menu.newSaleCheck = 1
        'Reset orderPageCheck flag to indicate the user is no loger on the new sale (order) form
        NewSaleCustomer.orderPageCheck = 0
        'Navigate to new sale (customer) form
        Me.Hide()
        NewSaleCustomer.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' Boolean flags to track validation checks for different fields  
        Dim itemTypeCheck As Boolean = True       ' Checks if the item type is valid  
        Dim itemNameCheck As Boolean = True       ' Checks if the item name is valid  
        Dim designerCheck As Boolean = True       ' Checks if the designer selection is valid  
        Dim colourCheck As Boolean = True         ' Checks if the colour selection is valid  
        Dim sizeCheck As Boolean = True           ' Checks if the size selection is valid  
        Dim quantityRangeCheck As Boolean = True  ' Checks if the quantity is within a valid range  
        Dim quantityCheck As Boolean = True       ' Checks if the quantity is properly entered  
        Dim discountCheck As Boolean = True       ' Checks if the discount value is valid  
        Dim priceCheck As Boolean = True          ' Checks if the price is valid  
        Dim stockCheck As Boolean = True          ' Checks if the stock status is valid  



        ' Check if txtQuantity is not empty and contains a numeric value  
        If Not String.IsNullOrEmpty(txtQuantity.Text) AndAlso IsNumeric(txtQuantity.Text) Then
            quantity = CInt(txtQuantity.Text) ' Convert quantity to an integer  
        End If

        ' Check if txtDiscount is not empty and contains a numeric value  
        If Not String.IsNullOrEmpty(txtDiscount.Text) AndAlso IsNumeric(txtDiscount.Text) Then
            discount = CDec(txtDiscount.Text) ' Convert discount to an decimal
        End If

        ' Check if txtPrice is not empty and contains a numeric value  
        If Not String.IsNullOrEmpty(txtPrice.Text) AndAlso IsNumeric(txtPrice.Text) Then
            ' Calculate price after applying the discount  
            price = CSng(txtPrice.Text) * (1 - (discount / 100))
        End If

        ' Validation for Item Type  
        If cmbItemType.Text = "" Then
            itemTypeCheck = False ' Empty selection is invalid  
        End If
        For Each ch As Char In cmbItemType.Text
            If Char.IsDigit(ch) Then
                itemTypeCheck = False ' Item type should not contain digits  
            End If
        Next
        If itemTypeCheck = False Then
            MsgBox("Please select a valid item type")
        End If

        ' Validation for Designer  
        If cmbDesigner.Text = "" Then
            designerCheck = False ' Empty selection is invalid  
        End If
        For Each ch As Char In cmbDesigner.Text
            If Char.IsDigit(ch) Then
                designerCheck = False ' Designer name should not contain digits  
            End If
        Next
        If designerCheck = False Then
            MsgBox("Please enter a valid designer")
        End If

        ' Validation for Item Name  
        If cmbItemName.Text = "" Then
            itemNameCheck = False ' Empty selection is invalid  
        End If
        If itemNameCheck = False Then
            MsgBox("Please select an item name")
        End If

        ' Validation for Colour  
        If txtColour.Text = "" Then
            colourCheck = False ' Empty field is invalid  
        End If
        For Each ch As Char In txtColour.Text
            If Char.IsDigit(ch) Then
                colourCheck = False ' Colour should not contain numbers  
            End If
        Next
        If colourCheck = False Then
            MsgBox("Enter a valid colour")
        End If

        ' Validation for Size  
        If cmbSize.Text = "" Then
            MsgBox("Please select size")
            sizeCheck = False ' Empty selection is invalid  
        End If

        ' Validation for Quantity Range  
        If txtQuantity.Text = "" Then
            quantityRangeCheck = False ' Empty field is invalid  
        ElseIf quantity < 1 Or quantity > 100 Then
            quantityRangeCheck = False ' Quantity must be between 1 and 100  
        Else
            quantityRangeCheck = True ' Valid range  
        End If

        ' Validation for Quantity (must be numeric)  
        If quantityRangeCheck Then
            For Each ch As Char In txtQuantity.Text
                If Not Char.IsDigit(ch) Then
                    quantityCheck = False ' Quantity should only contain digits  
                Else
                    quantityCheck = True ' Valid quantity  
                End If
            Next
            If quantityCheck = False Then
                MsgBox("Enter a valid quantity")
            End If
        End If

        ' Validation for Discount  
        If txtDiscount.Text = "" Then
            discountCheck = False ' Empty field is invalid  
        ElseIf discount < 0 Or discount > 100 Then
            discountCheck = False ' Discount must be between 0% and 100%  
        End If
        For Each ch As Char In txtDiscount.Text
            If Not Char.IsDigit(ch) Then
                discountCheck = False ' Discount should only contain digits  
            End If
        Next
        If discountCheck = False Then
            MsgBox("Please enter a valid discount or 0 if no discount")
        End If

        ' Validation for Price  
        If txtPrice.Text = "" Then
            priceCheck = False ' Empty field is invalid  
        ElseIf price < 0 Or price > 10000 Then
            priceCheck = False ' Price must be between 0 and 10,000  
        End If
        For Each ch As Char In txtPrice.Text
            If Not Char.IsDigit(ch) Then
                priceCheck = False ' Price should only contain digits  
            End If
        Next
        If priceCheck = False Then
            MsgBox("Enter a valid price")
        End If

        ' Validation for Stock Selection  
        If radHire.Checked Then
            stock = "Hired"
        ElseIf radNot.Checked Then
            stock = "Not Stock"
        ElseIf radStock.Checked Then
            stock = "Stock"
        Else
            MsgBox("Please select stock/hire/not")
            stockCheck = False ' No selection is invalid  
        End If



        ' Check if all validation checks are passed before proceeding
        If itemNameCheck And itemTypeCheck And designerCheck And designerCheck And colourCheck And sizeCheck And quantityCheck And discountCheck And priceCheck And stockCheck Then

            ' Check and assign the first available item slot
            If item1full = False Then
                ' Store item details
                item1type = cmbItemType.Text
                designer1 = cmbDesigner.Text
                item1name = cmbItemName.Text
                size1 = cmbSize.Text
                colour1 = txtColour.Text
                stock1 = stock
                item1price = price * quantity ' Calculate total price for this item
                discount1 = discount
                quantity1 = quantity


                ' Update checkbox text with item details
                chkItem1.Text = cmbItemType.Text & ", " & cmbDesigner.Text & ", " & cmbItemName.Text & ", " & txtColour.Text & ", " & cmbSize.Text & ", " & txtPrice.Text & ", " & txtDiscount.Text & "%, " & stock & vbNewLine & txtQuantity.Text & "x £" & item1price
                chkItem1.Visible = True ' Make checkbox visible
                item1full = True ' Mark item slot as full
                clearTextbox() ' Clear input fields after adding the item

                ' Repeat the same process for the remaining item slots (2-6)
            ElseIf item2full = False Then

                item2type = cmbItemType.Text
                designer2 = cmbDesigner.Text
                item2name = cmbItemName.Text
                size2 = cmbSize.Text
                colour2 = txtColour.Text
                stock2 = stock
                item2price = price * quantity
                discount2 = discount
                quantity2 = quantity


                chkItem2.Text = cmbItemType.Text & ", " & cmbDesigner.Text & ", " & cmbItemName.Text & ", " & txtColour.Text & ", " & cmbSize.Text & ", " & txtPrice.Text & ", " & txtDiscount.Text & "%, " & stock & vbNewLine & txtQuantity.Text & "x £" & item2price
                chkItem2.Visible = True
                item2full = True
                clearTextbox()

            ElseIf item3full = False Then

                item3type = cmbItemType.Text
                designer3 = cmbDesigner.Text
                item3name = cmbItemName.Text
                size3 = cmbSize.Text
                colour3 = txtColour.Text
                stock3 = stock
                item3price = price * quantity
                discount3 = discount
                quantity3 = quantity


                chkItem3.Text = cmbItemType.Text & ", " & cmbDesigner.Text & ", " & cmbItemName.Text & ", " & txtColour.Text & ", " & cmbSize.Text & ", " & txtPrice.Text & ", " & txtDiscount.Text & "%, " & stock & vbNewLine & txtQuantity.Text & "x £" & item3price
                chkItem3.Visible = True
                item3full = True
                clearTextbox()

            ElseIf item4full = False Then

                item4type = cmbItemType.Text
                designer4 = cmbDesigner.Text
                item4name = cmbItemName.Text
                size4 = cmbSize.Text
                colour4 = txtColour.Text
                stock4 = stock
                item4price = price * quantity
                discount4 = discount
                quantity4 = quantity

                chkItem4.Text = cmbItemType.Text & ", " & cmbDesigner.Text & ", " & cmbItemName.Text & ", " & txtColour.Text & ", " & cmbSize.Text & ", " & txtPrice.Text & ", " & txtDiscount.Text & "%, " & stock & vbNewLine & txtQuantity.Text & "x £" & item4price
                chkItem4.Visible = True
                item4full = True
                clearTextbox()


            ElseIf item5full = False Then

                item5type = cmbItemType.Text
                designer5 = cmbDesigner.Text
                item5name = cmbItemName.Text
                size5 = cmbSize.Text
                colour5 = txtColour.Text
                stock5 = stock
                item5price = price * quantity
                discount5 = discount
                quantity5 = quantity


                chkItem5.Text = cmbItemType.Text & ", " & cmbDesigner.Text & ", " & cmbItemName.Text & ", " & txtColour.Text & ", " & cmbSize.Text & ", " & txtPrice.Text & ", " & txtDiscount.Text & "%, " & stock & vbNewLine & txtQuantity.Text & "x £" & item5price
                chkItem5.Visible = True
                item5full = True
                clearTextbox()

            ElseIf item6full = False Then

                item6type = cmbItemType.Text
                designer6 = cmbDesigner.Text
                item6name = cmbItemName.Text
                size6 = cmbSize.Text
                colour6 = txtColour.Text
                stock6 = stock
                item6price = price * quantity
                discount6 = discount
                quantity6 = quantity


                chkItem6.Text = cmbItemType.Text & ", " & cmbDesigner.Text & ", " & cmbItemName.Text & ", " & txtColour.Text & ", " & cmbSize.Text & ", " & txtPrice.Text & ", " & txtDiscount.Text & "%, " & stock & vbNewLine & txtQuantity.Text & "x £" & item6price
                chkItem6.Visible = True
                item6full = True
                clearTextbox()
            Else
                ' Display a message when maximum items (6) are reached
                MsgBox("Max items reached")
            End If
        End If

        ' Calculate total cost of all items  
        totalCost = item1price + item2price + item3price + item4price + item5price + item6price

        ' Display the total cost in the label  
        lblTotalCost.Text = totalCost


    End Sub

    Private Sub btnRemoveItem_Click(sender As Object, e As EventArgs) Handles btnRemoveItem.Click
        ' Check if each checkbox is checked
        If chkItem1.Checked Then
            ' Reset the checkbox and item details
            chkItem1.Checked = False
            chkItem1.Text = ""
            chkItem1.Visible = False
            item1full = False
            item1type = ""
            designer1 = ""
            item1name = ""
            size1 = ""
            colour1 = ""
            stock1 = ""
            item1price = 0
            discount1 = 0
            quantity1 = 0
        End If

        If chkItem2.Checked Then
            ' Reset the checkbox and item details
            chkItem2.Checked = False
            chkItem2.Text = ""
            chkItem2.Visible = False
            item2full = False
            item2type = ""
            designer2 = ""
            item2name = ""
            size2 = ""
            colour2 = ""
            stock2 = ""
            item2price = 0
            discount2 = 0
            quantity2 = 0
        End If

        If chkItem3.Checked Then
            ' Reset the checkbox and item details
            chkItem3.Checked = False
            chkItem3.Text = ""
            chkItem3.Visible = False
            item3full = False
            item3type = ""
            designer3 = ""
            item3name = ""
            size3 = ""
            colour3 = ""
            stock3 = ""
            item3price = 0
            discount3 = 0
            quantity3 = 0
        End If

        If chkItem4.Checked Then
            ' Reset the checkbox and item details
            chkItem4.Checked = False
            chkItem4.Text = ""
            chkItem4.Visible = False
            item4full = False
            item4type = ""
            designer4 = ""
            item4name = ""
            size4 = ""
            colour4 = ""
            stock4 = ""
            item4price = 0
            discount4 = 0
            quantity4 = 0
        End If

        If chkItem5.Checked Then
            ' Reset the checkbox and item details
            chkItem5.Checked = False
            chkItem5.Text = ""
            chkItem5.Visible = False
            item5full = False
            item5type = ""
            designer5 = ""
            item5name = ""
            size5 = ""
            colour5 = ""
            stock5 = ""
            item5price = 0
            discount5 = 0
            quantity5 = 0
        End If

        If chkItem6.Checked Then
            ' Reset the checkbox and item details
            chkItem6.Checked = False
            chkItem6.Text = ""
            chkItem6.Visible = False
            item6full = False
            item6type = ""
            designer6 = ""
            item6name = ""
            size6 = ""
            colour6 = ""
            stock6 = ""
            item6price = 0
            discount6 = 0
            quantity6 = 0
        End If

        ' Calculate the total cost of all items based on their prices
        totalCost = item1price + item2price + item3price + item4price + item5price + item6price
        ' Display the total cost in the label
        lblTotalCost.Text = totalCost
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ' Check if any of the items are filled
        If item1full Or item2full Or item3full Or item4full Or item5full Or item6full Then
            ' Check if the user is making a new sale
            If NewSaleCustomer.orderPageCheck = 1 Then
                ' Set the labels on the Payment page to display the item details
                Payment.lblItem1.Text = chkItem1.Text
                Payment.lblItem2.Text = chkItem2.Text
                Payment.lblItem3.Text = chkItem3.Text
                Payment.lblItem4.Text = chkItem4.Text
                Payment.lblItem5.Text = chkItem5.Text
                Payment.lblItem6.Text = chkItem6.Text
                ' Set the total cost in the Payment page
                Payment.lblTotal.Text = lblTotalCost.Text
                Payment.txtOrderTotal.Text = lblTotalCost.Text
                Payment.txtRemaining.Text = lblTotalCost.Text
                Payment.balance = CDec(lblTotalCost.Text)

                ' Reset the order page check flag and set the payment page flag
                NewSaleCustomer.orderPageCheck = 0
                paymentPageCheck = 1
                ' Hide the current form and show the Payment form

                Me.Hide()
                Payment.Show()

                ' If adding an order from past orders
            ElseIf PastOrders.addOrder = 1 Then
                ' Declare a variable to store the customer ID

                If Not String.IsNullOrEmpty(txtID.Text) AndAlso IsNumeric(txtID.Text) Then
                    ' If valid, convert the text input to an integer and store it in the bust variable
                    CustomerID = CInt(txtID.Text)
                End If


                ' Establish a connection to the database
                Dim connection As OleDbConnection = connectDatabase()
                connection.Open()

                ' Query to check if a customer exists in tblPayment using a parameterized query
                Dim findCustomerQuery As String = "SELECT CustomerID FROM tblDetails WHERE CustomerID = ?"
                Dim findCustomerCommand As New OleDbCommand(findCustomerQuery, connection)
                findCustomerCommand.Parameters.AddWithValue("?", OleDbType.Integer).Value = CustomerID ' Pass CustomerID as an integer parameter

                ' Execute the query to check if the customer exists
                Dim reader1 As OleDbDataReader = findCustomerCommand.ExecuteReader()
                If reader1.Read() Then ' If a record is found
                    Customerfound = True
                End If

                ' Check if the Customer ID is valid
                If Customerfound = True Then
                    ' Set the labels on the Payment page to display the item details
                    Payment.lblItem1.Text = chkItem1.Text
                    Payment.lblItem2.Text = chkItem2.Text
                    Payment.lblItem3.Text = chkItem3.Text
                    Payment.lblItem4.Text = chkItem4.Text
                    Payment.lblItem5.Text = chkItem5.Text
                    Payment.lblItem6.Text = chkItem6.Text
                    ' Set the total cost in the Payment page
                    Payment.lblTotal.Text = lblTotalCost.Text
                    Payment.txtOrderTotal.Text = lblTotalCost.Text
                    Payment.txtRemaining.Text = lblTotalCost.Text
                    Payment.balance = CDec(lblTotalCost.Text)

                    'Navigate to payment
                    Me.Hide()
                    Payment.Show()
                Else
                    ' Show a message if Customer ID is invalid
                    MsgBox("Enter a valid Customer ID")
                End If
            End If
        Else
            ' Show a message if no item has been added to the order
            MsgBox("Add an item to order")
        End If





    End Sub


End Class