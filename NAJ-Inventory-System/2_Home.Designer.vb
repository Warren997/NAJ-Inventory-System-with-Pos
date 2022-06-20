<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventory))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateStocksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventoryReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SoldItemsReportssToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem13 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddStockHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddProducHistorytToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnedItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Account_Used = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SaveFileDialog2 = New System.Windows.Forms.SaveFileDialog()
        Me.SaveFileDialog3 = New System.Windows.Forms.SaveFileDialog()
        Me.SaveFileDialog4 = New System.Windows.Forms.SaveFileDialog()
        Me.SaveFileDialog5 = New System.Windows.Forms.SaveFileDialog()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Location = New System.Drawing.Point(-1, -5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(909, 40)
        Me.Panel1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripMenuItem6, Me.ToolStripMenuItem7, Me.ToolStripMenuItem8, Me.ToolStripMenuItem11, Me.ToolStripMenuItem10, Me.ToolStripMenuItem12, Me.ToolStripMenuItem13})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(909, 40)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ListToolStripMenuItem
        '
        Me.ListToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3})
        Me.ListToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListToolStripMenuItem.Margin = New System.Windows.Forms.Padding(20, 5, 0, 0)
        Me.ListToolStripMenuItem.Name = "ListToolStripMenuItem"
        Me.ListToolStripMenuItem.Size = New System.Drawing.Size(39, 31)
        Me.ListToolStripMenuItem.Text = "File"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(121, 22)
        Me.ToolStripMenuItem2.Text = "Log out"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(121, 22)
        Me.ToolStripMenuItem3.Text = "Exit"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4, Me.ToolStripMenuItem9, Me.ToolStripMenuItem5})
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.Margin = New System.Windows.Forms.Padding(10, 5, 0, 0)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(71, 31)
        Me.ToolStripMenuItem1.Text = "Products"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(155, 22)
        Me.ToolStripMenuItem4.Text = "Add Products"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(155, 22)
        Me.ToolStripMenuItem9.Text = "Products List"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(155, 22)
        Me.ToolStripMenuItem5.Text = "History"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateStocksToolStripMenuItem, Me.HistoryToolStripMenuItem})
        Me.ToolStripMenuItem6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem6.Margin = New System.Windows.Forms.Padding(10, 5, 0, 0)
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(57, 31)
        Me.ToolStripMenuItem6.Text = "Stocks"
        '
        'UpdateStocksToolStripMenuItem
        '
        Me.UpdateStocksToolStripMenuItem.Name = "UpdateStocksToolStripMenuItem"
        Me.UpdateStocksToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.UpdateStocksToolStripMenuItem.Text = "Update Stocks"
        '
        'HistoryToolStripMenuItem
        '
        Me.HistoryToolStripMenuItem.Name = "HistoryToolStripMenuItem"
        Me.HistoryToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.HistoryToolStripMenuItem.Text = "History"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem7.Margin = New System.Windows.Forms.Padding(10, 5, 0, 0)
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(72, 31)
        Me.ToolStripMenuItem7.Text = "Accounts"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem8.Margin = New System.Windows.Forms.Padding(10, 5, 0, 0)
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(44, 31)
        Me.ToolStripMenuItem8.Text = "POS"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InventoryReportsToolStripMenuItem, Me.SoldItemsReportssToolStripMenuItem})
        Me.ToolStripMenuItem11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem11.Margin = New System.Windows.Forms.Padding(10, 5, 0, 0)
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(66, 31)
        Me.ToolStripMenuItem11.Text = "Reports"
        '
        'InventoryReportsToolStripMenuItem
        '
        Me.InventoryReportsToolStripMenuItem.Name = "InventoryReportsToolStripMenuItem"
        Me.InventoryReportsToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.InventoryReportsToolStripMenuItem.Text = "Inventory Reports"
        '
        'SoldItemsReportssToolStripMenuItem
        '
        Me.SoldItemsReportssToolStripMenuItem.Name = "SoldItemsReportssToolStripMenuItem"
        Me.SoldItemsReportssToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.SoldItemsReportssToolStripMenuItem.Text = "Sold Items Reports"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem10.Margin = New System.Windows.Forms.Padding(10, 5, 0, 0)
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(79, 31)
        Me.ToolStripMenuItem10.Text = "QR Labels"
        '
        'ToolStripMenuItem12
        '
        Me.ToolStripMenuItem12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem12.Margin = New System.Windows.Forms.Padding(10, 5, 0, 0)
        Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
        Me.ToolStripMenuItem12.Size = New System.Drawing.Size(73, 31)
        Me.ToolStripMenuItem12.Text = "Returned"
        '
        'ToolStripMenuItem13
        '
        Me.ToolStripMenuItem13.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InventoryToolStripMenuItem, Me.SToolStripMenuItem, Me.AddStockHistoryToolStripMenuItem, Me.AddProducHistorytToolStripMenuItem, Me.ReturnedItemsToolStripMenuItem})
        Me.ToolStripMenuItem13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem13.Margin = New System.Windows.Forms.Padding(10, 5, 0, 0)
        Me.ToolStripMenuItem13.Name = "ToolStripMenuItem13"
        Me.ToolStripMenuItem13.Size = New System.Drawing.Size(61, 31)
        Me.ToolStripMenuItem13.Text = "Backup"
        '
        'InventoryToolStripMenuItem
        '
        Me.InventoryToolStripMenuItem.Name = "InventoryToolStripMenuItem"
        Me.InventoryToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.InventoryToolStripMenuItem.Text = "Inventory"
        '
        'SToolStripMenuItem
        '
        Me.SToolStripMenuItem.Name = "SToolStripMenuItem"
        Me.SToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.SToolStripMenuItem.Text = "Purchased Report"
        '
        'AddStockHistoryToolStripMenuItem
        '
        Me.AddStockHistoryToolStripMenuItem.Name = "AddStockHistoryToolStripMenuItem"
        Me.AddStockHistoryToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.AddStockHistoryToolStripMenuItem.Text = "Add Stock History"
        '
        'AddProducHistorytToolStripMenuItem
        '
        Me.AddProducHistorytToolStripMenuItem.Name = "AddProducHistorytToolStripMenuItem"
        Me.AddProducHistorytToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.AddProducHistorytToolStripMenuItem.Text = "Add Product History"
        '
        'ReturnedItemsToolStripMenuItem
        '
        Me.ReturnedItemsToolStripMenuItem.Name = "ReturnedItemsToolStripMenuItem"
        Me.ReturnedItemsToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ReturnedItemsToolStripMenuItem.Text = "Returned Items"
        '
        'Account_Used
        '
        Me.Account_Used.Location = New System.Drawing.Point(794, 52)
        Me.Account_Used.Name = "Account_Used"
        Me.Account_Used.Size = New System.Drawing.Size(100, 20)
        Me.Account_Used.TabIndex = 1
        Me.Account_Used.Visible = False
        '
        'Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.NAJ_LOGO
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(906, 562)
        Me.Controls.Add(Me.Account_Used)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Inventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "  NAJ Auto Supply"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateStocksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Account_Used As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripMenuItem11 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InventoryReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SoldItemsReportssToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem12 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem13 As ToolStripMenuItem
    Friend WithEvents InventoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddStockHistoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddProducHistorytToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReturnedItemsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents SaveFileDialog2 As SaveFileDialog
    Friend WithEvents SaveFileDialog3 As SaveFileDialog
    Friend WithEvents SaveFileDialog4 As SaveFileDialog
    Friend WithEvents SaveFileDialog5 As SaveFileDialog
End Class
