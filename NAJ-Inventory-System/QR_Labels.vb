Imports System.Data.OleDb
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel


Public Class QR_Labels


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


    Public Sub Reload_DataGridView_QRLables()
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - QR_Labels.accdb"
        Dim Myconnection As OleDbConnection
        Dim dbda As OleDbDataAdapter
        Dim dbds As DataSet
        Dim tables As DataTableCollection
        Dim source As New BindingSource
        Myconnection = New OleDbConnection
        Myconnection.ConnectionString = connString
        dbds = New DataSet
        tables = dbds.Tables
        dbda = New OleDbDataAdapter("Select * from [QR_Labels]", Myconnection)
        dbda.Fill(dbds, "QR_Labels")
        Dim view As New DataView(tables(0))
        source.DataSource = view
        DataGridView2.DataSource = view
    End Sub



    'Items to QR_Label DB
    Public Sub AddToQrLabelDB()



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


        ' Add Peso to Price and remove decimals
        Dim QR_Label_Price As String
        QR_Label_Price = FormatCurrency(DB_Selling_Price).Replace("$", "₱")
        QR_Label_Price = QR_Label_Price.Remove(QR_Label_Price.Length - 3)

        'Rows of Labels
        Dim DbColumn As Integer
        DbColumn = Math.Ceiling(TextBox2.Text / 3)
        DbColumn -= 1


        While DbColumn >= 0

            'Provider
            Dim myconnection As OleDbConnection = New OleDbConnection
            myconnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - QR_Labels.accdb"
            myconnection.Open()


            'Add Values to Account Database
            Dim Cmd As OleDbCommand = New OleDbCommand("Insert into QR_Labels([Label_1],[QR_1],[Label_2],[QR_2],[Label_3],[QR_3]) Values(?,?,?,?,?,?)", myconnection)
            Cmd.Parameters.Add(New OleDbParameter("Label_1", CType(DB_Part_Number + vbCrLf + QR_Label_Price, String)))
            Cmd.Parameters.Add(New OleDbParameter("QR_1", CType("*" + TextBox2.Text + "*", String)))
            Cmd.Parameters.Add(New OleDbParameter("Label_2", CType(DB_Part_Number + vbCrLf + QR_Label_Price, String)))
            Cmd.Parameters.Add(New OleDbParameter("QR_2", CType("*" + TextBox2.Text + "*", String)))
            Cmd.Parameters.Add(New OleDbParameter("Label_3", CType(DB_Part_Number + vbCrLf + QR_Label_Price, String)))
            Cmd.Parameters.Add(New OleDbParameter("QR_3", CType("*" + TextBox2.Text + "*", String)))

            DbColumn -= 1

            Try
                Cmd.ExecuteNonQuery()
                Cmd.Dispose()
                myconnection.Close()

                'Reload DataGridView
                Reload_DataGridView()
                Reload_DataGridView_QRLables()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            '/--- End





        End While


    End Sub



    'Form Load
    Private Sub QR_Labels_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reload_DataGridView()
        Reload_DataGridView_QRLables()
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
        SaveFileDialog1.FileName = "NAJ - QR_Labels - " + DateTime.Now.ToString("MM-dd-yyyy_HH-mm-ss")

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

            For i = 0 To DataGridView2.RowCount - 2
                For j = 0 To DataGridView2.ColumnCount - 1
                    For k As Integer = 1 To DataGridView2.Columns.Count
                        xlWorkSheet.Cells(1, k) = DataGridView2.Columns(k - 1).HeaderText
                        xlWorkSheet.Cells(i + 2, j + 1) = DataGridView2(j, i).Value.ToString()
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

            MessageBox.Show("QR Labels successfully download!", "   NAJ - QR Labels", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' ---- Convert to excel end

        End If


    End Sub



    'Search by ID numbers
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged




        'Check if TextBox for ID is empty
        If TextBox1.Text = "" Then
            'Reload DataGridView
            Reload_DataGridView()
        Else
            'Search Function
            Dim connx As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb")
            If connx.State = ConnectionState.Closed Then
                connx.Open()
            End If
            Dim cmdx As New OleDbCommand("select * from Inventory where ID = " + TextBox1.Text + "", connx)
            Dim da As New OleDbDataAdapter
            Dim dt As New DataTable
            da.SelectCommand = cmdx
            dt.Clear()
            da.Fill(dt)
            DataGridView1.DataSource = dt
            connx.Close()
        End If






    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Add Items in QR labels
        AddToQrLabelDB()


        'Reload The QR lables DataGridView
        Reload_DataGridView_QRLables()


        'Clear Textbox
        TextBox1.Clear()
        TextBox2.Clear()

    End Sub


    'Search by Partnumber
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Inventory.accdb")

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        Dim cmd1 As New OleDbCommand("select * from Inventory where Part_Number like '%" + TextBox3.Text + "%'", conn)
        Dim da As New OleDbDataAdapter
        Dim dt As New DataTable

        da.SelectCommand = cmd1
        dt.Clear()
        da.Fill(dt)
        DataGridView1.DataSource = dt

        conn.Close()
    End Sub






    'Clear All rows in QR_Labels
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click



        'Check if DataGridView2 Has Value

        If DataGridView2.CurrentCell Is Nothing Then

            MessageBox.Show("Datagridview already clear!", " NAJ - QR Labels", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else


            'Clear all rows in QR_Labes DB
            Dim myreader As OleDbDataReader
            Dim myreader1 As OleDbDataReader
            Dim conn1 As OleDbConnection = New OleDbConnection
            conn1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - QR_Labels.accdb"
            conn1.Open()

            'Get last ID from DB
            If conn1.State = ConnectionState.Closed Then
                conn1.Open()
            End If

            'First ID
            Dim strsql As String = "select ID from QR_Labels where ID=(select min(ID)from QR_Labels)"
            Dim cmd1 As New OleDbCommand(strsql, conn1)
            myreader = cmd1.ExecuteReader
            myreader.Read()
            Dim FirstID As Integer
            FirstID = myreader("ID")

            'Last ID
            Dim strsql1 As String = "select ID from QR_Labels where ID=(select max(ID)from QR_Labels)"
            Dim cmd2 As New OleDbCommand(strsql1, conn1)
            myreader1 = cmd2.ExecuteReader
            myreader1.Read()
            Dim LastID As Integer
            LastID = myreader1("ID")


            conn1.Close()

            ' - Connection Close


            'Delete From First to Last ID
            For ID_X = FirstID To LastID

                'Delete DB by ID
                Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - QR_Labels.accdb")
                Dim cmd As New OleDbCommand("Delete from QR_Labels where ID=@ID", conn)
                cmd.Parameters.AddWithValue("@ID", ID_X)
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()



            Next


            'Reload DB QR_Lables
            Reload_DataGridView_QRLables()

            MessageBox.Show("Datagridview already clear!", " NAJ - QR Labels", MessageBoxButtons.OK, MessageBoxIcon.Information)


        End If






    End Sub
End Class