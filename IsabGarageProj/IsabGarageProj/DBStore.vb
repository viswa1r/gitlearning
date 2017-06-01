Imports System.Data.Odbc
Imports System.Data.SqlClient
Public Class DBStore
    Public ConnectionString As String =
    "Driver={MySQL ODBC 5.3 ANSI Driver} ; server=141.209.241.44; database=bis638_sprinters;user=VISWA1R;password=A1aB2bC3c"
    Public DBConnection As New OdbcConnection(ConnectionString)

    Public DBCommand As OdbcCommand

    Public DBDataAdapter As OdbcDataAdapter

    Friend Function SqlCmd() As SqlCommand
        Throw New NotImplementedException()
    End Function

    Public DBDataTable As DataTable

    Public Params As New List(Of OdbcParameter)

    Public RecordCount As Integer

    Public Exception As String

    Public Sub ExecuteQuery(QueryString As String)
        RecordCount = 0
        Exception = String.Empty

        Try
            DBConnection.Open()
            DBCommand = New OdbcCommand(QueryString, DBConnection)
            For Each p As OdbcParameter In Params
                DBCommand.Parameters.Add(p)
            Next

            Params.Clear()

            DBDataTable = New DataTable

            DBDataAdapter = New OdbcDataAdapter(DBCommand)

            RecordCount = DBDataAdapter.Fill(DBDataTable)

        Catch ex As Exception
            Exception = ex.Message
        End Try

        If DBConnection.State = ConnectionState.Open Then
            DBConnection.Close()
        End If
    End Sub

    Public Sub AddParam(Name As String, Value As Object)
        If IsDBNull(Value) = True Or Value = "" Then
            Dim NewParam As New OdbcParameter(Name, DBNull.Value)
            Params.Add(NewParam)
        Else
            Dim NewParam As New OdbcParameter(Name, Value)
            Params.Add(NewParam)
        End If

    End Sub
End Class
