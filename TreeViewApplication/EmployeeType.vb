Public Class EmployeeType
	Private memptype As String
	Private memployees As List(Of Employee)

	Public Sub New(pEmpType As String)
		Employees = New List(Of Employee)
		EmpType = pEmpType
	End Sub

	Public Property EmpType() As String
		Get
			Return memptype
		End Get
		Set(value As String)
			memptype = value
		End Set
	End Property

	Public Property Employees() As List(Of Employee)
		Get
			Return memployees
		End Get
		Set(value As List(Of Employee))
			memployees = value
		End Set
	End Property
End Class
