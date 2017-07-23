Module config
    Public PUID As String = ""
    Public binPath As String = ""
    Public detailsPath As String = ""
    Public tempPath As String = ""
    Public encodedFileHeader As Byte()
    Public FrmLoadingObj As New Loading


    Public PHPConKey As String = "lX5wf897+2dSfE^ks!14z5qq=498JHm5"  '32 chr shared ascii string (32 * 8 = 256 bit)
    Public PHPConIV As String = "7Oh952hhe%)y67#cs!9hjv48n9xx7(y)"  '32 chr shared ascii string (32 * 8 = 256 bit)
    Public LocalKey As String = "t8H(3dV4w!52"
    Public LocalIV As String = "O%vJ6GJv85$3"

    Public PackageCode As String = ""
    Public serverURI As String = ""
    Public CheckumBin As String = ""
    Public PackageName As String = ""
    Public DataVersion As String = ""
    Public AppVersion As String = ""
End Module
