Imports System.Data.SqlClient
Imports System.Reflection
Imports System.Windows.Forms
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB


Public Class DatabaseConnectionFactory
    Private Property ConParam As SqlConnectionParams
    Public Sub New()
        ConParam = New SqlConnectionParams With {.SqlDataBase = "", .SqlPass = "", .SqlServer = "", .SqlUser = ""}
    End Sub
    Public Sub New(SqlConParams As SqlConnectionParams)
        If SqlConParams Is Nothing Then
            ConParam = New SqlConnectionParams With {.SqlDataBase = "", .SqlPass = "", .SqlServer = "", .SqlUser = ""}
        Else
            ConParam = SqlConParams
        End If
    End Sub

    'Public Function TestConnection(ShowMessages As Boolean) As Boolean
    '    Dim SqlconParams As SqlConnectionParams = TryCast(ConParam, SqlConnectionParams)

    '    If Not SqlconParams Is Nothing Then
    '        Dim SqlConn As New SqlConnection
    '        Dim SqlConnStr As String = SqlconParams.GetConnectionString
    '        Using connection As New SqlConnection(SqlConnStr)
    '            Try
    '                connection.Open()
    '                If ShowMessages = True Then MessageBox.Show("Επιτυχής σύνδεση με τον Sql Server", "Sql Server Connection Test Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                Return True
    '            Catch ex As Exception
    '                If ShowMessages = True Then MessageBox.Show("Ανεπιτυχής σύνδεση με τον Sql Server" + vbCrLf + Err.Description, "Sql Server Connection Test Fail", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                Return False
    '            End Try
    '        End Using
    '    Else
    '        If ShowMessages = True Then MessageBox.Show("Ανεπιτυχής σύνδεση με τον Sql Server" + vbCrLf + Err.Description, "Sql Server Connection Test Fail", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Return False
    '    End If
    'End Function
    'Public Sub ShowDbWizard()
    '    Dim SqlconParams As SqlConnectionParams = TryCast(ConParam, SqlConnectionParams)
    '    Dim FrmWizard As DevExpress.XtraEditors.XtraForm
    '    If Not SqlconParams Is Nothing Then
    '        FrmWizard = New FrmSqlDetail(SqlconParams)
    '        FrmWizard.ShowDialog()
    '    End If
    'End Sub
End Class















