using System;
using System.Text;
/* 
UC1: Start with Displaying welcome to Employee Wage Computation Program on Master Branch
UC2: Calculate Daily Employee Wage assume per hour wage =20 daily working hours 8
UC3: Add Part time Employee & Wage - Assume Part time Hour is 4
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
            obj_program.EmployeeWage();
        }// end :  Main(string[] args)
        public void EmployeeWage()
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
            if(attandance == 1)
            { temp_hours = fullDay_hours; }//end: if(attandance == 1)
            else if(attandance == 2 )
            { temp_hours = parttime_hours; } // end: else if(attandance ==2 )
            total_day_wage = temp_hours * wage_per_hour;
            Console.WriteLine(total_day_wage);
        }// end:  EmployeeWage()
    } // end: class Program
}// end : namespace EmployeeWage
