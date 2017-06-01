Public Class Scheduling
    Private DB As New DBStore
    Dim serviceID As String
    Dim employeeID As String
    Dim startTime As String
    Dim endTime As String
    Dim scheduleID As String
    Dim assigedWork As String
    Private Sub Scheduling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadUnassignService()
        loadAvailableEmp()
    End Sub
    Public Sub loadUnassignService()
        serviceDataGridView.ReadOnly = True
        DB.ExecuteQuery("select s.ServiceID,s.ServiceType,s.Description,s.vehicleID from service s
                            left outer join empschedules esh on s.ServiceID=esh.serviceId
                            where esh.serviceId is null")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        serviceDataGridView.ForeColor = Color.Black
        serviceDataGridView.DataSource = DB.DBDataTable

    End Sub

    Public Sub loadAvailableEmp()
        Dim availableTime As String
        employeeDataGridView.ReadOnly = True
        DB.ExecuteQuery("SELECT es.EmployeeID AS EmployeeID,e.FirstName AS FirstName,round(TIMESTAMPDIFF(SECOND,es.starttime,es.endtime)/3600,0) as `assigned time (hrs)`,
        (40 - round(TIMESTAMPDIFF(SECOND,es.starttime,es.endtime)/3600,0)) AS availableTime,
        es.assignedWork AS assignedWork,CAST(es.startTime AS DATE) AS `assigned day`
        FROM
        (empschedules es LEFT JOIN employees e ON ((es.EmployeeID = e.EmployeeID))) GROUP BY es.EmployeeID , e.FirstName ,CAST(es.startTime AS DATE);")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        availableTime = DB.DBDataTable(0)!availableTime
        If availableTime > 0 Then
            employeeDataGridView.ForeColor = Color.Black
            employeeDataGridView.DataSource = DB.DBDataTable
        End If
    End Sub

    Private Sub assgnScheduleBtn_Click(sender As Object, e As EventArgs) Handles assgnScheduleBtn.Click
        Dim i As Integer

        i = serviceDataGridView.CurrentRow.Index
        serviceID = serviceDataGridView.Item(0, i).Value
        assigedWork = serviceDataGridView.Item(1, i).Value
        i = employeeDataGridView.CurrentRow.Index
        employeeID = employeeDataGridView.Item(0, i).Value
        startTime = startDateTimePicker.Value.ToString("yyyy-MM-dd hh:mm:ss")
        endTime = EndDateTimePicker.Value.ToString("yyyy-MM-dd hh:mm:ss")

        DB.ExecuteQuery("Select max(ScheduleID) as maxScheduleID from empschedules")
        If DB.RecordCount = 0 Then
            scheduleID = 4000
        Else
            scheduleID = DB.DBDataTable(0)!maxScheduleID + 1
        End If

        DB.AddParam("@scheduleID", scheduleID)
        DB.AddParam("@employeeID", employeeID)
        DB.AddParam("@startTime", startTime)
        DB.AddParam("@endTime", endTime)
        DB.AddParam("@serviceID", serviceID)
        DB.AddParam("@assigedWork", assigedWork)

        DB.ExecuteQuery("INSERT INTO empschedules (ScheduleID, EmployeeID,  startTime, EndTime,serviceID,assignedWork ) VALUES(?,?,?,?,?,?)")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        MessageBox.Show("Employee assigned for service successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        clearData()
    End Sub

    Public Sub clearData()
        loadUnassignService()
        loadAvailableEmp()
        startDateTimePicker.ResetText()
        EndDateTimePicker.ResetText()
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        clearData()
    End Sub
End Class