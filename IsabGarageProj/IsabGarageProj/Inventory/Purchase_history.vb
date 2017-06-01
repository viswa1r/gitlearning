Imports System.Data.SqlClient

Public Class Purchase_history_Form
    Private DB As New DBStore
    Dim compNameStr As String = ""
    Dim purchaseDate As String = ""

    Private Sub Purchase_history_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_company_name()

    End Sub

    Private Sub load_company_name()

        DB.ExecuteQuery("SELECT * FROM suppliers;")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        cmpComboBox.Items.Clear()
        cmpComboBox.Text = String.Empty

        'MsgBox(DB.RecordCount)

        For Each aDataRow As DataRow In DB.DBDataTable.Rows
            cmpComboBox.Items.Add(aDataRow("CompanyName"))

        Next
        If DB.RecordCount > 0 Then
            cmpComboBox.SelectedIndex = 0
        End If
    End Sub
    Private Sub CompName_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmpComboBox.SelectedIndexChanged
        cmpComboBox.Enabled = True
    End Sub

    Private Sub Search_Button_Click(sender As Object, e As EventArgs) Handles Search_Button.Click
        Dim searchPurDate As String = ""

        compNameStr = cmpComboBox.Text
        purchaseDate = PHDateTimePicker.Value.ToString("yyyy-MM-dd")
        searchPurDate = purchaseDate & "%"
        purchistryDataGridView.ReadOnly = True
        If CompanyName IsNot "" And purchaseDate IsNot "" Then

            DB.AddParam("@companyName", compNameStr)
            DB.AddParam("@purchaseDate", searchPurDate)
            DB.ExecuteQuery("select ph.partId,s.companyName,ph.purchasedate,ph.quantity,ph.unitprice  
                                        from purchasehistory ph
                                        inner join suppliers s on ph.supplierId=s.SupplierID
                                          where s.CompanyName=? and ph.purchasedate like ?;")

        Else
            MsgBox("Please select companyName and puchased Date to start search")
            Exit Sub
        End If

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        purchistryDataGridView.ForeColor = Color.Black
        purchistryDataGridView.DataSource = DB.DBDataTable

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        PHDateTimePicker.ResetText()
        Me.Close()
    End Sub

End Class