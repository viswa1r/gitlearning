Public Class SparePartsForm
    Private DB As New DBStore
    Public changeCode As Integer
    Public sparePartsobj As SpareParts = New SpareParts()
    Public errorCode As Integer = 0

    Public Class SpareParts
        Public companyName, Model, partID, partName, unitPrice, unitsInStock, unitsInOrder As String
    End Class

    Private Sub cmpComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmpComboBox.SelectedIndexChanged
        cmpComboBox.Enabled = True
        modelComboBox.Enabled = True
        partNameComboBox.Enabled = True
        sparePartsobj.companyName = cmpComboBox.Text
        load_model_name()
    End Sub

    Private Sub modelComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles modelComboBox.SelectedIndexChanged
        cmpComboBox.Enabled = True
        modelComboBox.Enabled = True
        partNameComboBox.Enabled = True
        sparePartsobj.Model = modelComboBox.Text
        load_part_Name()
    End Sub

    Private Sub partNameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles partNameComboBox.SelectedIndexChanged
        partNameComboBox.Enabled = True
        unitPriceTextBx.Enabled = True
        sparePartsobj.partName = partNameComboBox.Text
        load_part_price()
    End Sub

    Private Sub load_company_name()
        DB.ExecuteQuery("SELECT * FROM suppliers;")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        cmpComboBox.Items.Clear()
        cmpComboBox.Text = String.Empty
        For Each aDataRow As DataRow In DB.DBDataTable.Rows
            cmpComboBox.Items.Add(aDataRow("CompanyName"))
        Next
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

    End Sub

    Private Sub load_part_Name()

        DB.ExecuteQuery("select sp.partName from spareparts sp
                              inner join suppliers s on sp.supplierId=s.SupplierID
                               where s.CompanyName='" & cmpComboBox.Text & "' and sp.carModel='" & modelComboBox.Text & "';")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        partNameComboBox.Items.Clear()
        partNameComboBox.Text = String.Empty

        For Each aDataRow As DataRow In DB.DBDataTable.Rows
            partNameComboBox.Items.Add(aDataRow("partName"))
        Next

    End Sub

    Private Sub load_part_price()

        DB.ExecuteQuery("select partID,partName,unitPrice,unitsInStock,unitsInOrder from spareparts where partName='" & partNameComboBox.Text & "';")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        unitPriceTextBx.Text = DB.DBDataTable(0)!unitPrice
        unitsInStockTextBox.Text = DB.DBDataTable(0)!unitsInStock
        unitsInOrderTextBox.Text = DB.DBDataTable(0)!unitsInOrder
        sparePartsobj.partID = DB.DBDataTable(0)!partID
        sparePartsobj.unitPrice = unitPriceTextBx.Text
        sparePartsobj.unitsInStock = unitsInStockTextBox.Text
        sparePartsobj.unitsInOrder = unitsInOrderTextBox.Text

        unitPriceTextBx.Enabled = False
    End Sub

    Public Sub loadModeType()
        ModeComboBox.Items.Clear()
        ModeComboBox.Text = "Select"

        ModeComboBox.Items.Add("New")
        ModeComboBox.Items.Add("View")
        ModeComboBox.Items.Add("Edit")
        ModeComboBox.Items.Add("Delete")

    End Sub

    Private Sub SparePartsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadModeType()
        load_company_name()
    End Sub

    Private Sub ModeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ModeComboBox.SelectedIndexChanged

        If ModeComboBox.Text = "New" Or ModeComboBox.Text = "Edit" Then
            cmpComboBox.Enabled = True
            modelComboBox.Enabled = True
            modelComboBox.DropDownStyle = ComboBoxStyle.DropDown
            partNameComboBox.Enabled = True
            partNameComboBox.DropDownStyle = ComboBoxStyle.DropDown
            unitPriceTextBx.Enabled = True
            unitsInStockTextBox.Enabled = True
            unitsInOrderTextBox.Enabled = True
        End If

        If ModeComboBox.Text = "View" Or ModeComboBox.Text = "Delete" Then
            cmpComboBox.Enabled = True
            modelComboBox.Enabled = True
            modelComboBox.DropDownStyle = ComboBoxStyle.DropDownList
            partNameComboBox.Enabled = True
            partNameComboBox.DropDownStyle = ComboBoxStyle.DropDownList
            unitPriceTextBx.Enabled = False
            unitsInStockTextBox.Enabled = False
            unitsInOrderTextBox.Enabled = False
        End If
    End Sub

    Private Sub form_Closing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        clearData()
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Me.Close()
    End Sub

    Public Sub clearData()
        cmpComboBox.Items.Clear()
        modelComboBox.Items.Clear()
        partNameComboBox.Items.Clear()
        unitPriceTextBx.Clear()
        unitsInStockTextBox.Clear()
        unitsInOrderTextBox.Clear()
        loadModeType()
        load_company_name()
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        clearData()
    End Sub

    Public Sub checkChangesInForm()
        If sparePartsobj.companyName <> cmpComboBox.Text Then
            changeCode = 1
        End If
        If sparePartsobj.Model <> modelComboBox.Text Then
            changeCode = 1
        End If
        If sparePartsobj.partName <> partNameComboBox.Text Then
            changeCode = 1
        End If
        If sparePartsobj.unitPrice <> unitPriceTextBx.Text Then
            changeCode = 1
        End If

    End Sub

    Public Sub checkvalidations()
        If cmpComboBox.Text = "" Then
            ErrorProvider_sp.Clear()
            errorCode = 1
            ErrorProvider_sp.SetError(cmpComboBox, "Please select one value in drop down")
        ElseIf modelComboBox.Text = "" Then
            ErrorProvider_sp.Clear()
            errorCode = 1
            ErrorProvider_sp.SetError(modelComboBox, "Car Model cannot be empty")
        ElseIf partNameComboBox.Text = "" Then
            ErrorProvider_sp.Clear()
            errorCode = 1
            ErrorProvider_sp.SetError(partNameComboBox, "Part Name cannot be empty")
        ElseIf unitPriceTextBx.Text = "" Then
            ErrorProvider_sp.Clear()
            errorCode = 1
            ErrorProvider_sp.SetError(unitPriceTextBx, "Unit Price cannot be empty")
        End If
    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        checkvalidations()
        If errorCode = 0 Then
            If ModeComboBox.Text = "New" Then
                insertdata()
            ElseIf ModeComboBox.Text = "Edit" Then
                checkChangesInForm()
                If changeCode = 1 Then
                    updateDate()
                Else
                    MessageBox.Show("No changes Made", "Nothing Updated")
                End If
            ElseIf ModeComboBox.Text = "Delete" Then
                deleteData()
            End If
        Else

        End If

    End Sub

    Public Sub insertdata()
        Dim supplierID As String
        Dim partID As String = ""
        Dim existingPartID = sparePartsobj.partID

        DB.ExecuteQuery("Select * from spareparts where partID='" & existingPartID & "';")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        If DB.RecordCount > 0 Then
            partID = partNameComboBox.Text & "-" & modelComboBox.Text
            DB.ExecuteQuery("Select supplierID from suppliers where CompanyName='" & cmpComboBox.Text & "';")
            supplierID = DB.DBDataTable(0)!supplierID

            DB.AddParam("@partID", partID)
            DB.AddParam("@partName", partNameComboBox.Text)
            DB.AddParam("@unitPrice", unitPriceTextBx.Text)
            DB.AddParam("@supplierID", supplierID)
            DB.AddParam("@unitsInStock", unitsInStockTextBox.Text)
            DB.AddParam("@unitsInOrder", unitsInOrderTextBox.Text)
            DB.AddParam("@modelName", modelComboBox.Text)

            DB.ExecuteQuery("insert spareparts(partID,partName,unitPrice,supplierId,unitsInStock,unitsInOrder,carModel) values(?,?,?,?,?,?,?) ;")
            If DB.Exception <> String.Empty Then
                MessageBox.Show(DB.Exception)
                Exit Sub
            End If
            MessageBox.Show("sparepart Inserted successfully", "spareparts Inserted")
        Else
            MessageBox.Show("sparepart already Exists,Can you enter New spareparts details", "spareparts Error")
        End If

    End Sub

    Public Sub updateDate()
        DB.AddParam("@unitPrice", unitPriceTextBx.Text)
        DB.AddParam("@partName", partNameComboBox.Text)
        DB.AddParam("@unitsInStock", unitsInStockTextBox.Text)
        DB.AddParam("@unitsInOrder", unitsInOrderTextBox.Text)
        DB.AddParam("@partID", sparePartsobj.partID.ToString)

        DB.ExecuteQuery("Update spareparts set unitPrice=?,partName=?,unitsInStock=?,unitsInOrder=? where partID=?")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        MessageBox.Show("spareparts Updated successfully", "spareparts Updated")

    End Sub

    Public Sub deleteData()
        DB.AddParam("@partID", sparePartsobj.partID.ToString)
        DB.ExecuteQuery("delete from spareparts where patID=?")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        MessageBox.Show("sparepart " & sparePartsobj.partID.ToString & " deleted successfully", "sparepart deleted")

    End Sub

    Private Sub addSupplierBtn_Click(sender As Object, e As EventArgs) Handles addSupplierBtn.Click
        Suppliers_Form.searchGrpBx.Enabled = False
        Suppliers_Form.SupplierID_TextBox.Enabled = False
        Suppliers_Form.Search_SupID_Button.Enabled = False
        Suppliers_Form.ShowDialog()
    End Sub
End Class