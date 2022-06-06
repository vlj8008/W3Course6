using System;

namespace W3Course6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exception handlings

            //int[] myNumbers = { 1, 2, 3 };
            //Console.WriteLine(myNumbers[10]); // gives error message:
            // Outside the bounds of the array.

            // Try / Catch / Finally

            try
            {
                int[] myNum = { 1, 2, 3 };
                Console.WriteLine(myNum[10]);

            }

            catch(Exception )// if error occurs do this:
            {
                //Console.WriteLine(e.Message); // returns "index was outside bounds of array.

                Console.WriteLine("Something went wrong");
                
            }

            finally // lets you execute code, after try... catch, regardless 
            {
                Console.WriteLine("I believe this line always gets executed");
            }

            // throw keyword - allows you to create custom errors. 

            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();
            int ageCorrect = Convert.ToInt32(age);

            checkAge(ageCorrect);

            static void checkAge(int ageCorrect)
            {
                if (ageCorrect < 18)
                {
                    
                    throw new ArithmeticException(" Your age is " + ageCorrect + "You must be at least 18");
                }

                else
                {
                    Console.WriteLine("you are old enough !");
                }
            }


        }
    }
}
