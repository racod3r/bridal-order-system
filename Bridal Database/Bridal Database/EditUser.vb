Imports System.Data.OleDb

Public Class EditUser
    Sub clearEditUserFields()
        'Clears all the fields
        txtCurrentUser.Text = ""
        txtNewUserEdit.Text = ""
        txtNewPassEdit.Text = ""
        txtNewPassConfEdit.Text = ""
        cmbNewAccessLevel.Text = ""
        cmbNewAccessLevel.SelectedIndex = -1
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Clears fields and returns to login page
        clearEditUserFields()
        Me.Hide()
        LoginPage.Show()
    End Sub

    'Reveals new password
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        'When pressed, if characters are hidden then they are revealed, or if revealed then they become hidden
        If txtNewPassEdit.PasswordChar = "*" Then
            txtNewPassEdit.PasswordChar = ""
        Else
            txtNewPassEdit.PasswordChar = "*"
        End If
    End Sub

    'Reveals new password confirmation
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'When pressed, if characters are hidden then they are revealed, or if revealed then they become hidden
        If txtNewPassConfEdit.PasswordChar = "*" Then
            txtNewPassConfEdit.PasswordChar = ""
        Else
            txtNewPassConfEdit.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'Declares and assigns variables to inputs
        Dim CurrentUsername As String = txtCurrentUser.Text
        Dim NewUserEdit As String = txtNewUserEdit.Text
        Dim NewPassEdit As String = txtNewPassEdit.Text
        Dim NewPassEditConf As String = txtNewPassConfEdit.Text
        Dim NewUserAccess As String = cmbNewAccessLevel.Text

        'Boolean flags
        Dim userLengthCheck As Boolean = False  ' Checks if the username length is valid
        Dim userCheck As Boolean = False  ' Checks if the username meets all conditions
        Dim usernameSpecial As Integer = 0   ' Checks if the username contains a special character
        Dim passwordCheck As Boolean = False  ' Checks if the password length is valid
        Dim passwordSpecialCheck As Boolean = False  ' Checks if the password contains a special character
        Dim passwordNumCheck As Boolean = False  ' Checks if the password contains a number
        Dim accessCheck As Boolean = False  ' Checks if the access level is selected
        Dim userAlreadyExists As Boolean = False  ' Checks if the user exists in the database

        ' SQL query to find the user in the database
        Dim loginQuery As String = $"SELECT Username, Pass FROM tblLogin Where 'Username = {CurrentUsername}'"

        ' Establish a database connection
        Dim connection As OleDbConnection = connectDatabase()
        Dim command As New OleDbCommand(loginQuery, connection)

        ' Open the database connection
        connection.Open()

        ' Execute the query and retrieve data
        Dim reader As OleDbDataReader = command.ExecuteReader()

        ' Checks that an access level is selected
        If cmbNewAccessLevel.Text = "Admin" Or cmbNewAccessLevel.Text = "Basic" Then
            accessCheck = True
        End If
        ' Display a message if no access level is selected
        If accessCheck = False Then
            MsgBox("Select Access level")
        End If

        ' Check if the current username exists in the database
        While reader.Read()
            If reader("Username") = CurrentUsername Then
                userAlreadyExists = True
            End If
        End While

        ' Display a message if the user does not exist
        If userAlreadyExists = False Then
            MsgBox("User doesn't exist")
        Else
            ' Validate new username for special characters
            For Each ch As Char In NewUserEdit
                If Not (Char.IsLetterOrDigit(ch)) Then
                    usernameSpecial = usernameSpecial + 1
                End If
            Next

            ' Check username length and display message if needed
            If NewUserEdit.Length > 17 Then
                MsgBox("Username is maximum 16 characters")
            ElseIf NewUserEdit.Length < 5 Then
                MsgBox("Username is minimum 5 charachters")
            Else userLengthCheck = True
            End If

            ' Ensure username doesn't contain special characters
            If userLengthCheck = True Then
                If usernameSpecial > 0 Then
                    'Displays message if username contains special characters
                    MsgBox("Username mustn't contain special characters")
                Else userCheck = True
                End If
            End If


            ' Check if a password is entered 
            If NewPassEdit = "" Then
                'If not entered then display message
                MsgBox("Please enter a password")
            Else
                ' Check password for special characters and numbers
                For Each ch As Char In NewPassEdit
                    If Not (Char.IsLetterOrDigit(ch)) Then
                        passwordSpecialCheck = True
                    End If
                    If Char.IsDigit(ch) Then
                        passwordNumCheck = True
                    End If
                Next

                ' Check password length and display message if needed
                If NewPassEdit.Length > 20 Then
                    MsgBox("Password is maximum 20 characters")
                ElseIf NewPassEdit.Length < 8 Then
                    MsgBox("Password is minimum 8 charachters")
                Else passwordCheck = True
                End If

                ' Ensure password contains at least one number and one special character
                If passwordCheck = True Then
                    If passwordNumCheck = False Then
                        MsgBox("Password must contain a number")
                    End If

                    If passwordSpecialCheck = False Then
                        MsgBox("Password must contain a special character")
                    End If
                End If
            End If

            ' If all conditions are met, update user details in the database
            If passwordCheck And passwordNumCheck And passwordSpecialCheck And userAlreadyExists And userCheck And accessCheck Then
                'Check if passwords match before updating
                If txtNewPassEdit.Text = txtNewPassConfEdit.Text Then
                    ' SQL query to update the user details
                    Dim UpdateQuery As String = "UPDATE tblLogin SET Username = ?, Pass = ?, Access = ? WHERE Username = ? "
                    Dim newcommand As New OleDbCommand(UpdateQuery, connection)

                    ' Assign new values to the SQL parameters
                    newcommand.Parameters.AddWithValue("?", NewUserEdit)
                    newcommand.Parameters.AddWithValue("?", NewPassEdit)
                    newcommand.Parameters.AddWithValue("?", NewUserAccess)
                    newcommand.Parameters.AddWithValue("?", CurrentUsername)

                    ' Execute the update command
                    newcommand.ExecuteNonQuery()

                    ' Clear input fields and show confirmation message
                    clearEditUserFields()
                    MsgBox("User details successfully updated")

                    ' Hide the current form and return to the login page
                    Me.Hide()
                    LoginPage.Show()
                Else
                    ' Display an error if the passwords do not match
                    MsgBox("Passwords do not match")
                End If
            End If
        End If


    End Sub
End Class