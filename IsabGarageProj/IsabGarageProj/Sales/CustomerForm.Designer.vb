<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerForm
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
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.emailTextBox = New System.Windows.Forms.TextBox()
        Me.cityLbl = New System.Windows.Forms.Label()
        Me.zipcodeTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.addressLbl = New System.Windows.Forms.Label()
        Me.addressTextBox = New System.Windows.Forms.TextBox()
        Me.stateLbl = New System.Windows.Forms.Label()
        Me.stateTextBox = New System.Windows.Forms.TextBox()
        Me.cityTextBox = New System.Windows.Forms.TextBox()
        Me.zipcodeLbl = New System.Windows.Forms.Label()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.backBtn = New System.Windows.Forms.Button()
        Me.phoneNoTextBox = New System.Windows.Forms.TextBox()
        Me.searchGrpBox = New System.Windows.Forms.GroupBox()
        Me.lastNameRadioBtn = New System.Windows.Forms.RadioButton()
        Me.frstNameRadioBtn = New System.Windows.Forms.RadioButton()
        Me.customerIDRadioBtn = New System.Windows.Forms.RadioButton()
        Me.searchBtn = New System.Windows.Forms.Button()
        Me.SearchStrTextBox = New System.Windows.Forms.TextBox()
        Me.emailLbl = New System.Windows.Forms.Label()
        Me.phoneNoLbl = New System.Windows.Forms.Label()
        Me.firstNameLbl = New System.Windows.Forms.Label()
        Me.lastNameLbl = New System.Windows.Forms.Label()
        Me.lastNameTextBox = New System.Windows.Forms.TextBox()
        Me.personlDetailsGrpBox = New System.Windows.Forms.GroupBox()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox3.SuspendLayout()
        Me.searchGrpBox.SuspendLayout()
        Me.personlDetailsGrpBox.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'clearBtn
        '
        Me.clearBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.clearBtn.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.clearBtn.Location = New System.Drawing.Point(340, 350)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(75, 32)
        Me.clearBtn.TabIndex = 60
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = False
        '
        'emailTextBox
        '
        Me.emailTextBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailTextBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.emailTextBox.Location = New System.Drawing.Point(106, 162)
        Me.emailTextBox.Name = "emailTextBox"
        Me.emailTextBox.Size = New System.Drawing.Size(156, 23)
        Me.emailTextBox.TabIndex = 58
        '
        'cityLbl
        '
        Me.cityLbl.AutoSize = True
        Me.cityLbl.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cityLbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cityLbl.Location = New System.Drawing.Point(31, 65)
        Me.cityLbl.Name = "cityLbl"
        Me.cityLbl.Size = New System.Drawing.Size(32, 18)
        Me.cityLbl.TabIndex = 54
        Me.cityLbl.Text = "City"
        '
        'zipcodeTextBox
        '
        Me.zipcodeTextBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.zipcodeTextBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.zipcodeTextBox.Location = New System.Drawing.Point(82, 129)
        Me.zipcodeTextBox.Name = "zipcodeTextBox"
        Me.zipcodeTextBox.Size = New System.Drawing.Size(156, 23)
        Me.zipcodeTextBox.TabIndex = 62
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.zipcodeTextBox)
        Me.GroupBox3.Controls.Add(Me.addressLbl)
        Me.GroupBox3.Controls.Add(Me.cityLbl)
        Me.GroupBox3.Controls.Add(Me.addressTextBox)
        Me.GroupBox3.Controls.Add(Me.stateLbl)
        Me.GroupBox3.Controls.Add(Me.stateTextBox)
        Me.GroupBox3.Controls.Add(Me.cityTextBox)
        Me.GroupBox3.Controls.Add(Me.zipcodeLbl)
        Me.GroupBox3.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox3.Location = New System.Drawing.Point(306, 118)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(254, 216)
        Me.GroupBox3.TabIndex = 58
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Address Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(238, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 18)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "*"
        '
        'addressLbl
        '
        Me.addressLbl.AutoSize = True
        Me.addressLbl.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addressLbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.addressLbl.Location = New System.Drawing.Point(11, 30)
        Me.addressLbl.Name = "addressLbl"
        Me.addressLbl.Size = New System.Drawing.Size(58, 18)
        Me.addressLbl.TabIndex = 53
        Me.addressLbl.Text = "Address"
        '
        'addressTextBox
        '
        Me.addressTextBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addressTextBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.addressTextBox.Location = New System.Drawing.Point(82, 26)
        Me.addressTextBox.Name = "addressTextBox"
        Me.addressTextBox.Size = New System.Drawing.Size(156, 23)
        Me.addressTextBox.TabIndex = 60
        '
        'stateLbl
        '
        Me.stateLbl.AutoSize = True
        Me.stateLbl.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stateLbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.stateLbl.Location = New System.Drawing.Point(31, 94)
        Me.stateLbl.Name = "stateLbl"
        Me.stateLbl.Size = New System.Drawing.Size(38, 18)
        Me.stateLbl.TabIndex = 55
        Me.stateLbl.Text = "State"
        '
        'stateTextBox
        '
        Me.stateTextBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stateTextBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.stateTextBox.Location = New System.Drawing.Point(82, 92)
        Me.stateTextBox.Name = "stateTextBox"
        Me.stateTextBox.Size = New System.Drawing.Size(156, 23)
        Me.stateTextBox.TabIndex = 59
        '
        'cityTextBox
        '
        Me.cityTextBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cityTextBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cityTextBox.Location = New System.Drawing.Point(82, 61)
        Me.cityTextBox.Name = "cityTextBox"
        Me.cityTextBox.Size = New System.Drawing.Size(156, 23)
        Me.cityTextBox.TabIndex = 58
        '
        'zipcodeLbl
        '
        Me.zipcodeLbl.AutoSize = True
        Me.zipcodeLbl.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.zipcodeLbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.zipcodeLbl.Location = New System.Drawing.Point(12, 131)
        Me.zipcodeLbl.Name = "zipcodeLbl"
        Me.zipcodeLbl.Size = New System.Drawing.Size(57, 18)
        Me.zipcodeLbl.TabIndex = 57
        Me.zipcodeLbl.Text = "Zipcode"
        '
        'saveBtn
        '
        Me.saveBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.saveBtn.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.saveBtn.Location = New System.Drawing.Point(219, 350)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(75, 32)
        Me.saveBtn.TabIndex = 59
        Me.saveBtn.Text = "Save"
        Me.saveBtn.UseVisualStyleBackColor = False
        '
        'backBtn
        '
        Me.backBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.backBtn.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.backBtn.Location = New System.Drawing.Point(450, 350)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(75, 32)
        Me.backBtn.TabIndex = 61
        Me.backBtn.Text = "Exit"
        Me.backBtn.UseVisualStyleBackColor = False
        '
        'phoneNoTextBox
        '
        Me.phoneNoTextBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phoneNoTextBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.phoneNoTextBox.Location = New System.Drawing.Point(106, 131)
        Me.phoneNoTextBox.Name = "phoneNoTextBox"
        Me.phoneNoTextBox.Size = New System.Drawing.Size(156, 23)
        Me.phoneNoTextBox.TabIndex = 56
        '
        'searchGrpBox
        '
        Me.searchGrpBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.searchGrpBox.Controls.Add(Me.lastNameRadioBtn)
        Me.searchGrpBox.Controls.Add(Me.frstNameRadioBtn)
        Me.searchGrpBox.Controls.Add(Me.customerIDRadioBtn)
        Me.searchGrpBox.Controls.Add(Me.searchBtn)
        Me.searchGrpBox.Controls.Add(Me.SearchStrTextBox)
        Me.searchGrpBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchGrpBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.searchGrpBox.Location = New System.Drawing.Point(17, 12)
        Me.searchGrpBox.Name = "searchGrpBox"
        Me.searchGrpBox.Size = New System.Drawing.Size(543, 100)
        Me.searchGrpBox.TabIndex = 55
        Me.searchGrpBox.TabStop = False
        Me.searchGrpBox.Text = "Search Details"
        '
        'lastNameRadioBtn
        '
        Me.lastNameRadioBtn.AutoSize = True
        Me.lastNameRadioBtn.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastNameRadioBtn.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lastNameRadioBtn.Location = New System.Drawing.Point(268, 19)
        Me.lastNameRadioBtn.Name = "lastNameRadioBtn"
        Me.lastNameRadioBtn.Size = New System.Drawing.Size(91, 22)
        Me.lastNameRadioBtn.TabIndex = 55
        Me.lastNameRadioBtn.Text = "Last Name"
        Me.lastNameRadioBtn.UseVisualStyleBackColor = True
        '
        'frstNameRadioBtn
        '
        Me.frstNameRadioBtn.AutoSize = True
        Me.frstNameRadioBtn.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frstNameRadioBtn.ForeColor = System.Drawing.Color.MidnightBlue
        Me.frstNameRadioBtn.Location = New System.Drawing.Point(144, 19)
        Me.frstNameRadioBtn.Name = "frstNameRadioBtn"
        Me.frstNameRadioBtn.Size = New System.Drawing.Size(92, 22)
        Me.frstNameRadioBtn.TabIndex = 54
        Me.frstNameRadioBtn.Text = "First Name"
        Me.frstNameRadioBtn.UseVisualStyleBackColor = True
        '
        'customerIDRadioBtn
        '
        Me.customerIDRadioBtn.AutoSize = True
        Me.customerIDRadioBtn.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customerIDRadioBtn.ForeColor = System.Drawing.Color.MidnightBlue
        Me.customerIDRadioBtn.Location = New System.Drawing.Point(12, 20)
        Me.customerIDRadioBtn.Name = "customerIDRadioBtn"
        Me.customerIDRadioBtn.Size = New System.Drawing.Size(103, 22)
        Me.customerIDRadioBtn.TabIndex = 53
        Me.customerIDRadioBtn.Text = "Customer ID"
        Me.customerIDRadioBtn.UseVisualStyleBackColor = True
        '
        'searchBtn
        '
        Me.searchBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.searchBtn.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.searchBtn.Location = New System.Drawing.Point(218, 52)
        Me.searchBtn.Name = "searchBtn"
        Me.searchBtn.Size = New System.Drawing.Size(75, 26)
        Me.searchBtn.TabIndex = 52
        Me.searchBtn.Text = "Search"
        Me.searchBtn.UseVisualStyleBackColor = False
        '
        'SearchStrTextBox
        '
        Me.SearchStrTextBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchStrTextBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.SearchStrTextBox.Location = New System.Drawing.Point(12, 55)
        Me.SearchStrTextBox.Name = "SearchStrTextBox"
        Me.SearchStrTextBox.Size = New System.Drawing.Size(177, 23)
        Me.SearchStrTextBox.TabIndex = 51
        '
        'emailLbl
        '
        Me.emailLbl.AutoSize = True
        Me.emailLbl.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailLbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.emailLbl.Location = New System.Drawing.Point(37, 162)
        Me.emailLbl.Name = "emailLbl"
        Me.emailLbl.Size = New System.Drawing.Size(43, 18)
        Me.emailLbl.TabIndex = 54
        Me.emailLbl.Text = "Email"
        '
        'phoneNoLbl
        '
        Me.phoneNoLbl.AutoSize = True
        Me.phoneNoLbl.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phoneNoLbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.phoneNoLbl.Location = New System.Drawing.Point(20, 131)
        Me.phoneNoLbl.Name = "phoneNoLbl"
        Me.phoneNoLbl.Size = New System.Drawing.Size(67, 18)
        Me.phoneNoLbl.TabIndex = 55
        Me.phoneNoLbl.Text = "Phone No"
        '
        'firstNameLbl
        '
        Me.firstNameLbl.AutoSize = True
        Me.firstNameLbl.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstNameLbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.firstNameLbl.Location = New System.Drawing.Point(15, 61)
        Me.firstNameLbl.Name = "firstNameLbl"
        Me.firstNameLbl.Size = New System.Drawing.Size(74, 18)
        Me.firstNameLbl.TabIndex = 25
        Me.firstNameLbl.Text = "First Name"
        '
        'lastNameLbl
        '
        Me.lastNameLbl.AutoSize = True
        Me.lastNameLbl.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastNameLbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lastNameLbl.Location = New System.Drawing.Point(15, 95)
        Me.lastNameLbl.Name = "lastNameLbl"
        Me.lastNameLbl.Size = New System.Drawing.Size(73, 18)
        Me.lastNameLbl.TabIndex = 26
        Me.lastNameLbl.Text = "Last Name"
        '
        'lastNameTextBox
        '
        Me.lastNameTextBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastNameTextBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lastNameTextBox.Location = New System.Drawing.Point(106, 95)
        Me.lastNameTextBox.Name = "lastNameTextBox"
        Me.lastNameTextBox.Size = New System.Drawing.Size(156, 23)
        Me.lastNameTextBox.TabIndex = 30
        '
        'personlDetailsGrpBox
        '
        Me.personlDetailsGrpBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.personlDetailsGrpBox.Controls.Add(Me.CustomerIDTextBox)
        Me.personlDetailsGrpBox.Controls.Add(Me.Label1)
        Me.personlDetailsGrpBox.Controls.Add(Me.Label19)
        Me.personlDetailsGrpBox.Controls.Add(Me.Label18)
        Me.personlDetailsGrpBox.Controls.Add(Me.Label14)
        Me.personlDetailsGrpBox.Controls.Add(Me.emailTextBox)
        Me.personlDetailsGrpBox.Controls.Add(Me.phoneNoTextBox)
        Me.personlDetailsGrpBox.Controls.Add(Me.phoneNoLbl)
        Me.personlDetailsGrpBox.Controls.Add(Me.emailLbl)
        Me.personlDetailsGrpBox.Controls.Add(Me.firstNameLbl)
        Me.personlDetailsGrpBox.Controls.Add(Me.lastNameLbl)
        Me.personlDetailsGrpBox.Controls.Add(Me.FirstNameTextBox)
        Me.personlDetailsGrpBox.Controls.Add(Me.lastNameTextBox)
        Me.personlDetailsGrpBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.personlDetailsGrpBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.personlDetailsGrpBox.Location = New System.Drawing.Point(14, 118)
        Me.personlDetailsGrpBox.Name = "personlDetailsGrpBox"
        Me.personlDetailsGrpBox.Size = New System.Drawing.Size(287, 216)
        Me.personlDetailsGrpBox.TabIndex = 57
        Me.personlDetailsGrpBox.TabStop = False
        Me.personlDetailsGrpBox.Text = "Personal Details"
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.Enabled = False
        Me.CustomerIDTextBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerIDTextBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(106, 27)
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(156, 23)
        Me.CustomerIDTextBox.TabIndex = 70
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 18)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Customer ID"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(268, 93)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(14, 18)
        Me.Label19.TabIndex = 68
        Me.Label19.Text = "*"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(268, 52)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(14, 18)
        Me.Label18.TabIndex = 67
        Me.Label18.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(269, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(14, 18)
        Me.Label14.TabIndex = 51
        Me.Label14.Text = "*"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameTextBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FirstNameTextBox.Location = New System.Drawing.Point(106, 61)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(156, 23)
        Me.FirstNameTextBox.TabIndex = 29
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'CustomerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(571, 408)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.backBtn)
        Me.Controls.Add(Me.searchGrpBox)
        Me.Controls.Add(Me.personlDetailsGrpBox)
        Me.Name = "CustomerForm"
        Me.Text = "CustomerForm"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.searchGrpBox.ResumeLayout(False)
        Me.searchGrpBox.PerformLayout()
        Me.personlDetailsGrpBox.ResumeLayout(False)
        Me.personlDetailsGrpBox.PerformLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents clearBtn As Button
    Friend WithEvents emailTextBox As TextBox
    Friend WithEvents cityLbl As Label
    Friend WithEvents zipcodeTextBox As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents addressLbl As Label
    Friend WithEvents addressTextBox As TextBox
    Friend WithEvents stateLbl As Label
    Friend WithEvents stateTextBox As TextBox
    Friend WithEvents cityTextBox As TextBox
    Friend WithEvents zipcodeLbl As Label
    Friend WithEvents saveBtn As Button
    Friend WithEvents backBtn As Button
    Friend WithEvents phoneNoTextBox As TextBox
    Friend WithEvents searchGrpBox As GroupBox
    Friend WithEvents lastNameRadioBtn As RadioButton
    Friend WithEvents frstNameRadioBtn As RadioButton
    Friend WithEvents customerIDRadioBtn As RadioButton
    Friend WithEvents searchBtn As Button
    Friend WithEvents SearchStrTextBox As TextBox
    Friend WithEvents emailLbl As Label
    Friend WithEvents phoneNoLbl As Label
    Friend WithEvents firstNameLbl As Label
    Friend WithEvents lastNameLbl As Label
    Friend WithEvents lastNameTextBox As TextBox
    Friend WithEvents personlDetailsGrpBox As GroupBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents CustomerIDTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents Label2 As Label
End Class
