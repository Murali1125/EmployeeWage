using System;
using System.Text;
/* 
UC1: Start with Displaying welcome to Employee Wage Computation Program on Master Branch
UC2: Calculate Daily Employee Wage assume per hour wage =20 daily working hours 8
UC3: Add Part time Employee & Wage - Assume Part time Hour is 4
UC4: Solving using Switch Statement
UC5: Calculating Wages for a Month  Assume 20 Working Day per Month
UC6: Calculate Wages till a condition of total working hours or days is reached for a month - Assume 100 hours 
*/


namespace EmployeeWage
{
    class Program
    {
        static int days=20 ,
                   hours=0;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage");
            // create object for Program class
            Program obj_program = new Program();
            // call EmployeeWage function
            Program.MontlyEmpWage();
        }// end :  Main(string[] args)


        // method for montly employee wage calculation
        public static void MontlyEmpWage() {
            // monthly wage variable
            int total_monthly_wage = 0,
                maxdays=days;

            // cal Employeedailywage upto number of days times
            for (int i = 1; i <=maxdays; i++) {
                total_monthly_wage = total_monthly_wage + Program.EmployeeDailyWage(i);
                // break the loop  if hourse reached to 100 or days reached 20
                if (hours >= 100)
                {
                    days = i;
                    break;
                }//end : if (hours >= 100)
            }//end: for (int i = 1; i <= 20; i++)

            Console.WriteLine("Total monthly wage = " + total_monthly_wage);
            Console.WriteLine("Toal working hourse in the month " + hours);
            Console.WriteLine("Total working days in the month " + days);
        }//end: MontlyEmpWage()


        // employee daily wage method
        public static int EmployeeDailyWage(int day)
        {
            // Variables 
            int attandance,
                wage_per_hour=20,
                fullDay_hours=8,
                parttime_hours=4,
                total_day_wage=0,
                temp_hours=0;

            // generating random number if the number=  0 absent ,  1 fulltime_present, 2 parttime_present
            Random random = new Random();
            attandance = random.Next(0,3);
            switch (attandance) {
                case 1:
                    if (hours + fullDay_hours > 100)
                    {
                        temp_hours = 100 - hours;
                        hours = 100;
                    }// end: if (hours + fullDay_hours > 100)
                    else
                    {
                        hours += fullDay_hours;
                        temp_hours = fullDay_hours;
                    }// end : else -> if (hours + fullDay_hours > 100)
                    break;
                case 2:
                    if (hours + parttime_hours > 100)
                    {
                        temp_hours = 100 - hours;
                        hours = 100;
                    }//end :  if (hours + parttime_hours > 100)
                    else
                    {
                        hours += parttime_hours;
                        temp_hours = parttime_hours;
                    }// end: else -> if (hours + parttime_hours > 100)
                    break;
            }//end:switch (attandance)
            total_day_wage = temp_hours * wage_per_hour;
            Console.Write(" day {0,2} wage ", day); 
            Console.WriteLine(total_day_wage);
            return total_day_wage;

        }// end:  EmployeeDailyWage()
    } // end: class Program
}// end : namespace EmployeeWage
