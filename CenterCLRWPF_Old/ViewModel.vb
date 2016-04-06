Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Linq.Expressions
Imports System.IO

Public Class ViewModel
    Implements INotifyPropertyChanged

    Private _familyName As String
    Property FamilyName As String
        Get
            Return _familyName
        End Get
        Set(value As String)
            If _familyName = value Then Return
            _familyName = value
            RaisePropertyChanged()
            RaisePropertyChanged("FullName")
        End Set
    End Property

    Private _name As String
    Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            If _name = value Then Return
            _name = value
            RaisePropertyChanged()

            '手抜きです
            Dim f As Expression(Of Func(Of String)) = Function() FullName
            RaisePropertyChanged(CType(f.Body, MemberExpression).Member.Name)
        End Set
    End Property

    ReadOnly Property FullName As String
        Get
            Return String.Concat(FamilyName, "　", Name)
        End Get
    End Property

#Region "INotifyPropertyChanged"
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Sub RaisePropertyChanged(<CallerMemberName> Optional propertyName As String = Nothing)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub
#End Region

End Class
