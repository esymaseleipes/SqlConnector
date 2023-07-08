'Imports Newtonsoft
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports Newtonsoft.Json

Public Class ClsConnHelper
    Public ReadOnly Property CryptKey As String
    Public Sub New(_CryptKey As String)
        CryptKey = _CryptKey
    End Sub

    Private Function DecryptJsonStr(JsonStr As String, key As String) As String
        Return ClassEncrypt.Decrypt(JsonStr, key)
    End Function
    Private Function EncrypJsonStr(JsonStr As String, key As String) As String
        Return ClassEncrypt.Encrypt(JsonStr, key)
    End Function

    Private Function FileExist(FilePath As String) As Boolean

        If Dir(FilePath) = "" Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function SaveObjectToFile(_Object As Object, FilePath As String) As String
        Try
            Dim SerObj As String = Newtonsoft.Json.JsonConvert.SerializeObject(_Object, Formatting.Indented)
            If CryptKey <> "" Then SerObj = EncrypJsonStr(SerObj, CryptKey)
            Return SaveFile(FilePath, SerObj)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function ReadObjectFromFile(Of T)(FilePath As String) As T

        If FileExist(FilePath) = False Then Return Nothing
        Try
            Dim fileReader As String = My.Computer.FileSystem.ReadAllText(FilePath)
            If CryptKey <> "" Then fileReader = DecryptJsonStr(fileReader, CryptKey)
            Return JsonConvert.DeserializeObject(Of T)(fileReader)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function
    Public Shared Function SaveFile(FilePath As String, contex As String) As Boolean
        Try
            My.Computer.FileSystem.WriteAllText(FilePath, contex, False)
            Return True
        Catch ex As Exception

            Return False
        End Try
    End Function







End Class

