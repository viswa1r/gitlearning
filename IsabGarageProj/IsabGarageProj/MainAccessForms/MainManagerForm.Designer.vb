<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainManagerForm
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
        Me.CustomerNameLbl = New System.Windows.Forms.Label()
        Me.employeeServiceBtn = New System.Windows.Forms.Button()
        Me.logoutLbl = New System.Windows.Forms.Label()
        Me.addNewEmployeeBtn = New System.Windows.Forms.Button()
        Me.empScheduleBtn = New System.Windows.Forms.Button()
        Me.employeePayrollBtn = New System.Windows.Forms.Button()
        Me.purchaseHistoryBtn = New System.Windows.Forms.Button()
        Me.addPurchaseOrderBtn = New System.Windows.Forms.Button()
        Me.addSupplierBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CustomerNameLbl
        '
        Me.CustomerNameLbl.AutoSize = True
        Me.CustomerNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerNameLbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.CustomerNameLbl.Location = New System.Drawing.Point(374, 50)
        Me.CustomerNameLbl.Name = "CustomerNameLbl"
        Me.CustomerNameLbl.Size = New System.Drawing.Size(0, 16)
        Me.CustomerNameLbl.TabIndex = 16
        '
        'employeeServiceBtn
        '
        Me.employeeServiceBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.employeeServiceBtn.Font = New System.Drawing.Font("Book Antiqua", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeServiceBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.employeeServiceBtn.Location = New System.Drawing.Point(345, 197)
        Me.employeeServiceBtn.Name = "employeeServiceBtn"
        Me.employeeServiceBtn.Size = New System.Drawing.Size(241, 45)
        Me.employeeServiceBtn.TabIndex = 15
        Me.employeeServiceBtn.Text = "Employee Service"
        Me.employeeServiceBtn.UseVisualStyleBackColor = False
        '
        'logoutLbl
        '
        Me.logoutLbl.AutoSize = True
        Me.logoutLbl.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.logoutLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logoutLbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.logoutLbl.Location = New System.Drawing.Point(21, 42)
        Me.logoutLbl.Name = "logoutLbl"
        Me.logoutLbl.Size = New System.Drawing.Size(74, 24)
        Me.logoutLbl.TabIndex = 14
        Me.logoutLbl.Text = "Logout"
        '
        'addNewEmployeeBtn
        '
        Me.addNewEmployeeBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.addNewEmployeeBtn.Font = New System.Drawing.Font("Book Antiqua", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addNewEmployeeBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.addNewEmployeeBtn.Location = New System.Drawing.Point(345, 117)
        Me.addNewEmployeeBtn.Name = "addNewEmployeeBtn"
        Me.addNewEmployeeBtn.Size = New System.Drawing.Size(241, 45)
        Me.addNewEmployeeBtn.TabIndex = 13
        Me.addNewEmployeeBtn.Text = "Add/Update Employee"
        Me.addNewEmployeeBtn.UseVisualStyleBackColor = False
        '
        'empScheduleBtn
        '
        Me.empScheduleBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.empScheduleBtn.Font = New System.Drawing.Font("Book Antiqua", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empScheduleBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.empScheduleBtn.Location = New System.Drawing.Point(345, 276)
        Me.empScheduleBtn.Name = "empScheduleBtn"
        Me.empScheduleBtn.Size = New System.Drawing.Size(241, 45)
        Me.empScheduleBtn.TabIndex = 17
        Me.empScheduleBtn.Text = "Employee Schedules"
        Me.empScheduleBtn.UseVisualStyleBackColor = False
        '
        'employeePayrollBtn
        '
        Me.employeePayrollBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.employeePayrollBtn.Font = New System.Drawing.Font("Book Antiqua", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeePayrollBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.employeePayrollBtn.Location = New System.Drawing.Point(345, 351)
        Me.employeePayrollBtn.Name = "employeePayrollBtn"
        Me.employeePayrollBtn.Size = New System.Drawing.Size(241, 45)
        Me.employeePayrollBtn.TabIndex = 18
        Me.employeePayrollBtn.Text = "Employee Payroll"
        Me.employeePayrollBtn.UseVisualStyleBackColor = False
        '
        'purchaseHistoryBtn
        '
        Me.purchaseHistoryBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.purchaseHistoryBtn.Font = New System.Drawing.Font("Book Antiqua", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.purchaseHistoryBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.purchaseHistoryBtn.Location = New System.Drawing.Point(25, 276)
        Me.purchaseHistoryBtn.Name = "purchaseHistoryBtn"
        Me.purchaseHistoryBtn.Size = New System.Drawing.Size(241, 45)
        Me.purchaseHistoryBtn.TabIndex = 21
        Me.purchaseHistoryBtn.Text = "Purchase History"
        Me.purchaseHistoryBtn.UseVisualStyleBackColor = False
        '
        'addPurchaseOrderBtn
        '
        Me.addPurchaseOrderBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.addPurchaseOrderBtn.Font = New System.Drawing.Font("Book Antiqua", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addPurchaseOrderBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.addPurchaseOrderBtn.Location = New System.Drawing.Point(25, 197)
        Me.addPurchaseOrderBtn.Name = "addPurchaseOrderBtn"
        Me.addPurchaseOrderBtn.Size = New System.Drawing.Size(241, 45)
        Me.addPurchaseOrderBtn.TabIndex = 20
        Me.addPurchaseOrderBtn.Text = "Add Puchase Order"
        Me.addPurchaseOrderBtn.UseVisualStyleBackColor = False
        '
        'addSupplierBtn
        '
        Me.addSupplierBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.addSupplierBtn.Font = New System.Drawing.Font("Book Antiqua", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addSupplierBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.addSupplierBtn.Location = New System.Drawing.Point(25, 117)
        Me.addSupplierBtn.Name = "addSupplierBtn"
        Me.addSupplierBtn.Size = New System.Drawing.Size(241, 45)
        Me.addSupplierBtn.TabIndex = 19
        Me.addSupplierBtn.Text = "Add/Update Suppliers"
        Me.addSupplierBtn.UseVisualStyleBackColor = False
        '
        'MainManagerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 441)
        Me.Controls.Add(Me.purchaseHistoryBtn)
        Me.Controls.Add(Me.addPurchaseOrderBtn)
        Me.Controls.Add(Me.addSupplierBtn)
        Me.Controls.Add(Me.employeePayrollBtn)
        Me.Controls.Add(Me.empScheduleBtn)
        Me.Controls.Add(Me.CustomerNameLbl)
        Me.Controls.Add(Me.employeeServiceBtn)
        Me.Controls.Add(Me.logoutLbl)
        Me.Controls.Add(Me.addNewEmployeeBtn)
        Me.Name = "MainManagerForm"
        Me.Text = "MainManagerForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CustomerNameLbl As Label
    Friend WithEvents employeeServiceBtn As Button
    Friend WithEvents logoutLbl As Label
    Friend WithEvents addNewEmployeeBtn As Button
    Friend WithEvents empScheduleBtn As Button
    Friend WithEvents employeePayrollBtn As Button
    Friend WithEvents purchaseHistoryBtn As Button
    Friend WithEvents addPurchaseOrderBtn As Button
    Friend WithEvents addSupplierBtn As Button
End Class
