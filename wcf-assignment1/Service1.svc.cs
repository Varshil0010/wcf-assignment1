using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace wcf_assignment1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string primeNumber(int primeNum)
        {
            int a;

            for (a = 2; a <= primeNum / 2; a++)
            {
                if (primeNum % a == 0)
                {
                    break;
                }
            }
            if (a > primeNum / 2)
            {
                return "Number is Prime";
            }
            else
            {
                return "Number is not Prime";
            }
        }

        public string sumOfDigits(int sum)
        {
            int total = 0;
            while (sum != 0)
            {
                total += sum % 10;
                sum /= 10;
            }
            return "Total is: " + total;
        }

        public string reverseString(string reverse)
        {
            char[] reverseArray = reverse.ToCharArray();
            string output = String.Empty;
            for (int i = reverseArray.Length - 1; i > -1; i--)
            {
                output += reverseArray[i];
            }
            return output;
        }

        public int[] sortNumber(int[] sortNum)
        {
            sortNum = new int[5];
            Console.WriteLine("1. Ascending");
            Console.WriteLine("2. Descending");

            string sort = "";
            int output;
            int output1;
            if (sort == "1")
            {
                Console.WriteLine("Sorted array in ASC order");
                Array.Sort(sortNum);
                foreach (int i in sortNum)
                {
                    output = i;
                }
                return sortNum;
            }

            else if(sort == "2")
            {
                Console.WriteLine("Sorted array in DESC order");
                // Sort Array in DESC order
                Array.Reverse(sortNum);
                foreach (int i in sortNum)
                {
                    output1 = i;
                }
                return sortNum;
            }
            return null;
            
        }
    }
}


