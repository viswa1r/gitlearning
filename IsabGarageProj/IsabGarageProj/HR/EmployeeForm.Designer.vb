<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmployeeForm
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
        Me.searchGrpBox = New System.Windows.Forms.GroupBox()
        Me.lastNameRadioBtn = New System.Windows.Forms.RadioButton()
        Me.frstNameRadioBtn = New System.Windows.Forms.RadioButton()
        Me.employeeIDRadioBtn = New System.Windows.Forms.RadioButton()
        Me.searchBtn = New System.Windows.Forms.Button()
        Me.SearchStrTextBox = New System.Windows.Forms.TextBox()
        Me.personlDetailsGrpBox = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EmployeeIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.hiredDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.hireDateLbl = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.hourlyPayTextBox = New System.Windows.Forms.TextBox()
        Me.supervisorComboBox = New System.Windows.Forms.ComboBox()
        Me.hrlyPayLbl = New System.Windows.Forms.Label()
        Me.supervisorLbl = New System.Windows.Forms.Label()
        Me.pwdLbl = New System.Windows.Forms.Label()
        Me.pwdTextBox = New System.Windows.Forms.TextBox()
        Me.DOBDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.workTypeComboBx = New System.Windows.Forms.ComboBox()
        Me.firstNameLbl = New System.Windows.Forms.Label()
        Me.DOBLbl = New System.Windows.Forms.Label()
        Me.lastNameLbl = New System.Windows.Forms.Label()
        Me.workTypeLbl = New System.Windows.Forms.Label()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.lastNameTextBox = New System.Windows.Forms.TextBox()
        Me.emailTextBox = New System.Windows.Forms.TextBox()
        Me.phoneNoTextBox = New System.Windows.Forms.TextBox()
        Me.phoneNoLbl = New System.Windows.Forms.Label()
        Me.emailLbl = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.address2TextBox = New System.Windows.Forms.TextBox()
        Me.zipcodeTextBox = New System.Windows.Forms.TextBox()
        Me.addressLbl = New System.Windows.Forms.Label()
        Me.countryTextBox = New System.Windows.Forms.TextBox()
        Me.cityLbl = New System.Windows.Forms.Label()
        Me.address1TextBox = New System.Windows.Forms.TextBox()
        Me.stateLbl = New System.Windows.Forms.Label()
        Me.stateTextBox = New System.Windows.Forms.TextBox()
        Me.countryLbl = New System.Windows.Forms.Label()
        Me.cityTextBox = New System.Windows.Forms.TextBox()
        Me.zipcodeLbl = New System.Windows.Forms.Label()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.backBtn = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.searchGrpBox.SuspendLayout()
        Me.personlDetailsGrpBox.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'searchGrpBox
        '
        Me.searchGrpBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.searchGrpBox.Controls.Add(Me.lastNameRadioBtn)
        Me.searchGrpBox.Controls.Add(Me.frstNameRadioBtn)
        Me.searchGrpBox.Controls.Add(Me.employeeIDRadioBtn)
        Me.searchGrpBox.Controls.Add(Me.searchBtn)
        Me.searchGrpBox.Controls.Add(Me.SearchStrTextBox)
        Me.searchGrpBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchGrpBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.searchGrpBox.Location = New System.Drawing.Point(16, 11)
        Me.searchGrpBox.Margin = New System.Windows.Forms.Padding(4)
        Me.searchGrpBox.Name = "searchGrpBox"
        Me.searchGrpBox.Padding = New System.Windows.Forms.Padding(4)
        Me.searchGrpBox.Size = New System.Drawing.Size(600, 136)
        Me.searchGrpBox.TabIndex = 48
        Me.searchGrpBox.TabStop = False
        Me.searchGrpBox.Text = "EMPLOYEE"
        '
        'lastNameRadioBtn
        '
        Me.lastNameRadioBtn.AutoSize = True
        Me.lastNameRadioBtn.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastNameRadioBtn.Location = New System.Drawing.Point(357, 26)
        Me.lastNameRadioBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.lastNameRadioBtn.Name = "lastNameRadioBtn"
        Me.lastNameRadioBtn.Size = New System.Drawing.Size(91, 22)
        Me.lastNameRadioBtn.TabIndex = 55
        Me.lastNameRadioBtn.TabStop = True
        Me.lastNameRadioBtn.Text = "Last Name"
        Me.lastNameRadioBtn.UseVisualStyleBackColor = True
        '
        'frstNameRadioBtn
        '
        Me.frstNameRadioBtn.AutoSize = True
        Me.frstNameRadioBtn.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frstNameRadioBtn.Location = New System.Drawing.Point(192, 26)
        Me.frstNameRadioBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.frstNameRadioBtn.Name = "frstNameRadioBtn"
        Me.frstNameRadioBtn.Size = New System.Drawing.Size(92, 22)
        Me.frstNameRadioBtn.TabIndex = 54
        Me.frstNameRadioBtn.TabStop = True
        Me.frstNameRadioBtn.Text = "First Name"
        Me.frstNameRadioBtn.UseVisualStyleBackColor = True
        '
        'employeeIDRadioBtn
        '
        Me.employeeIDRadioBtn.AutoSize = True
        Me.employeeIDRadioBtn.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeIDRadioBtn.Location = New System.Drawing.Point(16, 28)
        Me.employeeIDRadioBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.employeeIDRadioBtn.Name = "employeeIDRadioBtn"
        Me.employeeIDRadioBtn.Size = New System.Drawing.Size(105, 22)
        Me.employeeIDRadioBtn.TabIndex = 53
        Me.employeeIDRadioBtn.TabStop = True
        Me.employeeIDRadioBtn.Text = "Employee ID"
        Me.employeeIDRadioBtn.UseVisualStyleBackColor = True
        '
        'searchBtn
        '
        Me.searchBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.searchBtn.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchBtn.ForeColor = System.Drawing.SystemColors.Control
        Me.searchBtn.Location = New System.Drawing.Point(291, 72)
        Me.searchBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.searchBtn.Name = "searchBtn"
        Me.searchBtn.Size = New System.Drawing.Size(61, 27)
        Me.searchBtn.TabIndex = 52
        Me.searchBtn.Text = "Search"
        Me.searchBtn.UseVisualStyleBackColor = False
        '
        'SearchStrTextBox
        '
        Me.SearchStrTextBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchStrTextBox.Location = New System.Drawing.Point(16, 76)
        Me.SearchStrTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SearchStrTextBox.Name = "SearchStrTextBox"
        Me.SearchStrTextBox.Size = New System.Drawing.Size(235, 23)
        Me.SearchStrTextBox.TabIndex = 51
        '
        'personlDetailsGrpBox
        '
        Me.personlDetailsGrpBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.personlDetailsGrpBox.Controls.Add(Me.Label4)
        Me.personlDetailsGrpBox.Controls.Add(Me.Label3)
        Me.personlDetailsGrpBox.Controls.Add(Me.EmployeeIDTextBox)
        Me.personlDetailsGrpBox.Controls.Add(Me.Label2)
        Me.personlDetailsGrpBox.Controls.Add(Me.hiredDatePicker)
        Me.personlDetailsGrpBox.Controls.Add(Me.Label19)
        Me.personlDetailsGrpBox.Controls.Add(Me.hireDateLbl)
        Me.personlDetailsGrpBox.Controls.Add(Me.Label20)
        Me.personlDetailsGrpBox.Controls.Add(Me.Label21)
        Me.personlDetailsGrpBox.Controls.Add(Me.Label18)
        Me.personlDetailsGrpBox.Controls.Add(Me.Label17)
        Me.personlDetailsGrpBox.Controls.Add(Me.Label14)
        Me.personlDetailsGrpBox.Controls.Add(Me.hourlyPayTextBox)
        Me.personlDetailsGrpBox.Controls.Add(Me.supervisorComboBox)
        Me.personlDetailsGrpBox.Controls.Add(Me.hrlyPayLbl)
        Me.personlDetailsGrpBox.Controls.Add(Me.supervisorLbl)
        Me.personlDetailsGrpBox.Controls.Add(Me.pwdLbl)
        Me.personlDetailsGrpBox.Controls.Add(Me.pwdTextBox)
        Me.personlDetailsGrpBox.Controls.Add(Me.DOBDatePicker)
        Me.personlDetailsGrpBox.Controls.Add(Me.workTypeComboBx)
        Me.personlDetailsGrpBox.Controls.Add(Me.firstNameLbl)
        Me.personlDetailsGrpBox.Controls.Add(Me.DOBLbl)
        Me.personlDetailsGrpBox.Controls.Add(Me.lastNameLbl)
        Me.personlDetailsGrpBox.Controls.Add(Me.workTypeLbl)
        Me.personlDetailsGrpBox.Controls.Add(Me.FirstNameTextBox)
        Me.personlDetailsGrpBox.Controls.Add(Me.lastNameTextBox)
        Me.personlDetailsGrpBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.personlDetailsGrpBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.personlDetailsGrpBox.Location = New System.Drawing.Point(16, 155)
        Me.personlDetailsGrpBox.Margin = New System.Windows.Forms.Padding(4)
        Me.personlDetailsGrpBox.Name = "personlDetailsGrpBox"
        Me.personlDetailsGrpBox.Padding = New System.Windows.Forms.Padding(4)
        Me.personlDetailsGrpBox.Size = New System.Drawing.Size(600, 228)
        Me.personlDetailsGrpBox.TabIndex = 50
        Me.personlDetailsGrpBox.TabStop = False
        Me.personlDetailsGrpBox.Text = "PERSONAL PROFILE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(409, 183)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 18)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(376, 142)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 18)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "*"
        '
        'EmployeeIDTextBox
        '
        Me.EmployeeIDTextBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeIDTextBox.Location = New System.Drawing.Point(108, 28)
        Me.EmployeeIDTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.EmployeeIDTextBox.Name = "EmployeeIDTextBox"
        Me.EmployeeIDTextBox.Size = New System.Drawing.Size(167, 23)
        Me.EmployeeIDTextBox.TabIndex = 73
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(5, 31)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 18)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Employee ID"
        '
        'hiredDatePicker
        '
        Me.hiredDatePicker.CustomFormat = "MM/dd/yyyy"
        Me.hiredDatePicker.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hiredDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.hiredDatePicker.Location = New System.Drawing.Point(400, 70)
        Me.hiredDatePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.hiredDatePicker.Name = "hiredDatePicker"
        Me.hiredDatePicker.Size = New System.Drawing.Size(185, 23)
        Me.hiredDatePicker.TabIndex = 53
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(373, 68)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(14, 18)
        Me.Label19.TabIndex = 68
        Me.Label19.Text = "*"
        '
        'hireDateLbl
        '
        Me.hireDateLbl.AutoSize = True
        Me.hireDateLbl.BackColor = System.Drawing.Color.LightSteelBlue
        Me.hireDateLbl.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hireDateLbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.hireDateLbl.Location = New System.Drawing.Point(301, 71)
        Me.hireDateLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.hireDateLbl.Name = "hireDateLbl"
        Me.hireDateLbl.Size = New System.Drawing.Size(75, 18)
        Me.hireDateLbl.TabIndex = 51
        Me.hireDateLbl.Text = "Hired Date"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(708, 24)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(14, 18)
        Me.Label20.TabIndex = 71
        Me.Label20.Text = "*"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Red
        Me.Label21.Location = New System.Drawing.Point(709, 168)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(14, 18)
        Me.Label21.TabIndex = 70
        Me.Label21.Text = "*"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(78, 109)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(14, 18)
        Me.Label18.TabIndex = 67
        Me.Label18.Text = "*"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(78, 71)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(14, 18)
        Me.Label17.TabIndex = 66
        Me.Label17.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(72, 142)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(14, 18)
        Me.Label14.TabIndex = 51
        Me.Label14.Text = "*"
        '
        'hourlyPayTextBox
        '
        Me.hourlyPayTextBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hourlyPayTextBox.Location = New System.Drawing.Point(470, 190)
        Me.hourlyPayTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.hourlyPayTextBox.Name = "hourlyPayTextBox"
        Me.hourlyPayTextBox.Size = New System.Drawing.Size(114, 23)
        Me.hourlyPayTextBox.TabIndex = 64
        '
        'supervisorComboBox
        '
        Me.supervisorComboBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.supervisorComboBox.FormattingEnabled = True
        Me.supervisorComboBox.Location = New System.Drawing.Point(400, 143)
        Me.supervisorComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.supervisorComboBox.Name = "supervisorComboBox"
        Me.supervisorComboBox.Size = New System.Drawing.Size(184, 26)
        Me.supervisorComboBox.TabIndex = 63
        '
        'hrlyPayLbl
        '
        Me.hrlyPayLbl.AutoSize = True
        Me.hrlyPayLbl.BackColor = System.Drawing.Color.LightSteelBlue
        Me.hrlyPayLbl.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hrlyPayLbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.hrlyPayLbl.Location = New System.Drawing.Point(304, 189)
        Me.hrlyPayLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.hrlyPayLbl.Name = "hrlyPayLbl"
        Me.hrlyPayLbl.Size = New System.Drawing.Size(97, 18)
        Me.hrlyPayLbl.TabIndex = 60
        Me.hrlyPayLbl.Text = "Hourly pay     $"
        '
        'supervisorLbl
        '
        Me.supervisorLbl.AutoSize = True
        Me.supervisorLbl.BackColor = System.Drawing.Color.LightSteelBlue
        Me.supervisorLbl.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.supervisorLbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.supervisorLbl.Location = New System.Drawing.Point(305, 147)
        Me.supervisorLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.supervisorLbl.Name = "supervisorLbl"
        Me.supervisorLbl.Size = New System.Drawing.Size(73, 18)
        Me.supervisorLbl.TabIndex = 59
        Me.supervisorLbl.Text = "Supervisor"
        '
        'pwdLbl
        '
        Me.pwdLbl.AutoSize = True
        Me.pwdLbl.BackColor = System.Drawing.Color.LightSteelBlue
        Me.pwdLbl.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pwdLbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.pwdLbl.Location = New System.Drawing.Point(6, 143)
        Me.pwdLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.pwdLbl.Name = "pwdLbl"
        Me.pwdLbl.Size = New System.Drawing.Size(66, 18)
        Me.pwdLbl.TabIndex = 57
        Me.pwdLbl.Text = "Password"
        '
        'pwdTextBox
        '
        Me.pwdTextBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pwdTextBox.Location = New System.Drawing.Point(110, 144)
        Me.pwdTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.pwdTextBox.Name = "pwdTextBox"
        Me.pwdTextBox.Size = New System.Drawing.Size(167, 23)
        Me.pwdTextBox.TabIndex = 33
        Me.pwdTextBox.UseSystemPasswordChar = True
        '
        'DOBDatePicker
        '
        Me.DOBDatePicker.CustomFormat = "MM/dd/yyyy"
        Me.DOBDatePicker.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOBDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DOBDatePicker.Location = New System.Drawing.Point(110, 189)
        Me.DOBDatePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.DOBDatePicker.Name = "DOBDatePicker"
        Me.DOBDatePicker.Size = New System.Drawing.Size(167, 23)
        Me.DOBDatePicker.TabIndex = 52
        '
        'workTypeComboBx
        '
        Me.workTypeComboBx.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.workTypeComboBx.FormattingEnabled = True
        Me.workTypeComboBx.Items.AddRange(New Object() {"Sales", "Manager", "Worker"})
        Me.workTypeComboBx.Location = New System.Drawing.Point(400, 103)
        Me.workTypeComboBx.Margin = New System.Windows.Forms.Padding(4)
        Me.workTypeComboBx.Name = "workTypeComboBx"
        Me.workTypeComboBx.Size = New System.Drawing.Size(184, 26)
        Me.workTypeComboBx.TabIndex = 31
        '
        'firstNameLbl
        '
        Me.firstNameLbl.AutoSize = True
        Me.firstNameLbl.BackColor = System.Drawing.Color.LightSteelBlue
        Me.firstNameLbl.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstNameLbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.firstNameLbl.Location = New System.Drawing.Point(5, 70)
        Me.firstNameLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.firstNameLbl.Name = "firstNameLbl"
        Me.firstNameLbl.Size = New System.Drawing.Size(74, 18)
        Me.firstNameLbl.TabIndex = 25
        Me.firstNameLbl.Text = "First Name"
        '
        'DOBLbl
        '
        Me.DOBLbl.AutoSize = True
        Me.DOBLbl.BackColor = System.Drawing.Color.LightSteelBlue
        Me.DOBLbl.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOBLbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DOBLbl.Location = New System.Drawing.Point(8, 188)
        Me.DOBLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DOBLbl.Name = "DOBLbl"
        Me.DOBLbl.Size = New System.Drawing.Size(42, 18)
        Me.DOBLbl.TabIndex = 27
        Me.DOBLbl.Text = "DOB "
        '
        'lastNameLbl
        '
        Me.lastNameLbl.AutoSize = True
        Me.lastNameLbl.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lastNameLbl.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastNameLbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lastNameLbl.Location = New System.Drawing.Point(6, 106)
        Me.lastNameLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lastNameLbl.Name = "lastNameLbl"
        Me.lastNameLbl.Size = New System.Drawing.Size(73, 18)
        Me.lastNameLbl.TabIndex = 26
        Me.lastNameLbl.Text = "Last Name"
        '
        'workTypeLbl
        '
        Me.workTypeLbl.AutoSize = True
        Me.workTypeLbl.BackColor = System.Drawing.Color.LightSteelBlue
        Me.workTypeLbl.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.workTypeLbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.workTypeLbl.Location = New System.Drawing.Point(303, 108)
        Me.workTypeLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.workTypeLbl.Name = "workTypeLbl"
        Me.workTypeLbl.Size = New System.Drawing.Size(75, 18)
        Me.workTypeLbl.TabIndex = 28
        Me.workTypeLbl.Text = "Work Type"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(108, 68)
        Me.FirstNameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(167, 23)
        Me.FirstNameTextBox.TabIndex = 29
        '
        'lastNameTextBox
        '
        Me.lastNameTextBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastNameTextBox.Location = New System.Drawing.Point(108, 108)
        Me.lastNameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.lastNameTextBox.Name = "lastNameTextBox"
        Me.lastNameTextBox.Size = New System.Drawing.Size(166, 23)
        Me.lastNameTextBox.TabIndex = 30
        '
        'emailTextBox
        '
        Me.emailTextBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailTextBox.Location = New System.Drawing.Point(379, 57)
        Me.emailTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.emailTextBox.Name = "emailTextBox"
        Me.emailTextBox.Size = New System.Drawing.Size(185, 23)
        Me.emailTextBox.TabIndex = 58
        '
        'phoneNoTextBox
        '
        Me.phoneNoTextBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phoneNoTextBox.Location = New System.Drawing.Point(379, 26)
        Me.phoneNoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.phoneNoTextBox.Name = "phoneNoTextBox"
        Me.phoneNoTextBox.Size = New System.Drawing.Size(185, 23)
        Me.phoneNoTextBox.TabIndex = 56
        '
        'phoneNoLbl
        '
        Me.phoneNoLbl.AutoSize = True
        Me.phoneNoLbl.BackColor = System.Drawing.Color.LightSteelBlue
        Me.phoneNoLbl.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phoneNoLbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.phoneNoLbl.Location = New System.Drawing.Point(309, 34)
        Me.phoneNoLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.phoneNoLbl.Name = "phoneNoLbl"
        Me.phoneNoLbl.Size = New System.Drawing.Size(67, 18)
        Me.phoneNoLbl.TabIndex = 55
        Me.phoneNoLbl.Text = "Phone No"
        '
        'emailLbl
        '
        Me.emailLbl.AutoSize = True
        Me.emailLbl.BackColor = System.Drawing.Color.LightSteelBlue
        Me.emailLbl.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailLbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.emailLbl.Location = New System.Drawing.Point(309, 60)
        Me.emailLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.emailLbl.Name = "emailLbl"
        Me.emailLbl.Size = New System.Drawing.Size(59, 18)
        Me.emailLbl.TabIndex = 54
        Me.emailLbl.Text = "EmailID"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.address2TextBox)
        Me.GroupBox3.Controls.Add(Me.zipcodeTextBox)
        Me.GroupBox3.Controls.Add(Me.addressLbl)
        Me.GroupBox3.Controls.Add(Me.countryTextBox)
        Me.GroupBox3.Controls.Add(Me.cityLbl)
        Me.GroupBox3.Controls.Add(Me.address1TextBox)
        Me.GroupBox3.Controls.Add(Me.stateLbl)
        Me.GroupBox3.Controls.Add(Me.stateTextBox)
        Me.GroupBox3.Controls.Add(Me.countryLbl)
        Me.GroupBox3.Controls.Add(Me.cityTextBox)
        Me.GroupBox3.Controls.Add(Me.emailTextBox)
        Me.GroupBox3.Controls.Add(Me.zipcodeLbl)
        Me.GroupBox3.Controls.Add(Me.phoneNoTextBox)
        Me.GroupBox3.Controls.Add(Me.emailLbl)
        Me.GroupBox3.Controls.Add(Me.phoneNoLbl)
        Me.GroupBox3.Font = New System.Drawing.Font("Book Antiqua", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox3.Location = New System.Drawing.Point(13, 391)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(603, 164)
        Me.GroupBox3.TabIndex = 51
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CONTACT INFORMATION"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(7, 62)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 18)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Address Line 2"
        '
        'address2TextBox
        '
        Me.address2TextBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address2TextBox.Location = New System.Drawing.Point(124, 57)
        Me.address2TextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.address2TextBox.Name = "address2TextBox"
        Me.address2TextBox.Size = New System.Drawing.Size(154, 23)
        Me.address2TextBox.TabIndex = 63
        '
        'zipcodeTextBox
        '
        Me.zipcodeTextBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.zipcodeTextBox.Location = New System.Drawing.Point(379, 123)
        Me.zipcodeTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.zipcodeTextBox.Name = "zipcodeTextBox"
        Me.zipcodeTextBox.Size = New System.Drawing.Size(185, 23)
        Me.zipcodeTextBox.TabIndex = 62
        '
        'addressLbl
        '
        Me.addressLbl.AutoSize = True
        Me.addressLbl.BackColor = System.Drawing.Color.LightSteelBlue
        Me.addressLbl.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addressLbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.addressLbl.Location = New System.Drawing.Point(8, 29)
        Me.addressLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.addressLbl.Name = "addressLbl"
        Me.addressLbl.Size = New System.Drawing.Size(98, 18)
        Me.addressLbl.TabIndex = 53
        Me.addressLbl.Text = "Address Line 1"
        '
        'countryTextBox
        '
        Me.countryTextBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.countryTextBox.Location = New System.Drawing.Point(379, 87)
        Me.countryTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.countryTextBox.Name = "countryTextBox"
        Me.countryTextBox.Size = New System.Drawing.Size(185, 23)
        Me.countryTextBox.TabIndex = 61
        '
        'cityLbl
        '
        Me.cityLbl.AutoSize = True
        Me.cityLbl.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cityLbl.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cityLbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cityLbl.Location = New System.Drawing.Point(10, 93)
        Me.cityLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.cityLbl.Name = "cityLbl"
        Me.cityLbl.Size = New System.Drawing.Size(32, 18)
        Me.cityLbl.TabIndex = 54
        Me.cityLbl.Text = "City"
        '
        'address1TextBox
        '
        Me.address1TextBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address1TextBox.Location = New System.Drawing.Point(125, 26)
        Me.address1TextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.address1TextBox.Name = "address1TextBox"
        Me.address1TextBox.Size = New System.Drawing.Size(154, 23)
        Me.address1TextBox.TabIndex = 60
        '
        'stateLbl
        '
        Me.stateLbl.AutoSize = True
        Me.stateLbl.BackColor = System.Drawing.Color.LightSteelBlue
        Me.stateLbl.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stateLbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.stateLbl.Location = New System.Drawing.Point(10, 123)
        Me.stateLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.stateLbl.Name = "stateLbl"
        Me.stateLbl.Size = New System.Drawing.Size(38, 18)
        Me.stateLbl.TabIndex = 55
        Me.stateLbl.Text = "State"
        '
        'stateTextBox
        '
        Me.stateTextBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stateTextBox.Location = New System.Drawing.Point(125, 120)
        Me.stateTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.stateTextBox.Name = "stateTextBox"
        Me.stateTextBox.Size = New System.Drawing.Size(153, 23)
        Me.stateTextBox.TabIndex = 59
        '
        'countryLbl
        '
        Me.countryLbl.AutoSize = True
        Me.countryLbl.BackColor = System.Drawing.Color.LightSteelBlue
        Me.countryLbl.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.countryLbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.countryLbl.Location = New System.Drawing.Point(309, 87)
        Me.countryLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.countryLbl.Name = "countryLbl"
        Me.countryLbl.Size = New System.Drawing.Size(56, 18)
        Me.countryLbl.TabIndex = 56
        Me.countryLbl.Text = "Country"
        '
        'cityTextBox
        '
        Me.cityTextBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cityTextBox.Location = New System.Drawing.Point(125, 87)
        Me.cityTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.cityTextBox.Name = "cityTextBox"
        Me.cityTextBox.Size = New System.Drawing.Size(153, 23)
        Me.cityTextBox.TabIndex = 58
        '
        'zipcodeLbl
        '
        Me.zipcodeLbl.AutoSize = True
        Me.zipcodeLbl.BackColor = System.Drawing.Color.LightSteelBlue
        Me.zipcodeLbl.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.zipcodeLbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.zipcodeLbl.Location = New System.Drawing.Point(308, 120)
        Me.zipcodeLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.zipcodeLbl.Name = "zipcodeLbl"
        Me.zipcodeLbl.Size = New System.Drawing.Size(57, 18)
        Me.zipcodeLbl.TabIndex = 57
        Me.zipcodeLbl.Text = "Zipcode"
        '
        'saveBtn
        '
        Me.saveBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.saveBtn.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveBtn.ForeColor = System.Drawing.SystemColors.Control
        Me.saveBtn.Location = New System.Drawing.Point(126, 563)
        Me.saveBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(102, 24)
        Me.saveBtn.TabIndex = 52
        Me.saveBtn.Text = "Save"
        Me.saveBtn.UseVisualStyleBackColor = False
        '
        'clearBtn
        '
        Me.clearBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.clearBtn.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearBtn.ForeColor = System.Drawing.SystemColors.Control
        Me.clearBtn.Location = New System.Drawing.Point(248, 563)
        Me.clearBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(102, 24)
        Me.clearBtn.TabIndex = 53
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = False
        '
        'backBtn
        '
        Me.backBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.backBtn.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backBtn.ForeColor = System.Drawing.SystemColors.Control
        Me.backBtn.Location = New System.Drawing.Point(371, 563)
        Me.backBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(102, 24)
        Me.backBtn.TabIndex = 54
        Me.backBtn.Text = "Back"
        Me.backBtn.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'EmployeeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(627, 609)
        Me.Controls.Add(Me.backBtn)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.personlDetailsGrpBox)
        Me.Controls.Add(Me.searchGrpBox)
        Me.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "EmployeeForm"
        Me.Text = "EmployeeForm"
        Me.searchGrpBox.ResumeLayout(False)
        Me.searchGrpBox.PerformLayout()
        Me.personlDetailsGrpBox.ResumeLayout(False)
        Me.personlDetailsGrpBox.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents searchGrpBox As GroupBox
    Friend WithEvents searchBtn As Button
    Friend WithEvents SearchStrTextBox As TextBox
    Friend WithEvents personlDetailsGrpBox As GroupBox
    Friend WithEvents pwdTextBox As TextBox
    Friend WithEvents lastNameTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents workTypeLbl As Label
    Friend WithEvents DOBLbl As Label
    Friend WithEvents lastNameLbl As Label
    Friend WithEvents firstNameLbl As Label
    Friend WithEvents workTypeComboBx As ComboBox
    Friend WithEvents hireDateLbl As Label
    Friend WithEvents DOBDatePicker As DateTimePicker
    Friend WithEvents emailLbl As Label
    Friend WithEvents hiredDatePicker As DateTimePicker
    Friend WithEvents phoneNoTextBox As TextBox
    Friend WithEvents phoneNoLbl As Label
    Friend WithEvents pwdLbl As Label
    Friend WithEvents emailTextBox As TextBox
    Friend WithEvents supervisorComboBox As ComboBox
    Friend WithEvents hrlyPayLbl As Label
    Friend WithEvents supervisorLbl As Label
    Friend WithEvents hourlyPayTextBox As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents zipcodeTextBox As TextBox
    Friend WithEvents addressLbl As Label
    Friend WithEvents countryTextBox As TextBox
    Friend WithEvents cityLbl As Label
    Friend WithEvents address1TextBox As TextBox
    Friend WithEvents stateLbl As Label
    Friend WithEvents stateTextBox As TextBox
    Friend WithEvents countryLbl As Label
    Friend WithEvents cityTextBox As TextBox
    Friend WithEvents zipcodeLbl As Label
    Friend WithEvents saveBtn As Button
    Friend WithEvents clearBtn As Button
    Friend WithEvents backBtn As Button
    Friend WithEvents lastNameRadioBtn As RadioButton
    Friend WithEvents frstNameRadioBtn As RadioButton
    Friend WithEvents employeeIDRadioBtn As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents address2TextBox As TextBox
    Friend WithEvents EmployeeIDTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
