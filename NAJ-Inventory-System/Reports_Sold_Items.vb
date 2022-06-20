Imports System.Data.OleDb
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel

Public Class Reports_Sold_Items



    'Reload DataGridView Function
    Public Sub Reload_DataGridView()

        'Connection to data grid view
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Purchased_Report.accdb"
        Dim myconnection As OleDbConnection = New OleDbConnection
        Dim dbda As OleDbDataAdapter
        Dim dbds As DataSet
        Dim tables As DataTableCollection
        Dim source As New BindingSource
        myconnection = New OleDbConnection
        myconnection.ConnectionString = connString
        dbds = New DataSet
        tables = dbds.Tables
        dbda = New OleDbDataAdapter("Select * from [Purchased_Report]", myconnection)
        dbda.Fill(dbds, "Purchased_Report")
        Dim view As New DataView(tables(0))
        source.DataSource = view
        DataGridView1.DataSource = view
    End Sub








    'Get the Sum of Capital, Total Amount and Profit
    Public Sub GetReportSum()

        'Capital
        Dim Sum1 As Decimal = 0
        For i = 0 To DataGridView1.Rows.Count - 1
            Sum1 += DataGridView1.Rows(i).Cells(4).Value
        Next

        'Add Currency Format and replace dollar to peso
        CapitalSum.Text = FormatCurrency(Sum1).Replace("$", "₱")
        'Remove the last three char(".00")
        CapitalSum.Text = CapitalSum.Text.Remove(CapitalSum.Text.Length - 3)



        'Total Amount
        Dim Sum2 As Decimal = 0
        For i = 0 To DataGridView1.Rows.Count - 1
            Sum2 += DataGridView1.Rows(i).Cells(7).Value
        Next

        'Add Currency Format and replace dollar to peso
        Total_AmountSum.Text = FormatCurrency(Sum2).Replace("$", "₱")
        'Remove the last three char(".00")
        Total_AmountSum.Text = Total_AmountSum.Text.Remove(Total_AmountSum.Text.Length - 3)



        'Profit
        Dim Sum3 As Decimal = 0
        For i = 0 To DataGridView1.Rows.Count - 1
            Sum3 += DataGridView1.Rows(i).Cells(8).Value
        Next

        'Add Currency Format and replace dollar to peso
        ProfitSum.Text = FormatCurrency(Sum3).Replace("$", "₱")
        'Remove the last three char(".00")
        ProfitSum.Text = ProfitSum.Text.Remove(ProfitSum.Text.Length - 3)


    End Sub


    'Filter DataGridView By Date
    Public Sub filterByDate()
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Purchased_Report.accdb")

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        Dim dtdate1 As DateTime = DateTime.Parse(d1.Text)
        Dim dtdate2 As DateTime = DateTime.Parse(d2.Text)
        Dim cmd1 As OleDbCommand = New OleDbCommand("select ID,Account_Used,Invoicing,Sold_Items,Capital,NAJ_Selling_Price,Discount,Total_Amount,Profit,Date from Purchased_Report where Date between #" & dtdate1.ToString("MM/dd/yyyy") & "# and #" & dtdate2.ToString("MM/dd/yyyy") & "# order by Date desc", conn)

        Dim da As New OleDbDataAdapter
        da.SelectCommand = cmd1
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        DataGridView1.DataSource = dt
        conn.Close()


        'Get the Sum of Capital, Total Amount and Profit
        GetReportSum()

    End Sub





    'Report Form Load
    Private Sub Reports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_NAJ_DB___Purchased_ReportDataSet.Purchased_Report' table. You can move, or remove it, as needed.
        ' Me.Purchased_ReportTableAdapter.Fill(Me._NAJ_DB___Purchased_ReportDataSet.Purchased_Report)
        Reload_DataGridView()

        'Get the Sum of Capital, Total Amount and Profit
        GetReportSum()


        'DateTime Picker
        d1.Format = DateTimePickerFormat.Custom
        d1.CustomFormat = "MM/dd/yyyy"

        d2.Format = DateTimePickerFormat.Custom
        d2.CustomFormat = "MM/dd/yyyy"




    End Sub

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


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        'Set DataPicker DateTime to Format as only months
        Dim dt1 As DateTime = DateTime.Parse(d1.Text)
        Dim dt2 As DateTime = DateTime.Parse(d2.Text)


        ' -- Start confirmation for download

        If MessageBox.Show("Do you wanna download this report?", " NAJ - Reports", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then

            SaveFileDialog1.Filter = "Excel Documents|*.xlsx"
            SaveFileDialog1.FileName = "NAJ - Purchased_Report - " + DateTime.Now.ToString("MM-dd-yyyy_HH-mm-ss")

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

                MessageBox.Show("Purchased Report successfully converted!", "   NAJ - Reports", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' ---- Convert to excel end


            End If


        End If




    End Sub


    'Refresh button
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        'Restart Form
        Dim Reports As Form = Application.OpenForms("Reports")
        Reports = New Reports_Sold_Items
        Me.Close()
        Reports.Show()

    End Sub



    'DatePicker1 ValueChange
    Private Sub d1_ValueChanged(sender As Object, e As EventArgs) Handles d1.ValueChanged

        'Filter DataGridView By Date
        filterByDate()

    End Sub



    'DatePicker2 ValueChange
    Private Sub d2_ValueChanged(sender As Object, e As EventArgs) Handles d2.ValueChanged

        'Filter DataGridView By Date
        filterByDate()

    End Sub



    'ComboBox Text change
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged


        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Purchased_Report.accdb")

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        Dim cmd1 As New OleDbCommand("select * from Purchased_Report where Invoicing like '%" + ComboBox1.Text + "%'", conn)
        Dim da As New OleDbDataAdapter
        Dim dt As New DataTable

        da.SelectCommand = cmd1
        dt.Clear()
        da.Fill(dt)
        DataGridView1.DataSource = dt

        conn.Close()

        'Get the Sum of Capital, Total Amount and Profit
        GetReportSum()

    End Sub
End Class