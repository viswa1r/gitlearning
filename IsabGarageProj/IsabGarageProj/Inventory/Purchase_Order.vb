Public Class Purchase_Order_Form
    Private DB As New DBStore
    Dim Order_quantity As Integer = 0
    Public Class OrderDetails
        Public PartId, supplierId, puchasedate As String
        Public unitPrice As Decimal = 0
        Public Quantity As Integer = 0
    End Class
    Dim orderDetailsObj As OrderDetails = New OrderDetails()

    Private Sub AddSup_Button_Click(sender As Object, e As EventArgs) Handles AddSup_Button.Click
        Suppliers_Form.ShowDialog()
    End Sub

    Private Sub Purchase_Order_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_Supplier_ID()
    End Sub
    Private Sub load_Supplier_ID()

        DB.ExecuteQuery("SELECT * FROM suppliers;")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        SupplierIDComboBox.Items.Clear()
        SupplierIDComboBox.Text = String.Empty
        'MsgBox(DB.RecordCount)

        For Each aDataRow As DataRow In DB.DBDataTable.Rows
            SupplierIDComboBox.Items.Add(aDataRow("SupplierID"))

        Next
        If DB.RecordCount > 0 Then
            SupplierIDComboBox.SelectedIndex = 0
        End If
    End Sub
    Private Sub SupplierIDComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SupplierIDComboBox.SelectedIndexChanged
        SupplierIDComboBox.Enabled = True
        cmpComboBox.Enabled = True
        modelComboBox.Enabled = True
        partNameComboBox.Enabled = True

        load_company_name()
    End Sub
    Private Sub load_company_name()

        DB.ExecuteQuery("select distinct s.CompanyName from spareparts sp
                                inner join suppliers s on sp.supplierId=s.SupplierID
                                    where s.SupplierID='" & SupplierIDComboBox.Text & "';")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        cmpComboBox.Items.Clear()
        cmpComboBox.Text = String.Empty

        'MsgBox(DB.RecordCount)

        For Each aDataRow As DataRow In DB.DBDataTable.Rows
            cmpComboBox.Items.Add(aDataRow("CompanyName"))

        Next
        If DB.RecordCount > 0 Then
            cmpComboBox.SelectedIndex = 0
        End If
    End Sub
    Private Sub cmpComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmpComboBox.SelectedIndexChanged

        cmpComboBox.Enabled = True
        modelComboBox.Enabled = True
        partNameComboBox.Enabled = True

        load_model_name()
    End Sub

    Private Sub load_model_name()

        DB.ExecuteQuery("select distinct sp.carModel from spareparts sp
                              inner join suppliers s on sp.supplierId=s.SupplierID
                               where s.CompanyName='" & cmpComboBox.Text & "';")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        modelComboBox.Items.Clear()
        modelComboBox.Text = String.Empty

        For Each aDataRow As DataRow In DB.DBDataTable.Rows
            modelComboBox.Items.Add(aDataRow("carModel"))
        Next
        If DB.RecordCount > 0 Then
            modelComboBox.SelectedIndex = 0
        End If


    End Sub

    Private Sub load_part_name()

        DB.ExecuteQuery("select sp.partId,sp.unitPrice from spareparts sp
                              inner join suppliers s on sp.supplierId=s.SupplierID
                               where s.CompanyName='" & cmpComboBox.Text & "' and sp.carModel='" & modelComboBox.Text & "';")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        partNameComboBox.Items.Clear()
        partNameComboBox.Text = String.Empty

        For Each aDataRow As DataRow In DB.DBDataTable.Rows
            partNameComboBox.Items.Add(aDataRow("partId"))
            UnitPriceTextBox.Text = (aDataRow("unitPrice"))
        Next
        If DB.RecordCount > 0 Then
            partNameComboBox.SelectedIndex = 0
        End If
        'UnitPriceTextBox.Text = DB.DBDataTable(0)!unitPrice
    End Sub

    Private Sub modelComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles modelComboBox.SelectedIndexChanged
        cmpComboBox.Enabled = True
        modelComboBox.Enabled = True
        partNameComboBox.Enabled = True


        load_part_name()
    End Sub
    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub
    Private Sub Order_Button_Click(sender As Object, e As EventArgs) Handles Order_Button.Click
        InsertNewPurchaseHistory()

    End Sub
    Public Sub InsertNewPurchaseHistory()
        Dim today As System.DateTime
        today = System.DateTime.Now

        DB.AddParam("@partId", partNameComboBox.Text)
        DB.AddParam("@supplierId", SupplierIDComboBox.Text)
            DB.AddParam("@purchasedate", today)
            DB.AddParam("@unitprice", UnitPriceTextBox.Text)
            DB.AddParam("@quantity", quantityTextBox.Text)


            DB.ExecuteQuery("INSERT INTO purchasehistory (partId, supplierId, purchasedate, unitprice,quantity) VALUES(?,?,?,?,?)")
            If DB.Exception <> String.Empty Then
                MessageBox.Show(DB.Exception)
                Exit Sub
            End If
            MessageBox.Show("A New Purchase Order is created successfully", "Purchase History Updated")

    End Sub

End Class