Imports System.Console
Imports System.Runtime.CompilerServices
Imports CenterCLR.Extensions
Module Module1

    Sub Main()
#Region "変数宣言"
        Dim s = ""
        Dim i = 0
#End Region
        Try
            IntroduceNameOf()
        Catch ex As ArgumentNullException
#Disable Warning IDE0002
            Console.WriteLine(ex.Message)
#Enable Warning IDE0002
            Console.WriteLine(ex.Message)
        End Try
#Region "これ、どうする？"
        Dim collectionInitializer = New String({"0"c}) From {"1"c}
#End Region
    End Sub

    Private Sub IntroduceNameOf(Optional arg As String = Nothing)
        If arg Is Nothing Then Throw New ArgumentNullException(NameOf(arg))

    End Sub

End Module
Namespace Extensions
    Friend Module SampleExtension
        <Extension>
        Friend Sub Add(target As String, param As Char)

        End Sub
    End Module
End Namespace
