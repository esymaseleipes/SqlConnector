Public Class SqlConnectionParams

#Region "Properites"
    Private _SqlServer As String
    Public Property SqlServer() As String
        Get
            Return _SqlServer
        End Get
        Set(ByVal value As String)
            _SqlServer = value
        End Set
    End Property
    Private _SqlUser As String
    Public Property SqlUser() As String
        Get
            Return _SqlUser
        End Get
        Set(ByVal value As String)
            _SqlUser = value
        End Set
    End Property
    Private _SqlPass As String
    Public Property SqlPass() As String
        Get
            Return _SqlPass
        End Get
        Set(ByVal value As String)
            _SqlPass = value
        End Set
    End Property
    Private _SqlDataBase As String
    Public Property SqlDataBase() As String
        Get
            Return _SqlDataBase
        End Get
        Set(ByVal value As String)
            _SqlDataBase = value
        End Set
    End Property
#End Region
    Public Sub New()
        Me.SqlServer = ""
        Me.SqlDataBase = ""
        Me.SqlPass = ""
        Me.SqlUser = ""
    End Sub
    Public Sub New(Params As SqlConnectionParams)
        Me.SqlServer = Params.SqlServer
        Me.SqlDataBase = Params.SqlDataBase
        Me.SqlPass = Params.SqlPass
        Me.SqlUser = Params.SqlUser
    End Sub
    Public Function GetConnectionString() As String
        Return "Data Source=" & SqlServer & ";Persist Security Info=False;User ID=" & SqlUser & ";Password=" & SqlPass
    End Function
End Class