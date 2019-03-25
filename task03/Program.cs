using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task03
{
    class Program
    {
        static void AgeCalculator(DateTime birthdate)
        {
            int age = DateTime.Now.Year - birthdate.Year;
            if (birthdate.DayOfYear > DateTime.Now.DayOfYear)
            {
                age--;
            }
            else if(DateTime.Now.Month < birthdate.Month || (DateTime.Now.Month == birthdate.Month && DateTime.Now.Day < birthdate.Day))
            {
                age--;
            }
            Console.WriteLine($"Your age is: {age}");
            Console.ReadLine();


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter birth date");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());
            AgeCalculator(birthdate);
        }
    }
}
