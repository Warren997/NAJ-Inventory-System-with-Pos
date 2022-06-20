Imports System.Data.OleDb

Public Class Product_History


    'Connection
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Add_Product_History.accdb"
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
        dbda = New OleDbDataAdapter("Select * from [Add_Product_History]", Myconnection)
        dbda.Fill(dbds, "Add_Product_History")
        Dim view As New DataView(tables(0))
        source.DataSource = view
        DataGridView1.DataSource = view
    End Sub




    'Filter DataGridView By Date
    Public Sub filterByDate()

        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Add_Product_History.accdb")

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        Dim dtdate1 As DateTime = DateTime.Parse(d1.Text)
        Dim dtdate2 As DateTime = DateTime.Parse(d2.Text)
        Dim cmd1 As OleDbCommand = New OleDbCommand("select ID,Account_Used,Part_Number,Description,Brand,Quantity,Supplier_Price,Date_Added from Add_Product_History where Date_Added between #" & dtdate1.ToString("MM/dd/yyyy") & "# and #" & dtdate2.ToString("MM/dd/yyyy") & "# order by Date_Added desc", conn)

        Dim da As New OleDbDataAdapter
        da.SelectCommand = cmd1
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        DataGridView1.DataSource = dt
        conn.Close()



    End Sub




    'Form Load'
    Private Sub Product_History_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Reload_DataGridView()

        'DateTime Picker
        d1.Format = DateTimePickerFormat.Custom
        d1.CustomFormat = "MM/dd/yyyy"

        d2.Format = DateTimePickerFormat.Custom
        d2.CustomFormat = "MM/dd/yyyy"




    End Sub

    'Search Box by Part Number'
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NAJ-DB - Add_Product_History.accdb")

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        Dim cmd1 As New OleDbCommand("select * from Add_Product_History where Part_Number like '%" + TextBox1.Text + "%'", conn)
        Dim da As New OleDbDataAdapter
        Dim dt As New DataTable

        da.SelectCommand = cmd1
        dt.Clear()
        da.Fill(dt)
        DataGridView1.DataSource = dt

        conn.Close()
    End Sub



    'Add Product Show Btn'
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Add_New_Product.Show()
    End Sub

    'Update Stocks Show Btn'
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Stocks_Update_Stocks.Show()
    End Sub


    'Filter by Date
    Private Sub d1_ValueChanged(sender As Object, e As EventArgs) Handles d1.ValueChanged
        filterByDate()
    End Sub

    Private Sub d2_ValueChanged(sender As Object, e As EventArgs) Handles d2.ValueChanged
        filterByDate()
    End Sub
End Class