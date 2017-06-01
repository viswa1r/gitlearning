Public Class EmployeeSevice
    Private DB As New DBStore
    Dim empId As String
    Dim serviceId As String
    Dim hoursEstimated As String

    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        empId = EmpIDTextBox.Text
        serviceId = SvcIDTextBox.Text
        If empId IsNot "" And serviceId IsNot "" Then
            DB.ExecuteQuery("Select * From empschedules Where EmployeeID = " & empId & " And serviceID = " & serviceId)
        ElseIf empId IsNot "" Then
            DB.ExecuteQuery("Select * From empschedules Where EmployeeID = " & empId)
        ElseIf serviceId IsNot "" Then
            DB.ExecuteQuery("Select * From empschedules Where serviceID = " & serviceId)
        Else
            MsgBox("Please enter either Employee Id or Service Id to start the search")
            Exit Sub
        End If


        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        'EmpSchedlesGridView.SelectAll()
        ' EmpSchedlesGridView.ClearSelection()
        'MsgBox(DB.RecordCount)
        EmpSchedlesGridView.DataSource = DB.DBDataTable

        EmpSchedlesGridView.Enabled = True
        ' EmpSchedlesGridView.Visible = True
    End Sub

    Private Sub EmpSchedlesGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmpSchedlesGridView.CellClick
        Dim i As Integer

        i = EmpSchedlesGridView.CurrentRow.Index
        SvcIDTextBox.Text = EmpSchedlesGridView.Item(4, i).Value
    End Sub

    Private Sub srvcstartButton_Click(sender As Object, e As EventArgs) Handles srvcstartButton.Click
        empId = EmpIDTextBox.Text
        serviceId = SvcIDTextBox.Text
        hoursEstimated = hoursEstimatedTextBox.Text

        If empId IsNot "" And serviceId IsNot "" And hoursEstimated IsNot "" Then
            DB.AddParam("@employeeID", empId)
            DB.AddParam("@HoursEstimated", hoursEstimated)
            DB.AddParam("@serviceID", serviceId)

            DB.ExecuteQuery("insert into employeeservice(employeeID,checkInTime,HoursEstimated,serviceID) values(?,sysdate(),?,?)")

        Else
            MsgBox("Please enter Employee Id,  Service Id and Estimated hours to start service")
        End If

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        MsgBox("service check in time inserted successfully")
    End Sub

    Private Sub srvcendButton_Click(sender As Object, e As EventArgs) Handles srvcendButton.Click
        empId = EmpIDTextBox.Text
        serviceId = SvcIDTextBox.Text

        If empId IsNot "" And serviceId IsNot "" Then
            DB.AddParam("@employeeID", empId)
            DB.AddParam("@serviceID", serviceId)

            DB.ExecuteQuery("update employeeservice set CheckOutTime=sysDate() where employeeID=? and serviceID=?  ")

            If DB.Exception <> String.Empty Then
                MessageBox.Show(DB.Exception)
                Exit Sub
            End If

            DB.AddParam("@employeeID", empId)
            DB.AddParam("@serviceID", serviceId)

            DB.ExecuteQuery("Select Case round(TIMESTAMPDIFF(Second, CheckOutTime, CheckInTime) / 3600, 0) As actualHours 
                                From employeeservice Where EmployeeID =? And serviceId =?")

            If IsDBNull(DB.DBDataTable(0)!actualHours) Then
                actualhoursTextBox.Text = 0
            Else
                actualhoursTextBox = DB.DBDataTable(0)!actualHours
            End If

        Else
            MsgBox("Please enter Employee Id,  Service Id and Estimated hours to start service")
        End If

        MsgBox("service check out time inserted successfully")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
    End Sub

    Private Sub edtiScheduleBtn_Click(sender As Object, e As EventArgs) Handles edtiScheduleBtn.Click
        Scheduling.Show()
    End Sub

    Public Sub clearData()
        EmpIDTextBox.Clear()
        SvcIDTextBox.Clear()
        hoursEstimatedTextBox.Clear()
        actualhoursTextBox.Clear()
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        clearData()
        Me.Close()
    End Sub

    Private Sub form_Closing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        clearData()
    End Sub
End Class