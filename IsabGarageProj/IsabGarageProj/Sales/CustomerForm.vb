Public Class CustomerForm

    Private DB As New DBStore
    Dim Typefilter As String
    Dim searchID As Integer = 0
    Dim searchColName As String
    Dim searchColParam As String
    Public customerObj As Customer = New Customer()
    Dim changeCode As Integer = 0

    Public Class Customer
        Public customerID, firstName, lastName, phoneNum, emailId, address, city, state, zipCode As String
    End Class
    Private Sub CustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        generateCustID()
        Me.searchGrpBox.Enabled = True
        CustomerIDTextBox.Enabled = False
        ErrorProvider.Clear()
    End Sub

    Public Sub generateCustID()
        DB.ExecuteQuery("Select max(customerID) as maxCustID  from customers")
        CustomerIDTextBox.Text = DB.DBDataTable(0)!maxCustID + 1

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        If FirstNameTextBox.Text = "" Then
            ErrorProvider.Clear()
            ErrorProvider.SetError(FirstNameTextBox, "first name cannot be empty")
        ElseIf lastNameTextBox.Text = "" Then
            ErrorProvider.Clear()
            ErrorProvider.SetError(lastNameTextBox, "last name cannot be empty")
        ElseIf phoneNoTextBox.Text = "" Then
            ErrorProvider.Clear()
            ErrorProvider.SetError(phoneNoTextBox, "phone No cannot be empty")
        ElseIf zipcodeTextBox.Text = "" Then
            ErrorProvider.Clear()
            ErrorProvider.SetError(zipcodeTextBox, "Zip Code cannot be empty")
        Else
            ErrorProvider.Clear()
            InsertNewCustomer()
            'clearCustomer()
        End If
    End Sub

    Public Sub checkChangesMade()

        If customerObj.customerID <> CustomerIDTextBox.Text Then
            changeCode = 1
        End If
        If customerObj.firstName <> FirstNameTextBox.Text Then
            changeCode = 1
        End If
        If customerObj.lastName <> lastNameTextBox.Text Then
            changeCode = 1
        End If
        If customerObj.phoneNum <> phoneNoTextBox.Text Then
            changeCode = 1
        End If
        If customerObj.emailId <> emailTextBox.Text Then
            changeCode = 1
        End If
        If customerObj.address <> addressTextBox.Text Then
            changeCode = 1
        End If
        If customerObj.city <> cityTextBox.Text Then
            changeCode = 1
        End If
        If customerObj.state <> stateTextBox.Text Then
            changeCode = 1
        End If
        If customerObj.zipCode <> zipcodeTextBox.Text Then
            changeCode = 1
        End If
    End Sub

    Public Sub InsertNewCustomer()
        Dim customerId As Integer
        customerId = CustomerIDTextBox.Text

        If IsDBNull(customerObj) Then
            DB.AddParam("@CustomerID", CustomerIDTextBox.Text)
            DB.AddParam("@FirstName", FirstNameTextBox.Text)
            DB.AddParam("@LastName", lastNameTextBox.Text)
            DB.AddParam("@Phone", phoneNoTextBox.Text)
            DB.AddParam("@EmailID", emailTextBox.Text)
            DB.AddParam("@Address", addressTextBox.Text)
            DB.AddParam("@City", cityTextBox.Text)
            DB.AddParam("@State", stateTextBox.Text)
            DB.AddParam("@zipcode", zipcodeTextBox.Text)

            DB.ExecuteQuery("INSERT INTO customers (CustomerId,  FirstName, LastName, Phone,EmailID,Address,City,State,zipcode) VALUES(?,?,?,?,?,?,?,?,?)")
            If DB.Exception <> String.Empty Then
                MessageBox.Show(DB.Exception)
                Exit Sub
            End If
            MessageBox.Show("A New Customer is created successfully", "New Customer Inserted")

        Else
            checkChangesMade()
            If changeCode = 1 Then
                DB.AddParam("@FirstName", FirstNameTextBox.Text)
                DB.AddParam("@LastName", lastNameTextBox.Text)
                DB.AddParam("@Phone", phoneNoTextBox.Text)
                DB.AddParam("@EmailID", emailTextBox.Text)
                DB.AddParam("@Address", addressTextBox.Text)
                DB.AddParam("@City", cityTextBox.Text)
                DB.AddParam("@State", stateTextBox.Text)
                DB.AddParam("@zipcode", zipcodeTextBox.Text)
                DB.AddParam("@CustomerID", customerId)

                DB.ExecuteQuery("Update Customers set FirstName=?, LastName=?, Phone=?, EmailID=?, Address=?, City=?, State=?, zipcode=? where CustomerID=?")
                If DB.Exception <> String.Empty Then
                    MessageBox.Show(DB.Exception)
                    Exit Sub
                End If
                MessageBox.Show("Customer is Updated successfully", "Customer Updated")
            Else
                MessageBox.Show("No changes Made", "Nothing Updated")
            End If

        End If

    End Sub

    Public Sub clearCustomer()
        customerObj = New Customer()
        CustomerIDTextBox.Clear()
        SearchStrTextBox.Clear()
        FirstNameTextBox.Clear()
        lastNameTextBox.Clear()
        phoneNoTextBox.Clear()
        emailTextBox.Clear()
        addressTextBox.Clear()
        cityTextBox.Clear()
        stateTextBox.Clear()
        zipcodeTextBox.Clear()
        ErrorProvider.Clear()
    End Sub

    Private Sub customerIDRadioBtn_CheckedChanged(sender As Object, e As EventArgs) Handles customerIDRadioBtn.CheckedChanged, lastNameRadioBtn.CheckedChanged, frstNameRadioBtn.CheckedChanged
        Typefilter = CType(sender, RadioButton).Name
        SearchStrTextBox.Focus()

        Select Case Typefilter
            Case "lastNameRadioBtn"
                SearchStrTextBox.Clear()
                clearCustomer()
                generateCustID()
                searchID = 1
            Case "customerIDRadioBtn"
                SearchStrTextBox.Clear()
                clearCustomer()
                generateCustID()
                searchID = 2
            Case "frstNameRadioBtn"
                SearchStrTextBox.Clear()
                clearCustomer()
                generateCustID()
                searchID = 3
        End Select
    End Sub

    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        If SearchStrTextBox.Text <> "" Then
            Select Case searchID
                Case 0
                    MessageBox.Show("You must select one radio button", "Validation Error")
                    Exit Sub
                Case 1
                    searchColName = "Lastname"
                    searchColParam = "@Lastname"
                    CustomerIDTextBox.Clear()
                    SearchCustomer(SearchStrTextBox.Text)
                Case 2
                    searchColName = "CustomerID"
                    searchColParam = "@CustomerID"
                    CustomerIDTextBox.Clear()
                    SearchCustomer(SearchStrTextBox.Text)
                Case 3
                    searchColName = "FirstName"
                    searchColParam = "@FirstName"
                    CustomerIDTextBox.Clear()
                    SearchCustomer(SearchStrTextBox.Text)
            End Select
        Else
            MessageBox.Show("You must enter search string by selecting radio button type", "Validation Error")
        End If

    End Sub

    Private Sub SearchCustomer(SearchName As String)

        DB.AddParam(searchColParam, SearchName & "%")
        DB.ExecuteQuery("select * from customers where " & searchColName & " like ?")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        If DB.RecordCount > 0 Then
            CustomerIDTextBox.Text = DB.DBDataTable(0)!CustomerId
            FirstNameTextBox.Text = DB.DBDataTable(0)!FirstName
            lastNameTextBox.Text = DB.DBDataTable(0)!LastName
            phoneNoTextBox.Text = DB.DBDataTable(0)!Phone
            emailTextBox.Text = DB.DBDataTable(0)!EmailID
            addressTextBox.Text = DB.DBDataTable(0)!Address
            cityTextBox.Text = DB.DBDataTable(0)!City
            stateTextBox.Text = DB.DBDataTable(0)!State
            zipcodeTextBox.Text = DB.DBDataTable(0)!zipcode

            addValuesTocustObj()

        Else
            MessageBox.Show("No customer is available with" & CustomerIDTextBox.Text & " customer Id", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

    End Sub

    Public Sub addValuesTocustObj()

        customerObj.customerID = CustomerIDTextBox.Text
        customerObj.firstName = FirstNameTextBox.Text
        customerObj.lastName = lastNameTextBox.Text
        customerObj.phoneNum = phoneNoTextBox.Text
        customerObj.emailId = emailTextBox.Text
        customerObj.address = addressTextBox.Text
        customerObj.city = cityTextBox.Text
        customerObj.state = stateTextBox.Text
        customerObj.zipCode = zipcodeTextBox.Text

    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        clearCustomer()
        lastNameRadioBtn.Checked = False
        frstNameRadioBtn.Checked = False
        customerIDRadioBtn.Checked = False
        generateCustID()
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        clearCustomer()
        Me.Close()
    End Sub

    Private Sub form_Closing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        clearCustomer()
    End Sub

End Class