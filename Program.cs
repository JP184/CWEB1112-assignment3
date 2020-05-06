using System;
using System.Collections.Generic;
namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declarations
            string answer;
            Employee[] PL = new Employee[20]; // Personnel Array
            Employee[] MK = new Employee[20]; // Marketing Array
            Employee[] IT = new Employee[20]; // IT Array
            Employee[] CS = new Employee[20]; // Computer Services Array
            Employee[] SL = new Employee[20]; // Sales Array
            Employee[] LG = new Employee[20]; // Legal Array
            Employee[] AC = new Employee[20]; // Accounting Array
            int iP = 0; // Counter for Personnel
            int iM = 0; // Counter for Marketing
            int iI = 0; // Counter for IT
            int iC = 0; // Counter for Computer Services
            int iS = 0; // Counter for Sales
            int iL = 0; // Counter for Legal
            int iA = 0; // Counter for Accounting
            double perTotal = 0; // Personnel Total Amount
            double marTotal = 0; // Marketing Total Amount
            double itTotal = 0; // IT Total Amount
            double csTotal = 0; // Computer Services Total Amount
            double slTotal = 0; // Sales Total Amount
            double lgTotal = 0; // Legal Total Amount
            double accTotal = 0; // Accounting Total Amount
            int num = 0; // Counter for billing

            //Logic

            //Initial Greeting
            Console.WriteLine("MPLS Dog Boarding");
            Console.WriteLine("-----------------");
            Console.WriteLine("This console application is used to create a HR console report.");
            Console.WriteLine("Would you like to add an employee?(Y/N)");
            Console.WriteLine("You may only add a total of 20 employees per department.\n");
            answer = Console.ReadLine();

            //Begin While Loop for entering in employees into HR Payroll
            while (answer == "Y")
            {
                Console.WriteLine("Which department do they belong to?");
                // Shows Department List and current entered employees
                Console.WriteLine($"Department List\n1 - Personnel, Employees: {iP}\n2 - Marketing, Employees: {iM}\n3 - Information Technology, Employees: {iI}\n4 - Computer Services, Employees: {iC}\n5 - Sales, Employees: {iS}\n6 - Legal, Employees: {iL}\n7 - Accounting, Employees: {iA}\n");
                int dep = Convert.ToInt32(Console.ReadLine());
                // Covers entering in employees into Personnel Department
                if (dep == 1)
                {
                    Employee newPerson = new Employee(dep);
                    PL[iP] = newPerson;
                    iP = iP + 1;
                    Console.WriteLine("Do you want to add an Employee? (Y/N)\n");
                    answer = Console.ReadLine();
                }
                // Covers entering in employees into Marketing Department
                else if (dep == 2)
                {
                    Employee newPerson = new Employee(dep);
                    MK[iM] = newPerson;
                    iM = iM + 1;
                    Console.WriteLine("Do you want to add an Employee? (Y/N)\n");
                    answer = Console.ReadLine();
                }
                // Covers entering in employees into IT Department
                else if (dep == 3)
                {
                    Employee newPerson = new Employee(dep);
                    IT[iI] = newPerson;
                    iI = iI + 1;
                    Console.WriteLine("Do you want to add an Employee? (Y/N)\n");
                    answer = Console.ReadLine();
                }
                // Covers entering in employees into Computer Services Department
                else if (dep == 4)
                {
                    Employee newPerson = new Employee(dep);
                    CS[iC] = newPerson;
                    iC = iC + 1;
                    Console.WriteLine("Do you want to add an Employee? (Y/N)\n");
                    answer = Console.ReadLine();
                }
                // Covers entering in employees into Sales Department
                else if (dep == 5)
                {
                    Employee newPerson = new Employee(dep);
                    SL[iS] = newPerson;
                    iS = iS + 1;
                    Console.WriteLine("Do you want to add an Employee? (Y/N)\n");
                    answer = Console.ReadLine();
                }
                // Covers entering in employees into Legal Department
                else if (dep == 6)
                {
                    Employee newPerson = new Employee(dep);
                    LG[iL] = newPerson;
                    iL = iL + 1;
                    Console.WriteLine("Do you want to add an Employee? (Y/N)\n");
                    answer = Console.ReadLine();
                }
                // Covers entering in employees into Accounting Department
                else if (dep == 7)
                {
                    Employee newPerson = new Employee(dep);
                    AC[iA] = newPerson;
                    iA = iA + 1;
                    Console.WriteLine("Do you want to add an Employee? (Y/N)\n");
                    answer = Console.ReadLine();
                }
            }
            num = 0;
            while(num < 20 && PL[num] != null)
            {
                perTotal = perTotal + (PL[num].wage * PL[num].hours);
                num++;
            }
            num = 0;
            while(num < 20 && MK[num] != null)
            {
                marTotal = marTotal + (MK[num].wage * MK[num].hours);
                num++;
            }
            num = 0;
            while(num < 20 && IT[num] != null)
            {
                itTotal = itTotal + (IT[num].wage * IT[num].hours);
                num++;
            }
            num = 0;
            while(num < 20 && CS[num] != null)
            {
                csTotal = csTotal + (CS[num].wage * CS[num].hours);
                num++;
            }
            num = 0;
            while(num < 20 && SL[num] != null)
            {
                slTotal = slTotal + (SL[num].wage * SL[num].hours);
                num++;
            }
            num = 0;
            while(num < 20 && LG[num] != null)
            {
                lgTotal = lgTotal + (LG[num].wage * LG[num].hours);
                num++;
            }
            num = 0;
            while(num < 20 && AC[num] != null)
            {
                accTotal = accTotal + (AC[num].wage * AC[num].hours);
                num++;
            }
            Console.WriteLine("Department Number | Department Name | Department Total Payroll Amount");
            Console.WriteLine($"0 - Personnel - ${perTotal}");
            Console.WriteLine($"0 - Marketing - ${marTotal}");
            Console.WriteLine($"0 - Information Technology - ${itTotal}");
            Console.WriteLine($"0 - Computer Services - ${csTotal}");
            Console.WriteLine($"0 - Sales - ${slTotal}");
            Console.WriteLine($"0 - Legal - ${lgTotal}");
            Console.WriteLine($"0 - Accounting - ${accTotal}");
            Console.WriteLine();
            Console.WriteLine("---------------------");
            Console.WriteLine("End HR Payroll Report");
            Console.WriteLine("---------------------");
        }

        class Employee
        {

            public string name { get; set; }
            public int dNum { get; set; }
            public double wage { get; set; }
            public double hours { get; set; }

            public Employee(string name, int dNum, double wage, double hours)
            {
                this.name = name;
                this.dNum = dNum;
                this.wage = wage;
                this.hours = hours;
            }
            public Employee()
            {
                Console.WriteLine("What is their name?");
                this.name = Console.ReadLine();
                Console.WriteLine($"What is {this.name}'s department number");
                this.dNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"What is {this.name}'s hourly wage?");
                this.wage = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("How many hours did they put in?");
                this.hours = Convert.ToDouble(Console.ReadLine());
            }
            public Employee(int a)
            {
                Console.WriteLine("What is their name?");
                this.name = Console.ReadLine();
                this.dNum = a;
                Console.WriteLine($"What is {this.name}'s hourly wage?");
                this.wage = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("How many hours did they put in?");
                this.hours = Convert.ToDouble(Console.ReadLine());
            }
            public override string ToString()
            {
                return String.Format($"---Name:{this.name} Department Number:{this.dNum} Hourly Wage:{this.wage} Hours Put In:{this.hours}---");
            }
        }
    }
}
