using System;

namespace SamplePrograms
{
    class Program
    {

//This method calculates the Greatest common divisor between two numbers
       private static void GreatestCommonDivisor()
        {
            ulong bigNum, smallNum;
            ulong remainder,gcd = 0;
            string yes;

            do
            {

                Console.WriteLine("Enter a number");
                bigNum = Convert.ToUInt64(Console.ReadLine());

                Console.WriteLine("Enter another number");
                smallNum = Convert.ToUInt64(Console.ReadLine());

                //check if big Number is greater than the small Number
                if(bigNum < smallNum)
                {
                    ulong holder;
                    holder = smallNum;
                    smallNum = bigNum;
                    bigNum = holder;
                }
                //calculate the gcd
                do
                {
                    remainder = bigNum % smallNum;
                    if (remainder == 0)
                    {
                        break; //break the code if remainder is 0. We found the gcd to be the small Number
                    }
                    else
                    {
                        bigNum = smallNum;
                        smallNum = remainder;
                    }
                } while (true); //while remainder != 0 

   
                Console.WriteLine("The GCD is " + smallNum);

                //ask user if they want to continue to other numbers
                Console.WriteLine("Enter Y to continue");
                yes = Console.ReadLine().ToUpper();

            } while (yes.Equals("Y"));
        }

//This method returns the fibonacci sequence
        private static void Fibonacci()
        {

            ulong F1 = 1, F2 = 1;
            ulong next = 0;
            int num = 0;

            //function to print fibonacci numbers 1 and 2
            void printF1F2()
            {
                Console.WriteLine("F1 is " + F1);
                Console.WriteLine("F2 is " + F2);
            }
            Console.WriteLine("Enter the number of the fibonacci sequence to see");
            //test for valid input
            while (!Int32.TryParse(Console.ReadLine(), out num) || num <= 0)
            {

                Console.WriteLine("Invalid Entry.  Please re-enter");
            }
           
            if (num == 1)
            {
                Console.WriteLine("F1 is " + F1);
            }
            else if (num == 2)
            {
                printF1F2();
            }
            else //calculations for user input greater than 2
            {
                printF1F2();
                for (int i = 3; i < num + 1; i++)
                {    
                    next = F1 + F2;
                    F1 = F2;
                    F2 = next;
                    Console.WriteLine("F" + i + " is " + next);
                    
                }
            }

            Console.ReadLine();
        }

        private static void modulo()
        {
            Console.WriteLine("Enter a number");
           ulong bigNum = Convert.ToUInt64(Console.ReadLine());

            Console.WriteLine("Enter another number");
           ulong smallNum = Convert.ToUInt64(Console.ReadLine());

            ulong ans = bigNum % smallNum;
            Console.WriteLine(ans);
            Console.ReadLine();
        }
    
            static void Main(string[] args)
        {
            //GreatestCommonDivisor();
            // Fibonacci();
            modulo();
        }
    }
}
