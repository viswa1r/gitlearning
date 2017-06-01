<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vehicles
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.saveButton = New System.Windows.Forms.Button()
        Me.cancelButton = New System.Windows.Forms.Button()
        Me.vehicleidTB = New System.Windows.Forms.TextBox()
        Me.modelTB = New System.Windows.Forms.TextBox()
        Me.enginenumTB = New System.Windows.Forms.TextBox()
        Me.colorTB = New System.Windows.Forms.TextBox()
        Me.customeridTB = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vehicle ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(12, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Model"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(12, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Engine Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(12, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Color"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label5.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(12, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Customer ID"
        '
        'saveButton
        '
        Me.saveButton.BackColor = System.Drawing.Color.SteelBlue
        Me.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.saveButton.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.saveButton.Location = New System.Drawing.Point(22, 222)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(86, 26)
        Me.saveButton.TabIndex = 5
        Me.saveButton.Text = "Save"
        Me.saveButton.UseVisualStyleBackColor = False
        '
        'cancelButton
        '
        Me.cancelButton.BackColor = System.Drawing.Color.SteelBlue
        Me.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cancelButton.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cancelButton.Location = New System.Drawing.Point(125, 222)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(90, 26)
        Me.cancelButton.TabIndex = 6
        Me.cancelButton.Text = "Cancel"
        Me.cancelButton.UseVisualStyleBackColor = False
        '
        'vehicleidTB
        '
        Me.vehicleidTB.Location = New System.Drawing.Point(125, 25)
        Me.vehicleidTB.Name = "vehicleidTB"
        Me.vehicleidTB.Size = New System.Drawing.Size(122, 20)
        Me.vehicleidTB.TabIndex = 7
        '
        'modelTB
        '
        Me.modelTB.Location = New System.Drawing.Point(125, 55)
        Me.modelTB.Name = "modelTB"
        Me.modelTB.Size = New System.Drawing.Size(122, 20)
        Me.modelTB.TabIndex = 8
        '
        'enginenumTB
        '
        Me.enginenumTB.Location = New System.Drawing.Point(125, 84)
        Me.enginenumTB.Name = "enginenumTB"
        Me.enginenumTB.Size = New System.Drawing.Size(122, 20)
        Me.enginenumTB.TabIndex = 9
        '
        'colorTB
        '
        Me.colorTB.Location = New System.Drawing.Point(125, 117)
        Me.colorTB.Name = "colorTB"
        Me.colorTB.Size = New System.Drawing.Size(122, 20)
        Me.colorTB.TabIndex = 10
        '
        'customeridTB
        '
        Me.customeridTB.Location = New System.Drawing.Point(125, 150)
        Me.customeridTB.Name = "customeridTB"
        Me.customeridTB.Size = New System.Drawing.Size(122, 20)
        Me.customeridTB.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.IsabGarageProj.My.Resources.Resources.Isabellagarage
        Me.PictureBox1.Location = New System.Drawing.Point(253, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(341, 275)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'Vehicles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(606, 299)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.customeridTB)
        Me.Controls.Add(Me.colorTB)
        Me.Controls.Add(Me.enginenumTB)
        Me.Controls.Add(Me.modelTB)
        Me.Controls.Add(Me.vehicleidTB)
        Me.Controls.Add(Me.cancelButton)
        Me.Controls.Add(Me.saveButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Vehicles"
        Me.Text = "Vehicles"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents saveButton As Button
    Friend WithEvents cancelButton As Button
    Friend WithEvents vehicleidTB As TextBox
    Friend WithEvents modelTB As TextBox
    Friend WithEvents enginenumTB As TextBox
    Friend WithEvents colorTB As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ErrorProvider As ErrorProvider
    Public WithEvents customeridTB As TextBox
End Class
