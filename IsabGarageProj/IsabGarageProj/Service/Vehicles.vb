Public Class Vehicles

    Private DB As DBStore = New DBStore()

    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        If modelTB.Text = "" Then
            ErrorProvider.Clear()
            ErrorProvider.SetError(modelTB, "Enter car model")
        ElseIf enginenumTB.Text = "" Then
            ErrorProvider.Clear()
            ErrorProvider.SetError(enginenumTB, "Enter Engine Number")
        ElseIf colorTB.Text = "" Then
            ErrorProvider.Clear()
            ErrorProvider.SetError(colorTB, "Enter Color of Vehicle")
        ElseIf customeridTB.Text = "" Then
            ErrorProvider.Clear()
            ErrorProvider.SetError(customeridTB, "Enter the customer number")
        Else
            ErrorProvider.Clear()
            InsertNewVehicle()
            Me.Close()
        End If
    End Sub

    Private Sub InsertNewVehicle()
        DB.AddParam("@VehicleID", vehicleidTB.Text)
        DB.AddParam("@Model", modelTB.Text)
        DB.AddParam("@EngineNumber", enginenumTB.Text)
        DB.AddParam("@Color", colorTB.Text)
        DB.AddParam("@CustomerID", customeridTB.Text)

        DB.ExecuteQuery("INSERT INTO vehicles (VehicleID, Model, EngineNumber, Color, CustomerID) VALUES(?,?,?,?,?)")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        MessageBox.Show("New vehicle data entered successfully", "New vehicle data")
    End Sub

    Private Sub Vehicles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        generatevehicleID()
        vehicleidTB.Enabled = False
    End Sub

    Private Sub generatevehicleID()
        DB.ExecuteQuery("Select max(VehicleID) as maxVehicleID  from vehicles")
        vehicleidTB.Text = DB.DBDataTable(0)!maxVehicleID + 1

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Me.Close()
    End Sub
End Class