namespace PayProblem;

public class PayslipPrinter
{
    private readonly Employee _employee;

    public PayslipPrinter(Employee employee)
    {
        _employee = employee;
    }
    
    public void Print()
    {
        Console.WriteLine("\nYour payslip has been generated:\n");
        Console.WriteLine("Name: " + _employee.Name + " " + _employee.Surname);
        Console.WriteLine("Pay Period: " + _employee.Payslip._startDate + " - " + _employee.Payslip._endDate);
        Console.WriteLine("Gross Income: " + _employee.Payslip.GetGrossAmount());
        Console.WriteLine("Income Tax: " + _employee.Payslip.GetIncomeTax());
        Console.WriteLine("Net Income: " + _employee.Payslip.GetNetIncome());
        Console.WriteLine("Super: " + _employee.Payslip.GetSuperAmount());
        Console.WriteLine("\nThank you for using MYOB!");
        Console.WriteLine("~~~");
    }
}