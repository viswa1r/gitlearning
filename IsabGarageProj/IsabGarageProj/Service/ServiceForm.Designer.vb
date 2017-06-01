<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ServiceForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ServiceForm))
        Me.basicdetailsgrpbox = New System.Windows.Forms.GroupBox()
        Me.addvehiclesButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.addcustButton = New System.Windows.Forms.Button()
        Me.searchcustButton = New System.Windows.Forms.Button()
        Me.custTB = New System.Windows.Forms.TextBox()
        Me.customeridRB = New System.Windows.Forms.RadioButton()
        Me.phoneRB = New System.Windows.Forms.RadioButton()
        Me.firstnameRB = New System.Windows.Forms.RadioButton()
        Me.lastnameRB = New System.Windows.Forms.RadioButton()
        Me.servicedetailsgrpbox = New System.Windows.Forms.GroupBox()
        Me.servesttimeTB = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.servemployeeidTB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.servvehicleidTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.existingserviceRB = New System.Windows.Forms.RadioButton()
        Me.newserviceRB = New System.Windows.Forms.RadioButton()
        Me.servtypeTB = New System.Windows.Forms.TextBox()
        Me.servstatusComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.descrRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.servvehiclenameTB = New System.Windows.Forms.TextBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.descriptionLabel = New System.Windows.Forms.Label()
        Me.deliverydateLabel = New System.Windows.Forms.Label()
        Me.receiveddateLabel = New System.Windows.Forms.Label()
        Me.servicetypeLabel = New System.Windows.Forms.Label()
        Me.vehicleidLabel = New System.Windows.Forms.Label()
        Me.serviceidTB = New System.Windows.Forms.TextBox()
        Me.searchservButton = New System.Windows.Forms.Button()
        Me.serviceidLabel = New System.Windows.Forms.Label()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.saveButton = New System.Windows.Forms.Button()
        Me.priceGrpBox = New System.Windows.Forms.GroupBox()
        Me.servtaxTB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cancelButton = New System.Windows.Forms.Button()
        Me.invoiceButton = New System.Windows.Forms.Button()
        Me.paymentstatusComboBox = New System.Windows.Forms.ComboBox()
        Me.totalpaymentTB = New System.Windows.Forms.TextBox()
        Me.hourlycostTB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.totalpaymentLabel = New System.Windows.Forms.Label()
        Me.hourlycostLabel = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.basicdetailsgrpbox.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.servicedetailsgrpbox.SuspendLayout()
        Me.priceGrpBox.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'basicdetailsgrpbox
        '
        Me.basicdetailsgrpbox.Controls.Add(Me.addvehiclesButton)
        Me.basicdetailsgrpbox.Controls.Add(Me.DataGridView1)
        Me.basicdetailsgrpbox.Controls.Add(Me.addcustButton)
        Me.basicdetailsgrpbox.Controls.Add(Me.searchcustButton)
        Me.basicdetailsgrpbox.Controls.Add(Me.custTB)
        Me.basicdetailsgrpbox.Controls.Add(Me.customeridRB)
        Me.basicdetailsgrpbox.Controls.Add(Me.phoneRB)
        Me.basicdetailsgrpbox.Controls.Add(Me.firstnameRB)
        Me.basicdetailsgrpbox.Controls.Add(Me.lastnameRB)
        Me.basicdetailsgrpbox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.basicdetailsgrpbox.Location = New System.Drawing.Point(12, 12)
        Me.basicdetailsgrpbox.Name = "basicdetailsgrpbox"
        Me.basicdetailsgrpbox.Size = New System.Drawing.Size(473, 186)
        Me.basicdetailsgrpbox.TabIndex = 0
        Me.basicdetailsgrpbox.TabStop = False
        Me.basicdetailsgrpbox.Text = "Basic Details"
        '
        'addvehiclesButton
        '
        Me.addvehiclesButton.BackColor = System.Drawing.Color.SteelBlue
        Me.addvehiclesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.addvehiclesButton.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addvehiclesButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.addvehiclesButton.Location = New System.Drawing.Point(360, 150)
        Me.addvehiclesButton.Name = "addvehiclesButton"
        Me.addvehiclesButton.Size = New System.Drawing.Size(107, 23)
        Me.addvehiclesButton.TabIndex = 9
        Me.addvehiclesButton.Text = "Add Vehicles"
        Me.addvehiclesButton.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 74)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(342, 99)
        Me.DataGridView1.TabIndex = 7
        '
        'addcustButton
        '
        Me.addcustButton.BackColor = System.Drawing.Color.SteelBlue
        Me.addcustButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.addcustButton.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addcustButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.addcustButton.Location = New System.Drawing.Point(360, 45)
        Me.addcustButton.Name = "addcustButton"
        Me.addcustButton.Size = New System.Drawing.Size(107, 23)
        Me.addcustButton.TabIndex = 6
        Me.addcustButton.Text = "Add Customer"
        Me.addcustButton.UseVisualStyleBackColor = False
        '
        'searchcustButton
        '
        Me.searchcustButton.BackColor = System.Drawing.Color.SteelBlue
        Me.searchcustButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.searchcustButton.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchcustButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.searchcustButton.Location = New System.Drawing.Point(273, 45)
        Me.searchcustButton.Name = "searchcustButton"
        Me.searchcustButton.Size = New System.Drawing.Size(75, 23)
        Me.searchcustButton.TabIndex = 5
        Me.searchcustButton.Text = "Search"
        Me.searchcustButton.UseVisualStyleBackColor = False
        '
        'custTB
        '
        Me.custTB.Location = New System.Drawing.Point(273, 19)
        Me.custTB.Name = "custTB"
        Me.custTB.Size = New System.Drawing.Size(194, 23)
        Me.custTB.TabIndex = 4
        '
        'customeridRB
        '
        Me.customeridRB.AutoSize = True
        Me.customeridRB.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customeridRB.Location = New System.Drawing.Point(149, 43)
        Me.customeridRB.Name = "customeridRB"
        Me.customeridRB.Size = New System.Drawing.Size(99, 21)
        Me.customeridRB.TabIndex = 3
        Me.customeridRB.Text = "Customer ID"
        Me.customeridRB.UseVisualStyleBackColor = True
        '
        'phoneRB
        '
        Me.phoneRB.AutoSize = True
        Me.phoneRB.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phoneRB.Location = New System.Drawing.Point(10, 43)
        Me.phoneRB.Name = "phoneRB"
        Me.phoneRB.Size = New System.Drawing.Size(63, 21)
        Me.phoneRB.TabIndex = 2
        Me.phoneRB.Text = "Phone"
        Me.phoneRB.UseVisualStyleBackColor = True
        '
        'firstnameRB
        '
        Me.firstnameRB.AutoSize = True
        Me.firstnameRB.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstnameRB.Location = New System.Drawing.Point(149, 18)
        Me.firstnameRB.Name = "firstnameRB"
        Me.firstnameRB.Size = New System.Drawing.Size(90, 21)
        Me.firstnameRB.TabIndex = 1
        Me.firstnameRB.Text = "First Name"
        Me.firstnameRB.UseVisualStyleBackColor = True
        '
        'lastnameRB
        '
        Me.lastnameRB.AutoSize = True
        Me.lastnameRB.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastnameRB.Location = New System.Drawing.Point(10, 19)
        Me.lastnameRB.Name = "lastnameRB"
        Me.lastnameRB.Size = New System.Drawing.Size(89, 21)
        Me.lastnameRB.TabIndex = 0
        Me.lastnameRB.Text = "Last Name"
        Me.lastnameRB.UseVisualStyleBackColor = True
        '
        'servicedetailsgrpbox
        '
        Me.servicedetailsgrpbox.Controls.Add(Me.servesttimeTB)
        Me.servicedetailsgrpbox.Controls.Add(Me.Label6)
        Me.servicedetailsgrpbox.Controls.Add(Me.Button1)
        Me.servicedetailsgrpbox.Controls.Add(Me.servemployeeidTB)
        Me.servicedetailsgrpbox.Controls.Add(Me.Label5)
        Me.servicedetailsgrpbox.Controls.Add(Me.servvehicleidTB)
        Me.servicedetailsgrpbox.Controls.Add(Me.Label4)
        Me.servicedetailsgrpbox.Controls.Add(Me.existingserviceRB)
        Me.servicedetailsgrpbox.Controls.Add(Me.newserviceRB)
        Me.servicedetailsgrpbox.Controls.Add(Me.servtypeTB)
        Me.servicedetailsgrpbox.Controls.Add(Me.servstatusComboBox)
        Me.servicedetailsgrpbox.Controls.Add(Me.Label3)
        Me.servicedetailsgrpbox.Controls.Add(Me.descrRichTextBox)
        Me.servicedetailsgrpbox.Controls.Add(Me.servvehiclenameTB)
        Me.servicedetailsgrpbox.Controls.Add(Me.DateTimePicker2)
        Me.servicedetailsgrpbox.Controls.Add(Me.DateTimePicker1)
        Me.servicedetailsgrpbox.Controls.Add(Me.descriptionLabel)
        Me.servicedetailsgrpbox.Controls.Add(Me.deliverydateLabel)
        Me.servicedetailsgrpbox.Controls.Add(Me.receiveddateLabel)
        Me.servicedetailsgrpbox.Controls.Add(Me.servicetypeLabel)
        Me.servicedetailsgrpbox.Controls.Add(Me.vehicleidLabel)
        Me.servicedetailsgrpbox.Controls.Add(Me.serviceidTB)
        Me.servicedetailsgrpbox.Controls.Add(Me.searchservButton)
        Me.servicedetailsgrpbox.Controls.Add(Me.serviceidLabel)
        Me.servicedetailsgrpbox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.servicedetailsgrpbox.Location = New System.Drawing.Point(12, 204)
        Me.servicedetailsgrpbox.Name = "servicedetailsgrpbox"
        Me.servicedetailsgrpbox.Size = New System.Drawing.Size(473, 322)
        Me.servicedetailsgrpbox.TabIndex = 1
        Me.servicedetailsgrpbox.TabStop = False
        Me.servicedetailsgrpbox.Text = "Service Details"
        '
        'servesttimeTB
        '
        Me.servesttimeTB.Location = New System.Drawing.Point(333, 138)
        Me.servesttimeTB.Name = "servesttimeTB"
        Me.servesttimeTB.Size = New System.Drawing.Size(100, 24)
        Me.servesttimeTB.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(238, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 17)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Estimated Time"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SteelBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(273, 285)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(194, 31)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Parts Used in Service"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'servemployeeidTB
        '
        Me.servemployeeidTB.Location = New System.Drawing.Point(93, 76)
        Me.servemployeeidTB.Name = "servemployeeidTB"
        Me.servemployeeidTB.Size = New System.Drawing.Size(100, 24)
        Me.servemployeeidTB.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 17)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Employee ID"
        '
        'servvehicleidTB
        '
        Me.servvehicleidTB.Location = New System.Drawing.Point(333, 76)
        Me.servvehicleidTB.Name = "servvehicleidTB"
        Me.servvehicleidTB.Size = New System.Drawing.Size(100, 24)
        Me.servvehicleidTB.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(238, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 17)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Vehicle ID"
        '
        'existingserviceRB
        '
        Me.existingserviceRB.AutoSize = True
        Me.existingserviceRB.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.existingserviceRB.Location = New System.Drawing.Point(273, 16)
        Me.existingserviceRB.Name = "existingserviceRB"
        Me.existingserviceRB.Size = New System.Drawing.Size(118, 21)
        Me.existingserviceRB.TabIndex = 19
        Me.existingserviceRB.TabStop = True
        Me.existingserviceRB.Text = "Existing Service"
        Me.existingserviceRB.UseVisualStyleBackColor = True
        '
        'newserviceRB
        '
        Me.newserviceRB.AutoSize = True
        Me.newserviceRB.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newserviceRB.Location = New System.Drawing.Point(10, 16)
        Me.newserviceRB.Name = "newserviceRB"
        Me.newserviceRB.Size = New System.Drawing.Size(98, 21)
        Me.newserviceRB.TabIndex = 18
        Me.newserviceRB.TabStop = True
        Me.newserviceRB.Text = "New Service"
        Me.newserviceRB.UseVisualStyleBackColor = True
        '
        'servtypeTB
        '
        Me.servtypeTB.Location = New System.Drawing.Point(93, 106)
        Me.servtypeTB.Name = "servtypeTB"
        Me.servtypeTB.Size = New System.Drawing.Size(131, 24)
        Me.servtypeTB.TabIndex = 17
        '
        'servstatusComboBox
        '
        Me.servstatusComboBox.FormattingEnabled = True
        Me.servstatusComboBox.Items.AddRange(New Object() {"Pending", "Completed"})
        Me.servstatusComboBox.Location = New System.Drawing.Point(93, 137)
        Me.servstatusComboBox.Name = "servstatusComboBox"
        Me.servstatusComboBox.Size = New System.Drawing.Size(135, 25)
        Me.servstatusComboBox.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 17)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Service Status"
        '
        'descrRichTextBox
        '
        Me.descrRichTextBox.Location = New System.Drawing.Point(93, 208)
        Me.descrRichTextBox.Name = "descrRichTextBox"
        Me.descrRichTextBox.Size = New System.Drawing.Size(374, 67)
        Me.descrRichTextBox.TabIndex = 11
        Me.descrRichTextBox.Text = ""
        '
        'servvehiclenameTB
        '
        Me.servvehiclenameTB.Location = New System.Drawing.Point(333, 106)
        Me.servvehiclenameTB.Name = "servvehiclenameTB"
        Me.servvehiclenameTB.Size = New System.Drawing.Size(134, 24)
        Me.servvehiclenameTB.TabIndex = 10
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "yyyy-MM-dd hh:mm:ss"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(333, 169)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(135, 24)
        Me.DateTimePicker2.TabIndex = 9
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd hh:mm:ss"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(93, 169)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(131, 24)
        Me.DateTimePicker1.TabIndex = 8
        Me.DateTimePicker1.Value = New Date(2016, 12, 14, 11, 36, 0, 0)
        '
        'descriptionLabel
        '
        Me.descriptionLabel.AutoSize = True
        Me.descriptionLabel.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descriptionLabel.Location = New System.Drawing.Point(6, 208)
        Me.descriptionLabel.Name = "descriptionLabel"
        Me.descriptionLabel.Size = New System.Drawing.Size(76, 17)
        Me.descriptionLabel.TabIndex = 7
        Me.descriptionLabel.Text = "Description"
        '
        'deliverydateLabel
        '
        Me.deliverydateLabel.AutoSize = True
        Me.deliverydateLabel.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deliverydateLabel.Location = New System.Drawing.Point(238, 174)
        Me.deliverydateLabel.Name = "deliverydateLabel"
        Me.deliverydateLabel.Size = New System.Drawing.Size(87, 17)
        Me.deliverydateLabel.TabIndex = 6
        Me.deliverydateLabel.Text = "Delivery Date"
        '
        'receiveddateLabel
        '
        Me.receiveddateLabel.AutoSize = True
        Me.receiveddateLabel.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.receiveddateLabel.Location = New System.Drawing.Point(7, 172)
        Me.receiveddateLabel.Name = "receiveddateLabel"
        Me.receiveddateLabel.Size = New System.Drawing.Size(90, 17)
        Me.receiveddateLabel.TabIndex = 5
        Me.receiveddateLabel.Text = "Received Date"
        '
        'servicetypeLabel
        '
        Me.servicetypeLabel.AutoSize = True
        Me.servicetypeLabel.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.servicetypeLabel.Location = New System.Drawing.Point(7, 110)
        Me.servicetypeLabel.Name = "servicetypeLabel"
        Me.servicetypeLabel.Size = New System.Drawing.Size(81, 17)
        Me.servicetypeLabel.TabIndex = 4
        Me.servicetypeLabel.Text = "Service Type"
        '
        'vehicleidLabel
        '
        Me.vehicleidLabel.AutoSize = True
        Me.vehicleidLabel.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vehicleidLabel.Location = New System.Drawing.Point(238, 110)
        Me.vehicleidLabel.Name = "vehicleidLabel"
        Me.vehicleidLabel.Size = New System.Drawing.Size(89, 17)
        Me.vehicleidLabel.TabIndex = 3
        Me.vehicleidLabel.Text = "Vehicle Name"
        '
        'serviceidTB
        '
        Me.serviceidTB.Enabled = False
        Me.serviceidTB.Location = New System.Drawing.Point(93, 44)
        Me.serviceidTB.Name = "serviceidTB"
        Me.serviceidTB.Size = New System.Drawing.Size(100, 24)
        Me.serviceidTB.TabIndex = 2
        '
        'searchservButton
        '
        Me.searchservButton.BackColor = System.Drawing.Color.SteelBlue
        Me.searchservButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.searchservButton.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchservButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.searchservButton.Location = New System.Drawing.Point(361, 44)
        Me.searchservButton.Name = "searchservButton"
        Me.searchservButton.Size = New System.Drawing.Size(106, 23)
        Me.searchservButton.TabIndex = 1
        Me.searchservButton.Text = "Search"
        Me.searchservButton.UseVisualStyleBackColor = False
        '
        'serviceidLabel
        '
        Me.serviceidLabel.AutoSize = True
        Me.serviceidLabel.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.serviceidLabel.Location = New System.Drawing.Point(7, 48)
        Me.serviceidLabel.Name = "serviceidLabel"
        Me.serviceidLabel.Size = New System.Drawing.Size(66, 17)
        Me.serviceidLabel.TabIndex = 0
        Me.serviceidLabel.Text = "Service ID"
        '
        'clearButton
        '
        Me.clearButton.BackColor = System.Drawing.Color.SteelBlue
        Me.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.clearButton.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.clearButton.Location = New System.Drawing.Point(285, 80)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(75, 23)
        Me.clearButton.TabIndex = 13
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = False
        '
        'saveButton
        '
        Me.saveButton.BackColor = System.Drawing.Color.SteelBlue
        Me.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.saveButton.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.saveButton.Location = New System.Drawing.Point(285, 46)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(75, 23)
        Me.saveButton.TabIndex = 12
        Me.saveButton.Text = "Save"
        Me.saveButton.UseVisualStyleBackColor = False
        '
        'priceGrpBox
        '
        Me.priceGrpBox.Controls.Add(Me.servtaxTB)
        Me.priceGrpBox.Controls.Add(Me.Label2)
        Me.priceGrpBox.Controls.Add(Me.cancelButton)
        Me.priceGrpBox.Controls.Add(Me.clearButton)
        Me.priceGrpBox.Controls.Add(Me.invoiceButton)
        Me.priceGrpBox.Controls.Add(Me.saveButton)
        Me.priceGrpBox.Controls.Add(Me.paymentstatusComboBox)
        Me.priceGrpBox.Controls.Add(Me.totalpaymentTB)
        Me.priceGrpBox.Controls.Add(Me.hourlycostTB)
        Me.priceGrpBox.Controls.Add(Me.Label1)
        Me.priceGrpBox.Controls.Add(Me.totalpaymentLabel)
        Me.priceGrpBox.Controls.Add(Me.hourlycostLabel)
        Me.priceGrpBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.priceGrpBox.Location = New System.Drawing.Point(12, 532)
        Me.priceGrpBox.Name = "priceGrpBox"
        Me.priceGrpBox.Size = New System.Drawing.Size(473, 120)
        Me.priceGrpBox.TabIndex = 2
        Me.priceGrpBox.TabStop = False
        Me.priceGrpBox.Text = "Pricing"
        '
        'servtaxTB
        '
        Me.servtaxTB.Location = New System.Drawing.Point(332, 15)
        Me.servtaxTB.Name = "servtaxTB"
        Me.servtaxTB.Size = New System.Drawing.Size(100, 23)
        Me.servtaxTB.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(252, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Service Tax"
        '
        'cancelButton
        '
        Me.cancelButton.BackColor = System.Drawing.Color.SteelBlue
        Me.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cancelButton.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cancelButton.Location = New System.Drawing.Point(392, 80)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(75, 23)
        Me.cancelButton.TabIndex = 7
        Me.cancelButton.Text = "Close"
        Me.cancelButton.UseVisualStyleBackColor = False
        '
        'invoiceButton
        '
        Me.invoiceButton.BackColor = System.Drawing.Color.SteelBlue
        Me.invoiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.invoiceButton.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.invoiceButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.invoiceButton.Location = New System.Drawing.Point(392, 46)
        Me.invoiceButton.Name = "invoiceButton"
        Me.invoiceButton.Size = New System.Drawing.Size(75, 23)
        Me.invoiceButton.TabIndex = 6
        Me.invoiceButton.Text = "Invoice"
        Me.invoiceButton.UseVisualStyleBackColor = False
        '
        'paymentstatusComboBox
        '
        Me.paymentstatusComboBox.FormattingEnabled = True
        Me.paymentstatusComboBox.Items.AddRange(New Object() {"Paid", "Pending"})
        Me.paymentstatusComboBox.Location = New System.Drawing.Point(103, 82)
        Me.paymentstatusComboBox.Name = "paymentstatusComboBox"
        Me.paymentstatusComboBox.Size = New System.Drawing.Size(121, 26)
        Me.paymentstatusComboBox.TabIndex = 5
        '
        'totalpaymentTB
        '
        Me.totalpaymentTB.Location = New System.Drawing.Point(103, 49)
        Me.totalpaymentTB.Name = "totalpaymentTB"
        Me.totalpaymentTB.Size = New System.Drawing.Size(100, 23)
        Me.totalpaymentTB.TabIndex = 4
        '
        'hourlycostTB
        '
        Me.hourlycostTB.Location = New System.Drawing.Point(103, 15)
        Me.hourlycostTB.Name = "hourlycostTB"
        Me.hourlycostTB.ReadOnly = True
        Me.hourlycostTB.Size = New System.Drawing.Size(100, 23)
        Me.hourlycostTB.TabIndex = 3
        Me.hourlycostTB.Text = "20.50"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Payment Status"
        '
        'totalpaymentLabel
        '
        Me.totalpaymentLabel.AutoSize = True
        Me.totalpaymentLabel.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalpaymentLabel.Location = New System.Drawing.Point(7, 50)
        Me.totalpaymentLabel.Name = "totalpaymentLabel"
        Me.totalpaymentLabel.Size = New System.Drawing.Size(92, 17)
        Me.totalpaymentLabel.TabIndex = 1
        Me.totalpaymentLabel.Text = "Total Payment"
        '
        'hourlycostLabel
        '
        Me.hourlycostLabel.AutoSize = True
        Me.hourlycostLabel.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hourlycostLabel.Location = New System.Drawing.Point(7, 19)
        Me.hourlycostLabel.Name = "hourlycostLabel"
        Me.hourlycostLabel.Size = New System.Drawing.Size(79, 17)
        Me.hourlycostLabel.TabIndex = 0
        Me.hourlycostLabel.Text = "Hourly Cost"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'ServiceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(497, 664)
        Me.Controls.Add(Me.priceGrpBox)
        Me.Controls.Add(Me.servicedetailsgrpbox)
        Me.Controls.Add(Me.basicdetailsgrpbox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ServiceForm"
        Me.Text = "ServiceForm"
        Me.basicdetailsgrpbox.ResumeLayout(False)
        Me.basicdetailsgrpbox.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.servicedetailsgrpbox.ResumeLayout(False)
        Me.servicedetailsgrpbox.PerformLayout()
        Me.priceGrpBox.ResumeLayout(False)
        Me.priceGrpBox.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents basicdetailsgrpbox As GroupBox
    Friend WithEvents addcustButton As Button
    Friend WithEvents searchcustButton As Button
    Friend WithEvents custTB As TextBox
    Friend WithEvents customeridRB As RadioButton
    Friend WithEvents phoneRB As RadioButton
    Friend WithEvents firstnameRB As RadioButton
    Friend WithEvents lastnameRB As RadioButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents addvehiclesButton As Button
    Friend WithEvents servicedetailsgrpbox As GroupBox
    Friend WithEvents serviceidTB As TextBox
    Friend WithEvents searchservButton As Button
    Friend WithEvents serviceidLabel As Label
    Friend WithEvents descriptionLabel As Label
    Friend WithEvents deliverydateLabel As Label
    Friend WithEvents receiveddateLabel As Label
    Friend WithEvents servicetypeLabel As Label
    Friend WithEvents vehicleidLabel As Label
    Friend WithEvents servvehiclenameTB As TextBox
    Friend WithEvents clearButton As Button
    Friend WithEvents saveButton As Button
    Friend WithEvents descrRichTextBox As RichTextBox
    Friend WithEvents priceGrpBox As GroupBox
    Friend WithEvents cancelButton As Button
    Friend WithEvents invoiceButton As Button
    Friend WithEvents paymentstatusComboBox As ComboBox
    Friend WithEvents totalpaymentTB As TextBox
    Friend WithEvents hourlycostTB As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents totalpaymentLabel As Label
    Friend WithEvents hourlycostLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents servtaxTB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents servstatusComboBox As ComboBox
    Friend WithEvents servtypeTB As TextBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents existingserviceRB As RadioButton
    Friend WithEvents newserviceRB As RadioButton
    Friend WithEvents servvehicleidTB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents servemployeeidTB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Public WithEvents DateTimePicker2 As DateTimePicker
    Public WithEvents DateTimePicker1 As DateTimePicker
    Public WithEvents servesttimeTB As TextBox
End Class
