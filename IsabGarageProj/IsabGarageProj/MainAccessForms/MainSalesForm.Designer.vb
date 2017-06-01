<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainSalesForm
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
        Me.logoutLbl = New System.Windows.Forms.Label()
        Me.newSalesOrderBtn = New System.Windows.Forms.Button()
        Me.addCustomerBtn = New System.Windows.Forms.Button()
        Me.CustomerNameLbl = New System.Windows.Forms.Label()
        Me.newUpdateServiceBtn = New System.Windows.Forms.Button()
        Me.sparePartsDetailsBtn = New System.Windows.Forms.Button()
        Me.addVehiclesBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'logoutLbl
        '
        Me.logoutLbl.AutoSize = True
        Me.logoutLbl.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.logoutLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logoutLbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.logoutLbl.Location = New System.Drawing.Point(12, 33)
        Me.logoutLbl.Name = "logoutLbl"
        Me.logoutLbl.Size = New System.Drawing.Size(74, 24)
        Me.logoutLbl.TabIndex = 8
        Me.logoutLbl.Text = "Logout"
        '
        'newSalesOrderBtn
        '
        Me.newSalesOrderBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.newSalesOrderBtn.Font = New System.Drawing.Font("Book Antiqua", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newSalesOrderBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.newSalesOrderBtn.Location = New System.Drawing.Point(304, 93)
        Me.newSalesOrderBtn.Name = "newSalesOrderBtn"
        Me.newSalesOrderBtn.Size = New System.Drawing.Size(241, 45)
        Me.newSalesOrderBtn.TabIndex = 7
        Me.newSalesOrderBtn.Text = "New Sales Order"
        Me.newSalesOrderBtn.UseVisualStyleBackColor = False
        '
        'addCustomerBtn
        '
        Me.addCustomerBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.addCustomerBtn.Font = New System.Drawing.Font("Book Antiqua", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addCustomerBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.addCustomerBtn.Location = New System.Drawing.Point(304, 173)
        Me.addCustomerBtn.Name = "addCustomerBtn"
        Me.addCustomerBtn.Size = New System.Drawing.Size(241, 45)
        Me.addCustomerBtn.TabIndex = 10
        Me.addCustomerBtn.Text = "Add/Update Customer"
        Me.addCustomerBtn.UseVisualStyleBackColor = False
        '
        'CustomerNameLbl
        '
        Me.CustomerNameLbl.AutoSize = True
        Me.CustomerNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerNameLbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.CustomerNameLbl.Location = New System.Drawing.Point(375, 41)
        Me.CustomerNameLbl.Name = "CustomerNameLbl"
        Me.CustomerNameLbl.Size = New System.Drawing.Size(0, 16)
        Me.CustomerNameLbl.TabIndex = 12
        '
        'newUpdateServiceBtn
        '
        Me.newUpdateServiceBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.newUpdateServiceBtn.Font = New System.Drawing.Font("Book Antiqua", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newUpdateServiceBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.newUpdateServiceBtn.Location = New System.Drawing.Point(12, 93)
        Me.newUpdateServiceBtn.Name = "newUpdateServiceBtn"
        Me.newUpdateServiceBtn.Size = New System.Drawing.Size(241, 45)
        Me.newUpdateServiceBtn.TabIndex = 13
        Me.newUpdateServiceBtn.Text = "New/Update Service"
        Me.newUpdateServiceBtn.UseVisualStyleBackColor = False
        '
        'sparePartsDetailsBtn
        '
        Me.sparePartsDetailsBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.sparePartsDetailsBtn.Font = New System.Drawing.Font("Book Antiqua", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sparePartsDetailsBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.sparePartsDetailsBtn.Location = New System.Drawing.Point(304, 249)
        Me.sparePartsDetailsBtn.Name = "sparePartsDetailsBtn"
        Me.sparePartsDetailsBtn.Size = New System.Drawing.Size(241, 45)
        Me.sparePartsDetailsBtn.TabIndex = 14
        Me.sparePartsDetailsBtn.Text = "Spare Parts Details"
        Me.sparePartsDetailsBtn.UseVisualStyleBackColor = False
        '
        'addVehiclesBtn
        '
        Me.addVehiclesBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.addVehiclesBtn.Font = New System.Drawing.Font("Book Antiqua", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addVehiclesBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.addVehiclesBtn.Location = New System.Drawing.Point(12, 173)
        Me.addVehiclesBtn.Name = "addVehiclesBtn"
        Me.addVehiclesBtn.Size = New System.Drawing.Size(241, 45)
        Me.addVehiclesBtn.TabIndex = 15
        Me.addVehiclesBtn.Text = "Add Vehicles"
        Me.addVehiclesBtn.UseVisualStyleBackColor = False
        '
        'MainSalesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(581, 382)
        Me.Controls.Add(Me.addVehiclesBtn)
        Me.Controls.Add(Me.sparePartsDetailsBtn)
        Me.Controls.Add(Me.newUpdateServiceBtn)
        Me.Controls.Add(Me.CustomerNameLbl)
        Me.Controls.Add(Me.addCustomerBtn)
        Me.Controls.Add(Me.logoutLbl)
        Me.Controls.Add(Me.newSalesOrderBtn)
        Me.Name = "MainSalesForm"
        Me.Text = "MainSalesForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents logoutLbl As Label
    Friend WithEvents newSalesOrderBtn As Button
    Friend WithEvents addCustomerBtn As Button
    Friend WithEvents CustomerNameLbl As Label
    Friend WithEvents newUpdateServiceBtn As Button
    Friend WithEvents sparePartsDetailsBtn As Button
    Friend WithEvents addVehiclesBtn As Button
End Class
