Public Class Employee
	Private mempname As String
	Public Sub New(pempname As String)
		EmpName = pempname
	End Sub
	Public Property EmpName() As String
		Get
			Return mempname
		End Get
		Set(value As String)
			mempname = value
		End Set
	End Property
End Class
