<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Scheduling
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
        Me.service = New System.Windows.Forms.Button()
        Me.serviceDataGridView = New System.Windows.Forms.DataGridView()
        Me.Schdserv = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.employeeDataGridView = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.startDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EndDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.assgnScheduleBtn = New System.Windows.Forms.Button()
        Me.clearBtn = New System.Windows.Forms.Button()
        CType(Me.serviceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Schdserv.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.employeeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'service
        '
        Me.service.BackColor = System.Drawing.Color.SteelBlue
        Me.service.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.service.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.service.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.service.ForeColor = System.Drawing.SystemColors.Control
        Me.service.Location = New System.Drawing.Point(27, 90)
        Me.service.Name = "service"
        Me.service.Size = New System.Drawing.Size(100, 31)
        Me.service.TabIndex = 0
        Me.service.Text = "Service ID"
        Me.service.UseVisualStyleBackColor = False
        '
        'serviceDataGridView
        '
        Me.serviceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.serviceDataGridView.GridColor = System.Drawing.SystemColors.ControlLight
        Me.serviceDataGridView.Location = New System.Drawing.Point(154, 18)
        Me.serviceDataGridView.Name = "serviceDataGridView"
        Me.serviceDataGridView.Size = New System.Drawing.Size(291, 189)
        Me.serviceDataGridView.TabIndex = 1
        '
        'Schdserv
        '
        Me.Schdserv.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Schdserv.Controls.Add(Me.service)
        Me.Schdserv.Controls.Add(Me.serviceDataGridView)
        Me.Schdserv.Font = New System.Drawing.Font("Book Antiqua", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Schdserv.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Schdserv.Location = New System.Drawing.Point(12, 12)
        Me.Schdserv.Margin = New System.Windows.Forms.Padding(0)
        Me.Schdserv.Name = "Schdserv"
        Me.Schdserv.Padding = New System.Windows.Forms.Padding(0)
        Me.Schdserv.Size = New System.Drawing.Size(455, 216)
        Me.Schdserv.TabIndex = 4
        Me.Schdserv.TabStop = False
        Me.Schdserv.Text = "UNASSIGNED SERVICE"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox2.Controls.Add(Me.employeeDataGridView)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Font = New System.Drawing.Font("Book Antiqua", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox2.Location = New System.Drawing.Point(12, 234)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(455, 220)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "AVAILABLE EMPLOYEE"
        '
        'employeeDataGridView
        '
        Me.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.employeeDataGridView.GridColor = System.Drawing.SystemColors.ControlLight
        Me.employeeDataGridView.Location = New System.Drawing.Point(154, 24)
        Me.employeeDataGridView.Name = "employeeDataGridView"
        Me.employeeDataGridView.Size = New System.Drawing.Size(291, 190)
        Me.employeeDataGridView.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SteelBlue
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(27, 97)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 31)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Employee ID"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(36, 475)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 21)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Start Time"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(36, 523)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 21)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Finish Time"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'startDateTimePicker
        '
        Me.startDateTimePicker.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.startDateTimePicker.CalendarMonthBackground = System.Drawing.Color.SteelBlue
        Me.startDateTimePicker.CalendarTitleBackColor = System.Drawing.Color.Gainsboro
        Me.startDateTimePicker.CalendarTitleForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.startDateTimePicker.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlDark
        Me.startDateTimePicker.CustomFormat = "yyyy-MM-dd hh:mm:ss"
        Me.startDateTimePicker.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.startDateTimePicker.Location = New System.Drawing.Point(180, 475)
        Me.startDateTimePicker.Name = "startDateTimePicker"
        Me.startDateTimePicker.Size = New System.Drawing.Size(246, 23)
        Me.startDateTimePicker.TabIndex = 9
        '
        'EndDateTimePicker
        '
        Me.EndDateTimePicker.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.EndDateTimePicker.CalendarMonthBackground = System.Drawing.Color.SteelBlue
        Me.EndDateTimePicker.CalendarTitleBackColor = System.Drawing.Color.Gainsboro
        Me.EndDateTimePicker.CalendarTitleForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.EndDateTimePicker.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlDark
        Me.EndDateTimePicker.CustomFormat = "yyyy-MM-dd hh:mm:ss"
        Me.EndDateTimePicker.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.EndDateTimePicker.Location = New System.Drawing.Point(180, 521)
        Me.EndDateTimePicker.Name = "EndDateTimePicker"
        Me.EndDateTimePicker.Size = New System.Drawing.Size(246, 23)
        Me.EndDateTimePicker.TabIndex = 10
        '
        'assgnScheduleBtn
        '
        Me.assgnScheduleBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.assgnScheduleBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.assgnScheduleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.assgnScheduleBtn.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.assgnScheduleBtn.ForeColor = System.Drawing.SystemColors.Control
        Me.assgnScheduleBtn.Location = New System.Drawing.Point(219, 568)
        Me.assgnScheduleBtn.Name = "assgnScheduleBtn"
        Me.assgnScheduleBtn.Size = New System.Drawing.Size(118, 31)
        Me.assgnScheduleBtn.TabIndex = 5
        Me.assgnScheduleBtn.Text = "Assign Schedule"
        Me.assgnScheduleBtn.UseVisualStyleBackColor = False
        '
        'clearBtn
        '
        Me.clearBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.clearBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.clearBtn.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearBtn.ForeColor = System.Drawing.SystemColors.Control
        Me.clearBtn.Location = New System.Drawing.Point(356, 568)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(101, 31)
        Me.clearBtn.TabIndex = 11
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = False
        '
        'Scheduling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(487, 611)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.assgnScheduleBtn)
        Me.Controls.Add(Me.EndDateTimePicker)
        Me.Controls.Add(Me.startDateTimePicker)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Schdserv)
        Me.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.Name = "Scheduling"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Scheduling"
        Me.TransparencyKey = System.Drawing.Color.Maroon
        CType(Me.serviceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Schdserv.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.employeeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents service As Button
    Friend WithEvents serviceDataGridView As DataGridView
    Friend WithEvents Schdserv As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents employeeDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents startDateTimePicker As DateTimePicker
    Friend WithEvents EndDateTimePicker As DateTimePicker
    Friend WithEvents assgnScheduleBtn As Button
    Friend WithEvents clearBtn As Button
End Class
