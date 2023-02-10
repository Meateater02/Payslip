namespace PayProblem;

public class Employee
{
    public string Name { get; }
    public string Surname { get; }
    public Payslip Payslip { get; }
    
    //constructor
    public Employee(string name, string surname, Payslip payslip)
    {
        Name = "";
        Surname = "";
        //_annualSalary = 0;
        //_superRate = 0;
        Payslip = payslip;
    }
}