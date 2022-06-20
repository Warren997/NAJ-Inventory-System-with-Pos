Public Class Inventory



    'Log Out'
    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Login.Show()
        Me.Close()

        Login.TextBox1.Text = ""
        Login.TextBox2.Text = ""

    End Sub


    'Exit Button'
    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click

        If MessageBox.Show("Are You Sure You Wanna Exit?", " NAJ Inventory System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Application.Exit()
        End If

    End Sub


    'Add New Product Button'
    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        Add_New_Product.Show()

    End Sub

    'Stock Button'
    Private Sub UpdateStocksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateStocksToolStripMenuItem.Click
        Stocks_Update_Stocks.Show()

    End Sub

    'Product History'
    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        Product_History.Show()
    End Sub


    'Accounts Button'
    Private Sub ToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem7.Click
        Account_Access.Show()
    End Sub


    'Stock History'
    Private Sub HistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistoryToolStripMenuItem.Click
        Stock_History.Show()
    End Sub

    'POS'
    Private Sub ToolStripMenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem8.Click
        POS.Show()
    End Sub

    'Product List'
    Private Sub ToolStripMenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem9.Click
        Product_List.Show()
    End Sub



    'Reports
    Private Sub SoldItemsReportssToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SoldItemsReportssToolStripMenuItem.Click
        Reports_Sold_Items.Show()
    End Sub

    Private Sub InventoryReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventoryReportsToolStripMenuItem.Click
        Reports_Inventory.Show()
    End Sub




    'QR Labels 
    Private Sub ToolStripMenuItem10_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem10.Click
        QR_Labels.Show()
    End Sub

    'Returned
    Private Sub ToolStripMenuItem12_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem12.Click
        Returned.Show()
    End Sub



    '--------- Save Database

    'Inventory
    Private Sub InventoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventoryToolStripMenuItem.Click
        SaveFileDialog1.Filter = "Access Documents|*.accdb"
        SaveFileDialog1.FileName = "NAJ - Inventory - " + DateTime.Now.ToString("MM-dd-yyyy_HH-mm-ss")

        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            My.Computer.FileSystem.CopyFile(Application.StartupPath & "\NAJ-DB - Inventory.accdb", SaveFileDialog1.FileName)
            MessageBox.Show("Inventory Database successfully dowload!", "   NAJ - Backup", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If



    End Sub


    'Purchased Record
    Private Sub SToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SToolStripMenuItem.Click

        SaveFileDialog2.Filter = "Access Documents|*.accdb"
        SaveFileDialog2.FileName = "NAJ - Purchased Report - " + DateTime.Now.ToString("MM-dd-yyyy_HH-mm-ss")

        If SaveFileDialog2.ShowDialog = DialogResult.OK Then
            My.Computer.FileSystem.CopyFile(Application.StartupPath & "\NAJ-DB - Purchased_Report.accdb", SaveFileDialog2.FileName)
            MessageBox.Show("Purchased Report Database successfully dowload!", "   NAJ - Backup", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub


    'Add Stock History
    Private Sub AddStockHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddStockHistoryToolStripMenuItem.Click

        SaveFileDialog3.Filter = "Access Documents|*.accdb"
        SaveFileDialog3.FileName = "NAJ - Add Stock History - " + DateTime.Now.ToString("MM-dd-yyyy_HH-mm-ss")

        If SaveFileDialog3.ShowDialog = DialogResult.OK Then
            My.Computer.FileSystem.CopyFile(Application.StartupPath & "\NAJ-DB - Add_Stock_History.accdb", SaveFileDialog3.FileName)
            MessageBox.Show("Add Stock History Database successfully dowload!", "   NAJ - Backup", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub


    'Add Product History
    Private Sub AddProducHistorytToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddProducHistorytToolStripMenuItem.Click

        SaveFileDialog4.Filter = "Access Documents|*.accdb"
        SaveFileDialog4.FileName = "NAJ - Add Product History - " + DateTime.Now.ToString("MM-dd-yyyy_HH-mm-ss")

        If SaveFileDialog4.ShowDialog = DialogResult.OK Then
            My.Computer.FileSystem.CopyFile(Application.StartupPath & "\NAJ-DB - Add_Product_History.accdb", SaveFileDialog4.FileName)
            MessageBox.Show("Add Product History Database successfully dowload!", "   NAJ - Backup", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub


    'Returned Items
    Private Sub ReturnedItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnedItemsToolStripMenuItem.Click

        SaveFileDialog5.Filter = "Access Documents|*.accdb"
        SaveFileDialog5.FileName = "NAJ - Returned Items - " + DateTime.Now.ToString("MM-dd-yyyy_HH-mm-ss")

        If SaveFileDialog5.ShowDialog = DialogResult.OK Then
            My.Computer.FileSystem.CopyFile(Application.StartupPath & "\NAJ-DB - Returned_Items.accdb", SaveFileDialog5.FileName)
            MessageBox.Show("Returned Items  Database successfully dowload!", "   NAJ - Backup", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub
End Class