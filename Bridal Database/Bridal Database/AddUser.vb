Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class AddUser

    Sub addUserClear()
        'Clears all fields
        txtPasswordAdd.Text = ""
        txtPasswordConfAdd.Text = ""
        txtUsernameAdd.Text = ""
        cmbAccessLevel.Text = ""
         cmbAccessLevel.SelectedIndex = -1
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'Declares and assigns variables to inputs
        Dim newUsername As String = txtUsernameAdd.Text
        Dim newPassword As String = txtPasswordAdd.Text
        Dim newAccessLevel As String = cmbAccessLevel.Text
        Dim newPasswordConf As String = txtPasswordConfAdd.Text

        'Boolean flags
        Dim usernameCheck As Boolean = False ' Checks if the username meets length requirements
        Dim usernameSpecial As Integer = 0 ' Checks for special characters in username
        Dim passwordCheck As Boolean = False ' Checks if the password meets length requirements
        Dim passwordSpecialCheck As Boolean = False ' Checks if the password contains a special character
        Dim passwordNumCheck As Boolean = False ' Checks if the password contains a number
        Dim accessCheck As Boolean = True ' Ensures the access level is valid
        Dim userDoesntExist As Boolean = True ' Flag to check if the username already exists

        ' Query to check if the username is already in the database
        Dim loginQuery As String = $"SELECT Username, Pass FROM tblLogin Where 'Username = {newUsername}'"

        ' Establish a connection to the database
        Dim connection As OleDbConnection = connectDatabase()
        Dim command As New OleDbCommand(loginQuery, connection)

        ' Open the database connection
        connection.Open()

        ' Execute the query to check if the username already exists
        Dim reader As OleDbDataReader = command.ExecuteReader()

        ' Checks access level is selected
        If Not (cmbAccessLevel.Text = "Admin" Or cmbAccessLevel.Text = "Basic") Then
            accessCheck = False
        End If
        If accessCheck = False Then
            'If not selected access level then displays message
            MsgBox("Select Access level")
        End If


        ' Check for special characters in username
        For Each ch As Char In newUsername
            If Not (Char.IsLetterOrDigit(ch)) Then
                usernameSpecial = usernameSpecial + 1
            End If
        Next

        ' Validate username length and display messages if invalid
        If newUsername.Length > 17 Then
            MsgBox("Username is maximum 16 characters")
        ElseIf newUsername.Length < 5 Then
            MsgBox("Username is minimum 5 charachters")
        Else usernameCheck = True
        End If

        ' Ensure username doesn't contain special characters 
        If usernameCheck = True Then
            If usernameSpecial > 0 Then
                'Displays message if contains special characters
                MsgBox("Username mustn't contain special characters")
            End If
        End If

        ' Check if the username already exists in the database
        While reader.Read()
            If reader("Username") = newUsername Then
                MsgBox("Username is already taken")
                userDoesntExist = False
            End If
        End While


        ' Validate password
        If newPassword = "" Then
            'If not entered password then display message
            MsgBox("Please enter a password")
        Else
            'Checks password contains number and special character
            For Each ch As Char In newPassword
                If Not (Char.IsLetterOrDigit(ch)) Then
                    passwordSpecialCheck = True
                End If
                If Char.IsDigit(ch) Then
                    passwordNumCheck = True
                End If
            Next

            ' Validate password length
            If newPassword.Length > 20 Then
                MsgBox("Password is maximum 20 characters")
            ElseIf newPassword.Length < 8 Then
                MsgBox("Password is minimum 8 charachters")
            Else passwordCheck = True
            End If

            ' Ensure password contains at least one number and one special character and displays message if not
            If passwordCheck = True Then
                If passwordNumCheck = False Then
                    MsgBox("Password must contain a number")
                End If

                If passwordSpecialCheck = False Then
                    MsgBox("Password must contain a special character")
                End If
            End If
        End If


        ' Check if all validation checks have passed before inserting the user into the database
        If passwordCheck And passwordNumCheck And passwordSpecialCheck And userDoesntExist And accessCheck Then

            ' Ensure the password confirmation matches the entered password
            If txtPasswordAdd.Text = txtPasswordConfAdd.Text Then
                ' Define an SQL query to insert the new user into the database
                Dim insertQuery As String = "INSERT INTO tblLogin (Username, Pass, Access) VALUES (@Username, @Pass, @Access)"
                Dim newcommand As New OleDbCommand(insertQuery, connection)

                ' Add parameters to the SQL command
                newcommand.Parameters.AddWithValue("@Username", newUsername)
                newcommand.Parameters.AddWithValue("@Pass", newPassword)
                newcommand.Parameters.AddWithValue("@Access", newAccessLevel)

                ' Execute the SQL query to insert the new user
                newcommand.ExecuteNonQuery()

                ' Clear input fields after successful insertion
                addUserClear()
                ' Notify the user that the account was created successfully
                MsgBox("User successfully added")

                ' Close the current form and return to the login page
                Me.Hide()
                LoginPage.Show()
            Else
                ' Show an error message if passwords do not match
                MsgBox("Passwords do not match")
            End If
        End If


    End Sub

    'Reveals Password
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        'When pressed, if characters are hidden then they are revealed, or if revealed then they become hidden
        If txtPasswordAdd.PasswordChar = "*" Then
            txtPasswordAdd.PasswordChar = ""
        Else
            txtPasswordAdd.PasswordChar = "*"
        End If
    End Sub

    'Reveals Password Confirmation
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'When pressed, if characters are hidden then they are revealed, or if revealed then they become hidden
        If txtPasswordConfAdd.PasswordChar = "*" Then
            txtPasswordConfAdd.PasswordChar = ""
        Else
            txtPasswordConfAdd.PasswordChar = "*"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Clears all fields and returns to login page
        addUserClear()

        Me.Hide()
        LoginPage.Show()
    End Sub


End Class