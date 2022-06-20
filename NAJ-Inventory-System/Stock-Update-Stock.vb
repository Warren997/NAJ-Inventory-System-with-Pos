
Imports System.Data.OleDb

Public Class Stocks_Update_Stocks


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
        dbda = New OleDbDataAdapter("Select * from [Inventory]", Myconnection)
        dbda.Fill(dbds, "Inventory")
        Dim view As New DataView(tables(0))
        source.DataSource = view
        DataGridView1.DataSource = view
    End Sub



    'Load Form with DataGridView'
    Private Sub Stock_Stock_In_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Reload_DataGridView()
    End Sub





    'Add Button'
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If TextBox3.Text = "" Or TextBox4.Text = "" Then
            MessageBox.Show("Please input the ID and Quantity to update!", " NAJ - Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Else

            'Get DB Quantity
            Dim DB_Quantity As Integer
            Dim conn1 As New OleDbConnection
            conn1.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb")
            conn1.Open()
            Dim strsql1 As String
            Dim myReader1 As OleDbDataReader
            strsql1 = "Select Quantity From Inventory Where ID = " & TextBox3.Text & ""
            Dim cmd1 As New OleDbCommand(strsql1, conn1)
            myReader1 = cmd1.ExecuteReader
            myReader1.Read()
            DB_Quantity = myReader1("Quantity")
            conn1.Close()


            ' - Part_Number
            Dim DB_Part_Number As String
            Dim conn2 As New OleDbConnection
            conn2.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb")
            conn2.Open()
            Dim strsql2 As String
            Dim myReader2 As OleDbDataReader
            strsql2 = "Select Part_Number From Inventory Where ID = " & TextBox3.Text & ""
            Dim cmd2 As New OleDbCommand(strsql2, conn2)
            myReader2 = cmd2.ExecuteReader
            myReader2.Read()
            DB_Part_Number = myReader2("Part_Number")
            conn2.Close()


            ' - Supplier_Price
            Dim DB_Supplier_Price As Integer
            Dim conn3 As New OleDbConnection
            conn3.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb")
            conn3.Open()
            Dim strsql3 As String
            Dim myReader3 As OleDbDataReader
            strsql3 = "Select Supplier_Price From Inventory Where ID = " & TextBox3.Text & ""
            Dim cmd3 As New OleDbCommand(strsql3, conn3)
            myReader3 = cmd3.ExecuteReader
            myReader3.Read()
            DB_Supplier_Price = myReader3("Supplier_Price")
            conn3.Close()


            ' - Selling_Price
            Dim DB_Selling_Price As Integer
            Dim conn4 As New OleDbConnection
            conn4.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb")
            conn4.Open()
            Dim strsql4 As String
            Dim myReader4 As OleDbDataReader
            strsql4 = "Select Selling_Price From Inventory Where ID = " & TextBox3.Text & ""
            Dim cmd4 As New OleDbCommand(strsql4, conn4)
            myReader4 = cmd4.ExecuteReader
            myReader4.Read()
            DB_Selling_Price = myReader4("Selling_Price")
            conn4.Close()


            ' - Total_Capital
            Dim DB_Total_Capital As Integer
            Dim conn5 As New OleDbConnection
            conn5.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb")
            conn5.Open()
            Dim strsql5 As String
            Dim myReader5 As OleDbDataReader
            strsql5 = "Select Total_Capital From Inventory Where ID = " & TextBox3.Text & ""
            Dim cmd5 As New OleDbCommand(strsql5, conn5)
            myReader5 = cmd5.ExecuteReader
            myReader5.Read()
            DB_Total_Capital = myReader5("Total_Capital")
            conn5.Close()


            ' - Total_Revenue
            Dim DB_Total_Revenue As Integer
            Dim conn6 As New OleDbConnection
            conn6.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb")
            conn6.Open()
            Dim strsql6 As String
            Dim myReader6 As OleDbDataReader
            strsql6 = "Select Total_Revenue From Inventory Where ID = " & TextBox3.Text & ""
            Dim cmd6 As New OleDbCommand(strsql6, conn6)
            myReader6 = cmd6.ExecuteReader
            myReader6.Read()
            DB_Total_Revenue = myReader6("Total_Revenue")
            conn6.Close()


            ' - Total_Profit
            Dim DB_Total_Profit As Integer
            Dim conn7 As New OleDbConnection
            conn7.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb")
            conn7.Open()
            Dim strsql7 As String
            Dim myReader7 As OleDbDataReader
            strsql7 = "Select Total_Profit From Inventory Where ID = " & TextBox3.Text & ""
            Dim cmd7 As New OleDbCommand(strsql7, conn7)
            myReader7 = cmd7.ExecuteReader
            myReader7.Read()
            DB_Total_Profit = myReader7("Total_Profit")
            conn7.Close()



            ' Update DB_Variables
            DB_Quantity = TextBox4.Text + DB_Quantity
            DB_Total_Capital = DB_Quantity * DB_Supplier_Price
            DB_Total_Revenue = DB_Quantity * DB_Selling_Price
            DB_Total_Profit = DB_Total_Revenue - DB_Total_Capital


            'Update Inventory using ID
            Myconnection = New OleDbConnection
            Myconnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb"
            Myconnection.Open()
            Dim str1 As String
            str1 = "Update [Inventory] set [Quantity] = '" & DB_Quantity & "', [Total_Capital] = '" & DB_Total_Capital & "', [Total_Revenue] = '" & DB_Total_Revenue & "', [Total_Profit] = '" & DB_Total_Profit & "' Where ID = " & TextBox3.Text & ""

            Dim cmd8 As OleDbCommand = New OleDbCommand(str1, Myconnection)

            Try
                cmd8.ExecuteNonQuery()
                cmd8.Dispose()
                Myconnection.Close()
                'Read Again the DataGridView'
                Reload_DataGridView()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try



            ' -- Add to History Stock Quantity

            'Database Provider
            Dim myconnection2 As OleDbConnection = New OleDbConnection
            myconnection2.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Add_Stock_History.accdb"
            myconnection2.Open()

            'Add Values to Inventory Database
            Dim Cmd9 As OleDbCommand = New OleDbCommand("Insert into Add_Stock_History([Account_Used],[Part_Number],[Quantity_Added],[Date_Added]) Values(?,?,?,?)", myconnection2)
            Cmd9.Parameters.Add(New OleDbParameter("Account_Used", CType(Inventory.Account_Used.Text, String)))
            Cmd9.Parameters.Add(New OleDbParameter("Part_Number", CType(DB_Part_Number, String)))
            Cmd9.Parameters.Add(New OleDbParameter("Quantity_Added", CType(TextBox3.Text, String)))
            Cmd9.Parameters.Add(New OleDbParameter("Date_Added", CType(DateTime.Now, String)))

            Try
                Cmd9.ExecuteNonQuery()
                Cmd9.Dispose()
                myconnection2.Close()

                'Reset TextBox
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox3.Clear()

            Catch ex As Exception
                MsgBox(ex.Message)
                MsgBox("Transaction didn't record to history")


            End Try


            '/--- End Add to History Stock Quantity



        End If


        MessageBox.Show("Stock successfully added!", "   NAJ - Update Stocks", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Reload_DataGridView()

        'Reset TextBox
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()



    End Sub


    'Search Box when text changed Part Number'
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged


        If TextBox2.Text = "" Then
            'Read Again the DataGridView'
            Reload_DataGridView()
        Else
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
        End If



    End Sub

    'Search Box when text changed ID'
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged



        If TextBox3.Text = "" Then
            'Read Again the DataGridView'
            Reload_DataGridView()
        Else
            Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb")
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim cmd2 As New OleDbCommand("select * from Inventory where ID = " + TextBox3.Text + "", conn)
            Dim da As New OleDbDataAdapter
            Dim dt As New DataTable
            da.SelectCommand = cmd2
            dt.Clear()
            da.Fill(dt)
            DataGridView1.DataSource = dt
            conn.Close()
        End If




    End Sub


    'Deduct Button
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click



        If TextBox3.Text = "" Or TextBox4.Text = "" Then
            MessageBox.Show("Please input the ID and Quantity to update!", " NAJ - Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Else

            'Get DB Quantity
            Dim DB_Quantity As Integer
            Dim conn1 As New OleDbConnection
            conn1.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb")
            conn1.Open()
            Dim strsql1 As String
            Dim myReader1 As OleDbDataReader
            strsql1 = "Select Quantity From Inventory Where ID = " & TextBox3.Text & ""
            Dim cmd1 As New OleDbCommand(strsql1, conn1)
            myReader1 = cmd1.ExecuteReader
            myReader1.Read()
            DB_Quantity = myReader1("Quantity")
            conn1.Close()


            ' - Part_Number
            Dim DB_Part_Number As String
            Dim conn2 As New OleDbConnection
            conn2.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb")
            conn2.Open()
            Dim strsql2 As String
            Dim myReader2 As OleDbDataReader
            strsql2 = "Select Part_Number From Inventory Where ID = " & TextBox3.Text & ""
            Dim cmd2 As New OleDbCommand(strsql2, conn2)
            myReader2 = cmd2.ExecuteReader
            myReader2.Read()
            DB_Part_Number = myReader2("Part_Number")
            conn2.Close()


            ' - Supplier_Price
            Dim DB_Supplier_Price As Integer
            Dim conn3 As New OleDbConnection
            conn3.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb")
            conn3.Open()
            Dim strsql3 As String
            Dim myReader3 As OleDbDataReader
            strsql3 = "Select Supplier_Price From Inventory Where ID = " & TextBox3.Text & ""
            Dim cmd3 As New OleDbCommand(strsql3, conn3)
            myReader3 = cmd3.ExecuteReader
            myReader3.Read()
            DB_Supplier_Price = myReader3("Supplier_Price")
            conn3.Close()


            ' - Selling_Price
            Dim DB_Selling_Price As Integer
            Dim conn4 As New OleDbConnection
            conn4.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb")
            conn4.Open()
            Dim strsql4 As String
            Dim myReader4 As OleDbDataReader
            strsql4 = "Select Selling_Price From Inventory Where ID = " & TextBox3.Text & ""
            Dim cmd4 As New OleDbCommand(strsql4, conn4)
            myReader4 = cmd4.ExecuteReader
            myReader4.Read()
            DB_Selling_Price = myReader4("Selling_Price")
            conn4.Close()


            ' - Total_Capital
            Dim DB_Total_Capital As Integer
            Dim conn5 As New OleDbConnection
            conn5.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb")
            conn5.Open()
            Dim strsql5 As String
            Dim myReader5 As OleDbDataReader
            strsql5 = "Select Total_Capital From Inventory Where ID = " & TextBox3.Text & ""
            Dim cmd5 As New OleDbCommand(strsql5, conn5)
            myReader5 = cmd5.ExecuteReader
            myReader5.Read()
            DB_Total_Capital = myReader5("Total_Capital")
            conn5.Close()


            ' - Total_Revenue
            Dim DB_Total_Revenue As Integer
            Dim conn6 As New OleDbConnection
            conn6.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb")
            conn6.Open()
            Dim strsql6 As String
            Dim myReader6 As OleDbDataReader
            strsql6 = "Select Total_Revenue From Inventory Where ID = " & TextBox3.Text & ""
            Dim cmd6 As New OleDbCommand(strsql6, conn6)
            myReader6 = cmd6.ExecuteReader
            myReader6.Read()
            DB_Total_Revenue = myReader6("Total_Revenue")
            conn6.Close()


            ' - Total_Profit
            Dim DB_Total_Profit As Integer
            Dim conn7 As New OleDbConnection
            conn7.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb")
            conn7.Open()
            Dim strsql7 As String
            Dim myReader7 As OleDbDataReader
            strsql7 = "Select Total_Profit From Inventory Where ID = " & TextBox3.Text & ""
            Dim cmd7 As New OleDbCommand(strsql7, conn7)
            myReader7 = cmd7.ExecuteReader
            myReader7.Read()
            DB_Total_Profit = myReader7("Total_Profit")
            conn7.Close()


            'Deduct
            'Update DB_Variables
            DB_Quantity = DB_Quantity - TextBox4.Text
            DB_Total_Capital = DB_Quantity * DB_Supplier_Price
            DB_Total_Revenue = DB_Quantity * DB_Selling_Price
            DB_Total_Profit = DB_Total_Revenue - DB_Total_Capital


            'Update Inventory using ID
            Myconnection = New OleDbConnection
            Myconnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb"
            Myconnection.Open()
            Dim str1 As String
            str1 = "Update [Inventory] set [Quantity] = '" & DB_Quantity & "', [Total_Capital] = '" & DB_Total_Capital & "', [Total_Revenue] = '" & DB_Total_Revenue & "', [Total_Profit] = '" & DB_Total_Profit & "' Where ID = " & TextBox3.Text & ""

            Dim cmd8 As OleDbCommand = New OleDbCommand(str1, Myconnection)

            Try
                cmd8.ExecuteNonQuery()
                cmd8.Dispose()
                Myconnection.Close()
                'Read Again the DataGridView'
                Reload_DataGridView()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try



            ' -- Add to History Stock Quantity

            'Database Provider
            Dim myconnection2 As OleDbConnection = New OleDbConnection
            myconnection2.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Add_Stock_History.accdb"
            myconnection2.Open()

            'Add Values to Inventory Database
            Dim Cmd9 As OleDbCommand = New OleDbCommand("Insert into Add_Stock_History([Account_Used],[Part_Number],[Quantity_Added],[Date_Added]) Values(?,?,?,?)", myconnection2)
            Cmd9.Parameters.Add(New OleDbParameter("Account_Used", CType(Inventory.Account_Used.Text, String)))
            Cmd9.Parameters.Add(New OleDbParameter("Part_Number", CType(DB_Part_Number, String)))
            Cmd9.Parameters.Add(New OleDbParameter("Quantity_Added", CType(TextBox3.Text, String)))
            Cmd9.Parameters.Add(New OleDbParameter("Date_Added", CType(DateTime.Now, String)))

            Try
                Cmd9.ExecuteNonQuery()
                Cmd9.Dispose()
                myconnection2.Close()

                'Reset TextBox
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()

            Catch ex As Exception
                MsgBox(ex.Message)
                MsgBox("Transaction didn't record to history")


            End Try


            '/--- End Add to History Stock Quantity



        End If


        MessageBox.Show("Stock successfully deducted!", "   NAJ - Update Stocks", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Reload_DataGridView()

        'Reset TextBox
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox3.Clear()




    End Sub


End Class

