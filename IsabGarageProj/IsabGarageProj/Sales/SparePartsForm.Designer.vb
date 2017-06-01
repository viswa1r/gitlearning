<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SparePartsForm
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.partNameComboBox = New System.Windows.Forms.ComboBox()
        Me.unitsInStockTextBox = New System.Windows.Forms.TextBox()
        Me.unitsInStockLbl = New System.Windows.Forms.Label()
        Me.unitsInOrderTextBox = New System.Windows.Forms.TextBox()
        Me.unitSInOrderLbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ModeComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.unitPriceTextBx = New System.Windows.Forms.TextBox()
        Me.unitPrice = New System.Windows.Forms.Label()
        Me.modelComboBox = New System.Windows.Forms.ComboBox()
        Me.modelLbl = New System.Windows.Forms.Label()
        Me.cmpComboBox = New System.Windows.Forms.ComboBox()
        Me.companyLbl = New System.Windows.Forms.Label()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.backBtn = New System.Windows.Forms.Button()
        Me.ErrorProvider_sp = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.addSupplierBtn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider_sp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.partNameComboBox)
        Me.GroupBox1.Controls.Add(Me.unitsInStockTextBox)
        Me.GroupBox1.Controls.Add(Me.unitsInStockLbl)
        Me.GroupBox1.Controls.Add(Me.unitsInOrderTextBox)
        Me.GroupBox1.Controls.Add(Me.unitSInOrderLbl)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ModeComboBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.unitPriceTextBx)
        Me.GroupBox1.Controls.Add(Me.unitPrice)
        Me.GroupBox1.Controls.Add(Me.modelComboBox)
        Me.GroupBox1.Controls.Add(Me.modelLbl)
        Me.GroupBox1.Controls.Add(Me.cmpComboBox)
        Me.GroupBox1.Controls.Add(Me.companyLbl)
        Me.GroupBox1.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox1.Location = New System.Drawing.Point(40, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 367)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Spare Parts Details"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(239, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 18)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(290, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 18)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(290, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 18)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(290, 67)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(14, 18)
        Me.Label14.TabIndex = 52
        Me.Label14.Text = "*"
        '
        'partNameComboBox
        '
        Me.partNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.partNameComboBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partNameComboBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.partNameComboBox.FormattingEnabled = True
        Me.partNameComboBox.Location = New System.Drawing.Point(133, 183)
        Me.partNameComboBox.Name = "partNameComboBox"
        Me.partNameComboBox.Size = New System.Drawing.Size(151, 26)
        Me.partNameComboBox.TabIndex = 4
        '
        'unitsInStockTextBox
        '
        Me.unitsInStockTextBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.unitsInStockTextBox.Location = New System.Drawing.Point(133, 269)
        Me.unitsInStockTextBox.Name = "unitsInStockTextBox"
        Me.unitsInStockTextBox.Size = New System.Drawing.Size(101, 23)
        Me.unitsInStockTextBox.TabIndex = 6
        Me.unitsInStockTextBox.Text = "0"
        Me.unitsInStockTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'unitsInStockLbl
        '
        Me.unitsInStockLbl.AutoSize = True
        Me.unitsInStockLbl.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.unitsInStockLbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.unitsInStockLbl.Location = New System.Drawing.Point(14, 269)
        Me.unitsInStockLbl.Name = "unitsInStockLbl"
        Me.unitsInStockLbl.Size = New System.Drawing.Size(86, 18)
        Me.unitsInStockLbl.TabIndex = 33
        Me.unitsInStockLbl.Text = "UnitsInStock"
        '
        'unitsInOrderTextBox
        '
        Me.unitsInOrderTextBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.unitsInOrderTextBox.Location = New System.Drawing.Point(133, 313)
        Me.unitsInOrderTextBox.Name = "unitsInOrderTextBox"
        Me.unitsInOrderTextBox.Size = New System.Drawing.Size(101, 23)
        Me.unitsInOrderTextBox.TabIndex = 7
        Me.unitsInOrderTextBox.Text = "0"
        Me.unitsInOrderTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'unitSInOrderLbl
        '
        Me.unitSInOrderLbl.AutoSize = True
        Me.unitSInOrderLbl.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.unitSInOrderLbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.unitSInOrderLbl.Location = New System.Drawing.Point(23, 313)
        Me.unitSInOrderLbl.Name = "unitSInOrderLbl"
        Me.unitSInOrderLbl.Size = New System.Drawing.Size(83, 18)
        Me.unitSInOrderLbl.TabIndex = 31
        Me.unitSInOrderLbl.Text = "UnitInOrder"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(28, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Part Name"
        '
        'ModeComboBox
        '
        Me.ModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ModeComboBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModeComboBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ModeComboBox.FormattingEnabled = True
        Me.ModeComboBox.Location = New System.Drawing.Point(133, 31)
        Me.ModeComboBox.Name = "ModeComboBox"
        Me.ModeComboBox.Size = New System.Drawing.Size(151, 26)
        Me.ModeComboBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(57, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 18)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Mode"
        '
        'unitPriceTextBx
        '
        Me.unitPriceTextBx.ForeColor = System.Drawing.Color.MidnightBlue
        Me.unitPriceTextBx.Location = New System.Drawing.Point(133, 229)
        Me.unitPriceTextBx.Name = "unitPriceTextBx"
        Me.unitPriceTextBx.Size = New System.Drawing.Size(101, 23)
        Me.unitPriceTextBx.TabIndex = 5
        Me.unitPriceTextBx.Text = "0.00"
        Me.unitPriceTextBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'unitPrice
        '
        Me.unitPrice.AutoSize = True
        Me.unitPrice.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.unitPrice.ForeColor = System.Drawing.Color.MidnightBlue
        Me.unitPrice.Location = New System.Drawing.Point(33, 229)
        Me.unitPrice.Name = "unitPrice"
        Me.unitPrice.Size = New System.Drawing.Size(67, 18)
        Me.unitPrice.TabIndex = 25
        Me.unitPrice.Text = "Unit Price"
        '
        'modelComboBox
        '
        Me.modelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.modelComboBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modelComboBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.modelComboBox.FormattingEnabled = True
        Me.modelComboBox.Location = New System.Drawing.Point(133, 136)
        Me.modelComboBox.Name = "modelComboBox"
        Me.modelComboBox.Size = New System.Drawing.Size(151, 26)
        Me.modelComboBox.TabIndex = 3
        '
        'modelLbl
        '
        Me.modelLbl.AutoSize = True
        Me.modelLbl.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modelLbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.modelLbl.Location = New System.Drawing.Point(50, 136)
        Me.modelLbl.Name = "modelLbl"
        Me.modelLbl.Size = New System.Drawing.Size(47, 18)
        Me.modelLbl.TabIndex = 21
        Me.modelLbl.Text = "Model"
        '
        'cmpComboBox
        '
        Me.cmpComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmpComboBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmpComboBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmpComboBox.FormattingEnabled = True
        Me.cmpComboBox.Location = New System.Drawing.Point(133, 83)
        Me.cmpComboBox.Name = "cmpComboBox"
        Me.cmpComboBox.Size = New System.Drawing.Size(151, 26)
        Me.cmpComboBox.TabIndex = 2
        '
        'companyLbl
        '
        Me.companyLbl.AutoSize = True
        Me.companyLbl.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.companyLbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.companyLbl.Location = New System.Drawing.Point(34, 83)
        Me.companyLbl.Name = "companyLbl"
        Me.companyLbl.Size = New System.Drawing.Size(66, 18)
        Me.companyLbl.TabIndex = 19
        Me.companyLbl.Text = "Company"
        '
        'clearBtn
        '
        Me.clearBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.clearBtn.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.clearBtn.Location = New System.Drawing.Point(187, 428)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(87, 37)
        Me.clearBtn.TabIndex = 10
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = False
        '
        'saveBtn
        '
        Me.saveBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.saveBtn.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.saveBtn.Location = New System.Drawing.Point(46, 428)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(87, 37)
        Me.saveBtn.TabIndex = 9
        Me.saveBtn.Text = "Save"
        Me.saveBtn.UseVisualStyleBackColor = False
        '
        'backBtn
        '
        Me.backBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.backBtn.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.backBtn.Location = New System.Drawing.Point(315, 428)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(87, 37)
        Me.backBtn.TabIndex = 11
        Me.backBtn.Text = "Exit"
        Me.backBtn.UseVisualStyleBackColor = False
        '
        'ErrorProvider_sp
        '
        Me.ErrorProvider_sp.ContainerControl = Me
        '
        'addSupplierBtn
        '
        Me.addSupplierBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.addSupplierBtn.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addSupplierBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.addSupplierBtn.Location = New System.Drawing.Point(358, 119)
        Me.addSupplierBtn.Name = "addSupplierBtn"
        Me.addSupplierBtn.Size = New System.Drawing.Size(114, 32)
        Me.addSupplierBtn.TabIndex = 12
        Me.addSupplierBtn.Text = "Add Supplier"
        Me.addSupplierBtn.UseVisualStyleBackColor = False
        '
        'SparePartsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(484, 492)
        Me.Controls.Add(Me.addSupplierBtn)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.backBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "SparePartsForm"
        Me.Text = "Spare Parts"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider_sp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents unitPriceTextBx As TextBox
    Friend WithEvents unitPrice As Label
    Friend WithEvents modelComboBox As ComboBox
    Friend WithEvents modelLbl As Label
    Friend WithEvents cmpComboBox As ComboBox
    Friend WithEvents companyLbl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ModeComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents clearBtn As Button
    Friend WithEvents saveBtn As Button
    Friend WithEvents backBtn As Button
    Friend WithEvents unitsInStockTextBox As TextBox
    Friend WithEvents unitsInStockLbl As Label
    Friend WithEvents unitsInOrderTextBox As TextBox
    Friend WithEvents unitSInOrderLbl As Label
    Friend WithEvents partNameComboBox As ComboBox
    Friend WithEvents ErrorProvider_sp As ErrorProvider
    Friend WithEvents Label14 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents addSupplierBtn As Button
End Class
