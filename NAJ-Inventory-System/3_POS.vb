Imports System.Data.OleDb


Public Class POS




    'Reload DataGridView Function
    Public Sub Reload_DataGridView()
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb"
        Dim Myconnection As OleDbConnection
        Dim dbda As OleDbDataAdapter
        Dim dbds As DataSet
        Dim tables As DataTableCollection
        Dim source As New BindingSource
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






    'ID Number TextChange
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        If IsNumeric(TextBox1.Text) Then




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





            'pass
        ElseIf TextBox1.Text = "" Then
            TextBox1.Text = ""
            Reload_DataGridView()
        Else
            MessageBox.Show("ID Number should be numbers only!", " NAJ - POS", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.Text.Length - 1)
        End If








    End Sub


    'Quantity TextChange
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If IsNumeric(TextBox2.Text) Then
            'pass
        ElseIf TextBox2.Text = "" Then
            TextBox2.Text = ""
        Else
            MessageBox.Show("Quantity should be numbers only!", " NAJ - POS", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            TextBox2.Text = TextBox2.Text.Substring(0, TextBox2.Text.Length - 1)
        End If
    End Sub


    'Next Button
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        'Check if TextBoxs has values
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("Please make sure input the ID and Quantity!", " NAJ - POS", MessageBoxButtons.OK, MessageBoxIcon.Hand)

        Else

            'Check if the ID is in Database
            Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb")
            Dim command As New OleDbCommand("SELECT [ID] FROM [Inventory] WHERE [IDField] = ID", connection)
            Dim IDParam As New OleDbParameter("ID", Me.TextBox1.Text)
            command.Parameters.Add(IDParam)
            command.Connection.Open()

            Dim reader As OleDbDataReader = command.ExecuteReader
            If Not reader.HasRows Then
                MessageBox.Show("ID is not in the database!", " NAJ - POS Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Else

                ' ----------- 1. Get all data needed in DB (Quantity, Part_Number, Suplier_Price,  Selling_Price, Total_Capital, Total_Revenue, Total_Profit)

                ' - Quantity
                Dim DB_Quantity As Integer
                Dim conn1 As New OleDbConnection
                conn1.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb")
                conn1.Open()
                Dim strsql1 As String
                Dim myReader1 As OleDbDataReader
                strsql1 = "Select Quantity From Inventory Where ID =" & TextBox1.Text & ""
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
                strsql2 = "Select Part_Number From Inventory Where ID =" & TextBox1.Text & ""
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
                strsql3 = "Select Supplier_Price From Inventory Where ID =" & TextBox1.Text & ""
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
                strsql4 = "Select Selling_Price From Inventory Where ID =" & TextBox1.Text & ""
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
                strsql5 = "Select Total_Capital From Inventory Where ID =" & TextBox1.Text & ""
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
                strsql6 = "Select Total_Revenue From Inventory Where ID =" & TextBox1.Text & ""
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
                strsql7 = "Select Total_Profit From Inventory Where ID =" & TextBox1.Text & ""
                Dim cmd7 As New OleDbCommand(strsql7, conn7)
                myReader7 = cmd7.ExecuteReader
                myReader7.Read()
                DB_Total_Profit = myReader7("Total_Profit")
                conn7.Close()


                ' - Item_Sold
                Dim DB_Item_Sold As Integer
                Dim conn12 As New OleDbConnection
                conn12.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb")
                conn12.Open()
                Dim strsql12 As String
                Dim myReader12 As OleDbDataReader
                strsql12 = "Select Item_Sold From Inventory Where ID =" & TextBox1.Text & ""
                Dim cmd12 As New OleDbCommand(strsql12, conn12)
                myReader12 = cmd12.ExecuteReader
                myReader12.Read()
                DB_Item_Sold = myReader12("Item_Sold")
                conn12.Close()


                ' ----------- 1 - End



                ' ----------- 1.5 Ask if they have discount






                ' ----------- 1.5 - End




                ' ----------- 2. Update DB Variables and Add values to AmountText and Receipt

                Dim Receipt_Price As String
                Receipt_Price = FormatCurrency(DB_Selling_Price * TextBox2.Text).Replace("$", "₱")
                Receipt_Price = Receipt_Price.Remove(Receipt_Price.Length - 3)



                AmountText.Text += DB_Selling_Price * TextBox2.Text
                Capital.Text += DB_Supplier_Price * TextBox2.Text
                Receipt.Text += TextBox2.Text + "  x  " + DB_Part_Number.ToString() + "  - - - - - - - - - - -  " + Receipt_Price + vbCrLf

                'Update => Quantity, Total_Capital, Total_Revenue, Total_Profit

                DB_Quantity -= TextBox2.Text
                DB_Total_Capital -= DB_Supplier_Price * TextBox2.Text
                DB_Total_Revenue -= DB_Selling_Price * TextBox2.Text
                DB_Total_Profit = DB_Total_Revenue - DB_Total_Capital
                DB_Item_Sold += TextBox2.Text


                ' ----------- 2 - End


                Discount.CapitalAmount.Text = Capital.Text



                ' ----------- 3. Update Database (Quantity, Total_Capital, Total_Revenue, Total_Profit) and Clear Textbox


                'Quantity
                Dim Myconnection8 As OleDbConnection
                Myconnection8 = New OleDbConnection
                Myconnection8.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb"
                Myconnection8.Open()
                Dim str8 As String
                str8 = "Update [Inventory] set [Quantity] = '" & DB_Quantity & "' Where ID =" & TextBox1.Text & ""
                Dim cmd8 As OleDbCommand = New OleDbCommand(str8, Myconnection8)
                Try
                    cmd8.ExecuteNonQuery()
                    cmd8.Dispose()
                    Myconnection8.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try


                'Total_Capital
                Dim Myconnection9 As OleDbConnection
                Myconnection9 = New OleDbConnection
                Myconnection9.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb"
                Myconnection9.Open()
                Dim str9 As String
                str9 = "Update [Inventory] set [Total_Capital] = '" & DB_Total_Capital & "' Where ID =" & TextBox1.Text & ""
                Dim cmd9 As OleDbCommand = New OleDbCommand(str9, Myconnection9)
                Try
                    cmd9.ExecuteNonQuery()
                    cmd9.Dispose()
                    Myconnection9.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try


                'Total_Revenue
                Dim Myconnection10 As OleDbConnection
                Myconnection10 = New OleDbConnection
                Myconnection10.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb"
                Myconnection10.Open()
                Dim str10 As String
                str10 = "Update [Inventory] set [Total_Revenue] = '" & DB_Total_Revenue & "' Where ID =" & TextBox1.Text & ""
                Dim cmd10 As OleDbCommand = New OleDbCommand(str10, Myconnection10)
                Try
                    cmd10.ExecuteNonQuery()
                    cmd10.Dispose()
                    Myconnection10.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try


                'Total_Profit
                Dim Myconnection11 As OleDbConnection
                Myconnection11 = New OleDbConnection
                Myconnection11.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb"
                Myconnection11.Open()
                Dim str11 As String
                str11 = "Update [Inventory] set [Total_Profit] = '" & DB_Total_Profit & "' Where ID =" & TextBox1.Text & ""
                Dim cmd11 As OleDbCommand = New OleDbCommand(str11, Myconnection11)
                Try
                    cmd11.ExecuteNonQuery()
                    cmd11.Dispose()
                    Myconnection11.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try


                'DB_Item_Sold
                Dim Myconnection13 As OleDbConnection
                Myconnection13 = New OleDbConnection
                Myconnection13.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb"
                Myconnection13.Open()
                Dim str13 As String
                str13 = "Update [Inventory] set [Item_Sold] = '" & DB_Item_Sold & "' Where ID =" & TextBox1.Text & ""
                Dim cmd13 As OleDbCommand = New OleDbCommand(str13, Myconnection13)
                Try
                    cmd13.ExecuteNonQuery()
                    cmd13.Dispose()
                    Myconnection13.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try


                'Clear Textbox
                TextBox1.Clear()
                TextBox2.Clear()


                ' ----------- 3 - End






                ' ----------- 4. Add Purchased transaction to Database - Purchased Report


            End If



        End If




    End Sub


    'Save Button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        Discount.Show()





    End Sub


    'Form Load
    Private Sub POS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reload_DataGridView()
    End Sub
End Class