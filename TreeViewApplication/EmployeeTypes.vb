Public Class EmployeeTypes
	Inherits List(Of EmployeeType)

	Public Sub New()
		Dim type As EmployeeType
		type = New EmployeeType("Managers")
		type.Employees.Add(New Employee("Shivani"))
		type.Employees.Add(New Employee("Krutika"))
		Me.Add(type)
	End Sub

End Class
