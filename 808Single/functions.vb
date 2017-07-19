Imports System.IO
Imports System.Net
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions

Module functions
    Public Function AES_encrypt(Input As String, Optional key As String = "", Optional iv As String = "") As String
        Dim aes As RijndaelManaged = New RijndaelManaged()
        aes.KeySize = 256
        aes.BlockSize = 256
        aes.Padding = PaddingMode.PKCS7
        If key = "" Or iv = "" Then
            aes.Key = Encoding.UTF8.GetBytes(PHPConKey)
            aes.IV = Encoding.UTF8.GetBytes(PHPConIV)
        Else
            aes.Key = Encoding.UTF8.GetBytes(key)
            aes.IV = Encoding.UTF8.GetBytes(iv)
        End If

        Dim encrypt As ICryptoTransform = aes.CreateEncryptor(aes.Key, aes.IV)
        Dim xBuff As Byte() = Nothing
        Using ms As MemoryStream = New MemoryStream()
            Using cs As CryptoStream = New CryptoStream(ms, encrypt, CryptoStreamMode.Write)
                Dim xXml As Byte() = Encoding.UTF8.GetBytes(Input)
                cs.Write(xXml, 0, xXml.Length)
            End Using

            xBuff = ms.ToArray()
        End Using

        Dim Output As String = Convert.ToBase64String(xBuff)
        Return Output
    End Function

    Public Function AES_decrypt(Input As String, Optional key As String = "", Optional iv As String = "") As String
        Dim aes As New RijndaelManaged()
        aes.KeySize = 256
        aes.BlockSize = 256
        aes.Mode = CipherMode.CBC
        aes.Padding = PaddingMode.PKCS7
        If key = "" Or iv = "" Then
            aes.Key = Encoding.UTF8.GetBytes(PHPConKey)
            aes.IV = Encoding.UTF8.GetBytes(PHPConIV)
        Else
            aes.Key = Encoding.UTF8.GetBytes(key)
            aes.IV = Encoding.UTF8.GetBytes(iv)
        End If

        Dim decrypt As ICryptoTransform = aes.CreateDecryptor()
        Dim xBuff As Byte() = Nothing
        Try
            Using ms As MemoryStream = New MemoryStream()
                Using cs As CryptoStream = New CryptoStream(ms, decrypt, CryptoStreamMode.Write)
                    Dim xXml As Byte() = Convert.FromBase64String(Input)
                    cs.Write(xXml, 0, xXml.Length)
                End Using

                xBuff = ms.ToArray()
            End Using
        Catch

        End Try
        Dim Output As String = Encoding.UTF8.GetString(xBuff)
        Return Output
    End Function

    Public Function IsEmail(ByVal input As String) As Boolean
        Dim email As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
        If email.IsMatch(input) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function ToMD5(ByVal input As String) As String
        Using md5Hash As MD5 = MD5.Create()
            Return GetMd5Hash(md5Hash, input)
        End Using
    End Function

    Public Function ToMD5(ByVal input As Byte()) As String
        Using md5Hash As MD5 = MD5.Create()
            Dim data As Byte() = md5Hash.ComputeHash(input)
            Dim sBuilder As New StringBuilder()
            Dim i As Integer
            For i = 0 To data.Length - 1
                sBuilder.Append(data(i).ToString("x2"))
            Next i
            Return sBuilder.ToString()
        End Using
    End Function

    Private Function GetMd5Hash(ByVal md5Hash As MD5, ByVal input As String) As String
        Dim data As Byte() = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input))
        Dim sBuilder As New StringBuilder()
        Dim i As Integer
        For i = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next i
        Return sBuilder.ToString()
    End Function

    Public Function GenerateHash(ByVal input As String, ByVal salt As String) As String
        Dim code As String = ServerHash(PUID + salt + input)
        Dim x As Long = 2146
        For Each c As Char In code
            x += ((((AscW(c) * 256) + 2048) / 64) + 1073) ^ 3

        Next
        x += -261
        If (x < 0) Then x = x * -1
        Dim tempStr As String = Strings.Right(CStr(x), CStr(x).Length - 2)
        Return tempStr
    End Function

    Public Function ServerHash(ByVal SourceText As String) As String
        Dim data1ToHash As Byte() = Encoding.UTF8.GetBytes(SourceText)
        Dim hashvalue1 As Byte() = CType(CryptoConfig.CreateFromName("MD5"), HashAlgorithm).ComputeHash(data1ToHash)
        Return Convert.ToBase64String(hashvalue1)
    End Function

    Public Function get_setting(ByVal Key As String, ByVal DefaultV As Object) As Object
        Dim temp As String = Nothing
        Dim Subject As String = "Single808Lock"

        temp = AES_decrypt(GetSetting(AES_encrypt(Application.ProductName & PackageCode, LocalKey, LocalIV), AES_encrypt(Subject & PackageCode, LocalKey, LocalIV), AES_encrypt(Key & PackageCode, LocalKey, LocalIV), AES_encrypt(DefaultV, LocalKey, LocalIV)), LocalKey, LocalIV)

        If temp = Nothing Then
            Return DefaultV
        End If

        Return temp
    End Function

    Public Sub set_setting(ByVal Key As String, ByVal Value As Object)
        Dim Subject As String = "Single808Lock"
        SaveSetting(AES_encrypt(Application.ProductName & PackageCode, LocalKey, LocalIV), AES_encrypt(Subject & PackageCode, LocalKey, LocalIV), AES_encrypt(Key & PackageCode, LocalKey, LocalIV), AES_encrypt(Value, LocalKey, LocalIV))
    End Sub

    Public Function GetRandom(ByVal Min As Long, ByVal Max As Long) As Long

        ' by making Generator static, we preserve the same instance '
        ' (i.e., do not create new instances with the same seed over and over) '
        ' between calls '
        Static Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)

        Return Nothing
    End Function

    Public Function jsonSerilizer(ByVal action As Short, ByVal puid As String, ByVal serial As String, ByVal package As String, ByVal ranber As Long, Optional name As String = "", Optional email As String = "", Optional phone As String = "") As String
        Return AES_encrypt("{""action"":" & action & ",""puid"":""" & puid & """,""serial"":""" & serial & """,""name"":""" & name & """,""email"":""" & email & """,""phone"":""" & phone & """,""package"":""" & package & """,""ranber"":" & ranber & "}")
    End Function

    Public Function importJson(ByVal input As String) As jsonStructure
        Dim jss As New System.Web.Script.Serialization.JavaScriptSerializer()
        Return jss.Deserialize(Of jsonStructure)(AES_decrypt(input))
    End Function
    Public Function HttpPostRequest(ByVal url As String, ByVal data As String, Optional ByVal HideErrors As Boolean = False) As String
        Dim responseFromServer As String = Nothing
        Try
            url = Replace(url, "https", "http")

            Dim request As System.Net.WebRequest = System.Net.WebRequest.Create(url)
            request.Method = "POST"
            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(data)

            request.ContentType = "application/x-www-form-urlencoded"
            CType(request, HttpWebRequest).UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows CE)"
            'CType(request, HttpWebRequest).Accept = "*/*"
            'request.Headers.Add("Accept-Language", "en-us\r\n")
            'request.Headers.Add("UA-CPU", "x86 \r\n")
            'request.Headers.Add("Cache-Control", "no-cache\r\n")
            CType(request, HttpWebRequest).Referer = url
            request.ContentLength = byteArray.Length

            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
            dataStream.Close()
            Dim response As WebResponse = request.GetResponse()
            dataStream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            responseFromServer = reader.ReadToEnd()
            reader.Close()
            dataStream.Close()
            response.Close()
            Return responseFromServer

        Catch ex As Exception
            Dim error1 As String = ErrorToString()
            If HideErrors = False Then
                If error1 = "Invalid URI: The format of the URI could not be determined." Then
                    MsgBox("ERROR! Must have HTTP:// before the URL.", "Webservice/httpRequest")
                Else
                    MsgBox(error1.ToString, System.Reflection.MethodBase.GetCurrentMethod.Name.ToString)
                End If
                Return ""
            Else
                Return error1
            End If
        End Try
    End Function

    Public Sub syncOfflineUser()
        On Error Resume Next
        Dim ranber As Long = GetRandom(10000, 100000)
        Dim hash As String = Web.HttpUtility.UrlEncodeUnicode(jsonSerilizer(1, get_setting("version", PUID), get_setting("serial", ""), PackageCode, ranber, get_setting("user_name", ""), get_setting("user_email", ""), get_setting("user_phone", "")))
        Dim response As String = HttpPostRequest(serverURI, "hash=" & hash.Trim)

        Dim result As New jsonStructure
        If response.Length > 20 Then
            result = importJson(response)
        Else
            Exit Sub
        End If

        If result.ranber = (ranber * 73) - 320 And CInt(result.response) = 1 Then
            Exit Sub
        ElseIf result.ranber = (ranber * 73) - 320 And (CInt(result.response) = 4 Or CInt(result.response) = 2) And get_setting("version", "") <> ""
            set_setting("version", "")
            Application.Restart()
        End If

    End Sub
End Module
