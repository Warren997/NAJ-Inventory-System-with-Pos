<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reports_Sold_Items
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reports_Sold_Items))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SaveFileDialog2 = New System.Windows.Forms.SaveFileDialog()
        Me.CapitalSum = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Total_AmountSum = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProfitSum = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.d1 = New System.Windows.Forms.DateTimePicker()
        Me.d2 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(31, 91)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(804, 200)
        Me.DataGridView1.TabIndex = 40
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(707, 476)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(126, 44)
        Me.Button2.TabIndex = 41
        Me.Button2.Text = "Download Excel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CapitalSum
        '
        Me.CapitalSum.AutoSize = True
        Me.CapitalSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CapitalSum.ForeColor = System.Drawing.Color.DodgerBlue
        Me.CapitalSum.Location = New System.Drawing.Point(275, 375)
        Me.CapitalSum.Name = "CapitalSum"
        Me.CapitalSum.Size = New System.Drawing.Size(35, 37)
        Me.CapitalSum.TabIndex = 42
        Me.CapitalSum.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 375)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 33)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Total Capital:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(77, 430)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 33)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Total Amount:"
        '
        'Total_AmountSum
        '
        Me.Total_AmountSum.AutoSize = True
        Me.Total_AmountSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total_AmountSum.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Total_AmountSum.Location = New System.Drawing.Point(275, 430)
        Me.Total_AmountSum.Name = "Total_AmountSum"
        Me.Total_AmountSum.Size = New System.Drawing.Size(35, 37)
        Me.Total_AmountSum.TabIndex = 44
        Me.Total_AmountSum.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(107, 486)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 33)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Total Profit:"
        '
        'ProfitSum
        '
        Me.ProfitSum.AutoSize = True
        Me.ProfitSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProfitSum.ForeColor = System.Drawing.Color.DodgerBlue
        Me.ProfitSum.Location = New System.Drawing.Point(275, 486)
        Me.ProfitSum.Name = "ProfitSum"
        Me.ProfitSum.Size = New System.Drawing.Size(35, 37)
        Me.ProfitSum.TabIndex = 46
        Me.ProfitSum.Text = "0"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(709, 316)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(126, 44)
        Me.Button3.TabIndex = 48
        Me.Button3.Text = "Reload Form"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'd1
        '
        Me.d1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d1.Location = New System.Drawing.Point(314, 50)
        Me.d1.Name = "d1"
        Me.d1.Size = New System.Drawing.Size(241, 22)
        Me.d1.TabIndex = 49
        '
        'd2
        '
        Me.d2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d2.Location = New System.Drawing.Point(592, 50)
        Me.d2.Name = "d2"
        Me.d2.Size = New System.Drawing.Size(241, 22)
        Me.d2.TabIndex = 50
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(561, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 16)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "To"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(269, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 16)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "From"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"DR", "SI"})
        Me.ComboBox1.Location = New System.Drawing.Point(31, 43)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(60, 28)
        Me.ComboBox1.TabIndex = 53
        '
        'Reports_Sold_Items
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 583)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.d2)
        Me.Controls.Add(Me.d1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ProfitSum)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Total_AmountSum)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CapitalSum)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Reports_Sold_Items"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "  NAJ  -  Sold Items Reports"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents SaveFileDialog2 As SaveFileDialog
    Friend WithEvents CapitalSum As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Total_AmountSum As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ProfitSum As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents d1 As DateTimePicker
    Friend WithEvents d2 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
