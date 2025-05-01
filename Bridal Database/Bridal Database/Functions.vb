Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Module Functions
    'Makes a string that gives the program a path to connect to the database'
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\irfan\OneDrive - The Sixth Form Bolton\A level Computer Science\VB PROJECT\Bridal Database\Bridal Database\Bridal System Database1.accdb"


    'This function contains the code to manually connect to the database'
    Public Function connectDatabase() As OleDbConnection
        Return New OleDbConnection(connectionString)
    End Function



End Module
