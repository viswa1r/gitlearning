Public Class Payroll_Processing
    Private DB As New DBStore
    Dim employeeID As String = ""
    Dim startDate As String = ""
    Dim endDate As String = ""

    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        employeeID = empIdTextBox.Text
        startDate = startDateTimePicker.Value.ToString("yyyy-MM-dd")
        endDate = endDateTimePicker.Value.ToString("yyyy-MM-dd")
        ' MsgBox(employeeID & startDate & endDate)

        timesheetDataGridView.ReadOnly = True

        If employeeID <> "" And startDate <> "" And endDate <> "" Then
            DB.AddParam("@employeeID", employeeID)
            DB.AddParam("@startDate", startDate)
            DB.AddParam("@endDate", endDate)
            DB.ExecuteQuery("select EmployeeID, loginTime,logoutTime,round(TIMESTAMPDIFF(SECOND,loginTime,logoutTime)/3600,0) as workedHours 
                            from timesheet where EmployeeID=? and loginTime >=? and loginTime <=? order by loginTime desc")

            If DB.Exception <> String.Empty Then
                MessageBox.Show(DB.Exception)
                Exit Sub
            End If
            timesheetDataGridView.ForeColor = Color.Black
            timesheetDataGridView.DataSource = DB.DBDataTable
            timesheetDataGridView.Enabled = True
        Else
            MessageBox.Show("Please enter employeeID,startDate and Enddate", "Message ERROR")
        End If

    End Sub

    Private Sub calculateBtn_Click(sender As Object, e As EventArgs) Handles calculateBtn.Click
        employeeID = empIdTextBox.Text
        startDate = startDateTimePicker.Value.ToString("yyyy-MM-dd")
        endDate = endDateTimePicker.Value.ToString("yyyy-MM-dd")
        ' MsgBox(employeeID & startDate & endDate)

        timesheetDataGridView.ReadOnly = True
        If employeeID <> "" And startDate <> "" And endDate <> "" Then
            DB.AddParam("@employeeID", employeeID)
            DB.AddParam("@startDate", startDate)
            DB.AddParam("@endDate", endDate)
            DB.ExecuteQuery("select sum(round(TIMESTAMPDIFF(SECOND,loginTime,logoutTime)/3600,0))  as totalHours, 
                            e.HourlyPay, (sum(round(TIMESTAMPDIFF(SECOND,loginTime,logoutTime)/3600,0)) * e.HourlyPay) as netSalary
                            from timesheet t join employees e on t.EmployeeID=e.EmployeeID
                            where e.EmployeeID = ?
                            and loginTime >= ? and loginTime <= ?")

            If DB.Exception <> String.Empty Then
                MessageBox.Show(DB.Exception)
                Exit Sub
            End If

            If IsDBNull(DB.DBDataTable(0)!totalHours) Then
                totalhrsTextBox.Text = 0
            Else
                totalhrsTextBox.Text = DB.DBDataTable(0)!totalHours
            End If
            hourlyWageTextBox.Text = DB.DBDataTable(0)!HourlyPay
            If IsDBNull(DB.DBDataTable(0)!netSalary) Then
                netSalaryTextBox.Text = 0
            Else
                netSalaryTextBox.Text = DB.DBDataTable(0)!totalHours
            End If
        Else
            MessageBox.Show("Please enter employeeID,startDate and Enddate", "Message ERROR")
        End If

    End Sub

    Private Sub form_Closing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        clearData()
    End Sub

    Public Sub clearData()
        empIdTextBox.Clear()
        startDateTimePicker.ResetText()
        endDateTimePicker.ResetText()
        totalhrsTextBox.Clear()
        netSalaryTextBox.Clear()
        hourlyWageTextBox.Clear()
        timesheetDataGridView.Rows.Clear()
    End Sub
    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        clearData()
    End Sub
End Class