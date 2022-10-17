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
            int [] number1 = new int [5];
            string sort = "";
            string htmlValue;
            string stringValue;
            string htmlString;
            
            //wcfAssignment1.Service1Client service1Client = new wcfAssignment1.Service1Client(); 
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
                    Console.WriteLine("Enter a html tag");
                    htmlValue = Convert.ToString(Console.ReadLine());

                    Console.WriteLine("Enter a string");
                    stringValue = Convert.ToString(Console.ReadLine());

                    htmlString = service1Client.printHtmlTags(htmlValue, stringValue);
                    Console.WriteLine(htmlString);

                }
                else if(select == "5")
                {
                    enter: 
                    Console.WriteLine("Enter Asc or Desc");
                    sort = Convert.ToString(Console.ReadLine());
                    if (sort == "Asc")
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            Console.WriteLine("Enter number" + (i + 1));
                            number1[i] = int.Parse(Console.ReadLine());
                        }


                        int[] number2 = service1Client.sortNumber(number1);
                        // Ascending 
                        Console.Write("Ascending Sort : ");
                        for (int i = 0; i < 5; i++)
                        {
                            Console.Write(number2[i] + " ");
                        }
                    }
                    else if (sort == "Desc")
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            Console.WriteLine("Enter number" + (i + 1));
                            number1[i] = int.Parse(Console.ReadLine());
                        }

                        int[] number2 = service1Client.desSortNumber(number1);
                        // Descending
                        Console.WriteLine("Descending Sort :");
                        for (int i = 0; i < 5; i++)
                        {
                            Console.Write(number2[i] + " ");
                        }
                    }
                    else
                    {
                        goto enter;
                    }
                    

                }
            }


        }
    }
}
