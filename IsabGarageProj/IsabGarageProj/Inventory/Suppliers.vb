Public Class Suppliers_Form
    Private DB As New DBStore
    Dim searchColName As String
    Dim searchColParam As String
    Public SupplierObj As Supplier = New Supplier()
    Dim changeCode As Integer = 0
    Public Class Supplier
        Public SupplierID, CompanyName, EmailID, Phone, Street, City, State, Country, Zipcode As String
    End Class
    Private Sub Search_SupID_Button_Click(sender As Object, e As EventArgs) Handles Search_SupID_Button.Click
        If SupplierID_TextBox.Text <> "" Then
            SearchSupplier(SupplierID_TextBox.Text)
        Else
            MessageBox.Show("You must enter supplier ID", "Vlalidation Error")
        End If

    End Sub
    Private Sub SearchSupplier(SearchName As String)

        DB.AddParam("@supplierID", SearchName & "%")
        DB.ExecuteQuery("select * from suppliers where supplierID like ?")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        If DB.RecordCount > 0 Then
            Compname_TextBox.Text = DB.DBDataTable(0)!CompanyName
            Emailid_TextBox.Text = DB.DBDataTable(0)!Email
            Phone_TextBox.Text = DB.DBDataTable(0)!Phone
            Street_TextBox.Text = DB.DBDataTable(0)!address
            City_TextBox.Text = DB.DBDataTable(0)!City
            State_TextBox.Text = DB.DBDataTable(0)!State
            Country_TextBox.Text = DB.DBDataTable(0)!Country
            Zipcode_TextBox.Text = DB.DBDataTable(0)!Zipcode

            addValuesToSupplierObj()

        Else
            MessageBox.Show("No Supplier with this " & "SupplierID ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Exit Sub
        End If

    End Sub

    Private Sub addValuesToSupplierObj()

        SupplierObj.SupplierID = SupplierID_TextBox.Text
        SupplierObj.CompanyName = Compname_TextBox.Text
        SupplierObj.EmailID = Emailid_TextBox.Text
        SupplierObj.Phone = Phone_TextBox.Text
        SupplierObj.Street = Street_TextBox.Text
        SupplierObj.City = City_TextBox.Text
        SupplierObj.State = State_TextBox.Text
        SupplierObj.Country = Country_TextBox.Text
        SupplierObj.Zipcode = Zipcode_TextBox.Text

    End Sub
    Public Sub generateSupID()
        DB.ExecuteQuery("Select max(SupplierID) as maxSupID  from suppliers")
        gensupid_TextBox.Text = DB.DBDataTable(0)!maxSupID + 1

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
    End Sub
    Private Sub Save_Button_Click(sender As Object, e As EventArgs) Handles Save_Button.Click
        If Compname_TextBox.Text = "" Then
            ErrorProvider1.Clear()
            ErrorProvider1.SetError(Compname_TextBox, "Company name cannot be empty")
        ElseIf Emailid_TextBox.Text = "" Then
            ErrorProvider1.Clear()
            ErrorProvider1.SetError(Emailid_TextBox, "EmailID cannot be empty")
        ElseIf Phone_TextBox.Text = "" Then
            ErrorProvider1.Clear()
            ErrorProvider1.SetError(Phone_TextBox, "phone No cannot be empty")
        ElseIf zipcode_TextBox.Text = "" Then
            ErrorProvider1.Clear()
            ErrorProvider1.SetError(Zipcode_TextBox, "Zip Code cannot be empty")
        Else
            ErrorProvider1.Clear()
            InsertNewSupplier()

        End If
    End Sub


    Private Sub Clear_Button_Click(sender As Object, e As EventArgs) Handles Clear_Button.Click
        SupplierObj = New Supplier()
        SupplierID_TextBox.Clear()
        Compname_TextBox.Clear()
        Emailid_TextBox.Clear()
        Phone_TextBox.Clear()
        Street_TextBox.Clear()
        City_TextBox.Clear()
        State_TextBox.Clear()
        Country_TextBox.Clear()
        Zipcode_TextBox.Clear()
        ErrorProvider1.Clear()
    End Sub

    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub
    Public Sub InsertNewSupplier()
        Dim SupplierId As Integer
        SupplierId = SupplierID_TextBox.Text

        If IsDBNull(SupplierObj) Then
            DB.AddParam("@SupplierID", SupplierID_TextBox.Text)
            DB.AddParam("@CompanyName", Compname_TextBox.Text)
            DB.AddParam("@Email", Emailid_TextBox.Text)
            DB.AddParam("@Phone", Phone_TextBox.Text)
            DB.AddParam("@address", Street_TextBox.Text)
            DB.AddParam("@City", City_TextBox.Text)
            DB.AddParam("@State", State_TextBox.Text)
            DB.AddParam("@Country", Country_TextBox.Text)
            DB.AddParam("@Zipcode", Zipcode_TextBox.Text)

            DB.ExecuteQuery("INSERT INTO suppliers (SupplierID, CompanyName, Email, Phone, address, City,State,Country,zipcode) VALUES(?,?,?,?,?,?,?,?,?)")
            If DB.Exception <> String.Empty Then
                MessageBox.Show(DB.Exception)
                Exit Sub
            End If
            MessageBox.Show("A New Supplier is created successfully", "New Supplier Inserted")

        Else
            checkChangesMade()
            If changeCode = 1 Then

                DB.AddParam("@CompanyName", Compname_TextBox.Text)
                DB.AddParam("@Email", Emailid_TextBox.Text)
                DB.AddParam("@Phone", Phone_TextBox.Text)
                DB.AddParam("@address", Street_TextBox.Text)
                DB.AddParam("@City", City_TextBox.Text)
                DB.AddParam("@State", State_TextBox.Text)
                DB.AddParam("@Country", Country_TextBox.Text)
                DB.AddParam("@Zipcode", Zipcode_TextBox.Text)
                DB.AddParam("@SupplierID", SupplierID_TextBox.Text)

                DB.ExecuteQuery("Update Suppliers set  CompanyName=?, Email=?, Phone=?, address=?, City=?, State=?, Country=?, zipcode=? where SupplierID=?")
                If DB.Exception <> String.Empty Then
                    MessageBox.Show(DB.Exception)
                    Exit Sub
                End If
                MessageBox.Show("Supplier is Updated successfully", "Supplier Updated")
            Else
                MessageBox.Show("No changes Made", "Nothing Updated")
            End If

        End If
    End Sub
    Public Sub checkChangesMade()

        If SupplierObj.SupplierID <> SupplierID_TextBox.Text Then
            changeCode = 1
        End If
        If SupplierObj.CompanyName <> Compname_TextBox.Text Then
            changeCode = 1
        End If
        If SupplierObj.EmailID <> Emailid_TextBox.Text Then
            changeCode = 1
        End If
        If SupplierObj.Phone <> Phone_TextBox.Text Then
            changeCode = 1
        End If

        If SupplierObj.Street <> Street_TextBox.Text Then
            changeCode = 1
        End If
        If SupplierObj.City <> City_TextBox.Text Then
            changeCode = 1
        End If
        If SupplierObj.State <> State_TextBox.Text Then
            changeCode = 1
        End If
        If SupplierObj.Country <> Country_TextBox.Text Then
            changeCode = 1
        End If
        If SupplierObj.Zipcode <> Zipcode_TextBox.Text Then
            changeCode = 1
        End If
    End Sub

    Private Sub Suppliers_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        generateSupID()
    End Sub

End Class


