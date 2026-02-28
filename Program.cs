using System;
class Payroll {

    static void Main(string[] args) { 
    
        string employeeName;
        double hoursWorked, BasicPay, Overtime_worked_pay = 0.0, time_in, time_out, Employee_ID,
            Overtime_worked_per_hour = 0.0, biWeeklyBasic, lunchAllowance, grossPay, sss, pagibig, totalDeductions, netPay, Overtime_worked_hourly_pay;

        Console.WriteLine("-----Payroll System-----");
        Console.WriteLine(" Input the Employee's Worked Information and such.");
        Console.WriteLine("------------------------");

        Console.Write("Enter Employee Name: ");
        employeeName = Console.ReadLine();

        Console.Write("Enter Employee ID: ");
        Employee_ID = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Time In (12-hour format | EX. 9.00 for 9 AM): ");
        time_in = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Time Out (12-hour format | EX. 5.00 for 5 PM): ");
        time_out = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Basic Pay per MONTH: ");
        BasicPay = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Overtime Hours Worked: ");
        Overtime_worked_hourly_pay = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Hours Worked per Day: ");
        hoursWorked = Convert.ToDouble(Console.ReadLine());

        biWeeklyBasic = BasicPay / 2;

        if (hoursWorked > 4)
            lunchAllowance = 300;
        else
            lunchAllowance = 0;

        grossPay = biWeeklyBasic + lunchAllowance + Overtime_worked_pay;

        Overtime_worked_pay = Overtime_worked_per_hour * Overtime_worked_hourly_pay;
        Overtime_worked_hourly_pay = 600;
        
        sss = 500;
        pagibig = 200;
        totalDeductions = sss + pagibig;

        netPay = grossPay - totalDeductions;

        Console.WriteLine(",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,");
        Console.WriteLine("\n-----Bi-Weekly Payroll Summary-----");
        Console.WriteLine("`````````````````````````````````````");
        Console.WriteLine("Employee Name: " + employeeName);
        Console.WriteLine("Employee ID: " + Employee_ID);
        Console.WriteLine("Bi-Weekly Basic Pay: " + biWeeklyBasic);
        Console.WriteLine("Overtime Pay: " + Overtime_worked_hourly_pay);
        Console.WriteLine("Lunch Allowance: " + lunchAllowance);
        Console.WriteLine("Gross Pay: " + grossPay);
        Console.WriteLine("SSS Deduction: " + sss);
        Console.WriteLine("Pag-IBIG Deduction: " + pagibig);
        Console.WriteLine("Total Deductions: " + totalDeductions);
        Console.WriteLine("Net Pay: " + netPay);
    }
}