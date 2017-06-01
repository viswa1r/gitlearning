Public Class MainSalesForm
    Private DB As New DBStore
    Public employeeID As String = ""
    Public timesheetID As String = ""
    Private Sub newSalesOrderBtn_Click(sender As Object, e As EventArgs) Handles newSalesOrderBtn.Click
        SalesOrderForm.ShowDialog()
    End Sub

    Private Sub logoutLbl_Click(sender As Object, e As EventArgs) Handles logoutLbl.Click

        DB.AddParam("@timesheetID", timesheetID)
        DB.AddParam("@EmployeeID", employeeID)
        DB.ExecuteQuery("update timesheet set logoutTime=sysdate() where timesheetID=? and EmployeeID=? ; ")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        MessageBox.Show("Sucessfully loggedout ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LoginPage.ShowDialog()
    End Sub

    Private Sub addCustomerBtn_Click(sender As Object, e As EventArgs) Handles addCustomerBtn.Click
        CustomerForm.clearCustomer()
        CustomerForm.lastNameRadioBtn.Enabled = True
        CustomerForm.frstNameRadioBtn.Enabled = True
        CustomerForm.customerIDRadioBtn.Enabled = True
        CustomerForm.searchGrpBox.Enabled = True
        CustomerForm.CustomerIDTextBox.Enabled = True
        CustomerForm.SearchStrTextBox.Enabled = True
        CustomerForm.searchBtn.Enabled = True
        CustomerForm.generateCustID()
        CustomerForm.ShowDialog()
    End Sub

    Private Sub sparePartsDetailsBtn_Click(sender As Object, e As EventArgs) Handles sparePartsDetailsBtn.Click
        SparePartsForm.clearData()
        SparePartsForm.ShowDialog()
    End Sub

    Private Sub newUpdateServiceBtn_Click(sender As Object, e As EventArgs) Handles newUpdateServiceBtn.Click
        ServiceForm.ShowDialog()
    End Sub

    Private Sub addVehiclesBtn_Click(sender As Object, e As EventArgs) Handles addVehiclesBtn.Click
        Vehicles.ShowDialog()
    End Sub
End Class