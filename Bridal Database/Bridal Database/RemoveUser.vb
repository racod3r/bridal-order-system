Imports System.Data.OleDb

Public Class RemoveUser
    ' Stores the username entered by the user
    Public ExistingUsername As String
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        ' Assigns value in the username textbox to the variable
        ExistingUsername = txtUsernameRemove.Text
        ' Boolean variable to check if the user exists in the database
        Dim userAlreadyExists As Boolean = False

        ' SQL query to check if the username exists in the database
        Dim loginQuery As String = $"SELECT Username, Pass FROM tblLogin Where 'Username = {ExistingUsername}'"

        ' Establishes a connection to the database
        Dim connection As OleDbConnection = connectDatabase()

        ' Creates an OleDbCommand to execute the SQL query
        Dim command As New OleDbCommand(loginQuery, connection)

        ' Opens the database connection
        connection.Open()

        ' Executes the query and retrieves the data
        Dim reader As OleDbDataReader = command.ExecuteReader()

        ' Loops through the retrieved records
        While reader.Read()
            ' Checks if the username in the database matches the entered username
            If reader("Username") = ExistingUsername Then
                ' Sets the flag to True if the user exists
                userAlreadyExists = True
            End If
        End While


        ' Checks if the user does not exist and shows a message
        If userAlreadyExists = False Then
            MsgBox("User doesn't exist")
        Else
            ' If the user exists, hide the current form and show the Warning form
            If userAlreadyExists Then

                Me.Hide()
                Warning.Show()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Clears the username textbox
        txtUsernameRemove.Text = ""

        ' Hides the current form and shows the LoginPage form
        Me.Hide()
        LoginPage.Show()
    End Sub


End Class