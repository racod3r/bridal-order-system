Imports System.Data.OleDb

Public Class orderSearch
    ' Clears all input fields and resets selections
    Sub clearFields()
        txtID.Clear() ' Clear Customer ID text field
        cmbItemType.SelectedIndex = -1 ' Reset Item Type dropdown
        cmbDesigner.SelectedIndex = -1 ' Reset Designer dropdown
        cmbItemName.SelectedIndex = -1 ' Reset Item Name dropdown
        txtColour.Clear() ' Clear Colour text field
        cmbSize.SelectedIndex = -1 ' Reset Size dropdown
        radHire.Checked = False ' Uncheck Hire radio button
        radNot.Checked = False ' Uncheck Not Stock radio button
        radStock.Checked = False ' Uncheck Stock radio button
        txtMinPrice.Clear() ' Clear Min Price text field
        txtMaxPrice.Clear() ' Clear Max Price text field
        txtMinTotal.Clear() ' Clear Min Total field
        txtMaxTotal.Clear() ' Clear Max Total field
        txtMinDiscount.Clear() ' Clear Min Discount field
        txtMaxDiscount.Clear() ' Clear Max Discount field
        txtMinQuantity.Clear() ' Clear Min Quantity field
        txtMaxQuantity.Clear() ' Clear Max Quantity field
    End Sub

    ' Builds a dynamic query based on what fields the user has filled, and displays matching orders
    Sub orderFinder()
        ' Start with a basic true condition to make appending easier
        Dim query As String = "SELECT * FROM tblOrder WHERE 1=1"
        Dim parameters As New List(Of OleDbParameter) ' List to store parameters for safety

        ' Check if each search field is filled and adjust query accordingly

        If Not String.IsNullOrEmpty(txtID.Text) Then
            query &= " AND CustomerID LIKE ?" ' Partial match for CustomerID
            parameters.Add(New OleDbParameter("?", "%" & txtID.Text & "%"))
        End If

        If cmbItemType.SelectedIndex <> -1 Then
            query &= " AND ItemType = ?" ' Exact match for ItemType
            parameters.Add(New OleDbParameter("?", cmbItemType.SelectedItem.ToString()))
        End If

        If cmbDesigner.SelectedIndex <> -1 Then
            query &= " AND Designer = ?" ' Exact match for Designer
            parameters.Add(New OleDbParameter("?", cmbDesigner.SelectedItem.ToString()))
        End If

        If cmbItemName.SelectedIndex <> -1 Then
            query &= " AND ItemName = ?" ' Exact match for ItemName
            parameters.Add(New OleDbParameter("?", cmbItemName.SelectedItem.ToString()))
        End If

        If Not String.IsNullOrEmpty(txtColour.Text) Then
            query &= " AND Colour LIKE ?" ' Partial match for Colour
            parameters.Add(New OleDbParameter("?", "%" & txtColour.Text & "%"))
        End If

        If cmbSize.SelectedIndex <> -1 Then
            query &= " AND ItemSize = ?" ' Exact match for Size
            parameters.Add(New OleDbParameter("?", cmbSize.SelectedItem.ToString()))
        End If

        ' Handle radio button selections for Stock Status
        If radHire.Checked Then
            query &= " AND StockStatus = ?" ' Hire items only
            parameters.Add(New OleDbParameter("?", "Hire"))
        ElseIf radNot.Checked Then
            query &= " AND StockStatus = ?" ' Not Stock items only
            parameters.Add(New OleDbParameter("?", "Not Stock"))
        ElseIf radStock.Checked Then
            query &= " AND StockStatus = ?" ' In Stock items only
            parameters.Add(New OleDbParameter("?", "In Stock"))
        End If


        ' Filter by Item Price After Discount (price range) if minimum and maximum prices are provided
        If Not String.IsNullOrEmpty(txtMinPrice.Text) AndAlso Not String.IsNullOrEmpty(txtMaxPrice.Text) Then
            query &= " AND ItemPriceAD BETWEEN ? AND ?" ' Search for prices within the range
            parameters.Add(New OleDbParameter("?", Convert.ToDecimal(txtMinPrice.Text)))
            parameters.Add(New OleDbParameter("?", Convert.ToDecimal(txtMaxPrice.Text)))
            ' If only minimum price is given, filter for prices greater than or equal to it
        ElseIf Not String.IsNullOrEmpty(txtMinPrice.Text) Then
            query &= " AND ItemPriceAD >= ?"
            parameters.Add(New OleDbParameter("?", Convert.ToDecimal(txtMinPrice.Text)))
            ' If only maximum price is given, filter for prices less than or equal to it
        ElseIf Not String.IsNullOrEmpty(txtMaxPrice.Text) Then
            query &= " AND ItemPriceAD <= ?"
            parameters.Add(New OleDbParameter("?", Convert.ToDecimal(txtMaxPrice.Text)))
        End If

        ' Filter by TotalCost (total price range)
        If Not String.IsNullOrEmpty(txtMinTotal.Text) AndAlso Not String.IsNullOrEmpty(txtMaxTotal.Text) Then
            query &= " AND TotalCost BETWEEN ? AND ?" ' Search for total cost within the range
            parameters.Add(New OleDbParameter("?", Convert.ToDecimal(txtMinTotal.Text)))
            parameters.Add(New OleDbParameter("?", Convert.ToDecimal(txtMaxTotal.Text)))
            ' If only minimum total is given, filter for totals greater than or equal to it
        ElseIf Not String.IsNullOrEmpty(txtMinTotal.Text) Then
            query &= " AND TotalCost >= ?"
            parameters.Add(New OleDbParameter("?", Convert.ToDecimal(txtMinTotal.Text)))
            ' If only maximum total is given, filter for totals less than or equal to it
        ElseIf Not String.IsNullOrEmpty(txtMaxTotal.Text) Then
            query &= " AND TotalCost <= ?"
            parameters.Add(New OleDbParameter("?", Convert.ToDecimal(txtMaxTotal.Text)))
        End If

        ' Filter by Quantity (quantity range)
        If Not String.IsNullOrEmpty(txtMinQuantity.Text) AndAlso Not String.IsNullOrEmpty(txtMaxQuantity.Text) Then
            query &= " AND Quantity BETWEEN ? AND ?" ' Search for quantities within the range
            parameters.Add(New OleDbParameter("?", Convert.ToInt32(txtMinQuantity.Text)))
            parameters.Add(New OleDbParameter("?", Convert.ToInt32(txtMaxQuantity.Text)))
            ' If only minimum quantity is given, filter for quantities greater than or equal to it
        ElseIf Not String.IsNullOrEmpty(txtMinQuantity.Text) Then
            query &= " AND Quantity >= ?"
            parameters.Add(New OleDbParameter("?", Convert.ToInt32(txtMinQuantity.Text)))
            ' If only maximum quantity is given, filter for quantities less than or equal to it
        ElseIf Not String.IsNullOrEmpty(txtMaxQuantity.Text) Then
            query &= " AND Quantity <= ?"
            parameters.Add(New OleDbParameter("?", Convert.ToInt32(txtMaxQuantity.Text)))
        End If

        ' Filter by Discount (discount range)
        If Not String.IsNullOrEmpty(txtMinDiscount.Text) AndAlso Not String.IsNullOrEmpty(txtMaxDiscount.Text) Then
            query &= " AND Discount BETWEEN ? AND ?" ' Search for discounts within the specified range
            parameters.Add(New OleDbParameter("?", Convert.ToDecimal(txtMinDiscount.Text)))
            parameters.Add(New OleDbParameter("?", Convert.ToDecimal(txtMaxDiscount.Text)))
            ' If only minimum discount is provided, filter for discounts greater than or equal to it
        ElseIf Not String.IsNullOrEmpty(txtMinDiscount.Text) Then
            query &= " AND Discount >= ?"
            parameters.Add(New OleDbParameter("?", Convert.ToDecimal(txtMinDiscount.Text)))
            ' If only maximum discount is provided, filter for discounts less than or equal to it
        ElseIf Not String.IsNullOrEmpty(txtMaxDiscount.Text) Then
            query &= " AND Discount <= ?"
            parameters.Add(New OleDbParameter("?", Convert.ToDecimal(txtMaxDiscount.Text)))
        End If

        ' Create database connection and run the query
        Dim connection As OleDbConnection = connectDatabase()
        connection.Open()

        Dim command As New OleDbCommand(query, connection)
        command.Parameters.AddRange(parameters.ToArray()) ' Add all built parameters safely

        Dim adapter As New OleDbDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table) ' Fill a DataTable with the search results

        ' Show results in the PastOrders form's DataGridView
        PastOrders.dgvOrders.DataSource = table
    End Sub


    ' Go back to PastOrders form
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        PastOrders.Show()
    End Sub

    ' Clear fields button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        clearFields()
    End Sub

    Private Sub btnCustomerSearch_Click(sender As Object, e As EventArgs) Handles btnCustomerSearch.Click
        orderFinder() ' Run the search
        Me.Hide()
        PastOrders.Show() ' Show the past orders form
    End Sub



End Class