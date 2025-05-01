Imports System.Data.OleDb

Public Class LoginPage
    'Instantiates variables
    Public AddCheck As Integer = 0
    Public EditCheck As Integer = 0
    Public RemoveCheck As Integer = 0

    Sub clearUserPass()
        'Clears both fields
        txtPassword.Clear()
        txtUsername.Clear()
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Get the inputted username and password from the textboxes and assign to variables
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text



        ' SQL query to check if the credentials exist in the tblLogin table
        Dim loginQuery As String = $"SELECT Username, Pass FROM tblLogin Where 'Username = {username} AND Pass = {password}'"

        ' Establish a connection to the database
        Dim connection As OleDbConnection = connectDatabase()


        ' Create an OleDbCommand to execute the query
        Dim command As New OleDbCommand(loginQuery, connection)

        ' Open the database connection
        connection.Open()

        ' Execute the query and store the results in a data reader
        Dim reader As OleDbDataReader = command.ExecuteReader()

        ' Boolean flag to track if a matching record is found
        Dim Found As Boolean = False

        ' Validate user input before querying the database
        If username = "" And password = "" Then
            MsgBox("Please enter a username and password")
        ElseIf password = "" Then
            MsgBox("Please enter a password")
        ElseIf username = "" Then
            MsgBox("Please enter a username")
        Else
            ' Loop through the query results to check if the credentials match
            While reader.Read()
                If reader("Username") = username And reader("Pass") = password Then
                    Found = True
                    Exit While
                End If
            End While


            ' If a match is found, clear the username and password fields and proceed to the main menu
            If Found = True Then
                clearUserPass()
                Me.Hide()
                Main_Menu.Show()
            Else
                ' Display an error message if the credentials are incorrect
                MsgBox("Username or Password incorrect")
            End If


        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        'When pressed, if characters are hidden then they are revealed, or if revealed then they become hidden
        If txtPassword.PasswordChar = "*" Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        ' Set AddCheck to 1 and reset other action flags then show admin check form
        AddCheck = 1
        EditCheck = 0
        RemoveCheck = 0
        Main_Menu.newSaleCheck = 0
        clearUserPass()
        Me.Hide()
        LoginCheck.Show()

    End Sub

    Private Sub btnEditUser_Click(sender As Object, e As EventArgs) Handles btnEditUser.Click
        ' Set EditCheck to 1 and reset other action flags then show admin check form
        EditCheck = 1
        AddCheck = 0
        RemoveCheck = 0
        Main_Menu.newSaleCheck = 0
        clearUserPass()
        Me.Hide()
        LoginCheck.Show()
    End Sub

    Private Sub btnRemoveUser_Click(sender As Object, e As EventArgs) Handles btnRemoveUser.Click
        ' Set RemmoveCheck to 1 and reset other action flags then show admin check form
        RemoveCheck = 1
        AddCheck = 0
        EditCheck = 0
        Main_Menu.newSaleCheck = 0
        clearUserPass()
        Me.Hide()
        LoginCheck.Show()
    End Sub
End Class