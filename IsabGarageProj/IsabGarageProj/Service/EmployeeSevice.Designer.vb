<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmployeeSevice
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.actualhoursTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EmpSchedlesGridView = New System.Windows.Forms.DataGridView()
        Me.SvcIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.searchBtn = New System.Windows.Forms.Button()
        Me.srvcendButton = New System.Windows.Forms.Button()
        Me.srvcstartButton = New System.Windows.Forms.Button()
        Me.hoursEstimatedTextBox = New System.Windows.Forms.TextBox()
        Me.EmpIDTextBox = New System.Windows.Forms.TextBox()
        Me.EmpIDLbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.edtiScheduleBtn = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.EmpSchedlesGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.Controls.Add(Me.actualhoursTextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.EmpSchedlesGridView)
        Me.GroupBox1.Controls.Add(Me.SvcIDTextBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.searchBtn)
        Me.GroupBox1.Controls.Add(Me.srvcendButton)
        Me.GroupBox1.Controls.Add(Me.srvcstartButton)
        Me.GroupBox1.Controls.Add(Me.hoursEstimatedTextBox)
        Me.GroupBox1.Controls.Add(Me.EmpIDTextBox)
        Me.GroupBox1.Controls.Add(Me.EmpIDLbl)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(691, 444)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "EMPLOYEE SERVICE DETAILS"
        '
        'actualhoursTextBox
        '
        Me.actualhoursTextBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.actualhoursTextBox.Location = New System.Drawing.Point(154, 198)
        Me.actualhoursTextBox.Name = "actualhoursTextBox"
        Me.actualhoursTextBox.Size = New System.Drawing.Size(189, 23)
        Me.actualhoursTextBox.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(34, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 18)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Actual Hours "
        '
        'EmpSchedlesGridView
        '
        Me.EmpSchedlesGridView.BackgroundColor = System.Drawing.Color.LightCyan
        Me.EmpSchedlesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpSchedlesGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.EmpSchedlesGridView.Location = New System.Drawing.Point(16, 247)
        Me.EmpSchedlesGridView.Name = "EmpSchedlesGridView"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGoldenrodYellow
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpSchedlesGridView.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.EmpSchedlesGridView.Size = New System.Drawing.Size(669, 177)
        Me.EmpSchedlesGridView.TabIndex = 1
        '
        'SvcIDTextBox
        '
        Me.SvcIDTextBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SvcIDTextBox.Location = New System.Drawing.Point(154, 135)
        Me.SvcIDTextBox.Name = "SvcIDTextBox"
        Me.SvcIDTextBox.Size = New System.Drawing.Size(189, 23)
        Me.SvcIDTextBox.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(53, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 18)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Service ID"
        '
        'searchBtn
        '
        Me.searchBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.searchBtn.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchBtn.ForeColor = System.Drawing.SystemColors.Control
        Me.searchBtn.Location = New System.Drawing.Point(361, 118)
        Me.searchBtn.Name = "searchBtn"
        Me.searchBtn.Size = New System.Drawing.Size(75, 25)
        Me.searchBtn.TabIndex = 6
        Me.searchBtn.Text = "Search"
        Me.searchBtn.UseVisualStyleBackColor = False
        '
        'srvcendButton
        '
        Me.srvcendButton.BackColor = System.Drawing.Color.SteelBlue
        Me.srvcendButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.srvcendButton.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.srvcendButton.ForeColor = System.Drawing.SystemColors.Control
        Me.srvcendButton.Location = New System.Drawing.Point(281, 47)
        Me.srvcendButton.Name = "srvcendButton"
        Me.srvcendButton.Size = New System.Drawing.Size(75, 23)
        Me.srvcendButton.TabIndex = 11
        Me.srvcendButton.Text = "End"
        Me.srvcendButton.UseVisualStyleBackColor = False
        '
        'srvcstartButton
        '
        Me.srvcstartButton.BackColor = System.Drawing.Color.SteelBlue
        Me.srvcstartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.srvcstartButton.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.srvcstartButton.ForeColor = System.Drawing.SystemColors.Control
        Me.srvcstartButton.Location = New System.Drawing.Point(144, 47)
        Me.srvcstartButton.Name = "srvcstartButton"
        Me.srvcstartButton.Size = New System.Drawing.Size(75, 23)
        Me.srvcstartButton.TabIndex = 10
        Me.srvcstartButton.Text = "Start"
        Me.srvcstartButton.UseVisualStyleBackColor = False
        '
        'hoursEstimatedTextBox
        '
        Me.hoursEstimatedTextBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hoursEstimatedTextBox.Location = New System.Drawing.Point(154, 165)
        Me.hoursEstimatedTextBox.Name = "hoursEstimatedTextBox"
        Me.hoursEstimatedTextBox.Size = New System.Drawing.Size(189, 23)
        Me.hoursEstimatedTextBox.TabIndex = 9
        '
        'EmpIDTextBox
        '
        Me.EmpIDTextBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpIDTextBox.Location = New System.Drawing.Point(154, 102)
        Me.EmpIDTextBox.Name = "EmpIDTextBox"
        Me.EmpIDTextBox.Size = New System.Drawing.Size(189, 23)
        Me.EmpIDTextBox.TabIndex = 8
        '
        'EmpIDLbl
        '
        Me.EmpIDLbl.AutoSize = True
        Me.EmpIDLbl.BackColor = System.Drawing.Color.LightSteelBlue
        Me.EmpIDLbl.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpIDLbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.EmpIDLbl.Location = New System.Drawing.Point(37, 107)
        Me.EmpIDLbl.Name = "EmpIDLbl"
        Me.EmpIDLbl.Size = New System.Drawing.Size(87, 18)
        Me.EmpIDLbl.TabIndex = 7
        Me.EmpIDLbl.Text = "Employee ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label3.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(13, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Estimated Hours "
        '
        'edtiScheduleBtn
        '
        Me.edtiScheduleBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.edtiScheduleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.edtiScheduleBtn.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtiScheduleBtn.ForeColor = System.Drawing.SystemColors.Control
        Me.edtiScheduleBtn.Location = New System.Drawing.Point(156, 485)
        Me.edtiScheduleBtn.Name = "edtiScheduleBtn"
        Me.edtiScheduleBtn.Size = New System.Drawing.Size(126, 25)
        Me.edtiScheduleBtn.TabIndex = 3
        Me.edtiScheduleBtn.Text = "Edit Schedules"
        Me.edtiScheduleBtn.UseVisualStyleBackColor = False
        '
        'exitBtn
        '
        Me.exitBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.exitBtn.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitBtn.ForeColor = System.Drawing.SystemColors.Control
        Me.exitBtn.Location = New System.Drawing.Point(305, 485)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(79, 25)
        Me.exitBtn.TabIndex = 4
        Me.exitBtn.Text = "Exit"
        Me.exitBtn.UseVisualStyleBackColor = False
        '
        'EmployeeSevice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(715, 519)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.edtiScheduleBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "EmployeeSevice"
        Me.Text = "Employeeservice"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.EmpSchedlesGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents EmpIDTextBox As TextBox
    Friend WithEvents EmpIDLbl As Label
    Friend WithEvents searchBtn As Button
    Friend WithEvents EmpSchedlesGridView As DataGridView
    Friend WithEvents edtiScheduleBtn As Button
    Friend WithEvents exitBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents SvcIDTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents srvcendButton As Button
    Friend WithEvents srvcstartButton As Button
    Friend WithEvents hoursEstimatedTextBox As TextBox
    Friend WithEvents actualhoursTextBox As TextBox
End Class
