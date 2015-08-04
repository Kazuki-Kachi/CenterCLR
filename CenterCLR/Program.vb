Imports System.Console
Imports System.Globalization
Imports System.Runtime.CompilerServices
Imports CenterCLR.Extensions
Module Program

    Sub Main()
#Region "変数宣言"
        Dim s = ""
        Dim i = 0
#End Region
        Try
            IntroduceNameOf("Value")
            IntroduceNameOf()
        Catch ex As ArgumentNullException
#Disable Warning IDE0002
            Console.WriteLine(ex.Message)
#Enable Warning IDE0002
            Console.WriteLine("")
        End Try

        IntroduceStringInterpolation()
        IntroduceMultilineStringLiterals()
        IntroduceYearFirstDateLiterals()

    End Sub
End Module


Namespace Extensions
    Friend Module SampleExtension
        <Extension>
        Friend Sub Add(target As String, param As Char)

        End Sub
    End Module
End Namespace
