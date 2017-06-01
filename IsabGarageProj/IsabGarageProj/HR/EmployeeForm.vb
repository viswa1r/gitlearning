Public Class EmployeeForm

    Private DB As New DBStore
        Dim Typefilter As String
        Dim searchID As Integer = 0
        Dim searchColName As String
        Dim searchColParam As String
    Public employeeObj As Employee = New Employee()
    Dim changeCode As Integer = 0
    Dim supervisorID As String = ""
    Dim supervisorName As String = ""

    Public Class Employee
        Public EmployeeID, firstName, lastName, password, DOB, HiredDate, Worktype, supervisor, HourlyPay, addressline1, addressline2, phoneNum, emailId, address, city, state, Country, zipCode As String
    End Class
    Private Sub EmployeeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        generateEmpID()
        Me.searchGrpBox.Enabled = True
        EmployeeIDTextBox.Enabled = False
        loadsupervisor()
        ErrorProvider1.Clear()
    End Sub

    Public Sub loadsupervisor()
        DB.ExecuteQuery("Select EmployeeID from employees where WorkType = 'manager'")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        supervisorComboBox.Items.Clear()
        supervisorComboBox.Text = String.Empty
        'MsgBox(DB.RecordCount)

        For Each aDataRow As DataRow In DB.DBDataTable.Rows
            supervisorComboBox.Items.Add(aDataRow("EmployeeID"))
        Next


    End Sub

    Public Sub generateEmpID()
        DB.ExecuteQuery("Select max(employeeID) as maxempID  from employees")
        EmployeeIDTextBox.Text = DB.DBDataTable(0)!maxempID + 1

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click

        If FirstNameTextBox.Text = "" Then
            ErrorProvider1.Clear()
            ErrorProvider1.SetError(FirstNameTextBox, "first name cannot be empty")
        ElseIf lastNameTextBox.Text = "" Then
            ErrorProvider1.Clear()
            ErrorProvider1.SetError(lastNameTextBox, "last name cannot be empty")
        ElseIf pwdTextBox.Text = "" Then
            ErrorProvider1.Clear()
            ErrorProvider1.SetError(pwdTextBox, "Password No cannot be empty")
        ElseIf hiredDatePicker.Text = "" Then
            ErrorProvider1.Clear()
            ErrorProvider1.SetError(hiredDatePicker, "Hired Date cannot be empty")
        ElseIf hourlyPayTextBox.Text = "" Then
            ErrorProvider1.Clear()
            ErrorProvider1.SetError(hourlyPayTextBox, "Hourly Pay cannot be empty")
        Else
            ErrorProvider1.Clear()
            'hireDate = hiredDatePicker.Value
            'MsgBox("hitre Date " & hiredDatePicker.Value.ToString("yyyy-mm-dd"))
            InsertNewEmployee()
            clearEmployee()
        End If
    End Sub

    Public Sub checkChangesMade()

        If employeeObj.EmployeeID <> EmployeeIDTextBox.Text Then
            changeCode = 1
        End If
        If employeeObj.firstName <> FirstNameTextBox.Text Then
            changeCode = 1
        End If
        If employeeObj.lastName <> lastNameTextBox.Text Then
            changeCode = 1
        End If
        If employeeObj.password <> pwdTextBox.Text Then
            changeCode = 1
        End If
        If employeeObj.DOB <> DOBDatePicker.Value.ToString("yyyy-MM-dd") Then
            changeCode = 1
        End If
        If employeeObj.HiredDate <> hiredDatePicker.Value.ToString("yyyy-MM-dd") Then
            changeCode = 1
        End If
        If employeeObj.Worktype <> workTypeComboBx.Text Then
            changeCode = 1
        End If
        If employeeObj.supervisor <> supervisorComboBox.Text Then
            changeCode = 1
        End If
        If employeeObj.HourlyPay <> hourlyPayTextBox.Text Then
            changeCode = 1
        End If
        If employeeObj.addressline1 <> address1TextBox.Text Then
            changeCode = 1
        End If
        If employeeObj.addressline2 <> address2TextBox.Text Then
            changeCode = 1
        End If
        If employeeObj.phoneNum <> phoneNoTextBox.Text Then
            changeCode = 1
        End If
        If employeeObj.emailId <> emailTextBox.Text Then
            changeCode = 1
        End If
        If employeeObj.city <> cityTextBox.Text Then
            changeCode = 1
        End If
        If employeeObj.state <> stateTextBox.Text Then
            changeCode = 1
        End If
        If employeeObj.Country <> countryTextBox.Text Then
            changeCode = 1
        End If
        If employeeObj.zipCode <> zipcodeTextBox.Text Then
            changeCode = 1
        End If
    End Sub

    Public Sub getSupervisorID(supervisorName As String)
        DB.AddParam("@userName", supervisorName & "%")
        DB.ExecuteQuery("Select  EmployeeID from employees 
                where concat(firstname,' ',lastname) like ?")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        supervisorID = DB.DBDataTable(0)!EmployeeID
    End Sub

    Public Sub InsertNewEmployee()
        Dim employeeId As Integer
        Dim address As String
        Dim supervisorID As String
        employeeId = EmployeeIDTextBox.Text
        address = address1TextBox.Text & address2TextBox.Text

        'getSupervisorID(supervisorComboBox.Text)
        If IsDBNull(employeeObj) Then
            DB.AddParam("@EmployeeID", EmployeeIDTextBox.Text)
            DB.AddParam("@LastName", lastNameTextBox.Text)
            DB.AddParam("@FirstName", FirstNameTextBox.Text)
            DB.AddParam("@DOB", DOBDatePicker.Value.ToString("yyyy-MM-dd"))
            DB.AddParam("@HireDate", hiredDatePicker.Value.ToString("yyyy-MM-dd"))
            DB.AddParam("@WorkType", workTypeComboBx.Text)
            DB.AddParam("@Address", address)
            DB.AddParam("@City", cityTextBox.Text)
            DB.AddParam("@State", stateTextBox.Text)
            DB.AddParam("@Country", countryTextBox.Text)
            DB.AddParam("@zipcode", zipcodeTextBox.Text)
            DB.AddParam("@SuperVisor", supervisorComboBox.Text)
            DB.AddParam("@EmpPassword", pwdTextBox.Text)
            DB.AddParam("@HourlyPay", hourlyPayTextBox.Text)
            DB.AddParam("@Phone", phoneNoTextBox.Text)
            DB.AddParam("@EmailID", emailTextBox.Text)



            DB.ExecuteQuery("INSERT INTO employees (EmployeeID, LastName,  FirstName, DOB, HireDate, WorkType, Address, City, State, Country, zipcode, SuperVisor, EmpPassword, HourlyPay, Phone, EmailID) VALUES(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)")
            If DB.Exception <> String.Empty Then
                MessageBox.Show(DB.Exception)
                Exit Sub
            End If
            MessageBox.Show("A New Employee is created successfully", "New Employee Inserted")

        Else
            checkChangesMade()
            If changeCode = 1 Then

                DB.AddParam("@LastName", lastNameTextBox.Text)
                DB.AddParam("@FirstName", FirstNameTextBox.Text)
                DB.AddParam("@DOB", DOBDatePicker.Value.ToString("yyyy-MM-dd"))
                DB.AddParam("@HireDate", hiredDatePicker.Value.ToString("yyyy-MM-dd"))
                DB.AddParam("@WorkType", workTypeComboBx.Text)
                DB.AddParam("@Address", address1TextBox.Text)
                DB.AddParam("@City", cityTextBox.Text)
                DB.AddParam("@State", stateTextBox.Text)
                DB.AddParam("@Country", countryTextBox.Text)
                DB.AddParam("@zipcode", zipcodeTextBox.Text)
                DB.AddParam("@SuperVisor", supervisorComboBox.Text)
                DB.AddParam("@EmpPassword", pwdTextBox.Text)
                DB.AddParam("@HourlyPay", hourlyPayTextBox.Text)
                DB.AddParam("@Phone", phoneNoTextBox.Text)
                DB.AddParam("@EmailID", emailTextBox.Text)
                DB.AddParam("@EmployeeID", EmployeeIDTextBox.Text)

                'MsgBox(lastNameTextBox.Text & FirstNameTextBox.Text & DOBDatePicker.Value.ToString("yyyy-MM-dd") & hiredDatePicker.Value.ToString("yyyy-MM-dd") & workTypeComboBx.Text & address1TextBox.Text & cityTextBox.Text)

                DB.ExecuteQuery("Update employees set LastName=?,  FirstName=?, DOB=?, HireDate=?, WorkType=?, Address=?, City=?, State=?, Country=?, zipcode=?, SuperVisor=?, EmpPassword=?, HourlyPay=?, Phone=?, EmailID=? where EmployeeID=?")
                If DB.Exception <> String.Empty Then
                    MessageBox.Show(DB.Exception)
                    Exit Sub
                End If
                MessageBox.Show("Employee is Updated successfully", "Employee Updated")
            Else
                MessageBox.Show("No changes Made", "Nothing Updated")
            End If

        End If

    End Sub

    Public Sub clearEmployee()
        employeeObj = New Employee()
        EmployeeIDTextBox.Clear()
        SearchStrTextBox.Clear()
        FirstNameTextBox.Clear()
        lastNameTextBox.Clear()
        pwdTextBox.Clear()
        DOBDatePicker.Text = String.Empty
        hiredDatePicker.ResetText()
        workTypeComboBx.Items.Clear()
        supervisorComboBox.Items.Clear()
        ErrorProvider1.Clear()
        address1TextBox.Clear()
        address2TextBox.Clear()
        cityTextBox.Clear()
        stateTextBox.Clear()
        phoneNoTextBox.Clear()
        emailTextBox.Clear()
        countryTextBox.Clear()
        zipcodeTextBox.Clear()

    End Sub

    Private Sub employeeIDRadioBtn_CheckedChanged(sender As Object, e As EventArgs) Handles employeeIDRadioBtn.CheckedChanged, lastNameRadioBtn.CheckedChanged, frstNameRadioBtn.CheckedChanged
        Typefilter = CType(sender, RadioButton).Name
        SearchStrTextBox.Focus()

        Select Case Typefilter
            Case "lastNameRadioBtn"
                SearchStrTextBox.Clear()
                clearEmployee()
                generateEmpID()
                searchID = 1
            Case "employeeIDRadioBtn"
                SearchStrTextBox.Clear()
                clearEmployee()
                generateEmpID()
                searchID = 2
            Case "frstNameRadioBtn"
                SearchStrTextBox.Clear()
                clearEmployee()
                generateEmpID()
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
                    EmployeeIDTextBox.Clear()
                    SearchEmployee(SearchStrTextBox.Text)
                Case 2
                    searchColName = "EmployeeID"
                    searchColParam = "@EmployeeID"
                    EmployeeIDTextBox.Clear()
                    SearchEmployee(SearchStrTextBox.Text)
                Case 3
                    searchColName = "FirstName"
                    searchColParam = "@FirstName"
                    EmployeeIDTextBox.Clear()
                    SearchEmployee(SearchStrTextBox.Text)
            End Select
        Else
            MessageBox.Show("You must enter search string by selecting radio button type", "Validation Error")
        End If

    End Sub

    Public Sub getSupervisorName(supervisorID As String)

        DB.ExecuteQuery("Select concat(firstname,' ',lastname) as userName from employees where EmployeeID =" & supervisorID)
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        supervisorName = DB.DBDataTable(0)!userName

    End Sub


    Private Sub SearchEmployee(SearchName As String)

        DB.AddParam(searchColParam, SearchName)
        DB.ExecuteQuery("select * from employees where " & searchColName & " = ?")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        If DB.RecordCount > 0 Then

            EmployeeIDTextBox.Text = DB.DBDataTable(0)!EmployeeID
            lastNameTextBox.Text = DB.DBDataTable(0)!LastName
            FirstNameTextBox.Text = DB.DBDataTable(0)!FirstName
            pwdTextBox.Text = DB.DBDataTable(0)!EmpPassword
            DOBDatePicker.Value = DB.DBDataTable(0)!DOB
            hiredDatePicker.Value = DB.DBDataTable(0)!HireDate
            workTypeComboBx.Text = DB.DBDataTable(0)!WorkType

            If IsDBNull(DB.DBDataTable(0)!SuperVisor) Then
                supervisorComboBox.Text = ""
            Else
                'getSupervisorName(DB.DBDataTable(0)!SuperVisor)
                supervisorComboBox.Text = DB.DBDataTable(0)!SuperVisor
            End If
            hourlyPayTextBox.Text = DB.DBDataTable(0)!HourlyPay
            address1TextBox.Text = DB.DBDataTable(0)!Address
            cityTextBox.Text = DB.DBDataTable(0)!City
            stateTextBox.Text = DB.DBDataTable(0)!State
            phoneNoTextBox.Text = DB.DBDataTable(0)!Phone
            If IsDBNull(DB.DBDataTable(0)!EmailID) Then
                emailTextBox.Text = ""
            Else

                emailTextBox.Text = DB.DBDataTable(0)!EmailID
            End If
            countryTextBox.Text = DB.DBDataTable(0)!Country
            zipcodeTextBox.Text = DB.DBDataTable(0)!zipcode

            addValuesToemployeeobj()
        Else
            MessageBox.Show("No employee is available with" & EmployeeIDTextBox.Text & " employee Id", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

    End Sub

    Public Sub addValuesToemployeeobj()

        employeeObj.EmployeeID = EmployeeIDTextBox.Text
        employeeObj.firstName = FirstNameTextBox.Text
        employeeObj.lastName = lastNameTextBox.Text
        employeeObj.password = pwdTextBox.Text
        employeeObj.DOB = DOBDatePicker.Value
        employeeObj.HiredDate = hiredDatePicker.Value
        employeeObj.Worktype = workTypeComboBx.Text
        employeeObj.supervisor = supervisorComboBox.Text
        employeeObj.addressline1 = address1TextBox.Text
        employeeObj.addressline2 = address2TextBox.Text
        employeeObj.phoneNum = phoneNoTextBox.Text
        employeeObj.emailId = emailTextBox.Text
        employeeObj.Country = countryTextBox.Text
        employeeObj.city = cityTextBox.Text
        employeeObj.state = stateTextBox.Text
        employeeObj.zipCode = zipcodeTextBox.Text

    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        clearEmployee()
        lastNameRadioBtn.Checked = False
        frstNameRadioBtn.Checked = False
        employeeIDRadioBtn.Checked = False
        generateEmpID()
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        clearEmployee()
        Me.Close()
    End Sub
    Private Sub form_Closing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        clearEmployee()
    End Sub
End Class