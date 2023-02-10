namespace PayProblem;

public class Payslip
{
    public string _startDate { get; }
    public string _endDate { get; }
    private int _annualSalary { get; }
    private int _superRate { get; }
    
    //constructor
    public Payslip(int annualSalary, int superRate, string startDate, string endDate)
    {
        _annualSalary = annualSalary;
        _superRate = superRate;
        _startDate = startDate;
        _endDate = endDate;
    }

    //calculate income tax
    public int GetIncomeTax()
    {
        if (_annualSalary >= 18201 && _annualSalary <= 37000)
        {
            return Convert.ToInt32(((_annualSalary - 18200) * 0.19) / 12);
        }
        else if (_annualSalary >= 37001 && _annualSalary<= 87000)
        {
            return Convert.ToInt32(((_annualSalary - 37000) * 0.325 + 3572) / 12);
        }
        else if (_annualSalary >= 87001 && _annualSalary <= 180000)
        {
            return Convert.ToInt32(((_annualSalary - 87000) * 0.37 + 19822) / 12);
        }
        else if (_annualSalary >= 180001)
        {
            return Convert.ToInt32(((_annualSalary - 180000) * 0.45 + 54232) / 12);
        }
        else
        {
            return 0;
        }
    }

    //calculate gross income
    public int GetGrossAmount()
    {
        return Convert.ToInt32(_annualSalary / 12);
    }

    //calculate net income
    public int GetNetIncome()
    {
        return this.GetGrossAmount() - this.GetIncomeTax();
    }

    //calculate super amount 
    public int GetSuperAmount()
    {
        return Convert.ToInt32(this.GetGrossAmount() * _superRate / 100);
    }
}