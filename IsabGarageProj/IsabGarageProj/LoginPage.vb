Public Class LoginPage
    Private DB As New DBStore
    Dim user_name As String = ""
    Dim user_id As String = ""
    Public direct_exit As Boolean = True
    Dim timesheetID As String

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Dim workType As String
        If String.IsNullOrEmpty(empIDTextBox.Text) Then
            MessageBox.Show("Enter Valid User Name", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            empIDTextBox.Focus()
        Else
            If String.IsNullOrEmpty(pwdTextBox.Text) Then
                MessageBox.Show("Enter Valid Password", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
                pwdTextBox.Focus()
            Else
                DB.AddParam("@username", empIDTextBox.Text)
                DB.AddParam("@password", pwdTextBox.Text)
                DB.ExecuteQuery("Select * from  employees where EmployeeID=? and EmpPassword=?")
                If DB.RecordCount = 0 Then
                    MessageBox.Show("Credentials are not valid! Please try again", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else
                    user_name = DB.DBDataTable(0)!FirstName & "," & DB.DBDataTable(0)!LastName
                    user_id = DB.DBDataTable(0)!EmployeeID
                    workType = DB.DBDataTable(0)!WorkType
                    'MessageBox.Show("Employee record successfully found.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    DB.ExecuteQuery("Select max(timesheetId) as maxtimeSheetID from timesheet")
                    If DB.RecordCount = 0 Then
                        timesheetID = 1
                    Else
                        timesheetID = DB.DBDataTable(0)!maxtimeSheetID + 1
                    End If

                    If DB.Exception <> String.Empty Then
                            MessageBox.Show(DB.Exception)
                            Exit Sub
                        End If

                        DB.AddParam("@timesheetID", timesheetID)
                        DB.AddParam("@EmployeeID", user_id)
                    DB.ExecuteQuery("insert into timesheet (timesheetId,loginTime,EmployeeID) values (?,sysdate(),?); ")
                    If DB.Exception <> String.Empty Then
                            MessageBox.Show(DB.Exception)
                            Exit Sub
                        End If

                        Me.Visible = False
                        Select Case workType
                        Case "Worker"
                            MessageBox.Show("Welcome Sales Representative: " & user_name, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                MainSalesForm.CustomerNameLbl.Text = user_name
                                MainSalesForm.employeeID = user_id
                                MainSalesForm.timesheetID = timesheetID
                            SalesOrderForm.EmpIDTextBox.Text = user_id
                            ServiceForm.servemployeeidTB.Text = user_id
                            MainSalesForm.Show()
                        Case "Manager"
                            MessageBox.Show("Welcome Garage Manager: " & user_name, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            MainManagerForm.CustomerNameLbl.Text = user_name
                            MainManagerForm.employeeID = user_id
                            MainManagerForm.timesheetID = timesheetID
                            MainManagerForm.Show()
                    End Select
                        clear_data()
                        direct_exit = False
                        Me.Visible = False
                        'Me.Close()
                    End If
                End If
        End If
    End Sub

    Private Sub clear_data()
        empIDTextBox.Clear()
        pwdTextBox.Clear()
        empIDTextBox.Focus()
        user_name = ""
        user_id = ""
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        clear_data()
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Me.Close()
    End Sub
End Class
