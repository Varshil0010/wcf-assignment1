using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wcf_assignment1_console
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int num1;
            string num2;
            string value1;
            string value2;
            int number1;
            int number2;

            wcfAssignment1.Service1Client service1Client = new wcfAssignment1.Service1Client();

            string select = "";

            while (!select.Equals("6"))
            {
                Console.WriteLine("WCF Assignment 1");
                Console.WriteLine("1. Prime Number");
                Console.WriteLine("2. Sum of digits");
                Console.WriteLine("3. Reverse a string");
                Console.WriteLine("4. Print HTML tags");
                Console.WriteLine("5: Sort 5 numbers");
                Console.WriteLine("6. Exit");
                Console.WriteLine("\tEnter your choice");
                select = Console.ReadLine();

                if (select == "1")
                {
                    Console.WriteLine("Enter a one number");
                    num1 = Convert.ToInt32(Console.ReadLine());

                    num2 = service1Client.primeNumber(num1);
                    Console.WriteLine(num2);

                }
                else if (select == "2")
                {
                    Console.WriteLine("Enter a number");
                    num1 = Convert.ToInt32(Console.ReadLine());

                    num2 = service1Client.sumOfDigits(num1);
                    Console.WriteLine(num2);
                }
                else if (select == "3")
                {
                    Console.WriteLine("Enter any string");
                    value1 = Convert.ToString(Console.ReadLine());

                    value2 = service1Client.reverseString(value1);
                    Console.WriteLine(value2);
                }
                else if (select == "4")
                {
                    Console.WriteLine("You select 4");
                }
                else if(select == "5")
                {
                    Console.WriteLine("Enter five numbers");
                    number1 = Convert.ToInt32(Console.ReadLine());

                    number2 = service1Client.sortNumber(number1);
                    Console.WriteLine(number2);

                }
            }


        }
    }
}
