<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payroll_Processing
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.totalhrsTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.endDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.startDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.netSalaryTextBox = New System.Windows.Forms.TextBox()
        Me.calculateBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.searchBtn = New System.Windows.Forms.Button()
        Me.hourlyWageTextBox = New System.Windows.Forms.TextBox()
        Me.empIdTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.timesheetDataGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.timesheetDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.Controls.Add(Me.clearBtn)
        Me.GroupBox1.Controls.Add(Me.totalhrsTextBox)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.endDateTimePicker)
        Me.GroupBox1.Controls.Add(Me.startDateTimePicker)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.netSalaryTextBox)
        Me.GroupBox1.Controls.Add(Me.calculateBtn)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.searchBtn)
        Me.GroupBox1.Controls.Add(Me.hourlyWageTextBox)
        Me.GroupBox1.Controls.Add(Me.empIdTextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Book Antiqua", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(540, 238)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "EMPLOYEE PAYROLL"
        '
        'totalhrsTextBox
        '
        Me.totalhrsTextBox.Location = New System.Drawing.Point(426, 29)
        Me.totalhrsTextBox.Name = "totalhrsTextBox"
        Me.totalhrsTextBox.Size = New System.Drawing.Size(100, 23)
        Me.totalhrsTextBox.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Location = New System.Drawing.Point(308, 31)
        Me.Label6.Margin = New System.Windows.Forms.Padding(3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 21)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Total Hours "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'endDateTimePicker
        '
        Me.endDateTimePicker.CustomFormat = "MM/dd/yyyy"
        Me.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.endDateTimePicker.Location = New System.Drawing.Point(125, 119)
        Me.endDateTimePicker.Name = "endDateTimePicker"
        Me.endDateTimePicker.Size = New System.Drawing.Size(170, 23)
        Me.endDateTimePicker.TabIndex = 27
        '
        'startDateTimePicker
        '
        Me.startDateTimePicker.CustomFormat = "MM/dd/yyyy"
        Me.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.startDateTimePicker.Location = New System.Drawing.Point(125, 78)
        Me.startDateTimePicker.Name = "startDateTimePicker"
        Me.startDateTimePicker.Size = New System.Drawing.Size(170, 23)
        Me.startDateTimePicker.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(33, 121)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 21)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "End Date"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Location = New System.Drawing.Point(33, 33)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 21)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Employee ID"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label3.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(310, 119)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 23)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Net Salary"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'netSalaryTextBox
        '
        Me.netSalaryTextBox.Location = New System.Drawing.Point(426, 119)
        Me.netSalaryTextBox.Name = "netSalaryTextBox"
        Me.netSalaryTextBox.Size = New System.Drawing.Size(100, 23)
        Me.netSalaryTextBox.TabIndex = 22
        '
        'calculateBtn
        '
        Me.calculateBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.calculateBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.calculateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.calculateBtn.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculateBtn.ForeColor = System.Drawing.SystemColors.Control
        Me.calculateBtn.Location = New System.Drawing.Point(371, 170)
        Me.calculateBtn.Name = "calculateBtn"
        Me.calculateBtn.Size = New System.Drawing.Size(76, 31)
        Me.calculateBtn.TabIndex = 21
        Me.calculateBtn.Text = "Calculate"
        Me.calculateBtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(310, 78)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 21)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Hourly Wage"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'searchBtn
        '
        Me.searchBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.searchBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.searchBtn.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchBtn.ForeColor = System.Drawing.SystemColors.Control
        Me.searchBtn.Location = New System.Drawing.Point(99, 174)
        Me.searchBtn.Name = "searchBtn"
        Me.searchBtn.Size = New System.Drawing.Size(76, 27)
        Me.searchBtn.TabIndex = 18
        Me.searchBtn.Text = "Search"
        Me.searchBtn.UseVisualStyleBackColor = False
        '
        'hourlyWageTextBox
        '
        Me.hourlyWageTextBox.Location = New System.Drawing.Point(426, 76)
        Me.hourlyWageTextBox.Name = "hourlyWageTextBox"
        Me.hourlyWageTextBox.Size = New System.Drawing.Size(100, 23)
        Me.hourlyWageTextBox.TabIndex = 11
        '
        'empIdTextBox
        '
        Me.empIdTextBox.Location = New System.Drawing.Point(156, 31)
        Me.empIdTextBox.Name = "empIdTextBox"
        Me.empIdTextBox.Size = New System.Drawing.Size(139, 23)
        Me.empIdTextBox.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(33, 78)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 21)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Start Date"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'timesheetDataGridView
        '
        Me.timesheetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.timesheetDataGridView.Location = New System.Drawing.Point(24, 26)
        Me.timesheetDataGridView.Name = "timesheetDataGridView"
        Me.timesheetDataGridView.Size = New System.Drawing.Size(443, 129)
        Me.timesheetDataGridView.TabIndex = 19
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox2.Controls.Add(Me.timesheetDataGridView)
        Me.GroupBox2.Font = New System.Drawing.Font("Book Antiqua", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox2.Location = New System.Drawing.Point(12, 256)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(540, 161)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TIME SHEET"
        '
        'clearBtn
        '
        Me.clearBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.clearBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.clearBtn.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearBtn.ForeColor = System.Drawing.SystemColors.Control
        Me.clearBtn.Location = New System.Drawing.Point(238, 173)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(76, 27)
        Me.clearBtn.TabIndex = 30
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = False
        '
        'Payroll_Processing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(561, 426)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.Name = "Payroll_Processing"
        Me.Text = "Payroll_Processing"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.timesheetDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents hourlyWageTextBox As TextBox
    Friend WithEvents empIdTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents calculateBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents timesheetDataGridView As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents netSalaryTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents searchBtn As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents totalhrsTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents endDateTimePicker As DateTimePicker
    Friend WithEvents startDateTimePicker As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents clearBtn As Button
End Class
