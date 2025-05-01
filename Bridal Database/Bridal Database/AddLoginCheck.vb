Imports stdole
Imports System.Data.OleDb
Imports System.Diagnostics.Eventing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel


Public Class LoginCheck

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        'When pressed, if characters are hidden then they are revealed, or if revealed then they become hidden
        If txtPassword2.PasswordChar = "*" Then
            txtPassword2.PasswordChar = ""
        Else
            txtPassword2.PasswordChar = "*"
        End If
    End Sub



    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Get the inputted username and password from the textboxes and assign to variables
        Dim username As String = txtUsername2.Text
        Dim password As String = txtPassword2.Text

        ' SQL query to check if the credentials exist in the tblLogin table
        Dim loginQuery As String = $"SELECT Username, Pass, Access FROM tblLogin Where 'Username = {username} AND Pass = {password}'"


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
        ' Boolean flag to track if the matching user is an admin
        Dim adminCheck As Boolean = True

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


            If Found Then
                'If user exists check if the user is an admin
                If reader("Access") = "Basic" Then
                    adminCheck = False
                ElseIf reader("Access") = "Admin" Then
                    adminCheck = True
                End If
            Else
                'If doesnt exist display error message
                MsgBox("Username or Password incorrect")
            End If
            If adminCheck And Found Then
                ' Clear input fields
                txtUsername2.Text = ""
                txtPassword2.Text = ""

                'Check boolean flag and navigate to relevant form
                If LoginPage.AddCheck = 1 Then
                    Me.Hide()
                    AddUser.Show()
                ElseIf LoginPage.EditCheck = 1 Then
                    Me.Hide()
                    EditUser.Show()
                ElseIf LoginPage.RemoveCheck = 1 Then
                    Me.Hide()
                    RemoveUser.Show()
                End If

            ElseIf Found Then
                'Display message if user exists but isnt an admin
                MsgBox("Only Admins can access this feature")

                End If
            End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Clear fields and show login page
        txtUsername2.Clear()
        txtPassword2.Clear()
        LoginPage.txtPassword.Clear()
        LoginPage.txtUsername.Clear()
        Me.Hide()
        LoginPage.Show()
    End Sub


End Class