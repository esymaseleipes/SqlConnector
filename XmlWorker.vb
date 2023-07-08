Imports System.IO

Imports System.Xml.Serialization

Public Class XmlWorkerxx
    Public Function GetObjectFromXml(Of T)(XmlFilenamePath As String) As T
        If Dir(XmlFilenamePath) = "" Then
            MsgBox("Το xml:" & XmlFilenamePath & vbCrLf & "Δεν Βρέθηκε!!!")
            Return Nothing
        End If
        Try
            Dim objStreamReader As New StreamReader(XmlFilenamePath)
            Dim Mytype As Type = GetType(T)
            Dim x As New XmlSerializer(Mytype)
            Return x.Deserialize(objStreamReader)
            objStreamReader.Close()
        Catch ex As Exception
            MsgBox("ClsDb->getParams Error:" & Err.Description)
            Debug.Print("ClsDb->getParams Error:" & Err.Description)
            Return Nothing
        End Try
    End Function
    Public Function SaveClassToXml(XmlFilenamePath As String, _Obj As Object) As Boolean
        Try
            Dim objStreamWriter As New StreamWriter(XmlFilenamePath)
            Dim TheType As Type = _Obj.GetType
            Dim serializer As New XmlSerializer(TheType)
            serializer.Serialize(objStreamWriter, _Obj)
            objStreamWriter.Close()
            Return True
        Catch ex As Exception
            Debug.Print(ex.Message)
            Return False
        End Try
    End Function
End Class


