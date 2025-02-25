using System;

public class Finance
{
	private readonly EmployeeSeperator employeeSeperator;
	public Finance(Employee employeeSeperator)
	{
		this.employeeSeperator = employeeSeperator;
		//Subscribing event
		employeeSeperator.EmployeeSeperated += EmployeeSeperatedEventHandler;

    }

	public void EmployeeSeperatedEventHandler()
	{
		Console.WriteLine("Finance department: employee seperation process related to finance");
	}
}
