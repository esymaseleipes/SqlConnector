
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB

Public Class ClsConnection
    Public Property ConnHelper As ClsConnHelper
    Public Property SqlConParams As ClsConnectionParams
    Public Property CryptKey As String
    Public Property FilePath As String
    Public Sub New(_FilePath As String, _CryptKey As String)
        CryptKey = _CryptKey
        FilePath = _FilePath
        ConnHelper = New ClsConnHelper(CryptKey)
        SqlConParams = ConnHelper.ReadObjectFromFile(Of ClsConnectionParams)(FilePath)
    End Sub
    Public Sub New(_server As String, _database As String, _user As String, _pass As String)
        SqlConParams = New ClsConnectionParams(_server, _user, _pass, _database)
    End Sub

    Public Function GetDataLayer(Optional CreateOption As AutoCreateOption = AutoCreateOption.None) As IDataLayer
        Try
            If SqlConParams Is Nothing Then
                Return Nothing
            Else



                Return XpoDefault.GetDataLayer(MSSqlConnectionProvider.GetConnectionString(
                                       SqlConParams.SqlServer,
                                       SqlConParams.SqlUser,
                                       SqlConParams.SqlPass,
                                       SqlConParams.SqlDataBase), CreateOption)
            End If

        Catch ex As Exception
            MsgBox("ClsCOnnection.GetDataLayer Error" & vbCrLf & ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GetSqlConnection(ShowMessages As Boolean) As SqlConnection
        If SqlConParams Is Nothing Then Return Nothing
        Dim SqlConn As New SqlConnection
        Using connection As New SqlConnection(SqlConParams.GetSqlConnectionString)
            Try
                connection.Open()
                If ShowMessages = True Then MessageBox.Show("Επιτυχής σύνδεση με τον Sql Server", "Sql Server Connection Test Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return connection
            Catch ex As Exception
                If ShowMessages = True Then MessageBox.Show("Ανεπιτυχής σύνδεση με τον Sql Server" + vbCrLf + Err.Description, "Sql Server Connection Test Fail", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return Nothing
            End Try
        End Using
    End Function


    Public Function ExecSql(sql As String) As Boolean

        Try
            Dim con As SqlConnection
            Dim cmd As SqlCommand
            Dim row As Integer
            Dim constr As String = "Server=" & Me.SqlConParams.SqlServer & ";Database=" & Me.SqlConParams.SqlDataBase & ";User Id=" & Me.SqlConParams.SqlUser & ";Password=" & Me.SqlConParams.SqlPass
            con = New SqlConnection(constr)
            con.Open()
            cmd = New SqlCommand(sql, con)
            row = cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception

            Debug.Print("Error")
            Debug.Print(ex.Message)
        End Try

    End Function




    Public Function GetListOfDatabases() As DataTable
        If SqlConParams Is Nothing Then Return Nothing
        Using connection As New SqlConnection(SqlConParams.GetSqlConnectionString)
            Try
                connection.Open()
                Return connection.GetSchema("Databases")
            Catch ex As Exception
                MessageBox.Show("Ανεπιτυχής σύνδεση με τον Sql Server" + vbCrLf + Err.Description, "Sql Server GetListOfDatabases", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return Nothing
            End Try
        End Using
    End Function
    Public Function ShowFrmSqlDetail()
        Dim f As FrmSqlDetail = New FrmSqlDetail(Me)
        f.ShowDialog()
    End Function
    Public Class ClsConnectionParams
#Region "Properites"
        Public Property SqlServer() As String
        Public Property SqlUser() As String
        Public Property SqlPass() As String
        Public Property SqlDataBase() As String
        Public ReadOnly Property GetSqlConnectionString As String
            Get
                Return "Data Source=" & SqlServer & ";Persist Security Info=False;User ID=" & SqlUser & ";Password=" & SqlPass
            End Get
        End Property
        Public Sub New(_SqlServer As String, _SqlUser As String, _SqlPass As String, _SqlDataBase As String)
            SqlServer = _SqlServer
            SqlUser = _SqlUser
            SqlPass = _SqlPass
            SqlDataBase = _SqlDataBase
        End Sub
        Public Sub New()

        End Sub

#End Region
    End Class


End Class


