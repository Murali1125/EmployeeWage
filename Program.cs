using System;
using System.Text;
/* 
UC1: Start with Displaying welcome to Employee Wage Computation Program on Master Branch
UC2: Calculate Daily Employee Wage assume per hour wage =20 daily working hours 8
UC3: Add Part time Employee & Wage - Assume Part time Hour is 4
UC4: Solving using Switch Statement
UC5:  Calculating Wages for a Month  Assume 20 Working Day per Month
*/


namespace EmployeeWage
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage");
            // create object for Program class
            Program obj_program = new Program();
            // call EmployeeWage function
            obj_program.MontlyEmpWage();
        }// end :  Main(string[] args)


        // method for montly employee wage calculation
        public void MontlyEmpWage() {
            // monthly wage variable
            int total_monthly_wage = 0;
            // cal 20 times Employeedailywage
            for (int i = 1; i <= 20; i++) {
                total_monthly_wage = total_monthly_wage + Program.EmployeeDailyWage(i);
            }//end: for (int i = 1; i <= 20; i++)

            Console.WriteLine("Total monthly wage = " + total_monthly_wage);
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
            Console.WriteLine(attandance);
            switch (attandance) {
                case 1:
                    temp_hours = fullDay_hours;
                    break;
                case 2:
                    temp_hours = parttime_hours;
                    break;
            }//end:switch (attandance)
            total_day_wage = temp_hours * wage_per_hour;
            Console.Write(" day {0,2} wage ", day); 
            Console.WriteLine(total_day_wage);
            return total_day_wage;

        }// end:  EmployeeDailyWage()
    } // end: class Program
}// end : namespace EmployeeWage
