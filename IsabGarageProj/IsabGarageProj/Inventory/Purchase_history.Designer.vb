<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Purchase_history_Form
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmpComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PHDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.purchistryDataGridView = New System.Windows.Forms.DataGridView()
        Me.Search_Button = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        CType(Me.purchistryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Company Name"
        '
        'cmpComboBox
        '
        Me.cmpComboBox.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmpComboBox.FormattingEnabled = True
        Me.cmpComboBox.Location = New System.Drawing.Point(199, 42)
        Me.cmpComboBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmpComboBox.Name = "cmpComboBox"
        Me.cmpComboBox.Size = New System.Drawing.Size(151, 25)
        Me.cmpComboBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 92)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Purchase Date"
        '
        'PHDateTimePicker
        '
        Me.PHDateTimePicker.CustomFormat = "yyyy-MM-dd "
        Me.PHDateTimePicker.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PHDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.PHDateTimePicker.Location = New System.Drawing.Point(199, 92)
        Me.PHDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PHDateTimePicker.Name = "PHDateTimePicker"
        Me.PHDateTimePicker.Size = New System.Drawing.Size(151, 24)
        Me.PHDateTimePicker.TabIndex = 3
        '
        'purchistryDataGridView
        '
        Me.purchistryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.purchistryDataGridView.Location = New System.Drawing.Point(17, 160)
        Me.purchistryDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.purchistryDataGridView.Name = "purchistryDataGridView"
        Me.purchistryDataGridView.Size = New System.Drawing.Size(551, 212)
        Me.purchistryDataGridView.TabIndex = 4
        '
        'Search_Button
        '
        Me.Search_Button.BackColor = System.Drawing.Color.SteelBlue
        Me.Search_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Search_Button.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Search_Button.Location = New System.Drawing.Point(405, 54)
        Me.Search_Button.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Search_Button.Name = "Search_Button"
        Me.Search_Button.Size = New System.Drawing.Size(116, 39)
        Me.Search_Button.TabIndex = 5
        Me.Search_Button.Text = "Search"
        Me.Search_Button.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.SteelBlue
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ExitButton.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ExitButton.Location = New System.Drawing.Point(405, 405)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(100, 39)
        Me.ExitButton.TabIndex = 6
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'Purchase_history_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(592, 460)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Search_Button)
        Me.Controls.Add(Me.purchistryDataGridView)
        Me.Controls.Add(Me.PHDateTimePicker)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmpComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Purchase_history_Form"
        Me.Text = "Purchase_history"
        CType(Me.purchistryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmpComboBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PHDateTimePicker As DateTimePicker
    Friend WithEvents purchistryDataGridView As DataGridView
    Friend WithEvents Search_Button As Button
    Friend WithEvents ExitButton As Button
End Class
