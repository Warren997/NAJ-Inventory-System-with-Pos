Imports System.Data.OleDb

Public Class Login

   

    'Login Button'
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Inventory.Account_Used.Text = Me.TextBox1.Text

        'Check if the user is in Database
        Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb")
        Dim command As New OleDbCommand("SELECT [ID] FROM [Accounts] WHERE [NameField] = Name AND [PasswordField] = Password", connection)

        Dim usernameParam As New OleDbParameter("Name", Me.TextBox1.Text)
        Dim passwordParam As New OleDbParameter("Password", Me.TextBox2.Text)

        command.Parameters.Add(usernameParam)
        command.Parameters.Add(passwordParam)
        command.Connection.Open()

        Dim reader As OleDbDataReader = command.ExecuteReader
        If reader.HasRows Then
            Me.Hide()
            Inventory.Show()
        Else
            MessageBox.Show("Username and Password are not found!", " NAJ - Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            TextBox2.Text = ""
        End If
    End Sub



End Class
