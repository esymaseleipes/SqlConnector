

Public Class ClassEncrypt


    Public Shared Function Encrypt(ByVal stringToEncrypt As String, ByVal key As String) As String
        Return (stringToEncrypt & key)
    End Function

    Public Shared Function Decrypt(ByVal encryptedString As String, ByVal key As String) As String
        Return (encryptedString & key)

    End Function

End Class
