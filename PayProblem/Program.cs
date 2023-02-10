// See https://aka.ms/new-console-template for more information
using System;
using System.Text.RegularExpressions;
using PayProblem;

//variables
string name = "";
string surname = "";
int annualSalary = 0;
int superRate = 0;
string startDate = "";
string endDate = "";

//variables to check validation
bool validSalary = false;
bool validRate = false;
bool validDate = false;
bool checkErrorSalary = false;
bool checkErrorRate = false;
bool checkMonthName = false;

//regular expression
string namePattern = @"^[A-Z][a-zA-Z]*$";
string datePattern = @"^\d{1,2}\s[A-Z][a-z]*$";
Regex nameRegex = new Regex(namePattern);
Regex dateRegex = new Regex(datePattern);

Console.Write("Welcome to the payslip generator!\n\n");
Console.Write("Please input your name: ");

name = Console.ReadLine();

Match m = nameRegex.Match(name);

//check for valid name
while (!m.Success)
{
    Console.WriteLine("Name should only contain letters and begin with an uppercase letter.");
    Console.Write("Please try again: ");
    name = Console.ReadLine();
    m = nameRegex.Match(name);
}

Console.Write("Please input your surname: ");
surname = Console.ReadLine();

m = nameRegex.Match(surname);

//check for valid surname
while (!m.Success)
{
    Console.WriteLine("Name should only contain letters and begin with an uppercase letter.");
    Console.Write("Please try again: ");
    surname = Console.ReadLine();
    m = nameRegex.Match(surname);
}

Console.Write("Please enter your annual salary: ");

//check for valid salary
do
{
    checkErrorSalary = int.TryParse(Console.ReadLine(), out annualSalary);

    if (annualSalary < 0)
    {
        Console.WriteLine("Salary cannot be a negative value.");
        Console.Write("Please try again: ");
    }
    else if (!checkErrorSalary)
    {
        Console.WriteLine("Invalid salary value.");
        Console.Write("Please try again: ");

        //clear buffer
        while (Console.KeyAvailable)
            Console.ReadKey(false);
    }
    else
    {
        validSalary = true;
    }
} while (!checkErrorSalary || !validSalary);

Console.Write("Please enter your super rate: ");

//check for valid rate
do
{
    checkErrorRate = int.TryParse(Console.ReadLine(), out superRate);
    
    if (superRate < 0)
    {
        Console.WriteLine("Super rate cannot be a negative value.");
        Console.Write("Please try again: ");
    }
    else if (!checkErrorRate)
    {
        Console.WriteLine("Invalid rate value.");
        Console.Write("Please try again: ");
        
        //clear buffer
        while (Console.KeyAvailable)
            Console.ReadKey(false);
    }
    else
    {
        validRate = true;
    }
} while (!checkErrorRate || !validRate);

Console.Write("Please enter your payment start date: ");
//startDate = Console.ReadLine();
Match d = dateRegex.Match(startDate);

//check for correct date format
do
{
    startDate = Console.ReadLine();
    d = dateRegex.Match(startDate);

    if (!d.Success)
    {
        Console.WriteLine("Invalid date!");
        Console.Write("Please try again: ");
    }
    else
    {
        //check whether input is a date
        string[] date = startDate.Split(' ');

        MonthEnum enumValue;

        checkMonthName = MonthEnum.TryParse(date[1], out enumValue);

        if (!checkMonthName)
        {
            Console.Write("Invalid month name.\nPlease try again: ");
        }
        else
        {
            //check for valid date
            int day = int.Parse(date[0]);
            switch (enumValue)
            {
                case MonthEnum.January :    //fall through
                case MonthEnum.March :      //fall through
                case MonthEnum.May :        //fall through
                case MonthEnum.July :       //fall through
                case MonthEnum.August :     //fall through
                case MonthEnum.October :    //fall through
                case MonthEnum.December :
                    if (day is > 0 and <= 31)
                    {
                        validDate = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid date!");
                        Console.Write("Please try again: ");
                    }
                    break;
                case MonthEnum.February :
                    if (day is > 0 and <= 28)
                    {
                        validDate = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid date!");
                        Console.Write("Please try again: ");
                    }
                    break;
                case MonthEnum.April :      //fall through
                case MonthEnum.June :       //fall through
                case MonthEnum.September :  //fall through
                case MonthEnum.November :
                    if (day is > 0 and <= 30)
                    {
                        validDate = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid date!");
                        Console.Write("Please try again: ");
                    }
                    break;
            }
        }
    }
} while (!d.Success || !validDate);

Console.Write("Please enter your payment end date: ");
endDate = Console.ReadLine();

validDate = false;
d = dateRegex.Match(endDate);

//check for correct date format
do
{
    endDate = Console.ReadLine();
    d = dateRegex.Match(endDate);

    if (!d.Success)
    {
        Console.WriteLine("Invalid date!");
        Console.Write("Please try again: ");
    }
    else
    {
        //check whether input is a date
        string[] date = endDate.Split(' ');

        MonthEnum month;

        checkMonthName = MonthEnum.TryParse(date[1], out month);

        if (!checkMonthName)
        {
            Console.Write("Invalid month name.\nPlease try again: ");
        }
        else
        {
            //check for valid date
            int day = int.Parse(date[0]);
            switch (month)
            {
                case MonthEnum.January :    //fall through
                case MonthEnum.March :      //fall through
                case MonthEnum.May :        //fall through
                case MonthEnum.July :       //fall through
                case MonthEnum.August :     //fall through
                case MonthEnum.October :    //fall through
                case MonthEnum.December :
                    if (day is > 0 and <= 31)
                    {
                        validDate = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid date!");
                        Console.Write("Please try again: ");
                    }
                    break;
                case MonthEnum.February :
                    if (day is > 0 and <= 28)
                    {
                        validDate = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid date!");
                        Console.Write("Please try again: ");
                    }
                    break;
                case MonthEnum.April :      //fall through
                case MonthEnum.June :       //fall through
                case MonthEnum.September :  //fall through
                case MonthEnum.November :
                    if (day is > 0 and <= 30)
                    {
                        validDate = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid date!");
                        Console.Write("Please try again: ");
                    }
                    break;
            }
        }
    }
} while (!d.Success || !validDate);

//Payslip payslip1 = new Payslip(name, surname, annualSalary, superRate, startDate, endDate);

Employee employee = new Employee(name, surname, new Payslip(annualSalary, superRate, startDate, endDate));
PayslipPrinter payslip = new PayslipPrinter(employee);

payslip.Print();

public enum MonthEnum
{
    January = 1,
    February = 2,
    March = 3,
    April = 4,
    May = 5,
    June = 6,
    July = 7,
    August = 8, 
    September = 9,
    October = 10,
    November = 11,
    December = 12
}