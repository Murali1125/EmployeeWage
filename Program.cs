using System;
using System.Collections.Generic;
/* 
UC1: Start with Displaying welcome to Employee Wage Computation Program on Master Branch
UC2: Calculate Daily Employee Wage assume per hour wage =20 daily working hours 8
UC3: Add Part time Employee & Wage - Assume Part time Hour is 4
UC4: Solving using Switch Statement
UC5: Calculating Wages for a Month  Assume 20 Working Day per Month
UC6: Calculate Wages till a condition of total working hours or days is reached for a month - Assume 100 hours 
UC7: Refactor the Code to write a function to get work hours
UC8: Store the Daily Wage along with the Total Wage
*/


namespace EmployeeWage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage");
            // creating list to store save companies
            var company_name = new List<string>();
            company_name.Add("Bridgelabzs");
            company_name.Add("SRRprojects");
            // create dictionary to store comapny and total montly wage
            Dictionary<string, int> com_wage = new Dictionary<string, int>();
            // create object for Employee for each company

            foreach (string s in company_name)
            {
                  Employee obj_emp = new Employee(s);
                 //call EmployeeWage function
                 int month_total_wage = obj_emp.MontlyEmpWage();
              com_wage.Add(s, month_total_wage);
            }//end :  for (string s in company_name)
            
        }// end :  Main(string[] args)


    } // end: class Program
    public class Employee
    {
        // variables
        public int max_days,
            total_monthly_wage,
            max_hours,
            wage_per_hour,
            hours=0;
        string company_name;
       
        
        // constructor for initilize default values
        public Employee(string company="Bridgelabz")
        {
            this.max_days = 20;
            this.max_hours = 100;
            this.wage_per_hour = 20;
            this.company_name = company;
        }
        // constructor to initilize the variables
        public Employee (string company_name , int max_days, int max_hours, int wage_per_hour)
        {
            // initilizing variables
            this.max_days = max_days;
            this.wage_per_hour = wage_per_hour;
            this.max_hours = max_hours;
            this.company_name = company_name;

        }// end: Employee(string company_name, int max_days, int max_hours, int wage_per_hour)

        // method for montly employee wage calculation
        public int MontlyEmpWage()
        {
            Console.WriteLine("Welcome to {0} company wage computation",company_name);
            
            // create instance for Employeewage class
            Employee obj_empwage = new Employee(company_name);
            //variables
            int days = 0;
            int[] hr_wage = new int[2];
            // cal Employeedailywage upto number of days times
            for (int i = 1; i <= max_days; i++)
            {
                hr_wage = obj_empwage.EmployeeDailyWage(i);
                total_monthly_wage += hr_wage[0] ;
                hours = hr_wage[1];
                // break the loop  if hourse reached to 100 or days reached 20
                if (hours >= max_hours)
                {   days = i;
                    break;
                }//end : if (hours >= 100)
                days++;
            }//end: for (int i = 1; i <= maxdays i++)
            Console.WriteLine("Total monthly wage = " + total_monthly_wage);
            Console.WriteLine("Toal working hourse in the month " + hours);
            Console.WriteLine("Total working days in the month " + days);
            return total_monthly_wage;
        }//end: MontlyEmpWage()


        // employee daily wage method
        public int[] EmployeeDailyWage(int day)
        {
            // Variables 
            int attandance,
                fullDay_hours = 8,
                parttime_hours = 4,
                total_day_wage,
                temp_hours = 0;
            int[] arr = new int[2];
            // crating a Dictionary to store day and its value
            Dictionary<int, int> day_wage = new Dictionary<int, int>();

            // generating random number if the number=  0 absent ,  1 fulltime_present, 2 parttime_present
            Random random = new Random();
            attandance = random.Next(0, 3);
            // checking the employee full time or part time by using swith
            switch (attandance)
            {
                case 1:
                    // if hourse getting morethan 100 then assign max hourse to it ie 100
                    if ( ( hours + fullDay_hours) > max_hours)
                    {
                        temp_hours = max_hours - hours;
                        hours = max_hours;
                    }// end: if (hours + fullDay_hours > 100)
                    else
                    {
                        hours += fullDay_hours;
                        temp_hours = fullDay_hours;
                    }// end : else -> if (hours + fullDay_hours > 100)
                    break;
                case 2:
                    if (hours + parttime_hours > max_hours)
                    {
                        temp_hours = max_hours - hours;
                        hours = max_hours;
                    }//end :  if (hours + parttime_hours > 100)
                    else
                    {
                        hours += parttime_hours;
                        temp_hours = parttime_hours;
                    }// end: else -> if (hours + parttime_hours > 100)
                    break;
            }//end:switch (attandance)
            total_day_wage = temp_hours * wage_per_hour;
            // add day and corresponding wage in a dictionary
            day_wage.Add(day, total_day_wage);
            Console.Write(" day {0,2} wage ", day);
            Console.WriteLine(total_day_wage);
            arr[0] = total_day_wage;
            arr[1] = hours;
            return arr;
        }// end:  EmployeeDailyWage()
    } // end: class EmployeeWage
}// end : namespace EmployeeWage
