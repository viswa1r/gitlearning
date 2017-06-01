<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SalesOrderForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalesOrderForm))
        Me.basicDetailsGrpBox = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.addCustomerBtn = New System.Windows.Forms.Button()
        Me.CustomerDataGridView = New System.Windows.Forms.DataGridView()
        Me.searchBtn = New System.Windows.Forms.Button()
        Me.custSearchStrTextBox = New System.Windows.Forms.TextBox()
        Me.custIDRadioBtn = New System.Windows.Forms.RadioButton()
        Me.phNoRadioBtn = New System.Windows.Forms.RadioButton()
        Me.frstNameRadioBtn = New System.Windows.Forms.RadioButton()
        Me.lastNameRadioBtn = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.WarrantyNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.warrentyLbl = New System.Windows.Forms.Label()
        Me.EmpIDTextBox = New System.Windows.Forms.TextBox()
        Me.empIDLbl = New System.Windows.Forms.Label()
        Me.custlDTextBox = New System.Windows.Forms.TextBox()
        Me.customerIDLbl = New System.Windows.Forms.Label()
        Me.OrderIDTextBox = New System.Windows.Forms.TextBox()
        Me.orderIDLbl = New System.Windows.Forms.Label()
        Me.sparePartsDetailsGrpBx = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.unitPriceTextBx = New System.Windows.Forms.TextBox()
        Me.unitPrice = New System.Windows.Forms.Label()
        Me.discountTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.QtyNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.selectedListLbl = New System.Windows.Forms.Label()
        Me.partIDLbl = New System.Windows.Forms.Label()
        Me.selectBtn = New System.Windows.Forms.Button()
        Me.deselectBtn = New System.Windows.Forms.Button()
        Me.selectedListItems = New System.Windows.Forms.ListBox()
        Me.partNameComboBox = New System.Windows.Forms.ComboBox()
        Me.partNameLbl = New System.Windows.Forms.Label()
        Me.modelComboBox = New System.Windows.Forms.ComboBox()
        Me.modelLbl = New System.Windows.Forms.Label()
        Me.cmpComboBox = New System.Windows.Forms.ComboBox()
        Me.companyLbl = New System.Windows.Forms.Label()
        Me.priceDetailsGroupBox = New System.Windows.Forms.GroupBox()
        Me.paymentComboBox = New System.Windows.Forms.ComboBox()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.paymentStatusLbl = New System.Windows.Forms.Label()
        Me.totDiscountTextBox = New System.Windows.Forms.TextBox()
        Me.TotalDisLbl = New System.Windows.Forms.Label()
        Me.createBtn = New System.Windows.Forms.Button()
        Me.printBtn = New System.Windows.Forms.Button()
        Me.finalPriceTextBox = New System.Windows.Forms.TextBox()
        Me.finalPriceLbl = New System.Windows.Forms.Label()
        Me.taxTextBox = New System.Windows.Forms.TextBox()
        Me.taxLbl = New System.Windows.Forms.Label()
        Me.subTotalTextBox = New System.Windows.Forms.TextBox()
        Me.subTotalLbl = New System.Windows.Forms.Label()
        Me.OrderPrintPreviewDialog = New System.Windows.Forms.PrintPreviewDialog()
        Me.OrderPrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.basicDetailsGrpBox.SuspendLayout()
        CType(Me.CustomerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WarrantyNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sparePartsDetailsGrpBx.SuspendLayout()
        CType(Me.QtyNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.priceDetailsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'basicDetailsGrpBox
        '
        Me.basicDetailsGrpBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.basicDetailsGrpBox.Controls.Add(Me.Label3)
        Me.basicDetailsGrpBox.Controls.Add(Me.addCustomerBtn)
        Me.basicDetailsGrpBox.Controls.Add(Me.CustomerDataGridView)
        Me.basicDetailsGrpBox.Controls.Add(Me.searchBtn)
        Me.basicDetailsGrpBox.Controls.Add(Me.custSearchStrTextBox)
        Me.basicDetailsGrpBox.Controls.Add(Me.custIDRadioBtn)
        Me.basicDetailsGrpBox.Controls.Add(Me.phNoRadioBtn)
        Me.basicDetailsGrpBox.Controls.Add(Me.frstNameRadioBtn)
        Me.basicDetailsGrpBox.Controls.Add(Me.lastNameRadioBtn)
        Me.basicDetailsGrpBox.Controls.Add(Me.Label5)
        Me.basicDetailsGrpBox.Controls.Add(Me.WarrantyNumericUpDown)
        Me.basicDetailsGrpBox.Controls.Add(Me.warrentyLbl)
        Me.basicDetailsGrpBox.Controls.Add(Me.EmpIDTextBox)
        Me.basicDetailsGrpBox.Controls.Add(Me.empIDLbl)
        Me.basicDetailsGrpBox.Controls.Add(Me.custlDTextBox)
        Me.basicDetailsGrpBox.Controls.Add(Me.customerIDLbl)
        Me.basicDetailsGrpBox.Controls.Add(Me.OrderIDTextBox)
        Me.basicDetailsGrpBox.Controls.Add(Me.orderIDLbl)
        Me.basicDetailsGrpBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.basicDetailsGrpBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.basicDetailsGrpBox.Location = New System.Drawing.Point(12, 12)
        Me.basicDetailsGrpBox.Name = "basicDetailsGrpBox"
        Me.basicDetailsGrpBox.Size = New System.Drawing.Size(654, 195)
        Me.basicDetailsGrpBox.TabIndex = 1
        Me.basicDetailsGrpBox.TabStop = False
        Me.basicDetailsGrpBox.Text = "Basic Details"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(205, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 18)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "*"
        '
        'addCustomerBtn
        '
        Me.addCustomerBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.addCustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.addCustomerBtn.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addCustomerBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.addCustomerBtn.Location = New System.Drawing.Point(529, 45)
        Me.addCustomerBtn.Name = "addCustomerBtn"
        Me.addCustomerBtn.Size = New System.Drawing.Size(119, 25)
        Me.addCustomerBtn.TabIndex = 17
        Me.addCustomerBtn.Text = "Add Customer"
        Me.addCustomerBtn.UseVisualStyleBackColor = False
        '
        'CustomerDataGridView
        '
        Me.CustomerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerDataGridView.Location = New System.Drawing.Point(242, 74)
        Me.CustomerDataGridView.Name = "CustomerDataGridView"
        Me.CustomerDataGridView.Size = New System.Drawing.Size(404, 115)
        Me.CustomerDataGridView.TabIndex = 16
        '
        'searchBtn
        '
        Me.searchBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.searchBtn.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.searchBtn.Location = New System.Drawing.Point(444, 45)
        Me.searchBtn.Name = "searchBtn"
        Me.searchBtn.Size = New System.Drawing.Size(78, 25)
        Me.searchBtn.TabIndex = 15
        Me.searchBtn.Text = "Search"
        Me.searchBtn.UseVisualStyleBackColor = False
        '
        'custSearchStrTextBox
        '
        Me.custSearchStrTextBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.custSearchStrTextBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.custSearchStrTextBox.Location = New System.Drawing.Point(444, 19)
        Me.custSearchStrTextBox.Name = "custSearchStrTextBox"
        Me.custSearchStrTextBox.Size = New System.Drawing.Size(175, 23)
        Me.custSearchStrTextBox.TabIndex = 14
        '
        'custIDRadioBtn
        '
        Me.custIDRadioBtn.AutoSize = True
        Me.custIDRadioBtn.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.custIDRadioBtn.ForeColor = System.Drawing.Color.MidnightBlue
        Me.custIDRadioBtn.Location = New System.Drawing.Point(335, 48)
        Me.custIDRadioBtn.Name = "custIDRadioBtn"
        Me.custIDRadioBtn.Size = New System.Drawing.Size(103, 22)
        Me.custIDRadioBtn.TabIndex = 13
        Me.custIDRadioBtn.Text = "Customer ID"
        Me.custIDRadioBtn.UseVisualStyleBackColor = True
        '
        'phNoRadioBtn
        '
        Me.phNoRadioBtn.AutoSize = True
        Me.phNoRadioBtn.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phNoRadioBtn.ForeColor = System.Drawing.Color.MidnightBlue
        Me.phNoRadioBtn.Location = New System.Drawing.Point(244, 48)
        Me.phNoRadioBtn.Name = "phNoRadioBtn"
        Me.phNoRadioBtn.Size = New System.Drawing.Size(85, 22)
        Me.phNoRadioBtn.TabIndex = 12
        Me.phNoRadioBtn.Text = "Phone No"
        Me.phNoRadioBtn.UseVisualStyleBackColor = True
        '
        'frstNameRadioBtn
        '
        Me.frstNameRadioBtn.AutoSize = True
        Me.frstNameRadioBtn.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frstNameRadioBtn.ForeColor = System.Drawing.Color.MidnightBlue
        Me.frstNameRadioBtn.Location = New System.Drawing.Point(335, 19)
        Me.frstNameRadioBtn.Name = "frstNameRadioBtn"
        Me.frstNameRadioBtn.Size = New System.Drawing.Size(92, 22)
        Me.frstNameRadioBtn.TabIndex = 11
        Me.frstNameRadioBtn.Text = "First Name"
        Me.frstNameRadioBtn.UseVisualStyleBackColor = True
        '
        'lastNameRadioBtn
        '
        Me.lastNameRadioBtn.AutoSize = True
        Me.lastNameRadioBtn.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastNameRadioBtn.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lastNameRadioBtn.Location = New System.Drawing.Point(244, 19)
        Me.lastNameRadioBtn.Name = "lastNameRadioBtn"
        Me.lastNameRadioBtn.Size = New System.Drawing.Size(91, 22)
        Me.lastNameRadioBtn.TabIndex = 10
        Me.lastNameRadioBtn.Text = "Last Name"
        Me.lastNameRadioBtn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Location = New System.Drawing.Point(154, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Yrs"
        '
        'WarrantyNumericUpDown
        '
        Me.WarrantyNumericUpDown.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WarrantyNumericUpDown.ForeColor = System.Drawing.Color.MidnightBlue
        Me.WarrantyNumericUpDown.Location = New System.Drawing.Point(102, 141)
        Me.WarrantyNumericUpDown.Name = "WarrantyNumericUpDown"
        Me.WarrantyNumericUpDown.Size = New System.Drawing.Size(47, 23)
        Me.WarrantyNumericUpDown.TabIndex = 8
        '
        'warrentyLbl
        '
        Me.warrentyLbl.AutoSize = True
        Me.warrentyLbl.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.warrentyLbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.warrentyLbl.Location = New System.Drawing.Point(25, 144)
        Me.warrentyLbl.Name = "warrentyLbl"
        Me.warrentyLbl.Size = New System.Drawing.Size(64, 18)
        Me.warrentyLbl.TabIndex = 6
        Me.warrentyLbl.Text = "Warrenty"
        '
        'EmpIDTextBox
        '
        Me.EmpIDTextBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpIDTextBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.EmpIDTextBox.Location = New System.Drawing.Point(102, 101)
        Me.EmpIDTextBox.Name = "EmpIDTextBox"
        Me.EmpIDTextBox.Size = New System.Drawing.Size(100, 23)
        Me.EmpIDTextBox.TabIndex = 5
        '
        'empIDLbl
        '
        Me.empIDLbl.AutoSize = True
        Me.empIDLbl.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empIDLbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.empIDLbl.Location = New System.Drawing.Point(1, 105)
        Me.empIDLbl.Name = "empIDLbl"
        Me.empIDLbl.Size = New System.Drawing.Size(87, 18)
        Me.empIDLbl.TabIndex = 4
        Me.empIDLbl.Text = "Employee ID"
        '
        'custlDTextBox
        '
        Me.custlDTextBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.custlDTextBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.custlDTextBox.Location = New System.Drawing.Point(102, 63)
        Me.custlDTextBox.Name = "custlDTextBox"
        Me.custlDTextBox.Size = New System.Drawing.Size(100, 23)
        Me.custlDTextBox.TabIndex = 3
        '
        'customerIDLbl
        '
        Me.customerIDLbl.AutoSize = True
        Me.customerIDLbl.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customerIDLbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.customerIDLbl.Location = New System.Drawing.Point(6, 67)
        Me.customerIDLbl.Name = "customerIDLbl"
        Me.customerIDLbl.Size = New System.Drawing.Size(85, 18)
        Me.customerIDLbl.TabIndex = 2
        Me.customerIDLbl.Text = "Customer ID"
        '
        'OrderIDTextBox
        '
        Me.OrderIDTextBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderIDTextBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.OrderIDTextBox.Location = New System.Drawing.Point(102, 28)
        Me.OrderIDTextBox.Name = "OrderIDTextBox"
        Me.OrderIDTextBox.Size = New System.Drawing.Size(100, 23)
        Me.OrderIDTextBox.TabIndex = 1
        '
        'orderIDLbl
        '
        Me.orderIDLbl.AutoSize = True
        Me.orderIDLbl.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.orderIDLbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.orderIDLbl.Location = New System.Drawing.Point(29, 31)
        Me.orderIDLbl.Name = "orderIDLbl"
        Me.orderIDLbl.Size = New System.Drawing.Size(63, 18)
        Me.orderIDLbl.TabIndex = 0
        Me.orderIDLbl.Text = "Order ID"
        '
        'sparePartsDetailsGrpBx
        '
        Me.sparePartsDetailsGrpBx.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.sparePartsDetailsGrpBx.Controls.Add(Me.Label6)
        Me.sparePartsDetailsGrpBx.Controls.Add(Me.Label4)
        Me.sparePartsDetailsGrpBx.Controls.Add(Me.unitPriceTextBx)
        Me.sparePartsDetailsGrpBx.Controls.Add(Me.unitPrice)
        Me.sparePartsDetailsGrpBx.Controls.Add(Me.discountTextBox)
        Me.sparePartsDetailsGrpBx.Controls.Add(Me.Label1)
        Me.sparePartsDetailsGrpBx.Controls.Add(Me.clearBtn)
        Me.sparePartsDetailsGrpBx.Controls.Add(Me.QtyNumericUpDown)
        Me.sparePartsDetailsGrpBx.Controls.Add(Me.Label2)
        Me.sparePartsDetailsGrpBx.Controls.Add(Me.selectedListLbl)
        Me.sparePartsDetailsGrpBx.Controls.Add(Me.partIDLbl)
        Me.sparePartsDetailsGrpBx.Controls.Add(Me.selectBtn)
        Me.sparePartsDetailsGrpBx.Controls.Add(Me.deselectBtn)
        Me.sparePartsDetailsGrpBx.Controls.Add(Me.selectedListItems)
        Me.sparePartsDetailsGrpBx.Controls.Add(Me.partNameComboBox)
        Me.sparePartsDetailsGrpBx.Controls.Add(Me.partNameLbl)
        Me.sparePartsDetailsGrpBx.Controls.Add(Me.modelComboBox)
        Me.sparePartsDetailsGrpBx.Controls.Add(Me.modelLbl)
        Me.sparePartsDetailsGrpBx.Controls.Add(Me.cmpComboBox)
        Me.sparePartsDetailsGrpBx.Controls.Add(Me.companyLbl)
        Me.sparePartsDetailsGrpBx.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sparePartsDetailsGrpBx.ForeColor = System.Drawing.Color.MidnightBlue
        Me.sparePartsDetailsGrpBx.Location = New System.Drawing.Point(12, 213)
        Me.sparePartsDetailsGrpBx.Name = "sparePartsDetailsGrpBx"
        Me.sparePartsDetailsGrpBx.Size = New System.Drawing.Size(654, 221)
        Me.sparePartsDetailsGrpBx.TabIndex = 2
        Me.sparePartsDetailsGrpBx.TabStop = False
        Me.sparePartsDetailsGrpBx.Text = "Spare Parts Details"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(301, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 18)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "(x%=x/100, Ex:0.02)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(404, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 18)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "*"
        '
        'unitPriceTextBx
        '
        Me.unitPriceTextBx.ForeColor = System.Drawing.Color.MidnightBlue
        Me.unitPriceTextBx.Location = New System.Drawing.Point(102, 153)
        Me.unitPriceTextBx.Name = "unitPriceTextBx"
        Me.unitPriceTextBx.Size = New System.Drawing.Size(80, 23)
        Me.unitPriceTextBx.TabIndex = 18
        Me.unitPriceTextBx.Text = "0.00"
        Me.unitPriceTextBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'unitPrice
        '
        Me.unitPrice.AutoSize = True
        Me.unitPrice.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.unitPrice.ForeColor = System.Drawing.Color.MidnightBlue
        Me.unitPrice.Location = New System.Drawing.Point(20, 156)
        Me.unitPrice.Name = "unitPrice"
        Me.unitPrice.Size = New System.Drawing.Size(67, 18)
        Me.unitPrice.TabIndex = 17
        Me.unitPrice.Text = "Unit Price"
        '
        'discountTextBox
        '
        Me.discountTextBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.discountTextBox.Location = New System.Drawing.Point(242, 183)
        Me.discountTextBox.Name = "discountTextBox"
        Me.discountTextBox.Size = New System.Drawing.Size(59, 23)
        Me.discountTextBox.TabIndex = 16
        Me.discountTextBox.Text = "0.00"
        Me.discountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(175, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 18)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Discount"
        '
        'clearBtn
        '
        Me.clearBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.clearBtn.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.clearBtn.Location = New System.Drawing.Point(529, 171)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(90, 25)
        Me.clearBtn.TabIndex = 10
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = False
        '
        'QtyNumericUpDown
        '
        Me.QtyNumericUpDown.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QtyNumericUpDown.ForeColor = System.Drawing.Color.MidnightBlue
        Me.QtyNumericUpDown.Location = New System.Drawing.Point(102, 186)
        Me.QtyNumericUpDown.Name = "QtyNumericUpDown"
        Me.QtyNumericUpDown.Size = New System.Drawing.Size(47, 23)
        Me.QtyNumericUpDown.TabIndex = 14
        Me.QtyNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(57, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 18)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Qty"
        '
        'selectedListLbl
        '
        Me.selectedListLbl.AutoSize = True
        Me.selectedListLbl.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectedListLbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.selectedListLbl.Location = New System.Drawing.Point(314, 22)
        Me.selectedListLbl.Name = "selectedListLbl"
        Me.selectedListLbl.Size = New System.Drawing.Size(84, 18)
        Me.selectedListLbl.TabIndex = 12
        Me.selectedListLbl.Text = "Selected List"
        '
        'partIDLbl
        '
        Me.partIDLbl.AutoSize = True
        Me.partIDLbl.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partIDLbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.partIDLbl.Location = New System.Drawing.Point(314, 43)
        Me.partIDLbl.Name = "partIDLbl"
        Me.partIDLbl.Size = New System.Drawing.Size(48, 18)
        Me.partIDLbl.TabIndex = 10
        Me.partIDLbl.Text = "PartID"
        '
        'selectBtn
        '
        Me.selectBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.selectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.selectBtn.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.selectBtn.Location = New System.Drawing.Point(528, 43)
        Me.selectBtn.Name = "selectBtn"
        Me.selectBtn.Size = New System.Drawing.Size(90, 25)
        Me.selectBtn.TabIndex = 9
        Me.selectBtn.Text = "Select"
        Me.selectBtn.UseVisualStyleBackColor = False
        '
        'deselectBtn
        '
        Me.deselectBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.deselectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.deselectBtn.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deselectBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.deselectBtn.Location = New System.Drawing.Point(528, 111)
        Me.deselectBtn.Name = "deselectBtn"
        Me.deselectBtn.Size = New System.Drawing.Size(90, 25)
        Me.deselectBtn.TabIndex = 7
        Me.deselectBtn.Text = "Deselect"
        Me.deselectBtn.UseVisualStyleBackColor = False
        '
        'selectedListItems
        '
        Me.selectedListItems.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectedListItems.ForeColor = System.Drawing.Color.MidnightBlue
        Me.selectedListItems.FormattingEnabled = True
        Me.selectedListItems.ItemHeight = 18
        Me.selectedListItems.Location = New System.Drawing.Point(317, 59)
        Me.selectedListItems.Name = "selectedListItems"
        Me.selectedListItems.Size = New System.Drawing.Size(170, 112)
        Me.selectedListItems.TabIndex = 6
        '
        'partNameComboBox
        '
        Me.partNameComboBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partNameComboBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.partNameComboBox.FormattingEnabled = True
        Me.partNameComboBox.Location = New System.Drawing.Point(102, 110)
        Me.partNameComboBox.Name = "partNameComboBox"
        Me.partNameComboBox.Size = New System.Drawing.Size(121, 26)
        Me.partNameComboBox.TabIndex = 5
        '
        'partNameLbl
        '
        Me.partNameLbl.AutoSize = True
        Me.partNameLbl.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partNameLbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.partNameLbl.Location = New System.Drawing.Point(15, 111)
        Me.partNameLbl.Name = "partNameLbl"
        Me.partNameLbl.Size = New System.Drawing.Size(72, 18)
        Me.partNameLbl.TabIndex = 4
        Me.partNameLbl.Text = "Part Name"
        '
        'modelComboBox
        '
        Me.modelComboBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modelComboBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.modelComboBox.FormattingEnabled = True
        Me.modelComboBox.Location = New System.Drawing.Point(102, 71)
        Me.modelComboBox.Name = "modelComboBox"
        Me.modelComboBox.Size = New System.Drawing.Size(121, 26)
        Me.modelComboBox.TabIndex = 3
        '
        'modelLbl
        '
        Me.modelLbl.AutoSize = True
        Me.modelLbl.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modelLbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.modelLbl.Location = New System.Drawing.Point(41, 71)
        Me.modelLbl.Name = "modelLbl"
        Me.modelLbl.Size = New System.Drawing.Size(47, 18)
        Me.modelLbl.TabIndex = 2
        Me.modelLbl.Text = "Model"
        '
        'cmpComboBox
        '
        Me.cmpComboBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmpComboBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmpComboBox.FormattingEnabled = True
        Me.cmpComboBox.Location = New System.Drawing.Point(102, 33)
        Me.cmpComboBox.Name = "cmpComboBox"
        Me.cmpComboBox.Size = New System.Drawing.Size(121, 26)
        Me.cmpComboBox.TabIndex = 1
        '
        'companyLbl
        '
        Me.companyLbl.AutoSize = True
        Me.companyLbl.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.companyLbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.companyLbl.Location = New System.Drawing.Point(21, 34)
        Me.companyLbl.Name = "companyLbl"
        Me.companyLbl.Size = New System.Drawing.Size(66, 18)
        Me.companyLbl.TabIndex = 0
        Me.companyLbl.Text = "Company"
        '
        'priceDetailsGroupBox
        '
        Me.priceDetailsGroupBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.priceDetailsGroupBox.Controls.Add(Me.paymentComboBox)
        Me.priceDetailsGroupBox.Controls.Add(Me.exitBtn)
        Me.priceDetailsGroupBox.Controls.Add(Me.paymentStatusLbl)
        Me.priceDetailsGroupBox.Controls.Add(Me.totDiscountTextBox)
        Me.priceDetailsGroupBox.Controls.Add(Me.TotalDisLbl)
        Me.priceDetailsGroupBox.Controls.Add(Me.createBtn)
        Me.priceDetailsGroupBox.Controls.Add(Me.printBtn)
        Me.priceDetailsGroupBox.Controls.Add(Me.finalPriceTextBox)
        Me.priceDetailsGroupBox.Controls.Add(Me.finalPriceLbl)
        Me.priceDetailsGroupBox.Controls.Add(Me.taxTextBox)
        Me.priceDetailsGroupBox.Controls.Add(Me.taxLbl)
        Me.priceDetailsGroupBox.Controls.Add(Me.subTotalTextBox)
        Me.priceDetailsGroupBox.Controls.Add(Me.subTotalLbl)
        Me.priceDetailsGroupBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.priceDetailsGroupBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.priceDetailsGroupBox.Location = New System.Drawing.Point(12, 440)
        Me.priceDetailsGroupBox.Name = "priceDetailsGroupBox"
        Me.priceDetailsGroupBox.Size = New System.Drawing.Size(654, 122)
        Me.priceDetailsGroupBox.TabIndex = 3
        Me.priceDetailsGroupBox.TabStop = False
        Me.priceDetailsGroupBox.Text = "Price Details"
        '
        'paymentComboBox
        '
        Me.paymentComboBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paymentComboBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.paymentComboBox.FormattingEnabled = True
        Me.paymentComboBox.Location = New System.Drawing.Point(369, 59)
        Me.paymentComboBox.Name = "paymentComboBox"
        Me.paymentComboBox.Size = New System.Drawing.Size(121, 26)
        Me.paymentComboBox.TabIndex = 20
        '
        'exitBtn
        '
        Me.exitBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.exitBtn.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.exitBtn.Location = New System.Drawing.Point(516, 97)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(117, 25)
        Me.exitBtn.TabIndex = 23
        Me.exitBtn.Text = "Exit"
        Me.exitBtn.UseVisualStyleBackColor = False
        '
        'paymentStatusLbl
        '
        Me.paymentStatusLbl.AutoSize = True
        Me.paymentStatusLbl.Location = New System.Drawing.Point(261, 60)
        Me.paymentStatusLbl.Name = "paymentStatusLbl"
        Me.paymentStatusLbl.Size = New System.Drawing.Size(101, 18)
        Me.paymentStatusLbl.TabIndex = 21
        Me.paymentStatusLbl.Text = "Payment Status"
        '
        'totDiscountTextBox
        '
        Me.totDiscountTextBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.totDiscountTextBox.Location = New System.Drawing.Point(102, 90)
        Me.totDiscountTextBox.Name = "totDiscountTextBox"
        Me.totDiscountTextBox.Size = New System.Drawing.Size(127, 23)
        Me.totDiscountTextBox.TabIndex = 20
        Me.totDiscountTextBox.Text = "0.00"
        Me.totDiscountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TotalDisLbl
        '
        Me.TotalDisLbl.AutoSize = True
        Me.TotalDisLbl.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalDisLbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TotalDisLbl.Location = New System.Drawing.Point(1, 90)
        Me.TotalDisLbl.Name = "TotalDisLbl"
        Me.TotalDisLbl.Size = New System.Drawing.Size(96, 18)
        Me.TotalDisLbl.TabIndex = 19
        Me.TotalDisLbl.Text = "Total Discount"
        '
        'createBtn
        '
        Me.createBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.createBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.createBtn.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.createBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.createBtn.Location = New System.Drawing.Point(516, 21)
        Me.createBtn.Name = "createBtn"
        Me.createBtn.Size = New System.Drawing.Size(117, 25)
        Me.createBtn.TabIndex = 9
        Me.createBtn.Text = "Create Order"
        Me.createBtn.UseVisualStyleBackColor = False
        '
        'printBtn
        '
        Me.printBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.printBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.printBtn.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.printBtn.Location = New System.Drawing.Point(516, 60)
        Me.printBtn.Name = "printBtn"
        Me.printBtn.Size = New System.Drawing.Size(117, 25)
        Me.printBtn.TabIndex = 8
        Me.printBtn.Text = "Print Receipt"
        Me.printBtn.UseVisualStyleBackColor = False
        '
        'finalPriceTextBox
        '
        Me.finalPriceTextBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.finalPriceTextBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.finalPriceTextBox.Location = New System.Drawing.Point(369, 20)
        Me.finalPriceTextBox.Name = "finalPriceTextBox"
        Me.finalPriceTextBox.Size = New System.Drawing.Size(118, 23)
        Me.finalPriceTextBox.TabIndex = 7
        Me.finalPriceTextBox.Text = "0.00"
        Me.finalPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'finalPriceLbl
        '
        Me.finalPriceLbl.AutoSize = True
        Me.finalPriceLbl.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.finalPriceLbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.finalPriceLbl.Location = New System.Drawing.Point(274, 21)
        Me.finalPriceLbl.Name = "finalPriceLbl"
        Me.finalPriceLbl.Size = New System.Drawing.Size(71, 18)
        Me.finalPriceLbl.TabIndex = 6
        Me.finalPriceLbl.Text = "Final Price"
        '
        'taxTextBox
        '
        Me.taxTextBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.taxTextBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.taxTextBox.Location = New System.Drawing.Point(102, 55)
        Me.taxTextBox.Name = "taxTextBox"
        Me.taxTextBox.Size = New System.Drawing.Size(127, 23)
        Me.taxTextBox.TabIndex = 5
        Me.taxTextBox.Text = "0.06"
        Me.taxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'taxLbl
        '
        Me.taxLbl.AutoSize = True
        Me.taxLbl.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.taxLbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.taxLbl.Location = New System.Drawing.Point(53, 57)
        Me.taxLbl.Name = "taxLbl"
        Me.taxLbl.Size = New System.Drawing.Size(31, 18)
        Me.taxLbl.TabIndex = 4
        Me.taxLbl.Text = "Tax"
        '
        'subTotalTextBox
        '
        Me.subTotalTextBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subTotalTextBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.subTotalTextBox.Location = New System.Drawing.Point(102, 20)
        Me.subTotalTextBox.Name = "subTotalTextBox"
        Me.subTotalTextBox.Size = New System.Drawing.Size(126, 23)
        Me.subTotalTextBox.TabIndex = 1
        Me.subTotalTextBox.Text = "0.00"
        Me.subTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'subTotalLbl
        '
        Me.subTotalLbl.AutoSize = True
        Me.subTotalLbl.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subTotalLbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.subTotalLbl.Location = New System.Drawing.Point(18, 23)
        Me.subTotalLbl.Name = "subTotalLbl"
        Me.subTotalLbl.Size = New System.Drawing.Size(66, 18)
        Me.subTotalLbl.TabIndex = 0
        Me.subTotalLbl.Text = "Sub Total"
        '
        'OrderPrintPreviewDialog
        '
        Me.OrderPrintPreviewDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.OrderPrintPreviewDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.OrderPrintPreviewDialog.ClientSize = New System.Drawing.Size(400, 300)
        Me.OrderPrintPreviewDialog.Enabled = True
        Me.OrderPrintPreviewDialog.Icon = CType(resources.GetObject("OrderPrintPreviewDialog.Icon"), System.Drawing.Icon)
        Me.OrderPrintPreviewDialog.Name = "OrderPrintPreviewDialog"
        Me.OrderPrintPreviewDialog.Visible = False
        '
        'OrderPrintDocument
        '
        '
        'SalesOrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(674, 574)
        Me.Controls.Add(Me.priceDetailsGroupBox)
        Me.Controls.Add(Me.sparePartsDetailsGrpBx)
        Me.Controls.Add(Me.basicDetailsGrpBox)
        Me.Name = "SalesOrderForm"
        Me.Text = "SalesOrderForm"
        Me.basicDetailsGrpBox.ResumeLayout(False)
        Me.basicDetailsGrpBox.PerformLayout()
        CType(Me.CustomerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WarrantyNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sparePartsDetailsGrpBx.ResumeLayout(False)
        Me.sparePartsDetailsGrpBx.PerformLayout()
        CType(Me.QtyNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.priceDetailsGroupBox.ResumeLayout(False)
        Me.priceDetailsGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents basicDetailsGrpBox As GroupBox
    Friend WithEvents custlDTextBox As TextBox
    Friend WithEvents customerIDLbl As Label
    Friend WithEvents OrderIDTextBox As TextBox
    Friend WithEvents orderIDLbl As Label
    Friend WithEvents EmpIDTextBox As TextBox
    Friend WithEvents empIDLbl As Label
    Friend WithEvents warrentyLbl As Label
    Friend WithEvents WarrantyNumericUpDown As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents custIDRadioBtn As RadioButton
    Friend WithEvents phNoRadioBtn As RadioButton
    Friend WithEvents frstNameRadioBtn As RadioButton
    Friend WithEvents lastNameRadioBtn As RadioButton
    Friend WithEvents searchBtn As Button
    Friend WithEvents custSearchStrTextBox As TextBox
    Friend WithEvents CustomerDataGridView As DataGridView
    Friend WithEvents addCustomerBtn As Button
    Friend WithEvents sparePartsDetailsGrpBx As GroupBox
    Friend WithEvents cmpComboBox As ComboBox
    Friend WithEvents companyLbl As Label
    Friend WithEvents partNameComboBox As ComboBox
    Friend WithEvents partNameLbl As Label
    Friend WithEvents modelComboBox As ComboBox
    Friend WithEvents modelLbl As Label
    Friend WithEvents partIDLbl As Label
    Friend WithEvents selectBtn As Button
    Friend WithEvents deselectBtn As Button
    Friend WithEvents selectedListItems As ListBox
    Friend WithEvents selectedListLbl As Label
    Friend WithEvents priceDetailsGroupBox As GroupBox
    Friend WithEvents subTotalLbl As Label
    Friend WithEvents taxLbl As Label
    Friend WithEvents subTotalTextBox As TextBox
    Friend WithEvents taxTextBox As TextBox
    Friend WithEvents finalPriceTextBox As TextBox
    Friend WithEvents finalPriceLbl As Label
    Friend WithEvents clearBtn As Button
    Friend WithEvents createBtn As Button
    Friend WithEvents printBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents QtyNumericUpDown As NumericUpDown
    Friend WithEvents discountTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents unitPriceTextBx As TextBox
    Friend WithEvents unitPrice As Label
    Friend WithEvents OrderPrintPreviewDialog As PrintPreviewDialog
    Friend WithEvents OrderPrintDocument As Printing.PrintDocument
    Friend WithEvents totDiscountTextBox As TextBox
    Friend WithEvents TotalDisLbl As Label
    Friend WithEvents paymentStatusLbl As Label
    Friend WithEvents exitBtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents paymentComboBox As ComboBox
    Friend WithEvents Label6 As Label
End Class
