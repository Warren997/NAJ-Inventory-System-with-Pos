<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reports_Inventory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reports_Inventory))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProfitSum = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Total_AmountSum = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CapitalSum = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SaveFileDialog2 = New System.Windows.Forms.SaveFileDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.InvItems = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ItemTypes = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(54, 582)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(218, 33)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Expected Profit:"
        '
        'ProfitSum
        '
        Me.ProfitSum.AutoSize = True
        Me.ProfitSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProfitSum.ForeColor = System.Drawing.Color.DodgerBlue
        Me.ProfitSum.Location = New System.Drawing.Point(275, 582)
        Me.ProfitSum.Name = "ProfitSum"
        Me.ProfitSum.Size = New System.Drawing.Size(35, 37)
        Me.ProfitSum.TabIndex = 53
        Me.ProfitSum.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(77, 526)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 33)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Total Amount:"
        '
        'Total_AmountSum
        '
        Me.Total_AmountSum.AutoSize = True
        Me.Total_AmountSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total_AmountSum.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Total_AmountSum.Location = New System.Drawing.Point(275, 526)
        Me.Total_AmountSum.Name = "Total_AmountSum"
        Me.Total_AmountSum.Size = New System.Drawing.Size(35, 37)
        Me.Total_AmountSum.TabIndex = 51
        Me.Total_AmountSum.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 471)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 33)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Total Capital:"
        '
        'CapitalSum
        '
        Me.CapitalSum.AutoSize = True
        Me.CapitalSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CapitalSum.ForeColor = System.Drawing.Color.DodgerBlue
        Me.CapitalSum.Location = New System.Drawing.Point(275, 471)
        Me.CapitalSum.Name = "CapitalSum"
        Me.CapitalSum.Size = New System.Drawing.Size(35, 37)
        Me.CapitalSum.TabIndex = 49
        Me.CapitalSum.Text = "0"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(27, 87)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(804, 245)
        Me.DataGridView1.TabIndex = 48
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(705, 575)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(126, 44)
        Me.Button2.TabIndex = 56
        Me.Button2.Text = "Download Excel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(458, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 24)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Description: "
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(592, 37)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(239, 29)
        Me.TextBox1.TabIndex = 57
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(46, 357)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(223, 33)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Individual Items:"
        '
        'InvItems
        '
        Me.InvItems.AutoSize = True
        Me.InvItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InvItems.ForeColor = System.Drawing.Color.DodgerBlue
        Me.InvItems.Location = New System.Drawing.Point(278, 357)
        Me.InvItems.Name = "InvItems"
        Me.InvItems.Size = New System.Drawing.Size(35, 37)
        Me.InvItems.TabIndex = 59
        Me.InvItems.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(106, 413)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(163, 33)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "Item Types:"
        '
        'ItemTypes
        '
        Me.ItemTypes.AutoSize = True
        Me.ItemTypes.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemTypes.ForeColor = System.Drawing.Color.DodgerBlue
        Me.ItemTypes.Location = New System.Drawing.Point(275, 413)
        Me.ItemTypes.Name = "ItemTypes"
        Me.ItemTypes.Size = New System.Drawing.Size(35, 37)
        Me.ItemTypes.TabIndex = 61
        Me.ItemTypes.Text = "0"
        '
        'Reports_Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 655)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ItemTypes)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.InvItems)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ProfitSum)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Total_AmountSum)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CapitalSum)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Reports_Inventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "  NAJ  -  Inventory Reports"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents ProfitSum As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Total_AmountSum As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CapitalSum As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents SaveFileDialog2 As SaveFileDialog
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents InvItems As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ItemTypes As Label
End Class
