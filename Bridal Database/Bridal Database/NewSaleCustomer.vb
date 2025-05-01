Imports System.Data.OleDb

Public Class NewSaleCustomer
    ' Public variable used to check if the order page is open
    Public orderPageCheck = 0

    'Declared public variables that hold customer details
    Public firstName As String ' Stores the customer's first name
    Public surname As String ' Stores the customer's surname
    Public postcodeWithSpaces As String ' Stores the customer's postcode
    Public city As String ' Stores the customer's city
    Public address As String ' Stores the customer's address
    Public wedDate As DateTime ' Stores the wedding date selected by the customer
    Public bust As Integer ' Stores the bust measurement of the customer
    Public waist As Integer ' Stores the waist measurement of the customer
    Public hips As Integer ' Stores the hips measurement of the customer
    Dim tel1WithSpaces As String ' Stores the primary contact number of the customer
    Dim tel2WithSpaces As String ' Stores the secondary contact number of the customer
    Public mail As String ' Stores the customer's email address

    'Declared variables to hold input without spaces for special character checks
    Public postcode As String ' Stores the customer's postcode (without spaces)
    Public tel1 As String ' Stores the primary contact number of the customer (without spaces)
    Public tel2 As String ' Stores the secondary contact number of the customer (without spaces)


    Private Sub btnOrderSearch_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ' Check if a new sale is being created
        If Main_Menu.newSaleCheck = 1 Then
            'Show the warning page
            Me.Hide()
            Warning.Show()
            'Check if a the user is adding a customer
        ElseIf BrideDetails.addBride = 1 Then
            'Clears the fields and show the brides details page
            Warning.clearNewCustomerFields()
            Me.Hide()
            BrideDetails.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ' Initialize validation flags for different fields
        Dim firstNameCheck = True ' Flag for validating first name
        Dim surnameCheck = True ' Flag for validating surname
        Dim postcodeLengthCheck = True ' Flag for checking postcode length
        Dim postcodeCheck = True ' Flag for checking postcode format
        Dim cityCheck = True ' Flag for validating city 
        Dim tel1Check = True ' Flag for validating first telephone number
        Dim tel2Check = True ' Flag for validating second telephone number
        Dim mailCheck = False ' Flag for validating email 
        Dim bustCheck = True ' Flag for validating bust measurement
        Dim waistCheck = True ' Flag for validating waist measurement
        Dim hipsCheck = True ' Flag for validating hips measurement
        Dim emptyCheck = True ' Flag to check if any field is empty
        Dim wedDateCheck = False ' Flag for validating wedding date

        ' Check if the Bust text field is not empty and contains a numeric value
        If Not String.IsNullOrEmpty(txtBust.Text) AndAlso IsNumeric(txtBust.Text) Then
            ' If valid, convert the text input to an integer and store it in the bust variable
            bust = CInt(txtBust.Text)
        Else
            bustCheck = False
        End If
        ' Check if the Waist text field is not empty and contains a numeric value
        If Not String.IsNullOrEmpty(txtWaist.Text) AndAlso IsNumeric(txtWaist.Text) Then
            ' If valid, convert the text input to an integer and store it in the waist variable
            waist = CInt(txtWaist.Text)
        Else
            waistCheck = False
        End If

        ' Check if the Hips text field is not empty and contains a numeric value
        If Not String.IsNullOrEmpty(txtHips.Text) AndAlso IsNumeric(txtHips.Text) Then
            ' If valid, convert the text input to an integer and store it in the hips variable
            hips = CInt(txtHips.Text)
        Else
            hipsCheck = False
        End If

        ' Assign user input from text fields to corresponding variables
        firstName = txtFirstName.Text ' Store the entered first name
        surname = txtSurname.Text ' Store the entered surname
        postcodeWithSpaces = txtPostcode.Text ' Store the entered postcode
        city = txtCity.Text 'Store the entered city
        address = txtAddress.Text ' Store the entered address
        wedDate = dtpDate.Value.Date ' Store the selected wedding date
        tel1WithSpaces = txtTel1.Text ' Store the entered primary telephone number
        tel2WithSpaces = txtTel2.Text ' Store the entered secondary telephone number
        mail = txtMail.Text ' Store the entered email address

        'Remove spaces from inputs and store
        postcode = postcodeWithSpaces.Replace(" ", "") ' Remove spaces from the postcode for validation
        tel1 = tel1WithSpaces.Replace(" ", "") ' Remove spaces from primary telephone number for validation
        tel2 = tel2WithSpaces.Replace(" ", "") ' Remove spaces from secondary telephone number for validation

        ' Loop through each character in firstName to ensure it contains only letters
        For Each ch As Char In firstName
            If Not (Char.IsLetter(ch)) Then
                firstNameCheck = False
            End If
        Next

        ' Loop through each character in surname to ensure it contains only letters
        For Each ch As Char In surname
            If Not (Char.IsLetter(ch)) Then
                surnameCheck = False
            End If
        Next

        ' Loop through each character in city to ensure it contains only letters
        For Each ch As Char In city
            If Not (Char.IsLetter(ch)) Then
                cityCheck = False
            End If
        Next

        ' Loop through each character in postcode to ensure it only contains letters and digits
        For Each ch As Char In postcode
            If Not (Char.IsLetterOrDigit(ch)) Then
                postcodeCheck = False
            End If
        Next

        ' Check if postcode length is within the valid range (5 to 7 characters)
        If postcode.Length < 5 OrElse postcode.Length > 7 Then
            postcodeLengthCheck = False
        End If

        ' Loop through each character in tel1 to ensure it contains only numbers unless it is "N/A"
        If txtTel1.Text = "N/A" Then
            tel1Check = True
        Else
            For Each ch As Char In tel1
                If Not (Char.IsDigit(ch)) Then
                    tel1Check = False
                End If
            Next
        End If


        ' Loop through each character in tel2 to ensure it contains only numbers unless it is "N/A"
        If txtTel1.Text = "N/A" Then
            tel1Check = True
        Else
            For Each ch As Char In tel2
                If Not (Char.IsDigit(ch)) Then
                    tel2Check = False
                End If
            Next
        End If

        ' Check to ensure email contains '@' character 
        For Each ch As Char In mail
            If ch = "@"c Then
                mailCheck = True
            End If
        Next

        'Check that measurements are with a reasonable range and are numeric
        If Not IsNumeric(bust) Or bust < 0 Or bust > 100 Then
            bustCheck = False
        End If

        If Not IsNumeric(waist) Or waist < 0 Or waist > 100 Then
            waistCheck = False
        End If

        If Not IsNumeric(hips) Or hips < 0 Or hips > 100 Then
            hipsCheck = False
        End If

        ' Validate wedding date to ensure it is in the future
        If dtpDate.Value.Date = DateTime.Now.Date Or dtpDate.Value.Date < DateTime.Now.Date Then
            MsgBox("Enter a date/valid date")
            wedDateCheck = False
        Else
            wedDateCheck = True
        End If

        'Check if fields are empty and also displays messages if inputs are invalid
        If firstName = ("") Then
            emptyCheck = False
        ElseIf firstNameCheck = False Then
            MsgBox("First Name must only contain letters")
        End If
        If surname = ("") Then
            emptyCheck = False
        ElseIf surnameCheck = False Then
            MsgBox("Surname must only contain letters")
        End If
        If postcode = ("") Then
            emptyCheck = False
        ElseIf postcodeCheck = False Then
            MsgBox("Postcode must only contain letters and numbers")
        ElseIf postcodeLengthCheck = False Then
            MsgBox("Postcode must be between 5 and 7 characters")
        End If
        If city = ("") Then
            emptyCheck = False
        ElseIf cityCheck = False Then
            MsgBox("City must only contain letters")
        End If
        If tel1 = ("") Then
            emptyCheck = False
        ElseIf tel1Check = False Then
            MsgBox("Tel1 must only contain numbers")
        End If
        If tel2 = ("") Then
            emptyCheck = False
        ElseIf tel2Check = False Then
            MsgBox("Tel2 must only contain numbers")
        End If
        If mail = ("") Then
            emptyCheck = False
        ElseIf mailCheck = False Then
            MsgBox("Enter a valid mail address")
        End If
        If address = ("") Then
            emptyCheck = False
        End If
        If txtBust.Text = ("") Then
            emptyCheck = False
        ElseIf bustCheck = False Then
            MsgBox("Bust is not within valid range")
        End If
        If txtWaist.Text = ("") Then
            emptyCheck = False
        ElseIf waistCheck = False Then
            MsgBox("Waist is not within valid range")
        End If
        If txtHips.Text = ("") Then
            emptyCheck = False
        ElseIf hipsCheck = False Then
            MsgBox("Hips is not within valid range")
        End If

        'If any of the fields are empty then display message
        If emptyCheck = False Then
            MsgBox("Please fill in all fields")
        End If


        ' Check if all validation checks have passed
        If emptyCheck And firstNameCheck And surnameCheck And postcodeCheck And postcodeLengthCheck And cityCheck And tel1Check And tel2Check And mailCheck And bustCheck And waistCheck And hipsCheck And wedDateCheck Then
            ' Checks if the user is making a new sale 
            If Main_Menu.newSaleCheck = 1 Then
                'Reset the newSaleCheck flag, set the order page flag and navigate to the OrderPage
                Main_Menu.newSaleCheck = 0
                orderPageCheck = 1 'indicates that the user is on the order page
                Me.Hide()
                OrderPage.Show()
                ' Checks if the user is adding brides details
            ElseIf BrideDetails.addBride = 1 Then
                ' Establish a connection to the database
                Dim connection As OleDbConnection = connectDatabase()

                ' Open the database connection
                connection.Open()

                ' Define the SQL query to insert new bride details into the tblDetails table
                Dim insertDetailsQuery As String = "INSERT INTO tblDetails (FirstName, Surname, Postcode, City, Address, WedDate, Tel1, Tel2, Mail, Bust, Waist, Hips) VALUES (@FirstName, @Surname, @Postcode, @City, @Address, @WedDate, @Tel1, @Tel2, @Mail, @Bust, @Waist, @Hips)"

                ' Create a new command object with the query and connection
                Dim newcommand As New OleDbCommand(insertDetailsQuery, connection)

                ' Add parameters and pass values into the query
                newcommand.Parameters.AddWithValue("@FirstName", OleDbType.VarChar).Value = firstName
                newcommand.Parameters.AddWithValue("@Surname", OleDbType.VarChar).Value = surname
                newcommand.Parameters.AddWithValue("@Postcode", OleDbType.VarChar).Value = postcodeWithSpaces
                newcommand.Parameters.AddWithValue("@City", OleDbType.VarChar).Value = city
                newcommand.Parameters.AddWithValue("@Address", OleDbType.VarChar).Value = address
                newcommand.Parameters.AddWithValue("@WedDate", OleDbType.Date).Value = wedDate
                newcommand.Parameters.AddWithValue("@Tel1", OleDbType.VarChar).Value = tel1
                newcommand.Parameters.AddWithValue("@Tel2", OleDbType.VarChar).Value = tel2
                newcommand.Parameters.AddWithValue("@Mail", OleDbType.VarChar).Value = mail
                newcommand.Parameters.AddWithValue("@Bust", OleDbType.Integer).Value = bust
                newcommand.Parameters.AddWithValue("@Waist", OleDbType.Integer).Value = waist
                newcommand.Parameters.AddWithValue("@Hips", OleDbType.Integer).Value = hips


                ' Execute the SQL query to insert the data into tblDetails
                newcommand.ExecuteNonQuery()

                ' Clear input fields after successful entry
                Warning.clearNewCustomerFields()

                ' Display confirmation message
                MsgBox("Bride successfully added")

                ' Hide current form and return to the BrideDetails page
                Me.Hide()
                BrideDetails.Show()
            End If
        End If
    End Sub


End Class