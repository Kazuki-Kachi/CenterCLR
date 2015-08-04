Imports System.Globalization
Imports System.Runtime.CompilerServices

Partial Module Program
    Private Class Point
        Public ReadOnly Property X As Integer
        Public ReadOnly Property Y As Integer
        Public Sub New(x As Integer, y As Integer)
            Me.X = x
            Me.Y = y
        End Sub
    End Class

    Private Sub IntroduceNameOf(Optional arg As String = Nothing)
        If arg Is Nothing Then Throw New ArgumentNullException(NameOf(arg))
        WriteLine($"{NameOf(arg)}:{arg}")
    End Sub
    Private Sub IntroduceStringInterpolation()
        Dim formated = $"{1000:C}" 'これは単なるString.FormatのSyntaxSugar(String.Format("{0:C}", 1000))
        WriteLine(formated)

        With New Object()
            Dim format1 As IFormattable = $"{1000:C}"
#Region "実際にはこう展開される(変数名は変えてます)"
            Dim format2 As IFormattable = FormattableStringFactory.Create("{0:C}", 1000)
#End Region
            WriteLine(format1.ToString(Nothing, CultureInfo.GetCultureInfo("en-us")))
            WriteLine(format2.ToString(Nothing, CultureInfo.GetCultureInfo("en-us")))
        End With

    End Sub

    Private Sub IntroduceMultilineStringLiterals()
        WriteLine("Hello
World")
    End Sub

    Private Sub IntroduceYearFirstDateLiterals()
        Dim today = #2015-08-29#
        Dim todayOnOldVersion = #08-29-2015#
        WriteLine($"Old:{todayOnOldVersion}{vbCrLf}New:{today}")
    End Sub

End Module
