Imports System.Data.OleDb
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel


Public Class Reports_Inventory

    'Reload DataGridView Function
    Public Sub Reload_DataGridView()

        'Connection to data grid view
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb"
        Dim myconnection As OleDbConnection = New OleDbConnection
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
    Private Sub Reports_Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reload_DataGridView()

        'Get Total Amounts
        GetReportSum()
    End Sub






    'Get the Sum of Capital, Total Amount and Profit
    Public Sub GetReportSum()

        'Capital
        Dim Sum1 As Decimal = 0
        For i = 0 To DataGridView1.Rows.Count - 1
            Sum1 += DataGridView1.Rows(i).Cells(7).Value
        Next

        'Add Currency Format and replace dollar to peso
        CapitalSum.Text = FormatCurrency(Sum1).Replace("$", "₱")
        'Remove the last three char(".00")
        CapitalSum.Text = CapitalSum.Text.Remove(CapitalSum.Text.Length - 3)



        'Total Amount
        Dim Sum2 As Decimal = 0
        For i = 0 To DataGridView1.Rows.Count - 1
            Sum2 += DataGridView1.Rows(i).Cells(8).Value
        Next

        'Add Currency Format and replace dollar to peso
        Total_AmountSum.Text = FormatCurrency(Sum2).Replace("$", "₱")
        'Remove the last three char(".00")
        Total_AmountSum.Text = Total_AmountSum.Text.Remove(Total_AmountSum.Text.Length - 3)



        'Profit
        Dim Sum3 As Decimal = 0
        For i = 0 To DataGridView1.Rows.Count - 1
            Sum3 += DataGridView1.Rows(i).Cells(9).Value
        Next

        'Add Currency Format and replace dollar to peso
        ProfitSum.Text = FormatCurrency(Sum3).Replace("$", "₱")
        'Remove the last three char(".00")
        ProfitSum.Text = ProfitSum.Text.Remove(ProfitSum.Text.Length - 3)



        'Individual Items 
        Dim Sum4 As Decimal = 0
        For i = 0 To DataGridView1.Rows.Count - 1
            Sum4 += DataGridView1.Rows(i).Cells(4).Value
        Next


        'Add Currency Format and replace dollar to blank
        InvItems.Text = FormatCurrency(Sum4).Replace("$", "")
        'Remove the last three char(".00")
        InvItems.Text = InvItems.Text.Remove(InvItems.Text.Length - 3) & " Items"



        'Item Types
        Dim Count As Integer = 0
        Count = DataGridView1.Rows.Count



        'Add Currency Format and replace dollar to blank
        ItemTypes.Text = FormatCurrency(Count - 1).Replace("$", "")
        'Remove the last three char(".00")
        ItemTypes.Text = ItemTypes.Text.Remove(ItemTypes.Text.Length - 3) & " Types"


    End Sub



    'For convertion of excel
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub



    'Download Excel
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        SaveFileDialog1.Filter = "Excel Documents|*.xlsx"
        SaveFileDialog1.FileName = "NAJ - Inventory_Report - " + DateTime.Now.ToString("MM-dd-yyyy_HH-mm-ss")

        'Ask for file location
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then

            Loading.Show()


            ' ---- Convert Data grid view to Excel

            Dim xlApp As Microsoft.Office.Interop.Excel.Application
            Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
            Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value
            Dim i As Integer
            Dim j As Integer

            xlApp = New Microsoft.Office.Interop.Excel.Application
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.Sheets("sheet1")

            For i = 0 To DataGridView1.RowCount - 2
                For j = 0 To DataGridView1.ColumnCount - 1
                    For k As Integer = 1 To DataGridView1.Columns.Count
                        xlWorkSheet.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText
                        xlWorkSheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()
                    Next
                Next
            Next

            xlWorkSheet.SaveAs(SaveFileDialog1.FileName)
            xlWorkBook.Close()
            xlApp.Quit()

            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)

            Loading.Close()

            MessageBox.Show("Inventory successfully download!", "   NAJ - Reports", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' ---- Convert to excel end


        End If
    End Sub

    'Search by Description
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb")

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        Dim cmd1 As New OleDbCommand("select * from Inventory where Description like '%" + TextBox1.Text + "%'", conn)
        Dim da As New OleDbDataAdapter
        Dim dt As New DataTable

        da.SelectCommand = cmd1
        dt.Clear()
        da.Fill(dt)
        DataGridView1.DataSource = dt

        conn.Close()

        'Get Total Amounts
        GetReportSum()

    End Sub



End Class