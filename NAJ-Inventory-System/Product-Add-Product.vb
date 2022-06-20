Imports System.Data.OleDb

Public Class Add_New_Product

    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim myconnection1 As OleDbConnection = New OleDbConnection

    'Provider
    Dim constring As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb"



    ' Get the last Id
    Public Sub GetLastId()
        Dim myreader As OleDbDataReader

        Dim conn1 As OleDbConnection = New OleDbConnection
        conn1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb"
        conn1.Open()

        'Get last ID from DB
        If conn1.State = ConnectionState.Closed Then
            conn1.Open()
        End If
        Dim strsql As String = "select ID from Inventory where ID=(select max(ID)from Inventory)"
        Dim cmd1 As New OleDbCommand(strsql, conn1)
        myreader = cmd1.ExecuteReader
        myreader.Read()



        Try
            TextBox4.Text = myreader("ID") + 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        conn1.Close()

    End Sub


    'Reload DataGridView Function
    Public Sub Reload_DataGridView()

        'Connection to data grid view
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





    'Get Item by Partnumber (ID, Supplier_Price, Selling_Price, Quantity)
    Public Sub GetOldItemsInDB()


        ' -- Start

        ' - Quantity
        Dim DB_Quantity As Integer
        Dim conn1 As New OleDbConnection
        conn1.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb")
        conn1.Open()
        Dim strsql1 As String
        Dim myReader1 As OleDbDataReader
        strsql1 = "Select Quantity From Inventory Where Part_Number like '%" + TextBox1.Text + "%' AND Description like '%" + TextBox2.Text + "%' AND Brand like '%" + TextBox3.Text + "%'"
        Dim cmd1 As New OleDbCommand(strsql1, conn1)
        myReader1 = cmd1.ExecuteReader
        myReader1.Read()
        DB_Quantity = myReader1("Quantity")
        conn1.Close()


        ' - ID
        Dim DB_ID As Integer
        Dim conn2 As New OleDbConnection
        conn2.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb")
        conn2.Open()
        Dim strsql2 As String
        Dim myReader2 As OleDbDataReader
        strsql2 = "Select ID From Inventory Where Part_Number like '%" + TextBox1.Text + "%' AND Description like '%" + TextBox2.Text + "%' AND Brand like '%" + TextBox3.Text + "%'"
        Dim cmd2 As New OleDbCommand(strsql2, conn2)
        myReader2 = cmd2.ExecuteReader
        myReader2.Read()
        DB_ID = myReader2("ID")
        conn2.Close()


        ' - Supplier_Price
        Dim DB_Supplier_Price As Integer
        Dim conn3 As New OleDbConnection
        conn3.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb")
        conn3.Open()
        Dim strsql3 As String
        Dim myReader3 As OleDbDataReader
        strsql3 = "Select Supplier_Price From Inventory Where Part_Number like '%" + TextBox1.Text + "%' AND Description like '%" + TextBox2.Text + "%' AND Brand like '%" + TextBox3.Text + "%'"
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
        strsql4 = "Select Selling_Price From Inventory Where Part_Number like '%" + TextBox1.Text + "%' AND Description like '%" + TextBox2.Text + "%' AND Brand like '%" + TextBox3.Text + "%'"
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
        strsql5 = "Select Total_Capital From Inventory Where Part_Number like '%" + TextBox1.Text + "%' AND Description like '%" + TextBox2.Text + "%' AND Brand like '%" + TextBox3.Text + "%'"
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
        strsql6 = "Select Total_Revenue From Inventory Where Part_Number like '%" + TextBox1.Text + "%' AND Description like '%" + TextBox2.Text + "%' AND Brand like '%" + TextBox3.Text + "%'"
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
        strsql7 = "Select Total_Profit From Inventory Where Part_Number like '%" + TextBox1.Text + "%' AND Description like '%" + TextBox2.Text + "%' AND Brand like '%" + TextBox3.Text + "%'"
        Dim cmd7 As New OleDbCommand(strsql7, conn7)
        myReader7 = cmd7.ExecuteReader
        myReader7.Read()
        DB_Total_Profit = myReader7("Total_Profit")
        conn7.Close()


        'Check if current Supplier price is the same 
        If TextBox6.Text <> DB_Supplier_Price Then
            'If you wanna update the price
            If MessageBox.Show("The previous Supplier price is ₱" + DB_Supplier_Price.ToString() + vbCrLf + vbCrLf + " Do you wanna update it?", " NAJ - Add Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then

                'Update using ID'
                myconnection = New OleDbConnection
                myconnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb"
                myconnection.Open()
                Dim str1 As String
                str1 = "Update [Inventory] set [Quantity] = '" & TextBox7.Text + DB_Quantity & "', [Supplier_Price] = '" & TextBox6.Text & "', [Selling_Price] = '" & Math.Ceiling((TextBox6.Text * 0.3) + TextBox6.Text) & "', [Total_Capital] = '" & TextBox6.Text * (TextBox7.Text + DB_Quantity) & "', [Total_Revenue] = '" & TextBox5.Text * (TextBox7.Text + DB_Quantity) & "', [Total_Profit] = '" & (TextBox5.Text * (TextBox7.Text + DB_Quantity)) - (TextBox6.Text * (TextBox7.Text + DB_Quantity)) & "' Where [ID] = " & DB_ID & ""
                Dim cmdx As OleDbCommand = New OleDbCommand(str1, myconnection)

                Try
                    cmdx.ExecuteNonQuery()
                    cmdx.Dispose()
                    myconnection.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            Else
                MessageBox.Show("If you don't want to update the Supplier price" + vbCrLf + vbCrLf + " Please use the Update Stock instead", " NAJ - Add Product", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End If


    End Sub



    'Save Button'
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        'Check if the Product is alredy in Database
        Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb")
        Dim command As New OleDbCommand("SELECT [ID] FROM [Inventory] WHERE [Part_NumberField] = Part_Number AND [DescriptionField] = Description AND [BrandField] = Brand", connection)

        Dim Part_NumberParam As New OleDbParameter("Part_Number", Me.TextBox1.Text)
        Dim DescriptionParam As New OleDbParameter("Description", Me.TextBox2.Text)
        Dim BrandParam As New OleDbParameter("Brand", Me.TextBox3.Text)
        command.Parameters.Add(Part_NumberParam)
        command.Parameters.Add(DescriptionParam)
        command.Parameters.Add(BrandParam)
        command.Connection.Open()
        Dim reader As OleDbDataReader = command.ExecuteReader


        'If Part_Number, Description, Brand is already in the database
        If reader.HasRows Then


            'Get Item by Partnumber (ID, Supplier_Price, Selling_Price, Quantity)
            GetOldItemsInDB()
            ' -- function end



            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox6.Clear()
            TextBox7.Clear()
        Else

            'Check if all textbox has value'
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox7.Text = "" Or TextBox6.Text = "" Then
                MessageBox.Show("Please make sure every textbox has input!", " NAJ - Add Product Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand)

            Else



                '/--- Add MS Database to Inventory --Start

                'Database Provider

                'Dim myconnection1 As OleDbConnection = New OleDbConnection
                myconnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb"
                myconnection.Open()

                'Add Values to Inventory Database
                Dim Cmd As OleDbCommand = New OleDbCommand("Insert into Inventory([Part_Number],[Description],[Brand],[Quantity],[Supplier_Price],[Selling_Price],[Total_Capital],[Total_Revenue],[Total_Profit]) Values(?,?,?,?,?,?,?,?,?)", myconnection)
                Cmd.Parameters.Add(New OleDbParameter("Part_Number", CType(TextBox1.Text, String)))
                Cmd.Parameters.Add(New OleDbParameter("Description", CType(TextBox2.Text, String)))
                Cmd.Parameters.Add(New OleDbParameter("Brand", CType(TextBox3.Text, String)))
                Cmd.Parameters.Add(New OleDbParameter("Quantity", CType(TextBox7.Text, String)))
                Cmd.Parameters.Add(New OleDbParameter("Supplier_Price", CType(TextBox6.Text, String)))
                Cmd.Parameters.Add(New OleDbParameter("Selling_Price", CType(TextBox5.Text, String)))
                Cmd.Parameters.Add(New OleDbParameter("Total_Capital", CType(TextBox7.Text * TextBox6.Text, String)))
                Cmd.Parameters.Add(New OleDbParameter("Total_Revenue", CType(TextBox7.Text * TextBox5.Text, String)))
                Cmd.Parameters.Add(New OleDbParameter("Total_Profit", CType((TextBox7.Text * TextBox5.Text) - (TextBox7.Text * TextBox6.Text), String)))

                Try
                    Cmd.ExecuteNonQuery()
                    Cmd.Dispose()
                    myconnection.Close()

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                '/--- End



                '/--- Add MS Database Add Product History --Start

                'Database Provider

                'Dim myconnection1 As OleDbConnection = New OleDbConnection
                myconnection1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Add_Product_History.accdb"
                myconnection1.Open()

                'Add Values to Inventory Database
                Dim Cmd1 As OleDbCommand = New OleDbCommand("Insert into Add_Product_History([Account_Used],[Part_Number],[Description],[Brand],[Quantity],[Supplier_Price],[Date_Added]) Values(?,?,?,?,?,?,?)", myconnection1)
                Cmd1.Parameters.Add(New OleDbParameter("Account_Used", CType(Inventory.Account_Used.Text, String)))
                Cmd1.Parameters.Add(New OleDbParameter("Part_Number", CType(TextBox1.Text, String)))
                Cmd1.Parameters.Add(New OleDbParameter("Description", CType(TextBox2.Text, String)))
                Cmd1.Parameters.Add(New OleDbParameter("Brand", CType(TextBox3.Text, String)))
                Cmd1.Parameters.Add(New OleDbParameter("Quantity", CType(TextBox7.Text, String)))
                Cmd1.Parameters.Add(New OleDbParameter("Supplier_Price", CType(TextBox6.Text, String)))
                Cmd1.Parameters.Add(New OleDbParameter("Date_Added", CType(DateTime.Now, String)))

                Try
                    Cmd1.ExecuteNonQuery()
                    Cmd1.Dispose()
                    myconnection1.Close()

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                '/--- End



                'Refresh the ID Number
                GetLastId()

                MessageBox.Show("Product successfully added!", " NAJ - Add Product", MessageBoxButtons.OK, MessageBoxIcon.Information)

                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox6.Clear()
                TextBox7.Clear()

            End If

        End If




    End Sub

    'Clear All
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox6.Clear()
        TextBox7.Clear()

    End Sub



    'Form Load
    Private Sub Add_New_Product_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        'Reload Data Grid 
        Reload_DataGridView()

        'Get last ID in DB
        GetLastId()
    End Sub


    'Seller Price Text Change
    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        If TextBox6.Text = "" Then
            TextBox5.Text = 0
            TextBox8.Text = 0

        End If

        If TextBox7.Text = "" Then
            TextBox7.Text = 0
        End If


        If IsNumeric(TextBox6.Text) Then
            'Selling Price formula
            TextBox5.Text = Math.Ceiling((TextBox6.Text * 0.3) + TextBox6.Text)
            TextBox8.Text = TextBox7.Text * TextBox5.Text

        ElseIf TextBox6.Text = "" Then
            'Pass
        Else
            MessageBox.Show("Supplier Price should only contain numbers!", " NAJ - Add Product", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            TextBox6.Text = TextBox6.Text.Substring(0, TextBox6.Text.Length - 1)
        End If




    End Sub

    'Quantity Text Change
    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        If TextBox5.Text = "" Then
            TextBox5.Text = 0
        End If


        If IsNumeric(TextBox7.Text) Then

            TextBox8.Text = TextBox7.Text * TextBox5.Text
        ElseIf TextBox7.Text = "" Then
            TextBox8.Text = 0
        Else
            MessageBox.Show("Quantity should only contain numbers!", " NAJ - Add Product", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            TextBox7.Text = TextBox7.Text.Substring(0, TextBox7.Text.Length - 1)
        End If
    End Sub


    'Part Number TextBox Changed -- Search to data grid view
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb")

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        Dim cmd1 As New OleDbCommand("select * from Inventory where Part_Number like '%" + TextBox1.Text + "%'", conn)
        Dim da As New OleDbDataAdapter
        Dim dt As New DataTable

        da.SelectCommand = cmd1
        dt.Clear()
        da.Fill(dt)
        DataGridView1.DataSource = dt

        conn.Close()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class