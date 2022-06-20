Imports System.Data.OleDb

Public Class Returned



    'Reload DataGridView Function
    Public Sub Reload_DataGridView()

        Dim myconnection As OleDbConnection = New OleDbConnection
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb"
        Dim dbda As OleDbDataAdapter
        Dim dbds As DataSet
        Dim tables As DataTableCollection
        Dim source As New BindingSource
        myconnection = New OleDbConnection
        myconnection.ConnectionString = connString
        dbds = New DataSet
        tables = dbds.Tables
        dbda = New OleDbDataAdapter("Select * from [Inventory]", myconnection)
        dbda.Fill(dbds, "Inventory")
        Dim view As New DataView(tables(0))
        source.DataSource = view
        DataGridView1.DataSource = view
    End Sub


    'Form Load
    Private Sub Returned_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reload_DataGridView()
    End Sub


    'Return Slip TextChange
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

        If IsNumeric(TextBox4.Text) Then
            'Pass

        ElseIf TextBox4.Text = "" Then
            TextBox4.Text = ""
        Else
            MessageBox.Show("Return Slip should be numbers only!", " NAJ - Returned", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            TextBox4.Text = TextBox4.Text.Substring(0, TextBox4.Text.Length - 1)
        End If

    End Sub


    'ID TextChange
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        If IsNumeric(TextBox1.Text) Then

            'Search by ID
            Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb")
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim cmd1 As New OleDbCommand("select * from Inventory where ID = " + TextBox1.Text + "", conn)
            Dim da As New OleDbDataAdapter
            Dim dt As New DataTable

            da.SelectCommand = cmd1
            dt.Clear()
            da.Fill(dt)
            DataGridView1.DataSource = dt
            conn.Close()
        ElseIf TextBox1.Text = "" Then
            TextBox1.Text = ""
            Reload_DataGridView()
        Else
            MessageBox.Show("ID Number should be numbers only!", " NAJ - Returned", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.Text.Length - 1)
        End If


    End Sub


    'Return Price TextChange
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

        If IsNumeric(TextBox3.Text) Then
            'pass
        ElseIf TextBox3.Text = "" Then
            TextBox3.Text = ""
        Else
            MessageBox.Show("Return Price should be numbers only!", " NAJ - Returned", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            TextBox3.Text = TextBox3.Text.Substring(0, TextBox3.Text.Length - 1)
        End If


    End Sub


    'Search by Part Number
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb")
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim cmd1 As New OleDbCommand("select * from Inventory where Part_Number like '%" + TextBox2.Text + "%'", conn)
        Dim da As New OleDbDataAdapter
        Dim dt As New DataTable

        da.SelectCommand = cmd1
        dt.Clear()
        da.Fill(dt)
        DataGridView1.DataSource = dt

        conn.Close()

    End Sub



    'Returned Button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Check if all textbox has input
        If TextBox4.Text = "" Or TextBox1.Text = "" Or TextBox3.Text = "" Or TextBox5.Text = "" Then
            MessageBox.Show("Please make sure all textbox has input!", " NAJ - Returned", MessageBoxButtons.OK, MessageBoxIcon.Hand)

        Else


            ' ---- Update Inventory Item Return


            ' - Item_Returned
            Dim DB_Item_Returned As Integer
            Dim conn1 As New OleDbConnection
            conn1.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb")
            conn1.Open()
            Dim strsql1 As String
            Dim myReader1 As OleDbDataReader
            strsql1 = "Select Item_Returned From Inventory Where ID =" & TextBox1.Text & ""
            Dim cmd1 As New OleDbCommand(strsql1, conn1)
            myReader1 = cmd1.ExecuteReader
            myReader1.Read()
            DB_Item_Returned = myReader1("Item_Returned")
            conn1.Close()


            'DB Variable Update
            DB_Item_Returned += TextBox5.Text


            'DB Update Item_Returned
            Dim Myconnection1 As OleDbConnection
            Myconnection1 = New OleDbConnection
            Myconnection1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb"
            Myconnection1.Open()
            Dim str1 As String
            str1 = "Update [Inventory] set [Item_Returned] = '" & DB_Item_Returned & "' Where ID =" & TextBox1.Text & ""
            Dim Cmd As OleDbCommand = New OleDbCommand(str1, Myconnection1)
            Try
                Cmd.ExecuteNonQuery()
                Cmd.Dispose()
                Myconnection1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try




            ' -- Add RS Record to Returned_Items DB



            ' Get Part_Number, Description, Brand to DB Return_items


            'DB Part_Number
            Dim DB_Part_Number As String
            Dim conn2 As New OleDbConnection
            conn2.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb")
            conn2.Open()
            Dim strsql2 As String
            Dim myReader2 As OleDbDataReader
            strsql2 = "Select Part_Number From Inventory Where ID =" & TextBox1.Text & ""
            Dim cmd2 As New OleDbCommand(strsql2, conn2)
            myReader2 = cmd2.ExecuteReader
            myReader2.Read()
            DB_Part_Number = myReader2("Part_Number")
            conn2.Close()


            'DB Description
            Dim DB_Description As String
            Dim conn3 As New OleDbConnection
            conn3.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb")
            conn3.Open()
            Dim strsql3 As String
            Dim myReader3 As OleDbDataReader
            strsql3 = "Select Description From Inventory Where ID =" & TextBox1.Text & ""
            Dim cmd3 As New OleDbCommand(strsql3, conn3)
            myReader3 = cmd3.ExecuteReader
            myReader3.Read()
            DB_Description = myReader3("Description")
            conn3.Close()


            'DB Brand
            Dim DB_Brand As String
            Dim conn4 As New OleDbConnection
            conn4.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb")
            conn4.Open()
            Dim strsql4 As String
            Dim myReader4 As OleDbDataReader
            strsql4 = "Select Brand From Inventory Where ID =" & TextBox1.Text & ""
            Dim cmd4 As New OleDbCommand(strsql4, conn4)
            myReader4 = cmd4.ExecuteReader
            myReader4.Read()
            DB_Brand = myReader4("Brand")
            conn4.Close()




            '/--- Add MS Database to Inventory --Start

            'Database Provider

            Dim myconnection As OleDbConnection = New OleDbConnection
            myconnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Returned_Items.accdb"
            myconnection.Open()

            'Add Values to Inventory Database
            Dim Cmdx As OleDbCommand = New OleDbCommand("Insert into Returned_Items([Returned_Slip],[Product_ID],[Part_Number],[Description],[Brand],[Returned_Price],[Quantity],[Returned_Date]) Values(?,?,?,?,?,?,?,?)", myconnection)
            Cmdx.Parameters.Add(New OleDbParameter("Returned_Slip", CType("#" & TextBox4.Text, String)))
            Cmdx.Parameters.Add(New OleDbParameter("Product_ID", CType(TextBox1.Text, String)))
            Cmdx.Parameters.Add(New OleDbParameter("Part_Number", CType(DB_Part_Number, String)))
            Cmdx.Parameters.Add(New OleDbParameter("Description", CType(DB_Description, String)))
            Cmdx.Parameters.Add(New OleDbParameter("Brand", CType(DB_Brand, String)))
            Cmdx.Parameters.Add(New OleDbParameter("Returned_Price", CType(TextBox3.Text, String)))
            Cmdx.Parameters.Add(New OleDbParameter("Quantity", CType(TextBox5.Text, String)))
            Cmdx.Parameters.Add(New OleDbParameter("Returned_Date", CType(DateTime.Now, String)))


            Try
                Cmdx.ExecuteNonQuery()
                Cmdx.Dispose()
                myconnection.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            '/--- End


            'Success Messege
            MessageBox.Show("Return items successfully returned and recorded!", " NAJ - Returned", MessageBoxButtons.OK, MessageBoxIcon.Information)



            'Clear Text
            TextBox4.Clear()
            TextBox1.Clear()
            TextBox3.Clear()
            TextBox5.Clear()



        End If








    End Sub


    'Quantity TextChange
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

        If IsNumeric(TextBox5.Text) Then
            'pass
        ElseIf TextBox5.Text = "" Then
            TextBox5.Text = ""
        Else
            MessageBox.Show("Quantity should be numbers only!", " NAJ - Returned", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            TextBox5.Text = TextBox5.Text.Substring(0, TextBox5.Text.Length - 1)
        End If

    End Sub
End Class