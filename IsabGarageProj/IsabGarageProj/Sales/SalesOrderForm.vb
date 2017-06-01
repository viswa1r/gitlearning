Public Class SalesOrderForm
    Private DB As New DBStore
    Dim Typefilter As String
    Dim searchID As Integer = 0
    Dim rowcount As Integer
    Dim searchitem As String
    Dim searchitem2 As String
    Dim createable As Boolean = False
    Dim Order_quantity As Integer = 0
    Dim subtotal As Decimal = 0
    Dim p_discount As Decimal = 0
    Const tax As Decimal = 0.06
    Dim totalTax As Decimal = 0
    Dim tot_discount_amount As Decimal = 0
    Dim selectedListSize As Integer = 0
    Public orderDetailsList As New List(Of OrderDetails)
    Dim orderDetailsObj As OrderDetails
    Dim customerName As String = ""
    Public serviceID As String = ""
    Dim warrantyExpDate As System.DateTime

    Public Class OrderDetails
        Public partID, partName, employeeID, orderID As String
        Public unitPrice As Decimal = 0
        Public discount As Decimal = 0
        Public Quantity As Integer = 0
        Public unitsInStock As Integer = 0
    End Class


    Private Sub addCustomerBtn_Click(sender As Object, e As EventArgs) Handles addCustomerBtn.Click
        CustomerForm.clearCustomer()
        CustomerForm.lastNameRadioBtn.Enabled = False
        CustomerForm.frstNameRadioBtn.Enabled = False
        CustomerForm.customerIDRadioBtn.Enabled = False
        CustomerForm.searchGrpBox.Enabled = False
        CustomerForm.CustomerIDTextBox.Enabled = False
        CustomerForm.SearchStrTextBox.Enabled = False
        CustomerForm.searchBtn.Enabled = False
        CustomerForm.ShowDialog()
    End Sub

    Private Sub columnsize()
        Dim column0 As DataGridViewColumn = CustomerDataGridView.Columns(0)
        column0.Width = 35
        column0.HeaderCell.Value = "ID"
        Dim column1 As DataGridViewColumn = CustomerDataGridView.Columns(1)
        column1.Width = 65
        column1.HeaderCell.Value = "F_Name"
        Dim column2 As DataGridViewColumn = CustomerDataGridView.Columns(2)
        column2.Width = 65
        column2.HeaderCell.Value = "L_Name"
    End Sub
    Sub customer_load()

        CustomerDataGridView.ReadOnly = True
        DB.ExecuteQuery("Select max(orderId) as maxOrderID from salesorder")
        If DB.RecordCount = 0 Then
            OrderIDTextBox.Text = 4000
        Else
            OrderIDTextBox.Text = DB.DBDataTable(0)!maxOrderID + 1
        End If

        DB.ExecuteQuery("Select * from customers order by customerID ASC")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        CustomerDataGridView.ForeColor = Color.Black
        CustomerDataGridView.DataSource = DB.DBDataTable
        columnsize()
        rowcount = CInt(DB.RecordCount)
        CustomerForm.CustomerIDTextBox.Text = (DB.RecordCount + 1).ToString

    End Sub

    Private Sub CustomerDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CustomerDataGridView.CellClick
        Dim i As Integer

        i = CustomerDataGridView.CurrentRow.Index
        custlDTextBox.Text = CustomerDataGridView.Item(0, i).Value
        customerName = CustomerDataGridView.Item(1, i).Value & " " & CustomerDataGridView.Item(2, i).Value

    End Sub


    Private Sub custIDRadioBtn_CheckedChanged(sender As Object, e As EventArgs) Handles custIDRadioBtn.CheckedChanged, lastNameRadioBtn.CheckedChanged, frstNameRadioBtn.CheckedChanged, phNoRadioBtn.CheckedChanged
        Typefilter = CType(sender, RadioButton).Name
        custSearchStrTextBox.Focus()

        Select Case Typefilter
            Case "phNoRadioBtn"
                custSearchStrTextBox.Clear()
                custlDTextBox.Clear()
                customer_load()
                searchID = 1
            Case "lastNameRadioBtn"
                custSearchStrTextBox.Clear()
                customer_load()
                custlDTextBox.Clear()
                searchID = 2
            Case "custIDRadioBtn"
                custSearchStrTextBox.Clear()
                custlDTextBox.Clear()
                customer_load()
                searchID = 4
            Case "frstNameRadioBtn"
                custSearchStrTextBox.Clear()
                custlDTextBox.Clear()
                customer_load()
                searchID = 3
        End Select
    End Sub

    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        If custSearchStrTextBox.Text <> "" Then
            Select Case searchID
                Case 0
                    MsgBox("You must select one radio button", "Validation Error")
                    Exit Sub
                Case 1
                    searchitem = "Phone"
                    searchitem2 = "@Phone"
                    custlDTextBox.Clear()
                    SearchCustomer(custSearchStrTextBox.Text)
                Case 2
                    searchitem = "Lastname"
                    searchitem2 = "@Lastname"
                    custlDTextBox.Clear()
                    SearchCustomer(custSearchStrTextBox.Text)
                Case 3
                    searchitem = "FirstName"
                    searchitem2 = "@FirstName"
                    custlDTextBox.Clear()
                    SearchCustomer(custSearchStrTextBox.Text)
                Case 4
                    searchitem = "CustomerID"
                    searchitem2 = "@CustomerID"
                    custlDTextBox.Clear()
                    SearchCustomer(custSearchStrTextBox.Text)

            End Select
        Else
            MessageBox.Show("You must enter search string by selecting radio button type", "Validation Error")
        End If

    End Sub

    Private Sub SearchCustomer(SearchName As String)
        DB.AddParam(searchitem2, SearchName & "%")
        DB.ExecuteQuery("select * from customers where " & searchitem & " like ?")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        CustomerDataGridView.DataSource = DB.DBDataTable

    End Sub

    Private Sub load_company_name()

        DB.ExecuteQuery("SELECT * FROM suppliers;")
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
        selectBtn.Enabled = True

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

        DB.ExecuteQuery("select sp.partId from spareparts sp
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
        Next
        If DB.RecordCount > 0 Then
            partNameComboBox.SelectedIndex = 0
        End If

    End Sub

    Private Sub modelComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles modelComboBox.SelectedIndexChanged
        cmpComboBox.Enabled = True
        modelComboBox.Enabled = True
        partNameComboBox.Enabled = True
        selectBtn.Enabled = True

        load_part_name()
    End Sub

    Private Sub load_part_price()

        DB.ExecuteQuery("select unitPrice from spareparts where partId='" & partNameComboBox.Text & "';")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        unitPriceTextBx.Text = DB.DBDataTable(0)!unitPrice
        unitPriceTextBx.Enabled = False

    End Sub

    Private Sub partNameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles partNameComboBox.SelectedIndexChanged
        partNameComboBox.Enabled = True
        unitPriceTextBx.Enabled = True
        selectBtn.Enabled = True

        load_part_price()
    End Sub

    Private Sub selectBtn_Click(sender As Object, e As EventArgs) Handles selectBtn.Click

        orderDetailsObj = New OrderDetails()

        DB.ExecuteQuery("select * from spareparts where partId='" & partNameComboBox.Text & "' ")
        If DB.DBDataTable(0)!unitsInStock <= 10 Then
            partNameComboBox.Focus()
            MessageBox.Show("The Amount of Product:'" & partNameComboBox.Text & "' has reached Safety Stock", "Product's stock is less than 10", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        If selectedListItems.Items.IndexOf(partNameComboBox.Text) <> -1 Then
            MessageBox.Show("You have already selected this part name in the List.. choose another part Name")
        Else
            orderDetailsObj.partID = partNameComboBox.Text
            orderDetailsObj.orderID = OrderIDTextBox.Text
            orderDetailsObj.Quantity = QtyNumericUpDown.Value
            orderDetailsObj.unitPrice = DB.DBDataTable(0)!unitPrice
            orderDetailsObj.discount = discountTextBox.Text
            orderDetailsObj.partName = DB.DBDataTable(0)!partName
            orderDetailsObj.unitsInStock = DB.DBDataTable(0)!unitsInStock
            orderDetailsList.Add(orderDetailsObj)
            selectedListItems.Items.Add(partNameComboBox.Text)
            Calculate_Price()
        End If

    End Sub

    Private Sub Calculate_Price()
        Dim p_price As Decimal = 0
        Dim p_count As Integer = 0
        Dim p_discount_amount As Decimal = 0

        For i = 0 To selectedListItems.Items.Count - 1
            For Each order As OrderDetails In orderDetailsList
                If order.partID = selectedListItems.Items(i).Trim Then
                    p_price = order.unitPrice
                    p_count = order.Quantity
                    p_discount = order.discount
                    p_price = p_price * p_count
                    p_discount_amount = p_price * p_discount
                    tot_discount_amount += p_discount_amount
                    subtotal += (p_price - (p_discount_amount))
                End If
            Next order
        Next

        subTotalTextBox.Text = Decimal.Round(subtotal, 2)
        taxTextBox.Text = Decimal.Round(subtotal * tax, 2)
        totDiscountTextBox.Text = Decimal.Round(tot_discount_amount, 2)
        totalTax = taxTextBox.Text
        finalPriceTextBox.Text = Decimal.Round(subtotal + totalTax, 2)
        subtotal = 0.00
        tot_discount_amount = 0.00
    End Sub

    Public Sub loadPaymentType()
        paymentComboBox.Items.Clear()
        paymentComboBox.Text = String.Empty

        paymentComboBox.Items.Add("Debit Card")
        paymentComboBox.Items.Add("Credit Card")
        paymentComboBox.Items.Add("Rewards Points")
        paymentComboBox.SelectedIndex = 0

    End Sub
    Private Sub SalesOrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_company_name()
        loadPaymentType()
        clear_data()
    End Sub

    Private Sub printBtn_Click(sender As Object, e As EventArgs) Handles printBtn.Click
        OrderPrintPreviewDialog.Document = OrderPrintDocument
        OrderPrintPreviewDialog.ShowDialog()
    End Sub

    Private Sub deselectBtn_Click(sender As Object, e As EventArgs) Handles deselectBtn.Click
        Dim deleted_item As String
        Dim selectedIndex As Integer
        If selectedListItems.SelectedIndex = -1 Then
            MsgBox(" Please select one item in selected list")
        Else
            deleted_item = selectedListItems.Items(selectedListItems.SelectedIndex).Trim
            'MsgBox("Delete Product with code:  " & selectedListItems.Items(selectedListItems.SelectedIndex))
            selectedIndex = selectedListItems.SelectedIndex
            selectedListItems.Items.RemoveAt(selectedListItems.SelectedIndex)
            orderDetailsList.RemoveAt(selectedIndex)
            'MsgBox(selectedListItems.SelectedIndex)

            Calculate_Price()
        End If

    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        clear_data()
    End Sub

    Public Sub clear_data()
        subtotal = 0
        finalPriceTextBox.Text = 0.00
        discountTextBox.Text = 0.00
        taxTextBox.Text = 0.06
        subTotalTextBox.Text = 0.00
        totDiscountTextBox.Text = 0.00

        finalPriceTextBox.Enabled = False
        taxTextBox.Enabled = False
        subTotalTextBox.Enabled = False
        totDiscountTextBox.Enabled = False
        printBtn.Enabled = False
        createBtn.Enabled = True

        selectedListItems.Items.Clear()
        custlDTextBox.Clear()
        custSearchStrTextBox.Clear()
        frstNameRadioBtn.Checked = True
        WarrantyNumericUpDown.SendToBack()
        custSearchStrTextBox.Focus()
        OrderIDTextBox.Enabled = False
        EmpIDTextBox.Enabled = False
        frstNameRadioBtn.Checked = True
        customer_load()
    End Sub

    Private Sub OrderPrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles OrderPrintDocument.PrintPage
        Dim ServicePrintFont As New Font("Arial", 15)
        Dim HeadingFont As New Font("Copper", 25, FontStyle.Bold)
        Dim SubheadingFont As New Font("Corbel", 23)
        Dim LineheightSingle As Single = ServicePrintFont.GetHeight + 10
        Dim title As New Font("Arial", 18, FontStyle.Bold)
        Dim x As Single = e.MarginBounds.Left
        Dim y As Single = e.MarginBounds.Top
        Dim b As Single = e.MarginBounds.Bottom
        Dim a As Single = e.MarginBounds.Right

        e.Graphics.DrawString("Order Receipt", HeadingFont, Brushes.Black, x, y)
        y += HeadingFont.GetHeight
        e.Graphics.DrawString("__________________________________", ServicePrintFont, Brushes.Black, x, y)
        y += HeadingFont.GetHeight
        e.Graphics.DrawString("Order ID: ", title, Brushes.Black, x, y)
        e.Graphics.DrawString(OrderIDTextBox.Text, ServicePrintFont, Brushes.Black, x + 200, y)
        y += HeadingFont.GetHeight
        e.Graphics.DrawString("Employee ID: ", title, Brushes.Black, x, y)
        e.Graphics.DrawString(EmpIDTextBox.Text, ServicePrintFont, Brushes.Black, x + 200, y)
        y += HeadingFont.GetHeight
        e.Graphics.DrawString("Customer : ", title, Brushes.Black, x, y)
        e.Graphics.DrawString(customerName, ServicePrintFont, Brushes.Black, x + 200, y)
        y += HeadingFont.GetHeight
        e.Graphics.DrawString("Warranty:", title, Brushes.Black, x + 300, y)
        e.Graphics.DrawString(WarrantyNumericUpDown.Value.ToString & " year(s)", ServicePrintFont, Brushes.Black, x + 450, y)

        y += HeadingFont.GetHeight

        e.Graphics.DrawString("---------------------------------------------------------------------------------", ServicePrintFont, Brushes.Black, x, y)
        y += HeadingFont.GetHeight

        e.Graphics.DrawString("Spare parts Purchased : ", title, Brushes.Black, x, y)
        y += HeadingFont.GetHeight + 10
        e.Graphics.DrawString("Part ID", title, Brushes.Black, x, y)
        e.Graphics.DrawString("Part Name", title, Brushes.Black, x + 200, y)
        e.Graphics.DrawString("Price", title, Brushes.Black, x + 450, y)

        y += HeadingFont.GetHeight + 10
        If selectedListItems.Items.Count <> 0 Then
            For Each order As OrderDetails In orderDetailsList
                e.Graphics.DrawString(order.partID, ServicePrintFont, Brushes.Black, x, y)
                e.Graphics.DrawString(order.partName, ServicePrintFont, Brushes.Black, x + 200, y)
                e.Graphics.DrawString(order.unitPrice, ServicePrintFont, Brushes.Black, x + 450, y)
                y += HeadingFont.GetHeight
            Next order
        Else
            y += HeadingFont.GetHeight
        End If

        e.Graphics.DrawString("---------------------------------------------------------------------------------", ServicePrintFont, Brushes.Black, x, y)
        y += HeadingFont.GetHeight
        e.Graphics.DrawString("Subtotal: ", title, Brushes.Black, x, y)
        e.Graphics.DrawString(subTotalTextBox.Text, ServicePrintFont, Brushes.Black, x + 200, y)
        y += HeadingFont.GetHeight

        e.Graphics.DrawString("Discount : ", title, Brushes.Black, x, y)
        Dim discount_message As String
        If tot_discount_amount = 0 Then
            discount_message = "No discount)"
        Else
            discount_message = "$" & totDiscountTextBox.Text & " off is applied)"
        End If

        e.Graphics.DrawString(totDiscountTextBox.Text & "    (" & discount_message, ServicePrintFont, Brushes.Black, x + 200, y)
        y += HeadingFont.GetHeight

        e.Graphics.DrawString("Tax : ", title, Brushes.Black, x, y)
        e.Graphics.DrawString(taxTextBox.Text, ServicePrintFont, Brushes.Black, x + 200, y)
        y += HeadingFont.GetHeight + 10
        e.Graphics.DrawString("Total : ", HeadingFont, Brushes.Black, x, y)
        e.Graphics.DrawString(finalPriceTextBox.Text, HeadingFont, Brushes.Black, x + 200, y)
        y += HeadingFont.GetHeight

        e.Graphics.DrawString("______________________________", ServicePrintFont, Brushes.Black, x, b - HeadingFont.GetHeight - 20)
        e.Graphics.DrawString("Customer's Signature x______________________" & "     " & Now.ToString, ServicePrintFont, Brushes.Black, x, b)

        clear_data()
    End Sub

    Public Sub GetwarrantyDate()
        Dim today As System.DateTime
        Dim duration As System.TimeSpan
        Dim warrantyDays As Integer

        today = System.DateTime.Now
        warrantyDays = WarrantyNumericUpDown.Value * 365
        duration = New System.TimeSpan(warrantyDays, 0, 0, 0)
        warrantyExpDate = today.Add(duration)
        'MessageBox.Show(warrantyExpDate)

    End Sub

    Public Sub insertData()
        Dim stockCount As Integer = 0

        DB.AddParam("@orderId", OrderIDTextBox.Text)
        DB.AddParam("@customerId", custlDTextBox.Text)
        DB.AddParam("@paymentType", paymentComboBox.Text)

        DB.ExecuteQuery("INSERT INTO salesorder (orderId, customerId,  orderDate, paymentType ) VALUES(?,?,sysdate(),?)")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            customer_load()
            Exit Sub
        End If

        GetwarrantyDate()
        For i = 0 To selectedListItems.Items.Count - 1
            For Each order As OrderDetails In orderDetailsList
                If order.partID = selectedListItems.Items(i).Trim Then
                    DB.AddParam("@orderId", OrderIDTextBox.Text)
                    DB.AddParam("@EmployeeID", EmpIDTextBox.Text)
                    DB.AddParam("@quantity", order.Quantity.ToString)
                    DB.AddParam("@unitPrice", order.unitPrice.ToString)
                    DB.AddParam("@discount", order.discount.ToString)
                    DB.AddParam("@partId", order.partID.ToString)
                    DB.AddParam("@warrantyExpDate", warrantyExpDate.ToString("yyyy-MM-dd hh:mm:ss"))
                    'MessageBox.Show(OrderIDTextBox.Text & "," & EmpIDTextBox.Text & "," & order.Quantity & "," & order.unitPrice & "," & order.discount & "," & order.partID & "," & warrantyExpDate.ToString("yyyy-mm-dd hh:mm:ss"))

                    DB.ExecuteQuery("INSERT INTO orderdetails (orderId, EmployeeId,  quantity, unitPrice,discount,partId,warrantyExpDate) VALUES(?,?,?,?,?,?,?)")
                    If DB.Exception <> String.Empty Then
                        MessageBox.Show(DB.Exception)
                        customer_load()
                        Exit Sub
                    End If

                    stockCount = orderDetailsObj.unitsInStock - order.Quantity
                    DB.AddParam("@unitsInStock", stockCount.ToString)
                    DB.AddParam("@partId", order.partID.ToString)

                    DB.ExecuteQuery("UPDATE spareparts set unitsInStock=? where partId=?")
                    If DB.Exception <> String.Empty Then
                        MessageBox.Show(DB.Exception)
                        Exit Sub
                    End If
                End If
            Next order
        Next

        MsgBox("New Order is created successfully!")

    End Sub
    Private Sub createBtn_Click(sender As Object, e As EventArgs) Handles createBtn.Click
        If serviceID = "" Then
            If (custlDTextBox.Text = "" Or selectedListItems.Items.Count = 0) Then
                MessageBox.Show("Enter mandatory(*) Fields", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                insertData()
                printBtn.Enabled = True
                createBtn.Enabled = False
            End If
        Else
            If (selectedListItems.Items.Count = 0) Then
                MessageBox.Show("Please Select spare parts in slected list", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                partsUsedInService()
                printBtn.Enabled = False

                ServiceForm.partsPrices = subTotalTextBox.Text
                MsgBox(ServiceForm.partsPrices)
                clear_data()
            End If
        End If

    End Sub

    Public Sub partsUsedInService()
        For i = 0 To selectedListItems.Items.Count - 1
            For Each order As OrderDetails In orderDetailsList
                If order.partID = selectedListItems.Items(i).Trim Then
                    DB.AddParam("@serviceID", serviceID)
                    DB.AddParam("@partID", orderDetailsObj.partID)
                    DB.AddParam("@Quantity", orderDetailsObj.Quantity)

                    DB.ExecuteQuery("INSERT INTO partsusedinservice (serviceId, partId,Quantity ) VALUES(?,?,?)")
                    If DB.Exception <> String.Empty Then
                        MessageBox.Show(DB.Exception)
                        customer_load()
                        Exit Sub
                    End If
                End If
            Next order
        Next

        MsgBox("parts updated in service order is created successfully!")
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        clear_data()
        Me.Close()
    End Sub

    Private Sub form_Closing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        clear_data()
    End Sub
End Class