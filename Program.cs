using System;
using System.Text;
/* 
UC1: Start with Displaying welcome to Employee Wage Computation Program on Master Branch
UC2: Calculate Daily Employee Wage assume per hour wage =20 daily working hours 8
*/


namespace EmployeeWage
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage");
        }
        public void EmployeeWage()
        {
            // Variables 
            int attandance,
                wage_per_hour=20,
                fullDay_hours=8,
                total_day_wage;

            // generating random number if the number=  0 absent ,  1 present
            Random random = new Random();
            attandance = random.Next(0, 2);
            
            if(attandance == 1)
            {
                total_day_wage = fullDay_hours * wage_per_hour;

            }//end: if(attandance == 1)
        }// end:  EmployeeWage()
    } // end: class Program
}// end : namespace EmployeeWage
