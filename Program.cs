using System;
using System.Text;

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
            int attandance;
            // generating random number if the number=  0 absent ,  1 present
            Random random = new Random();
            attandance = random.Next(0, 2);
        }
              
    }
}
