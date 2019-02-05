using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int age;
            bool isValid = false;

            do
            {
                Console.Write("enter your age : ");
                userInput = Console.ReadLine();

                // do validation
                                
                if (IsPresent(userInput, "age") == true && IsInteger(userInput, "age") == true && IsWithInRange(userInput, "age", 18, 21) == true)
                    isValid = true;
                else
                    isValid = false;

                
            }
            while (isValid == false);

            // contine with rest of program

        }

        static bool IsInteger(string textIn, string itemName)
        {

            bool isOK;
            int num;

            isOK = int.TryParse(textIn, out num); // out means pass the un-initialised variable by reference

            if (isOK == true)
                return true;
            else
            {
                Console.WriteLine("{0} must be of type integer", itemName);
                return false;
            }

        }


        // check if a value is present
        static bool IsPresent(string textIn, string itemName)
        {
            
            if (textIn != "")
                return true;
            else
            {
                Console.WriteLine("You must enter a value for {0}", itemName);
                return false;
            }


        }


        static bool IsWithInRange(string textIn, string itemName, int min, int max)
        {
            int num = int.Parse(textIn);

            if (num >= min && num <= max)
                return true;
            else
            {
                Console.WriteLine("{0} must be withiin the range 18 - 21", itemName);
                return false;
            }

        }
    }
}
