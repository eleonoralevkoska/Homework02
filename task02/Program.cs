using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task02
{
    class Program
    {
            public static void StudentGroup(string[] arr)
        {
            Console.WriteLine("The students are:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }


        }
            static void Main(string[] args)
        {

            string[] studentsG1 = new string[] {"Zdravko", "Petko", "Stanko", "Branko", "Trajko"};
            string[] studentsG2 = new string[] {"Zdravko2", "Petko2", "Stanko2", "Branko2", "Trajko2"};

            Console.WriteLine("Enter student group: ( there are 1 and 2 )");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {


                case 1:
                    StudentGroup(studentsG1);
                    break;
                case 2:
                    StudentGroup(studentsG2);
                    break;
                default:
                    Console.WriteLine("Error number");
                    break;
            }

            Console.ReadLine();
                      

        }


    }
}
