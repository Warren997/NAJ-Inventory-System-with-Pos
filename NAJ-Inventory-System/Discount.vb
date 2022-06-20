Imports System.Data.OleDb

Public Class Discount


    'Form Load
    Private Sub Discount_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'Add Currency Format and replace dollar to peso
        Label1.Text = FormatCurrency(POS.AmountText.Text).Replace("$", "₱")
        'Remove the last three char(".00")
        Label1.Text = Label1.Text.Remove(Label1.Text.Length - 3)


    End Sub



    'Discount TextBox change
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged


        If IsNumeric(TextBox1.Text) Then
            Label3.Text = Math.Ceiling(((TextBox1.Text / POS.AmountText.Text) * 100)) & "%"

            If Math.Ceiling((POS.AmountText.Text - TextBox1.Text) - POS.Capital.Text) <= 0 Then
                Label3.ForeColor = Color.Red
            Else
                Label3.ForeColor = Color.DodgerBlue
            End If
        ElseIf TextBox1.Text = "" Then
            TextBox1.Text = ""
        Else
            MessageBox.Show("Discount should be numbers only!", " NAJ - POS", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.Text.Length - 1)
        End If



    End Sub



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click


        'Check if ComboBox and TextBox has value
        If ComboBox1.Text = "" Or ComboBox1.Text = "" Then

            MessageBox.Show("Please make sure you add DR or SI!!", " NAJ - Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)

        ElseIf TextBox2.Text = "" Then

            MessageBox.Show("Please make sure you add invoincing number!!", " NAJ - Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)

        Else

            'If TextBox1 = "" the = 0
            If TextBox1.Text = "" Then
                TextBox1.Text = 0

            End If


            'Check if Dicount is Greater than Profit
            If (POS.AmountText.Text - TextBox1.Text) - POS.Capital.Text <= 0 Then
                MessageBox.Show("Lessen the customers discount because there is no Profit on this transaction!!", " NAJ - Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)

            Else


                '/--- Add MS Database --Start

                'Database Provider

                Dim myconnection As OleDbConnection = New OleDbConnection
                myconnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Purchased_Report.accdb"
                myconnection.Open()

                'Add Values to Purchased_Report Database
                Dim Cmd As OleDbCommand = New OleDbCommand("Insert into Purchased_Report([Account_Used],[Invoicing],[Sold_Items],[Capital],[NAJ_Selling_Price],[Discount],[Total_Amount],[Profit],[Date]) Values(?,?,?,?,?,?,?,?,?)", myconnection)
                Cmd.Parameters.Add(New OleDbParameter("Account_Used", CType(Inventory.Account_Used.Text, String)))
                Cmd.Parameters.Add(New OleDbParameter("Invoicing", CType(ComboBox1.Text & "#" & TextBox2.Text, String)))
                Cmd.Parameters.Add(New OleDbParameter("Sold_Items", CType(POS.Receipt.Text, String)))
                Cmd.Parameters.Add(New OleDbParameter("Capital", CType(POS.Capital.Text, String)))
                Cmd.Parameters.Add(New OleDbParameter("NAJ_Selling_Price", CType(POS.AmountText.Text, String)))
                Cmd.Parameters.Add(New OleDbParameter("Discount", CType(TextBox1.Text, String)))
                Cmd.Parameters.Add(New OleDbParameter("Total_Amount", CType(POS.AmountText.Text - TextBox1.Text, String)))
                Cmd.Parameters.Add(New OleDbParameter("Profit", CType((POS.AmountText.Text - TextBox1.Text) - POS.Capital.Text, String)))
                Cmd.Parameters.Add(New OleDbParameter("Date", CType(Date.Now, String)))

                Try
                    Cmd.ExecuteNonQuery()
                    Cmd.Dispose()
                    myconnection.Close()

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                '/--- End


                MessageBox.Show(POS.Receipt.Text, " NAJ - Purchased Report", MessageBoxButtons.OK, MessageBoxIcon.Information)


                'Reset TextBox
                POS.AmountText.Text = 0
                POS.Capital.Text = 0
                POS.Receipt.Text = ""

                TextBox1.Clear()


                Me.Close()


            End If


        End If








    End Sub



    'Invoicing TextChange
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged


        If IsNumeric(TextBox2.Text) Then
            'pass
        ElseIf TextBox2.Text = "" Then
            TextBox2.Text = ""
        Else
            MessageBox.Show("Invoicing should be numbers only!", " NAJ - POS", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            TextBox2.Text = TextBox2.Text.Substring(0, TextBox2.Text.Length - 1)
        End If


    End Sub


End Class