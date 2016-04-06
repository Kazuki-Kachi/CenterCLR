Module Program

    Sub Main()

    End Sub

    <AttributeUsage(AttributeTargets.All, AllowMultiple:=True, Inherited:=False)>
    Private NotInheritable Class SampleAttribute : Inherits Attribute
        Public Sub New(data As Object)
            Me.New(If(data Is Nothing, Nothing, data.ToString()))
        End Sub
        Public Sub New(data As String)
            _data = data
        End Sub

        Private ReadOnly _data As String
        Public ReadOnly Property Data As String
            Get
                Return _data
            End Get
        End Property
        Public Property DataByInt32 As Integer
    End Class
End Module
