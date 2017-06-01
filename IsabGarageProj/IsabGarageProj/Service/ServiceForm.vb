Public Class ServiceForm

    'DONE-Datetimepicker Not working, Not taking both date And time -- Issue resolved
    'DONE-Partsusedinservice button functionality -- done by Ramz
    'DONE-Data Not getting saved into both the tables i.e., employeeserve And service just by hitting save button
    'printed doc Not showing
    'exception when adding new vehicles for sales customer- solution: add vehicles button on customer form and take the vehicle details

    Private DB1 As DBStore = New DBStore
    Dim searchID = 1
    Dim searchitem As String
    Dim searchitem2 As String
    Dim Typefilter As String
    Dim rowcount As Integer
    Dim minutes As Int32
    Dim actualservcal As Decimal
    Dim customerName As String = ""
    Dim searchexistingservice As String
    Dim hourestimate As Integer
    Dim amount As Decimal
    Dim serviceamount As Decimal
    Dim serviceamount1 As Decimal
    Public partsPrices As Decimal
    Private Sub addvehiclesButton_Click(sender As Object, e As EventArgs) Handles addvehiclesButton.Click
        Vehicles.ShowDialog()
    End Sub
    Private Sub addcustButton_Click(sender As Object, e As EventArgs) Handles addcustButton.Click
        CustomerForm.ShowDialog()
    End Sub
    Private Sub customeridRB_CheckedChanged(sender As Object, e As EventArgs) Handles customeridRB.CheckedChanged, lastnameRB.CheckedChanged, firstnameRB.CheckedChanged, phoneRB.CheckedChanged
        Typefilter = CType(sender, RadioButton).Name
        custTB.Focus()

        Select Case Typefilter
            Case "phoneRB"
                custTB.Clear()
                customer_load()
                searchID = 1
            Case "lastnameRB"
                custTB.Clear()
                customer_load()
                searchID = 2
            Case "customeridRB"
                custTB.Clear()
                customer_load()
                searchID = 4
            Case "firstnameRB"
                custTB.Clear()
                customer_load()
                searchID = 3
        End Select
    End Sub
    Sub customer_load()

        DataGridView1.ReadOnly = True
        DB1.ExecuteQuery("Select customers.CustomerID as `ID`, Firstname, Lastname, vehicles.Model, vehicles.vehicleid from customers 
                         join vehicles on customers.CustomerID = vehicles.CustomerID
                         order by ID ASC")

        If DB1.Exception <> String.Empty Then
            MessageBox.Show(DB1.Exception)
            Exit Sub
        End If
        DataGridView1.ForeColor = Color.Black
        DataGridView1.DataSource = DB1.DBDataTable
        columnsize()

    End Sub

    Private Sub searchcustButton_Click(sender As Object, e As EventArgs) Handles searchcustButton.Click
        Select Case searchID
            Case 1
                searchitem = "Customers.Phone"
                searchitem2 = "@Phone"
                SearchCustomer(custTB.Text)
            Case 2
                searchitem = "Customers.LastName"
                searchitem2 = "@Lastname"
                SearchCustomer(custTB.Text)
            Case 3
                searchitem = "Customers.FirstName"
                searchitem2 = "@FirstName"
                SearchCustomer(custTB.Text)
            Case 4
                searchitem = "Customers.CustomerID"
                searchitem2 = "@CustomerID"
                SearchCustomer(custTB.Text)

        End Select
    End Sub

    Private Sub SearchCustomer(SearchName As String)
        DB1.AddParam(searchitem2, SearchName & "%")
        DB1.ExecuteQuery("select FirstName, LastName, Model, vehicleid, customers.customerid from customers
                        left join vehicles on customers.customerid = vehicles.customerid where " & searchitem & " like ?")

        If DB1.Exception <> String.Empty Then
            MessageBox.Show(DB1.Exception)
            Exit Sub
        End If
        DataGridView1.DataSource = DB1.DBDataTable

    End Sub

    Private Sub columnsize()
        Dim column0 As DataGridViewColumn = DataGridView1.Columns(0)
        column0.Width = 35
        column0.HeaderCell.Value = "ID"
        Dim column1 As DataGridViewColumn = DataGridView1.Columns(1)
        column1.Width = 65
        column1.HeaderCell.Value = "F_Name"
        Dim column2 As DataGridViewColumn = DataGridView1.Columns(2)
        column2.Width = 65
        column2.HeaderCell.Value = "L_Name"
        Dim column3 As DataGridViewColumn = DataGridView1.Columns(3)
        column3.Width = 65
        column3.HeaderCell.Value = "Vehicle"
    End Sub
    Private Sub existingserviceRB_CheckedChanged(sender As Object, e As EventArgs) Handles existingserviceRB.CheckedChanged
        serviceidTB.Enabled = True
    End Sub
    Private Sub newserviceRB_CheckedChanged(sender As Object, e As EventArgs) Handles newserviceRB.CheckedChanged
        generateserviceID()
        serviceidTB.Enabled = False
        searchservButton.Enabled = False
    End Sub
    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        'DateTimePicker1.Format = DateTimePickerFormat.Custom
        'DateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss"

        'DateTimePicker2.Format = DateTimePickerFormat.Custom
        'DateTimePicker2.CustomFormat = "yyyy-MM-dd HH:mm:ss"

        If DateTimePicker1.Text = "" Then
            ErrorProvider1.Clear()
            ErrorProvider1.SetError(DateTimePicker1, "Enter the received date")
        ElseIf servstatusComboBox.Text = "" Then
            ErrorProvider1.Clear()
            ErrorProvider1.SetError(servstatusComboBox, "Service Status of Vehicle")
        ElseIf descrRichTextBox.Text = "" Then
            ErrorProvider1.Clear()
            ErrorProvider1.SetError(descrRichTextBox, "Enter the customer number")
        ElseIf serviceidTB.Text = "" Then
            ErrorProvider1.Clear()
            ErrorProvider1.SetError(serviceidTB, "Enter the Service ID")
        ElseIf paymentstatusComboBox.Text = "" Then
            ErrorProvider1.Clear()
            ErrorProvider1.SetError(paymentstatusComboBox, "Enter the payment status")
        ElseIf Not IsNumeric(servesttimeTB.Text) Then
            ErrorProvider1.Clear()
            ErrorProvider1.SetError(servesttimeTB, "Enter number of hours")
        Else
            ErrorProvider1.Clear()
        End If

        If newserviceRB.Checked = True Then
            InsertNewService()
        ElseIf existingserviceRB.Checked = True Then
            InsertExistingService()
        Else MsgBox("Select a service")
        End If
    End Sub

    Private Sub InsertNewService()

        hourestimate = Convert.ToDecimal(servesttimeTB.Text)
        actualservcal = hourestimate * hourlycostTB.Text
        amount = Decimal.Round(actualservcal, 2)
        serviceamount = 0.15 * amount
        serviceamount1 = Decimal.Round(serviceamount, 2)
        servtaxTB.Text = serviceamount1
        totalpaymentTB.Text = amount + serviceamount1

        DB1.AddParam("@ServiceID", serviceidTB.Text)
        DB1.AddParam("@ReceivedDate", DateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss"))
        DB1.AddParam("@DeliveryDate", DateTimePicker2.Value.ToString("yyyy-MM-dd hh:mm:ss"))
        DB1.AddParam("@ServiceType", servtypeTB.Text)
        DB1.AddParam("@Description", descrRichTextBox.Text)
        DB1.AddParam("@ServiceStatus", servstatusComboBox.Text)
        DB1.AddParam("@ServiceTax", servtaxTB.Text)
        DB1.AddParam("@HourlyCost", hourlycostTB.Text)
        DB1.AddParam("@PaymentStatus", paymentstatusComboBox.Text)
        DB1.AddParam("@vehicleID", servvehicleidTB.Text)
        DB1.AddParam("@totalPayment", totalpaymentTB.Text)



        DB1.ExecuteQuery("insert into service(ServiceID, ReceivedDate, DeliveryDate, ServiceType, Description, ServiceStatus, ServiceTax, HourlyCost, PaymentStatus, vehicleID, totalPayment) VALUES(?,?,?,?,?,?,?,?,?,?,?)")
        If DB1.Exception <> String.Empty Then
            MessageBox.Show(DB1.Exception)
            Exit Sub
        End If
        'MsgBox("serviceid, ReceivedDate, DeliveryDate, ServiceType, Description, ServiceStatus, ServiceTax, HourlyCost, PaymentStatus, vehicleID, totalPayment : " & serviceidTB.Text & DateTimePicker1.Text & DateTimePicker2.Text & servtaxTB.Text & descrRichTextBox.Text & servstatusComboBox.Text & servtaxTB.Text & hourlycostTB.Text & paymentstatusComboBox.Text & servvehicleidTB.Text & totalpaymentTB.Text)

        MessageBox.Show("New service data entered successfully", "New service data")
    End Sub
    Private Sub InsertExistingService()

        hourestimate = Convert.ToDecimal(servesttimeTB.Text)
        actualservcal = (hourestimate * hourlycostTB.Text)
        MsgBox(actualservcal)
        amount = Decimal.Round(actualservcal, 2) + Decimal.Round(partsPrices, 2)
        MsgBox(amount)
        serviceamount = 0.15 * amount
        serviceamount1 = Decimal.Round(serviceamount, 2)
        servtaxTB.Text = serviceamount1
        totalpaymentTB.Text = amount + serviceamount1
        DB1.AddParam("@ReceivedDate", DateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss"))
        DB1.AddParam("@DeliveryDate", DateTimePicker2.Value.ToString("yyyy-MM-dd hh:mm:ss"))
        DB1.AddParam("@Description", descrRichTextBox.Text)
        DB1.AddParam("@ServiceStatus", servstatusComboBox.Text)
        DB1.AddParam("@ServiceTax", servtaxTB.Text)
        DB1.AddParam("@PaymentStatus", paymentstatusComboBox.Text)
        DB1.AddParam("@totalPayment", totalpaymentTB.Text)
        DB1.AddParam("@ServiceID", serviceidTB.Text)

        DB1.ExecuteQuery("Update service set ReceivedDate=?, DeliveryDate =?, Description =?, ServiceStatus =?, ServiceTax =?, PaymentStatus =?, totalPayment =? where ServiceID=?")
        If DB1.Exception <> String.Empty Then
            MessageBox.Show(DB1.Exception)
            Exit Sub
        End If
        MessageBox.Show("Service Data Updated", "Existing service data")
    End Sub
    Private Sub generateserviceID()
        DB1.ExecuteQuery("Select max(serviceID) as maxServiceID  from service")
        serviceidTB.Text = DB1.DBDataTable(0)!maxServiceID + 1

        If DB1.Exception <> String.Empty Then
            MessageBox.Show(DB1.Exception)
            Exit Sub
        End If
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        servvehiclenameTB.Clear()
        servtypeTB.Clear()
        descrRichTextBox.Clear()
        totalpaymentTB.Clear()
        servtaxTB.Clear()
        servstatusComboBox.Text = ""
        paymentstatusComboBox.Text = ""
    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer

        i = DataGridView1.CurrentRow.Index
        customerName = DataGridView1.Item(0, i).Value & " " & DataGridView1.Item(1, i).Value
        servvehiclenameTB.Text = DataGridView1.Item(2, i).Value
        servvehicleidTB.Text = DataGridView1.Item(3, i).Value
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim ServicePrintFont As New Font("Arial", 15)
        Dim HeadingFont As New Font("Copper", 25, FontStyle.Bold)
        Dim SubheadingFont As New Font("Corbel", 23)
        Dim LineheightSingle As Single = ServicePrintFont.GetHeight + 10
        Dim title As New Font("Arial", 18, FontStyle.Bold)
        Dim x As Single = e.MarginBounds.Left
        Dim y As Single = e.MarginBounds.Top
        Dim b As Single = e.MarginBounds.Bottom
        Dim a As Single = e.MarginBounds.Right

        e.Graphics.DrawString("Service Receipt", HeadingFont, Brushes.Black, x, y)
        y += HeadingFont.GetHeight
        e.Graphics.DrawString("__________________________________", ServicePrintFont, Brushes.Black, x, y)
        y += HeadingFont.GetHeight
        e.Graphics.DrawString("Service ID: ", title, Brushes.Black, x, y)
        e.Graphics.DrawString(serviceidTB.Text, ServicePrintFont, Brushes.Black, x + 200, y)
        y += HeadingFont.GetHeight
        e.Graphics.DrawString("Vehicle Name: ", title, Brushes.Black, x, y)
        e.Graphics.DrawString(servvehiclenameTB.Text, ServicePrintFont, Brushes.Black, x + 200, y)
        y += HeadingFont.GetHeight
        e.Graphics.DrawString("Customer Name: ", title, Brushes.Black, x, y)
        e.Graphics.DrawString(customerName, ServicePrintFont, Brushes.Black, x + 200, y)
        y += HeadingFont.GetHeight
        e.Graphics.DrawString("Service Description:", title, Brushes.Black, x + 300, y)
        e.Graphics.DrawString(descrRichTextBox.Text, ServicePrintFont, Brushes.Black, x + 450, y)

        y += HeadingFont.GetHeight

        e.Graphics.DrawString("---------------------------------------------------------------------------------", ServicePrintFont, Brushes.Black, x, y)
        y += HeadingFont.GetHeight

        e.Graphics.DrawString("Service Payment", HeadingFont, Brushes.Black, x, y)
        y += HeadingFont.GetHeight
        e.Graphics.DrawString("__________________________________", ServicePrintFont, Brushes.Black, x, y)
        y += HeadingFont.GetHeight
        e.Graphics.DrawString("Hourly Cost: ", title, Brushes.Black, x, y)
        e.Graphics.DrawString(hourlycostTB.Text, ServicePrintFont, Brushes.Black, x + 200, y)
        y += HeadingFont.GetHeight
        e.Graphics.DrawString("Service Tax: ", title, Brushes.Black, x, y)
        e.Graphics.DrawString(servtaxTB.Text, ServicePrintFont, Brushes.Black, x + 200, y)
        y += HeadingFont.GetHeight
        e.Graphics.DrawString("Total Payment: ", title, Brushes.Black, x, y)
        e.Graphics.DrawString(totalpaymentTB.Text, ServicePrintFont, Brushes.Black, x + 200, y)
        y += HeadingFont.GetHeight
        e.Graphics.DrawString("Payment Status:", title, Brushes.Black, x + 300, y)
        e.Graphics.DrawString(paymentstatusComboBox.Text, ServicePrintFont, Brushes.Black, x + 450, y)
        e.Graphics.DrawString("---------------------------------------------------------------------------------", ServicePrintFont, Brushes.Black, x, y)
        y += HeadingFont.GetHeight

        e.Graphics.DrawString("______________________________", ServicePrintFont, Brushes.Black, x, b - HeadingFont.GetHeight - 20)
        e.Graphics.DrawString("Customer's Signature x______________________" & "     " & Now.ToString, ServicePrintFont, Brushes.Black, x, b)

    End Sub

    Private Sub invoiceButton_Click(sender As Object, e As EventArgs) Handles invoiceButton.Click
        PrintDialog1.Document = PrintDocument1
        PrintDialog1.ShowDialog()
    End Sub

    Private Sub searchservButton_Click(sender As Object, e As EventArgs) Handles searchservButton.Click
        searchexistingservice = "service.ServiceID"
        DB1.ExecuteQuery("select service.vehicleID, ReceivedDate, DeliveryDate, ServiceType, ServiceStatus, Description, totalPayment, ServiceTax, PaymentStatus, vehicles.model from service
                        join vehicles on service.vehicleID = vehicles.vehicleID where " & searchexistingservice & " like '%" & serviceidTB.Text & "%'")

        If DB1.Exception <> String.Empty Then
            MessageBox.Show(DB1.Exception)
            Exit Sub
        End If

        servvehicleidTB.Text = DB1.DBDataTable(0)!vehicleID
        DateTimePicker1.Text = DB1.DBDataTable(0)!ReceivedDate
        DateTimePicker2.Text = DB1.DBDataTable(0)!DeliveryDate
        servtypeTB.Text = DB1.DBDataTable(0)!ServiceType
        servstatusComboBox.Text = DB1.DBDataTable(0)!ServiceStatus
        descrRichTextBox.Text = DB1.DBDataTable(0)!Description
        totalpaymentTB.Text = DB1.DBDataTable(0)!totalPayment
        servtaxTB.Text = DB1.DBDataTable(0)!ServiceTax
        paymentstatusComboBox.Text = DB1.DBDataTable(0)!PaymentStatus
        servvehiclenameTB.Text = DB1.DBDataTable(0)!model
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SalesOrderForm.serviceID = serviceidTB.Text
        SalesOrderForm.basicDetailsGrpBox.Enabled = False
        SalesOrderForm.ShowDialog()

    End Sub

    Private Sub ServiceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        servemployeeidTB.Enabled = False
    End Sub
End Class