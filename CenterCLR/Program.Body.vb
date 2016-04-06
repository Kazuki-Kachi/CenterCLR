﻿Imports System.Globalization
Imports System.Runtime.CompilerServices
Imports System.Console
Imports CenterCLR

Partial Module Program
    Private Class Point
        Private _x As Integer
        ReadOnly Property X As Integer
            Get
                Return _x
            End Get
        End Property
        ReadOnly Property Y As Integer
        ReadOnly Property Hoge As String = "Foo"

        Sub New(x As Integer, y As Integer)
            Me._x = x
            Me.Y = y
        End Sub
        Overrides Function ToString() As String
            Return $"X:{X},Y:{Y}"
        End Function
    End Class

    Private Sub IntroduceNameOf(Optional arg As String = Nothing)
        If arg Is Nothing Then
            Throw New ArgumentNullException(NameOf(arg))
        End If

        WriteLine($"{NameOf(arg)}:{arg}")
        WriteLine("おまけ")
        WriteLine($"{NameOf(DateTime.Now)}")
        WriteLine($"{NameOf(DateTime)}")
        WriteLine($"{NameOf(Date.Today)}")
#Region "実際にはこう展開される"
        WriteLine(String.Format("{0}:{1}", "arg", arg))
        WriteLine("おまけ")
        WriteLine(String.Format("{0}", "Now"))
        WriteLine(String.Format("{0}", "DateTime"))
        WriteLine(String.Format("{0}", "Today"))
#End Region
        'WriteLine($"{NameOf(Date)}") これはBuild Error
        Dim s = NameOf(System.String)

    End Sub
    Private Sub IntroduceStringInterpolation()
        Dim formated = $"{1000:C}" 'これは単なるString.FormatのSyntaxSugar(String.Format("{0:C}", 1000))
        WriteLine(formated)

        With New Object()
            Dim format1 As IFormattable = $"{1000:C}"
            Dim ci = CultureInfo.GetCultureInfo("en-us")
#Region "実際にはこう展開される(変数名は変えてます)"
            Dim format2 As IFormattable = FormattableStringFactory.Create("{0:C}", 1000)
#End Region
            WriteLine(format1.ToString(Nothing, CultureInfo.GetCultureInfo("en-us")))
            WriteLine(format2.ToString(Nothing, CultureInfo.GetCultureInfo("en-us")))
        End With
    End Sub

    Private Sub IntroduceMultilineStringLiterals()
        Console.WriteLine("Hello
　　　　　　　　　　　　　　　World")
    End Sub

    Private Sub CommentsAfterImplicitLineContinuation()
        Dim result = From i In Enumerable.Range(1, 10) '１~１０までの数
                     Where i Mod 2 = 0                 '偶数のみ
                     Select i * i                      '２乗した数

        Console.WriteLine(String.Join(",", result))
    End Sub

    Private Sub IntroduceYearFirstDateLiterals()
        Dim today = #2015-08-29# '年は1000以上でないとBuild error
        Dim todayOnOldVersion = #08-29-2015# '年は100以上でないとBuild error
        WriteLine($"Old:{todayOnOldVersion}{vbCrLf}New:{today}")
    End Sub

    Private Sub IntroduceNullConditionalOperators(
                               ps As IReadOnlyList(Of Point),
                               Optional act As Action = Nothing)
        Dim p = ps?(0) 'これはIndexer

        Dim s = p?.ToString()
        WriteLine(If(s, "Null"))
        Dim x = p?.X
        WriteLine(If(x.HasValue, x.ToString(), "Null"))

        act?.Invoke()　'delegateの場合はInvoke()を使用する
    End Sub

    Private Sub IntroduceTypeofIsNot(arg As Object)
        If TypeOf arg IsNot String Then WriteLine(arg?.ToString())
        WriteLine(NameOf(System.String))
    End Sub

    <Sample(CObj(""), DataByInt32:=0)>
    Private Sub IntroduceCObjInAttributes()
        Throw New NotImplementedException()
    End Sub

    <AttributeUsage(AttributeTargets.All, AllowMultiple:=True, Inherited:=False)>
    Private NotInheritable Class SampleAttribute : Inherits Attribute
        Public Sub New(data As Object)
            Me.New(data?.ToString())
        End Sub
        Public Sub New(data As String)
            Me.Data = data
        End Sub
        Public ReadOnly Property Data As String
        Public Property DataByInt32 As Integer
    End Class

End Module
