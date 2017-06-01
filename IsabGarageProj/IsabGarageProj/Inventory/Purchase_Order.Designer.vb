<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Purchase_Order_Form
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AddSup_Button = New System.Windows.Forms.Button()
        Me.Order_Button = New System.Windows.Forms.Button()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.cmpComboBox = New System.Windows.Forms.ComboBox()
        Me.modelComboBox = New System.Windows.Forms.ComboBox()
        Me.partNameComboBox = New System.Windows.Forms.ComboBox()
        Me.UnitPriceTextBox = New System.Windows.Forms.TextBox()
        Me.quantityTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SupplierIDComboBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(20, 80)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Car Company"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(23, 118)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Car Model"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(23, 155)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Part Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(23, 191)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Unit Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Location = New System.Drawing.Point(20, 227)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Units In Order"
        '
        'AddSup_Button
        '
        Me.AddSup_Button.BackColor = System.Drawing.Color.SteelBlue
        Me.AddSup_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AddSup_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.AddSup_Button.Location = New System.Drawing.Point(27, 278)
        Me.AddSup_Button.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AddSup_Button.Name = "AddSup_Button"
        Me.AddSup_Button.Size = New System.Drawing.Size(100, 32)
        Me.AddSup_Button.TabIndex = 5
        Me.AddSup_Button.Text = "Add Supplier"
        Me.AddSup_Button.UseVisualStyleBackColor = False
        '
        'Order_Button
        '
        Me.Order_Button.BackColor = System.Drawing.Color.SteelBlue
        Me.Order_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Order_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Order_Button.Location = New System.Drawing.Point(167, 278)
        Me.Order_Button.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Order_Button.Name = "Order_Button"
        Me.Order_Button.Size = New System.Drawing.Size(100, 32)
        Me.Order_Button.TabIndex = 6
        Me.Order_Button.Text = "Order"
        Me.Order_Button.UseVisualStyleBackColor = False
        '
        'Exit_Button
        '
        Me.Exit_Button.BackColor = System.Drawing.Color.SteelBlue
        Me.Exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Exit_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Exit_Button.Location = New System.Drawing.Point(311, 278)
        Me.Exit_Button.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(100, 32)
        Me.Exit_Button.TabIndex = 7
        Me.Exit_Button.Text = "Exit"
        Me.Exit_Button.UseVisualStyleBackColor = False
        '
        'cmpComboBox
        '
        Me.cmpComboBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmpComboBox.FormattingEnabled = True
        Me.cmpComboBox.Location = New System.Drawing.Point(139, 78)
        Me.cmpComboBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmpComboBox.Name = "cmpComboBox"
        Me.cmpComboBox.Size = New System.Drawing.Size(202, 26)
        Me.cmpComboBox.TabIndex = 8
        '
        'modelComboBox
        '
        Me.modelComboBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.modelComboBox.FormattingEnabled = True
        Me.modelComboBox.Location = New System.Drawing.Point(139, 115)
        Me.modelComboBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.modelComboBox.Name = "modelComboBox"
        Me.modelComboBox.Size = New System.Drawing.Size(202, 26)
        Me.modelComboBox.TabIndex = 9
        '
        'partNameComboBox
        '
        Me.partNameComboBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.partNameComboBox.FormattingEnabled = True
        Me.partNameComboBox.Location = New System.Drawing.Point(139, 152)
        Me.partNameComboBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.partNameComboBox.Name = "partNameComboBox"
        Me.partNameComboBox.Size = New System.Drawing.Size(202, 26)
        Me.partNameComboBox.TabIndex = 10
        '
        'UnitPriceTextBox
        '
        Me.UnitPriceTextBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UnitPriceTextBox.Location = New System.Drawing.Point(139, 188)
        Me.UnitPriceTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UnitPriceTextBox.Name = "UnitPriceTextBox"
        Me.UnitPriceTextBox.Size = New System.Drawing.Size(128, 23)
        Me.UnitPriceTextBox.TabIndex = 11
        '
        'quantityTextBox
        '
        Me.quantityTextBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.quantityTextBox.Location = New System.Drawing.Point(139, 227)
        Me.quantityTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.quantityTextBox.Name = "quantityTextBox"
        Me.quantityTextBox.Size = New System.Drawing.Size(128, 23)
        Me.quantityTextBox.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Location = New System.Drawing.Point(21, 44)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 18)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "SupplierID"
        '
        'SupplierIDComboBox
        '
        Me.SupplierIDComboBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.SupplierIDComboBox.FormattingEnabled = True
        Me.SupplierIDComboBox.Location = New System.Drawing.Point(139, 41)
        Me.SupplierIDComboBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SupplierIDComboBox.Name = "SupplierIDComboBox"
        Me.SupplierIDComboBox.Size = New System.Drawing.Size(202, 26)
        Me.SupplierIDComboBox.TabIndex = 14
        '
        'Purchase_Order_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(460, 330)
        Me.Controls.Add(Me.SupplierIDComboBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.quantityTextBox)
        Me.Controls.Add(Me.UnitPriceTextBox)
        Me.Controls.Add(Me.partNameComboBox)
        Me.Controls.Add(Me.modelComboBox)
        Me.Controls.Add(Me.cmpComboBox)
        Me.Controls.Add(Me.Exit_Button)
        Me.Controls.Add(Me.Order_Button)
        Me.Controls.Add(Me.AddSup_Button)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Purchase_Order_Form"
        Me.Text = "Purchase_Order"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents AddSup_Button As Button
    Friend WithEvents Order_Button As Button
    Friend WithEvents Exit_Button As Button
    Friend WithEvents cmpComboBox As ComboBox
    Friend WithEvents modelComboBox As ComboBox
    Friend WithEvents partNameComboBox As ComboBox
    Friend WithEvents UnitPriceTextBox As TextBox
    Friend WithEvents quantityTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents SupplierIDComboBox As ComboBox
End Class
