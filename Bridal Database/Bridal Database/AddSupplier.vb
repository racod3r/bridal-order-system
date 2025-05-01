Imports ADODB
Imports System.Data.OleDb
Public Class AddSupplier

    ' Function to clear the input fields on the Add Supplier form
    Public Function addSupplierClear()
        ' Clears the text in each input field
        txtAddress.Clear()
        txtMail.Clear()
        txtPostcode.Clear()
        txtSupplier.Clear()
        txtTel.Clear()
    End Function

    ' Event handler for the Cancel button click event
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ' Clear the input fields before hiding the form and showing the Suppliers form again
        addSupplierClear()
        Me.Hide()
        Suppliers.Show()
    End Sub

    ' Event handler for the Next button click event
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ' Declare variables to store input values
        Dim supplier As String
        Dim phone As String
        Dim phoneWithoutSpaces As String
        Dim address As String
        Dim postcode As String
        Dim postcodeWithoutSpaces As String
        Dim mail As String

        ' Get values from the input fields
        supplier = txtSupplier.Text
        phone = txtTel.Text
        phoneWithoutSpaces = phone.Replace(" ", "") ' Remove spaces from phone number
        address = txtAddress.Text
        postcode = txtPostcode.Text
        postcodeWithoutSpaces = postcode.Replace(" ", "") ' Remove spaces from postcode
        mail = txtMail.Text

        ' Declare validation flags
        Dim phoneCheck As Boolean = True
        Dim postcodeCheck As Boolean = True
        Dim postcodeLengthCheck As Boolean = True
        Dim mailCheck As Boolean = False
        Dim emptyCheck As Boolean = True ' Flag to check if any required field is empty

        ' Validate phone number (must only contain digits)
        For Each ch As Char In phoneWithoutSpaces
            If Not (Char.IsDigit(ch)) Then
                phoneCheck = False
            End If
        Next

        ' Validate postcode (must only contain alphanumeric characters)
        For Each ch As Char In postcodeWithoutSpaces
            If Not (Char.IsLetterOrDigit(ch)) Then
                postcodeCheck = False
            End If
        Next

        ' Validate the length of the postcode (must be between 5 and 7 characters)
        If postcodeWithoutSpaces.Length < 5 OrElse postcodeWithoutSpaces.Length > 7 Then
            postcodeLengthCheck = False
        End If

        ' Validate email (must contain "@")
        For Each ch As Char In mail
            If ch = "@"c Then
                mailCheck = True
            End If
        Next

        ' Check if required fields are empty
        If supplier = ("") Then
            emptyCheck = False
        End If
        If phoneWithoutSpaces = ("") Then
            emptyCheck = False
        ElseIf phoneCheck = False Then
            MsgBox("Tel1 must only contain numbers") ' Show error message if phone number is invalid
        End If
        If address = ("") Then
            emptyCheck = False
        End If
        If postcodeWithoutSpaces = ("") Then
            emptyCheck = False
        ElseIf postcodeCheck = False Then
            MsgBox("Postcode must only contain letters and numbers") ' Show error message if postcode is invalid
        ElseIf postcodeLengthCheck = False Then
            MsgBox("Postcode must be between 5 and 7 characters") ' Show error message if postcode length is invalid
        End If
        If mail = ("") Then
            emptyCheck = False
        ElseIf mailCheck = False Then
            MsgBox("Enter a valid mail address") ' Show error message if email is invalid
        End If

        ' If any field is empty or invalid, show a message asking the user to fill in all fields
        If emptyCheck = False Then
            MsgBox("Please fill in all fields")
        End If

        ' If all validations pass, proceed to insert the new supplier into the database
        If emptyCheck And postcodeCheck And postcodeLengthCheck And phoneCheck And mailCheck Then
            ' Establish connection to the database
            Dim connection As OleDbConnection = connectDatabase()

            connection.Open()

            ' Prepare the SQL query to insert the new supplier into the database
            Dim insertDetailsQuery As String = "INSERT INTO tblSupplier (Supplier, Postcode, Address, Telephone, Mail) VALUES (@Supplier, @Postcode, @Address, @Telephone, @Mail)"

            ' Create a new OleDbCommand object to execute the query
            Dim newcommand As New OleDbCommand(insertDetailsQuery, connection)

            ' Add parameters to the command to prevent SQL injection
            newcommand.Parameters.AddWithValue("@Supplier", OleDbType.VarChar).Value = supplier
            newcommand.Parameters.AddWithValue("@Postcode", OleDbType.VarChar).Value = postcode
            newcommand.Parameters.AddWithValue("@Address", OleDbType.VarChar).Value = address
            newcommand.Parameters.AddWithValue("@Telephone", OleDbType.VarChar).Value = phone
            newcommand.Parameters.AddWithValue("@Mail", OleDbType.VarChar).Value = mail

            ' Execute the query to insert the supplier data into the database
            newcommand.ExecuteNonQuery()

            ' Clear the input fields and refresh the supplier data on the Suppliers form
            addSupplierClear()
            Suppliers.supplierrefresh()

            ' Hide the current form and show the Suppliers form
            Me.Hide()
            Suppliers.Show()

            ' Show a success message
            MsgBox("Supplier added successfully")
        End If
    End Sub
End Class