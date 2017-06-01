Public Class MainManagerForm
    Private DB As New DBStore
    Public employeeID As String = ""
    Public timesheetID As String = ""
    Private Sub MainManagerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub addNewEmployeeBtn_Click(sender As Object, e As EventArgs) Handles addNewEmployeeBtn.Click
        EmployeeForm.ShowDialog()
    End Sub

    Private Sub employeeServiceBtn_Click(sender As Object, e As EventArgs) Handles employeeServiceBtn.Click
        EmployeeSevice.ShowDialog()
    End Sub

    Private Sub empScheduleBtn_Click(sender As Object, e As EventArgs) Handles empScheduleBtn.Click
        Scheduling.ShowDialog()
    End Sub

    Private Sub employeePayrollBtn_Click(sender As Object, e As EventArgs) Handles employeePayrollBtn.Click
        Payroll_Processing.ShowDialog()
    End Sub

    Private Sub addSupplierBtn_Click(sender As Object, e As EventArgs) Handles addSupplierBtn.Click
        Suppliers_Form.ShowDialog()
    End Sub

    Private Sub addPurchaseOrderBtn_Click(sender As Object, e As EventArgs) Handles addPurchaseOrderBtn.Click
        Purchase_Order_Form.ShowDialog()
    End Sub

    Private Sub purchaseHistoryBtn_Click(sender As Object, e As EventArgs) Handles purchaseHistoryBtn.Click
        Purchase_history_Form.ShowDialog()
    End Sub
End Class