<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginPage))
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.pwdTextBox = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.Label()
        Me.empIDTextBox = New System.Windows.Forms.TextBox()
        Me.employeeID = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'exitBtn
        '
        Me.exitBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.exitBtn.Font = New System.Drawing.Font("Book Antiqua", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.exitBtn.Location = New System.Drawing.Point(501, 265)
        Me.exitBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(133, 48)
        Me.exitBtn.TabIndex = 13
        Me.exitBtn.Text = "Exit"
        Me.exitBtn.UseVisualStyleBackColor = False
        '
        'clearBtn
        '
        Me.clearBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.clearBtn.Font = New System.Drawing.Font("Book Antiqua", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.clearBtn.Location = New System.Drawing.Point(330, 265)
        Me.clearBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(133, 48)
        Me.clearBtn.TabIndex = 12
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = False
        '
        'loginBtn
        '
        Me.loginBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.loginBtn.Font = New System.Drawing.Font("Book Antiqua", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.loginBtn.Location = New System.Drawing.Point(141, 265)
        Me.loginBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(133, 48)
        Me.loginBtn.TabIndex = 11
        Me.loginBtn.Text = "Login"
        Me.loginBtn.UseVisualStyleBackColor = False
        '
        'pwdTextBox
        '
        Me.pwdTextBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pwdTextBox.Location = New System.Drawing.Point(289, 160)
        Me.pwdTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.pwdTextBox.Multiline = True
        Me.pwdTextBox.Name = "pwdTextBox"
        Me.pwdTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pwdTextBox.Size = New System.Drawing.Size(204, 33)
        Me.pwdTextBox.TabIndex = 10
        '
        'password
        '
        Me.password.AutoSize = True
        Me.password.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.password.Font = New System.Drawing.Font("Book Antiqua", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.ForeColor = System.Drawing.Color.MidnightBlue
        Me.password.Location = New System.Drawing.Point(156, 165)
        Me.password.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(94, 23)
        Me.password.TabIndex = 9
        Me.password.Text = "Password"
        '
        'empIDTextBox
        '
        Me.empIDTextBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empIDTextBox.Location = New System.Drawing.Point(289, 88)
        Me.empIDTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.empIDTextBox.Multiline = True
        Me.empIDTextBox.Name = "empIDTextBox"
        Me.empIDTextBox.Size = New System.Drawing.Size(204, 33)
        Me.empIDTextBox.TabIndex = 8
        '
        'employeeID
        '
        Me.employeeID.AutoSize = True
        Me.employeeID.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.employeeID.Font = New System.Drawing.Font("Book Antiqua", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeID.ForeColor = System.Drawing.Color.MidnightBlue
        Me.employeeID.Location = New System.Drawing.Point(138, 96)
        Me.employeeID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.employeeID.Name = "employeeID"
        Me.employeeID.Size = New System.Drawing.Size(122, 23)
        Me.employeeID.TabIndex = 7
        Me.employeeID.Text = "EmployeeID"
        '
        'LoginPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(700, 372)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.loginBtn)
        Me.Controls.Add(Me.pwdTextBox)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.empIDTextBox)
        Me.Controls.Add(Me.employeeID)
        Me.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "LoginPage"
        Me.Text = "LoginPage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents exitBtn As Button
    Friend WithEvents clearBtn As Button
    Friend WithEvents loginBtn As Button
    Friend WithEvents pwdTextBox As TextBox
    Friend WithEvents password As Label
    Friend WithEvents empIDTextBox As TextBox
    Friend WithEvents employeeID As Label
End Class
