Imports System.Data.SqlClient
Imports DevExpress.Xpo

Public Class FrmSqlDetail
    Public Property ConnectionParams As ClsConnection.ClsConnectionParams
    Public Property con As SqlConnection
    Dim clsconnection As ClsConnection

    Public Sub New(_clsconnection As ClsConnection)
        InitializeComponent()
        clsconnection = _clsconnection
        con = clsconnection.GetSqlConnection(False)

        If clsconnection.SqlConParams Is Nothing Then
            clsconnection.SqlConParams = New ClsConnection.ClsConnectionParams With {.SqlDataBase = "", .SqlPass = "", .SqlServer = "", .SqlUser = ""}
            ConnectionParams = clsconnection.SqlConParams
        Else
            ConnectionParams = clsconnection.SqlConParams
        End If





        If con Is Nothing Then
            LayoutControlItem5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LCIDatabase.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LCIBtnTEstConnection.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        Else
            initCmb()
            LayoutControlItem5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            LCIDatabase.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            LCIBtnTEstConnection.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        End If

        InitBindings()
    End Sub
    Private Function initCmb() As Boolean
        CmbDatabase.Properties.DataSource = clsconnection.GetListOfDatabases()
        CmbDatabase.Properties.DisplayMember = "database_name"
        CmbDatabase.Properties.ValueMember = "database_name"
    End Function
    Private Sub InitBindings()
        TxtPassword.DataBindings.Add("Text", ConnectionParams, "SqlPass")
        TxtSqlServer.DataBindings.Add("Text", ConnectionParams, "SqlServer")
        TxtUserName.DataBindings.Add("Text", ConnectionParams, "SqlUser")
        CmbDatabase.DataBindings.Add("EditValue", ConnectionParams, "SqlDataBase")
    End Sub

    Private Sub BtnTestConnection_Click(sender As Object, e As EventArgs) Handles BtnTestConnection.Click

        If Not clsconnection.GetSqlConnection(True) Is Nothing Then
            initCmb()
            LayoutControlItem5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            LCIDatabase.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            LCIBtnTEstConnection.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        Else
            LayoutControlItem5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LCIDatabase.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LCIBtnTEstConnection.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        End If
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        If Not clsconnection.GetSqlConnection(True) Is Nothing Then

            clsconnection.ConnHelper.SaveObjectToFile(clsconnection.SqlConParams, clsconnection.FilePath)

            'Dim cx As ClsNrgHelper = New ClsNrgHelper(clsconnection.CryptKey)
            'cx.SaveObjectToFile(clsconnection.SqlConParams, clsconnection.FilePath)
            Me.Close()
        Else
            MsgBox("Οι Παράμετροι σύνδεσης με το Sql Δέν Είναι Σωστές!!!")
        End If


    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
End Class