using System;
class Payroll {

    static void Main(string[] args) { 
    
        string employeeName;
        double hoursWorked, BasicPay, Overtime_worked, time_in, time_out, Employee_ID;

        Console.WriteLine("-----Payroll System-----");
        Console.WriteLine(" Input the Employee's Worked Information and such.");
        Console.Writeline("-----------------");

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

        Console.Write("Enter Overtime worked per Hour: ");
        Overtime_worked = Convert.ToDouble(Console.ReadLine()); 

        Console.Write(" enter Hours Worked: ");
        hoursWorked = Convert.ToDouble(Console.ReadLine());

        





    }
}
