Imports System.Console
Imports System.Globalization
Imports System.Runtime.CompilerServices
Imports CenterCLR.Extensions
Module Module1

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
#Region "これ、どうする？"
        Dim collectionInitializer = New String({"0"c}) From {"1"c}
#End Region
    End Sub

    Private Sub IntroduceNameOf(Optional arg As String = Nothing)
        If arg Is Nothing Then Throw New ArgumentNullException(NameOf(arg))
        WriteLine($"{NameOf(arg)}:{arg}")
    End Sub
    Private Sub IntroduceStringInterpolation(Optional arg As String = Nothing)
        WriteLine($"{1000:C}")
        With New Object()
            Dim format As IFormattable = $"{1000:C}"
            WriteLine(format.ToString(Nothing, CultureInfo.GetCultureInfo("en-us")))
        End With

        With New Object()
            Dim format As IFormattable = FormattableStringFactory.Create("{0:C}", 1000)
            WriteLine(format.ToString(Nothing, CultureInfo.GetCultureInfo("en-us")))
        End With
    End Sub

End Module
Namespace Extensions
    Friend Module SampleExtension
        <Extension>
        Friend Sub Add(target As String, param As Char)

        End Sub
    End Module
End Namespace
