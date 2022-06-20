Imports System.Data.OleDb

Public Class Accounts


    'Connection
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb"
    Dim Myconnection As OleDbConnection
    Dim dbda As OleDbDataAdapter
    Dim dbds As DataSet
    Dim tables As DataTableCollection
    Dim source As New BindingSource

    'For Update
    Dim provider As String
    Dim datafile As String



    'Reload DataGridView Function
    Public Sub Reload_DataGridView()
        Myconnection = New OleDbConnection
        Myconnection.ConnectionString = connString
        dbds = New DataSet
        tables = dbds.Tables
        dbda = New OleDbDataAdapter("Select [ID],[Name],[Position] from [Accounts]", Myconnection)
        dbda.Fill(dbds, "Accounts")
        Dim view As New DataView(tables(0))
        source.DataSource = view
        DataGridView1.DataSource = view
    End Sub

    'Load Form'
    Private Sub Accounts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Reload_DataGridView()
    End Sub

    'Add Account Button'
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim myconnection As OleDbConnection = New OleDbConnection


        'Database Provider
        myconnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb"
        myconnection.Open()

        

        If TextBox3.Text <> "Admin" Then
            'Add Values to Account Database
            Dim Cmd As OleDbCommand = New OleDbCommand("Insert into Accounts([Name],[Password],[Position]) Values(?,?,?)", myconnection)
            Cmd.Parameters.Add(New OleDbParameter("Name", CType(TextBox1.Text, String)))
            Cmd.Parameters.Add(New OleDbParameter("Password", CType(TextBox2.Text, String)))
            Cmd.Parameters.Add(New OleDbParameter("Position", CType(TextBox3.Text, String)))

            Try
                Cmd.ExecuteNonQuery()
                Cmd.Dispose()
                myconnection.Close()


                'Reload DataGridView
                Reload_DataGridView()


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            '/--- End

        Else

            'Add Values to Account_Admin Database
            Dim Cmd As OleDbCommand = New OleDbCommand("Insert into Accounts_Admin([Name],[Password]) Values(?,?)", myconnection)
            Cmd.Parameters.Add(New OleDbParameter("Name", CType(TextBox1.Text, String)))
            Cmd.Parameters.Add(New OleDbParameter("Password", CType(TextBox2.Text, String)))


            Try
                Cmd.ExecuteNonQuery()
                Cmd.Dispose()



                'Reload DataGridView
                Reload_DataGridView()


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            '/--- End Account_Admin



            'Add Values to Account Database
            Dim Cmd1 As OleDbCommand = New OleDbCommand("Insert into Accounts([Name],[Password],[Position]) Values(?,?,?)", myconnection)
            Cmd1.Parameters.Add(New OleDbParameter("Name", CType(TextBox1.Text, String)))
            Cmd1.Parameters.Add(New OleDbParameter("Password", CType(TextBox2.Text, String)))
            Cmd1.Parameters.Add(New OleDbParameter("Position", CType(TextBox3.Text, String)))

            Try
                Cmd1.ExecuteNonQuery()
                Cmd1.Dispose()
                myconnection.Close()

                'Reload DataGridView
                Reload_DataGridView()


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            '/--- End Account_Admin


        End If



        'Reset TextBox
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        

    End Sub

    'Delete Button'
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb")
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If TextBox4.Text = "" Or Not IsNumeric(TextBox4.Text) Then
            MessageBox.Show("ID Input is Invalid", " NAJ - Delete Account", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Else
            Dim cmd As New OleDbCommand("Delete from Accounts where ID=@ID", conn)
            cmd.Parameters.AddWithValue("@ID", TextBox4.Text)
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Account successfully deleted!", " NAJ - Accounts", MessageBoxButtons.OK)
            TextBox4.Clear()
            Reload_DataGridView()
        End If


        

    End Sub
End Class