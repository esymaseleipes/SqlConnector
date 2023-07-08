Imports System.Data.SqlClient
Imports System.Reflection
Imports System.Windows.Forms
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports ClsXml
Imports ClsCrypto
Imports System.Security.AccessControl

Public Class SqlConnectionCommandsss
    Public Property SqlConnectionName As String
    Private _ConnectionParams As SqlConnectionParams
    Public Property ConnectionParams() As SqlConnectionParams
        Get
            Return _ConnectionParams
        End Get
        Set(ByVal value As SqlConnectionParams)
            _ConnectionParams = value
        End Set
    End Property
    Public Sub New(_SqlConnectionName As String)
        SqlConnectionName = _SqlConnectionName
    End Sub
    Private Function GetXmlPath() As String
        Dim fullpath As String = Assembly.GetExecutingAssembly().Location
        Dim newpath As String = fullpath.Replace("PrintKingHelper.dll", SqlConnectionName & ".xml")
        Return newpath
    End Function
    Public Sub SaveParamsToXml()

        Dim XmlWork As New XmlWorker
        EncryptConnectionParams()
        XmlWork.SaveClassToXml(GetXmlPath, Me.ConnectionParams)
    End Sub
    Public Sub ReadParamsFromXml()
        If Dir(GetXmlPath) = "" Then
            If ShowSqlFormSetup() = False Then
                Throw New Exception
            Else
                SaveParamsToXml()
            End If
        End If


        Dim xmlwork As New XmlWorker
        Me.ConnectionParams = xmlwork.GetObjectFromXml(Of SqlConnectionParams)(GetXmlPath)
        DecryptConnectionParams()
    End Sub
    Private Sub EncryptConnectionParams()
        ShowLog("Before Encrypt")

        With Me.ConnectionParams
            .SqlDataBase = ClassEncrypt.Encrypt(.SqlDataBase, "")
            .SqlServer = ClassEncrypt.Encrypt(.SqlServer, "")
            .SqlUser = ClassEncrypt.Encrypt(.SqlUser, "")
            .SqlPass = ClassEncrypt.Encrypt(.SqlPass, "")
        End With
        ShowLog("After Encrypt")
    End Sub
    Private Sub DecryptConnectionParams()
        With Me.ConnectionParams
            .SqlDataBase = ClassEncrypt.Decrypt(.SqlDataBase, "")
            .SqlServer = ClassEncrypt.Decrypt(.SqlServer, "")
            .SqlUser = ClassEncrypt.Decrypt(.SqlUser, "")
            .SqlPass = ClassEncrypt.Decrypt(.SqlPass, "")
        End With
    End Sub
    Public Function ShowSqlFormSetup() As Boolean
        '    If Me.ConnectionParams Is Nothing Then Me.ConnectionParams = New SqlConnectionParams
        '    Dim f As FrmSqlDetail = New FrmSqlDetail(Me.ConnectionParams)
        '    If f.ShowDialog = DialogResult.OK Then
        '        Me.ConnectionParams = f.oSqlServerConnectionPrams
        '        Return True
        '    Else
        '        Return False
        '    End If
    End Function
    Private Function GetSqlConnectionString() As String
        Return "Data Source=" & Me.ConnectionParams.SqlServer & ";Persist Security Info=False;User ID=" & Me.ConnectionParams.SqlUser & ";Password=" & Me.ConnectionParams.SqlPass
    End Function
    Public Function TestSqlConnection(ShowMessages As Boolean) As Boolean
        Dim SqlConn As New SqlConnection
        Dim SqlConnStr As String = GetSqlConnectionString()
        Using connection As New SqlConnection(SqlConnStr)
            Try
                connection.Open()
                If ShowMessages = True Then MessageBox.Show("Επιτυχής σύνδεση με τον Sql Server", "Sql Server Connection Test Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return True
            Catch ex As Exception
                If ShowMessages = True Then MessageBox.Show("Ανεπιτυχής σύνδεση με τον Sql Server" + vbCrLf + Err.Description, "Sql Server Connection Test Fail", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Using
    End Function
    Public Function GetListOfDatabases() As DataTable
        Using connection As New SqlConnection(GetSqlConnectionString())
            Try
                connection.Open()
                Return connection.GetSchema("Databases")
            Catch ex As Exception
                MessageBox.Show("Ανεπιτυχής σύνδεση με τον Sql Server" + vbCrLf + Err.Description, "Sql Server Connection Test Fail", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return Nothing
            End Try
        End Using
    End Function
    Private Sub ShowLog(msg As String)
        Debug.Print("------------------- " & msg & " -------------------")
        With Me.ConnectionParams
            Debug.Print(".SqlServer=" & .SqlServer)
            Debug.Print(".SqlDataBase=" & .SqlDataBase)
            Debug.Print(".SqlUser=" & .SqlUser)
            Debug.Print(".SqlPass=" & .SqlPass)
        End With
    End Sub
    Public Function GetDataLayer(_AutoCreateOption As AutoCreateOption) As IDataLayer
        ReadParamsFromXml()

        Try
            Return XpoDefault.GetDataLayer(
            MSSqlConnectionProvider.GetConnectionString(
                                       ConnectionParams.SqlServer,
                                       ConnectionParams.SqlUser,
                                       ConnectionParams.SqlPass,
                                       ConnectionParams.SqlDataBase
                                       ),
            _AutoCreateOption
            )
        Catch ex As Exception
            MsgBox("Δέν Μπορώ Να Συνδεθώ Στον SqlServer=" & ConnectionParams.SqlServer & vbCrLf & ex.Message)
            Return Nothing
        End Try
    End Function
End Class
Public Class SqlConnectionCommand
    Private SqlConnParams As SqlConnectionParams = Nothing

    Public Sub New(xmlFile As String, CryptoKey As String)
        Dim xxx As ClsXml.XmlClass = New XmlClass(xmlFile, CryptoKey)

        SqlConnParams = xxx.GetTypeFromXml(GetType(SqlConnectionParams))
    End Sub

    Public Function TestSqlConnection(ShowMessages As Boolean) As Boolean
        Dim SqlConn As New SqlConnection
        Dim SqlConnStr As String = GetSqlConnectionString()
        Using connection As New SqlConnection(SqlConnStr)
            Try
                connection.Open()
                If ShowMessages = True Then MessageBox.Show("Επιτυχής σύνδεση με τον Sql Server", "Sql Server Connection Test Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return True
            Catch ex As Exception
                If ShowMessages = True Then MessageBox.Show("Ανεπιτυχής σύνδεση με τον Sql Server" + vbCrLf + Err.Description, "Sql Server Connection Test Fail", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Using
    End Function
    Private Function GetSqlConnectionString() As String
        Return "Data Source=" & SqlConnParams.SqlServer & ";Persist Security Info=False;User ID=" & SqlConnParams.SqlUser & ";Password=" & SqlConnParams.SqlPass
    End Function


End Class