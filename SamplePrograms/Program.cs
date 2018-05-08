using System;
using System.Globalization;

namespace SamplePrograms
{
    class Program
    {

        //This method calculates the Greatest common divisor between two numbers
        private static void GreatestCommonDivisor()
        {
            long bigNum, smallNum;
            long remainder;
            string yes;

            do
            {

                Console.WriteLine("Enter a number");
                while (!Int64.TryParse(Console.ReadLine(), out bigNum)) {
                    Console.WriteLine("Invalid Input. Please re-enter");
                }

                Console.WriteLine("Enter another number");
                while (!Int64.TryParse(Console.ReadLine(), out smallNum))
                {
                    Console.WriteLine("Invalid Input. Please re-enter");
                }

                //check if big Number is greater than the small Number
                if (bigNum < smallNum)
                {
                    long holder;
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

        //Factorial Calculation
        private static long Fact(int num)
        {
            long factorial = 1;
            if (num == 0)
            {
                return 1;
            }
            else
            {
                for (int i = num; i >= 1; i--)
                {
                    factorial *= i;
                }

            }
            return factorial;
        }

        //Parallel Arrays   
        private static void ParallelArrays()
        {
            string[] Names = { "Rick Sanchez", "Morty Smith", "Jerry Smith", "Beth Smith", "Summer Smith" };
            string[] Phone = { "555-1334", "555-3882", "555-8211", "555-1617", "555-2803" };
            string strSearch;

            //prompt user
            Console.WriteLine("Type a name to search for in the phone book:");
            strSearch = Console.ReadLine();

            for (int i = 0; i < Names.Length; i++)
            {
                if (Names[i].IndexOf(strSearch) > -1)
                {
                    Console.WriteLine(Names[i] + " -> " + Phone[i]);
                }

            }
            Console.ReadLine();
        }

        //Experimenting with strings
        private static void FunWithStrings()
        {
            char[] test = { };
            string name = "Edge Tech Academy";
            Console.WriteLine("My name is '" + name + "' and it is " + name.Length + " characters long");

            bool hasTech = name.Contains("Tech");
            Console.WriteLine("Does my name contain Tech? " + (hasTech ? "Why yes it does!" : "No Tech :-("));

            bool isBoring = name.Contains("boring stuff");
            Console.WriteLine("Does my name contain 'boring stuff'? " + (isBoring ? "Not So!" : "All exciting stuff"));

            bool ending = name.EndsWith("h Academy");
            Console.WriteLine("Does my name end with 'h Academy'? " + (ending ? "yup" : "nope"));

            bool starting = name.StartsWith("Edge");
            Console.WriteLine("Does my name start with 'Edge'? " + (starting ? "yup" : "nope"));

            bool doTheyMatch = name.Equals("EDGE tech ACADemy");
            Console.WriteLine("Are they equal? " + (doTheyMatch ? "yup" : "nope"));

            bool ignoreCase = name.Equals("EDGE tech ACADemy", StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine("Can I compare and ignore case? " + (ignoreCase ? "yup" : "nope"));

            name.CopyTo(0, test, name.IndexOf('y'), 3);
            Console.WriteLine(test);

            int eIndex = name.IndexOf("e");
            while (eIndex >= 0)
            {
                Console.WriteLine("Found 'e' at: " + eIndex);
                eIndex = name.IndexOf("e", eIndex + 1);
            }
            string newString = name.Insert(9, ">HELLO!<");
            Console.WriteLine(newString);

            int dIndex = name.LastIndexOf('d');
            Console.WriteLine("Found last 'd' at: " + dIndex);

            string[] aNames = name.Split(" ");
            foreach (string str in aNames)
            {
                string padLeft = str.PadLeft(15, '.');
                string padRight = str.PadRight(15, '_');
                Console.WriteLine("Pad Left ->" + padLeft);
                Console.WriteLine("Pad Right ->" + padRight);

                Console.WriteLine("Unpad " + padLeft.Trim('.'));
                Console.WriteLine("Unpad " + padRight.Trim('_'));
            }

            string nickName = name.Remove(4);
            Console.WriteLine(nickName);

            Console.WriteLine("Chop characters out of the middle: " + name.Substring(7, 8));

            Console.WriteLine("Look Ma! No 'e's! " + name.Replace('e', '_'));

            Console.WriteLine("UPPER CASE: " + name.ToUpper());
            Console.WriteLine("lower case: " + name.ToLower());
            Console.ReadLine();
        }

        //Methods- Random Number / The guessing game
        private static int RandomNumber(int min, int max)
        {

            Random random = new Random();
            return random.Next(min, max);
        }

        private static void GuessNumber()
        {
            long num;
            string response;

            do
            {
                int rand = RandomNumber(1, 100); //generate a random number and assign to variable rand.
                //ask user for an input
                Console.WriteLine("Hey You! Give me a number!");
                //test for a valid input; ensure it is a number
                while (!Int64.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Invalid number! Try again");
                }
                int numberOfGuesses = 1;
                //here's the guessing game logic. 
                //while the user's guess is not equal to the random Number, stay in this while loop
                //test if the user's guess is greater than or less than the random number
                while (num != rand)
                {
                    numberOfGuesses++;
                    if (num > rand)
                    {
                        Console.WriteLine("Thats too high!Try again");
                    }
                    else if (num < rand)
                    {
                        Console.WriteLine("Thats too low! Try again");
                    }
                    //below while loop asks the user for another guess if the previous guess is less than or greater than
                    //the random number
                    while (!Int64.TryParse(Console.ReadLine(), out num))
                    {
                        Console.WriteLine("Invalid number! Try again");
                    }
                }

                Console.WriteLine("Your guess was right!");
                Console.WriteLine("Number of guesses: " + numberOfGuesses++);
                //ask if the user wants to continue the game
                Console.WriteLine("Wanna play again? type Y to continue");
                //response holds the user's input and converts it to an upper case.
                //any response other than Y means the game is over.
                response = Console.ReadLine().ToUpper();

            } while (response.Equals("Y")); //go back to the beginning of the do..while loop if response is Y.
        }


        //Calculate what century a year is
        private static int CalculateCentury(int year)
        {
            //int century = (year % 100 == 0) ? year / 100 : year / 100 + 1;
            // return century  ;
            return year / 100 + ((year % 100 == 0) ? 0 : 1);
        }


        //Add weeks to a date
        static DateTime CalculateDueDate(DateTime date, int NoOfWeeks)
        {
            Calendar myCal = CultureInfo.InvariantCulture.Calendar;
            myCal.AddWeeks(date, NoOfWeeks);
            return myCal.AddWeeks(date, NoOfWeeks);
        }

        //Method to get numbers from users
        public static int GetNumber(string prompt)
        {
            int userNumber;
            string strNumber;
            do
            {
                strNumber = GetInput(prompt + " ");
                if (Int32.TryParse(strNumber, out userNumber))
                {
                    break;
                }
                Console.WriteLine("Not an integer. Please Reenter.");
            } while (true);

            return userNumber;
        }
        //Method to read Input from user
        public static string GetInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
        //function to return the larger of two numbers
        public static void LargerNumber(int num1, int num2)
        {
            if (num1 > num2)
            {
                Console.WriteLine(num1 + " is larger than " + num2);
            }

            else
            {
                Console.WriteLine(num2 + " is larger than " + num1);
            }
        }

        //function to return the smaller of two numbers
        public static void SmallerNumber(int num1, int num2)
            {
                Console.WriteLine((num1 < num2) ? num1 + " is smaller " : num2 + " is smaller");
            }

        //function to return number of words in a string
        public static void NumberOfWords(string Astring)
        {
            string[] words = Astring.Split(" ");
            
            Console.WriteLine("Number of Words in your input is " + words.Length);
        }
        //function to return longest word in a string
        public static void FindLongestWord(string Astring)
        {
            string[] words = Astring.Split(" ");
            string longestWord = words[0];
            foreach(string word in words){
                if(word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }
            Console.WriteLine("Longest Word is  " + longestWord);
        }

        //function
        public static void AddNames(int Number)
        {
            string[] names = new string[Number];
            for (int i = 0; i < names.Length ; i++)
            {
                names[i] = GetInput("Enter name " + (i+1) + ": ");              
            }
            Console.WriteLine(" ");
            Console.Write("Your Names are : ");
            foreach (string name in names)
            {
                Console.Write(name + " ");
            }
        }
        //max of three values using tenary operator
        public static int Max(int a, int b, int c)
        {
            return a > b ? 
                ((a > c) ? a : c)
                : ((b > c) ? b : (c > a ? c : a));
                
               
        }
        //max of three values using if statements
        public static int Maxi(int a, int b, int c)
        {
            int max = 0;
            if ( a > b)
            {
                if(a > c)
                {
                    max = a;
                }
            }
            else if (b > c)
            {
                max = b;
            }
            else
            {
                max = c;
            }
            return max;
        }

        //find max of in an array
        public static int FindMax(int[] anArray)
        {
            int max = anArray[0];
            for (int i = 0; i < anArray.Length; i++)
            {
                if(anArray[i] > max)
                {
                    max = anArray[i];
                }
            }
            return max;
        }

        //Reverse an Array
        public static string[] ReverseArray(string[] anArray)
        {
            string temp;
            int size = anArray.Length - 1;
            int length = anArray.Length;
            for (int i = 0; i < length ; i++)
            {
                if (size >= (length/2) )
                {
                    temp = anArray[i];
                    anArray[i] = anArray[size];
                    anArray[size] = temp;
                    size--;
                }
                else {
                    break;
                }
            }
            return anArray;
        }

        //Reverse Array --more efficient way
        public static string[] ReverseArray2(string[] anArray)
        {
            string temp;
            for (int i = 0; i < anArray.Length/2; i++)
            {
                temp = anArray[i];
                anArray[i] = anArray[anArray.Length - 1 - i];
                anArray[anArray.Length - 1 - i] = temp;
            }
            return anArray;
        }
        
        //Convert temperature
        private static float ConvertTemp(string convertTo, float temperature)
        {
            switch (convertTo)
            {
                case "CtoF":
                    temperature = temperature * 9.0f / 5.0f + 32;
                    break;
                case "FtoC":
                    temperature = (temperature -32) * 5.0f / 9.0f;
                    break;
                default: 
                    break;
            }
            return temperature;
        }

        //find average
        private static float FindAverage(int[] anArray)
        {
            float total = 0;

            for (int i = 0; i < anArray.Length; i++)
            {
                total += anArray[i];
            }
           
            return total/anArray.Length;
        }

        //uppercase a word
        public static void UppercaseWordX(string word, int numToUpperCase)
        {
          string[] wordArray = word.Split(" ");
            if (numToUpperCase > wordArray.Length)
            {
                Console.WriteLine("null");
            }
            else
            {
                Console.WriteLine("\"" + wordArray[numToUpperCase].ToUpper() + "\"");
            }
        }

        //Random price,amount tendered generator
        public static void MakeChange()
        {
            string exit = "";
            Random rnd = new Random();
            while (!exit.Equals("x"))
            {
                int intPrice = rnd.Next(1, 100);
                decimal price = (decimal)intPrice / 100.00M + rnd.Next(10);
                int tendered = rnd.Next((int)price, (int)price + rnd.Next(20));
              //  string change = MakingChange(tendered, price);
               // exit = GetInput(change);
            }
        }
        //method to calculate the change due for an amt tendered and price of an item
      //  public static string MakingChange(int amtTendered, decimal price)
        //{
            //int Dollar = 0, Q=0, D=0, N=0, P=0;
            //decimal cent,coin;
            //string[] money = { "Q", "D", "N", "P" };
            //decimal[] denom = { .25M, .10M, .05M, .01M };
            //decimal remainder = amtTendered - price;


            //for (int i = 0; i < denom.Length; i++)
            //{
            //    coin = (int)(remainder / denom[i]);
            //    remainder %= denom[i];

            //}
            //Dollar = (int)((decimal)amtTendered - price);
            //cents = (decimal)amtTendered % price;

            //Q = (decimal)(cents % 0.25M);
            //rem = rem % ;
            
            //return Q + "Quarters" + D + "Dime" + N + "Nickel" + P + "Penny";
      //  }
        //method to calculate how many seconds in a given parameter
        public static int GetSeconds(string time)
        {
            int noOfSeconds = -1;

            switch (time.ToUpper())
            {
                case "S":
                    noOfSeconds = 1;
                    break;
                case "M":
                    noOfSeconds = 60;
                    break;
                case "H":
                    noOfSeconds = 3600;
                    break;
                case "D":
                    noOfSeconds = 3600 * 24;
                    break;
                case "W":
                    noOfSeconds = 3600 * 24 * 7;
                    break;
                case "Y":
                    noOfSeconds = 3600 * 24 * 7 * 52;
                    break;
                default:
                    break;

            }
            return noOfSeconds;
        }

        public static int GetSeconds(string time)
        {
            int noOfSeconds = -1;
            string[] array = { "S", "M", "H", "D", "W", "Y" };
            int[] arraySeconds = { };
            for (int i = 0; i < array.Length; i++)
            {
                arraySeconds[0] = 1;

            }

        }


            static void Main(string[] args)
            {
            // GreatestCommonDivisor();
            // Fibonacci();
            //Calling the Factorial method
            /* int num = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine(Fact(num));
             Console.ReadLine();*/

            //ParallelArrays();

            // FunWithStrings();
            //  GuessNumber();
            // CalculateCentury(2000);

            /* DateTime dueDate = CalculateDueDate(Convert.ToDateTime("2017-12-19"), 32);
            * Console.WriteLine(dueDate);
            * Console.WriteLine(dueDate.DayOfWeek);
            * Console.ReadLine();
            */
            //Test the Larger number function
            /*  int num1 = GetNumber("Enter an Integer: ");
              int num2 = GetNumber("Enter another Integer: ");
              LargerNumber(num1, num2);
              SmallerNumber(num1, num2);
              Console.ReadLine();
              */
            //Number of words in a string
            /*  string input = GetInput("Enter a string: ");
               NumberOfWords(input);
              //Largest word in a string
              FindLongestWord(input);
               Console.ReadLine();*/

            // AddNames(GetNumber("Enter a number"));
            // int larg =  max(2, 3, 5);
            //Console.WriteLine(larg);
            //Console.ReadLine();
            /* int ans = 3,  v1 = 4;
             Console.WriteLine( ans *= v1 - 1);
            Console.WriteLine(v1);
            ans = 3;  v1 = 4;
             Console.WriteLine(ans = ans * --v1);
            Console.WriteLine(v1);
             Console.ReadLine();*/


            /*Console.WriteLine(max(12, 8, 4));
             Console.ReadLine();*/

            /*  int[] array1 = { 1, 4, 6, 1, 3, 9, 0, -1, -6, 11 };
              int[] array2 = { -9, -7 , -11, -7, -88, -5, -10 };
              Console.WriteLine("Max is " + FindMax(array1));
              Console.WriteLine("Max is " + FindMax(array2));
              */

            //string[] arrayX = { "AAAAA", "BBBB", "CCC", "DD", "E" };
            string[] arrayX = { "AAAAA", "BBBB", "CCC", "DD", "E","A","B","C","E","F"};
            //string[] arrayY = { "Texas", "New York", "Washington", "Nevada" };
            string[] arrayY = { "1", "2", "3", "4","5","6","7","8","9","10","11","12","13","14","15","16","17","18","19","20" };
            /*   ReverseArray(arrayX);
               ReverseArray(arrayY);

               for (int i = 0; i < arrayX.Length; i++)
               {
                  Console.Write(arrayX[i] + " ");
               }
               Console.WriteLine();
               for (int i = 0; i < arrayY.Length; i++)
               {
                   Console.Write(arrayY[i] + " ");
               }
               */

            /* Console.WriteLine(ConvertTemp("CtoF", 100));
             Console.WriteLine(ConvertTemp("FtoC", 212));
             Console.WriteLine(ConvertTemp("CtoF", 0));
             Console.WriteLine(ConvertTemp("FtoC", 0));
             */
            /*
                        int[] array1 = { 1, 4, 6, 1, 3, 9, 0, -1, -6, 11 };
                        int[] array2 = { -9, -7, -11, -7, -88, -5, -10 };

                        Console.WriteLine("Average is " + FindAverage(array1));
                        Console.WriteLine("Average is " + FindAverage(array2));*/

            /* UppercaseWordX("This is a test", 3);
             UppercaseWordX("I love, my C# class", 1);
             UppercaseWordX("this is a longer string with more words", 5);
             UppercaseWordX("edge tech academy is located in hurst texas on bedford euless road", 8);
             UppercaseWordX("short string", 3);
             Console.ReadLine();
             */
            //Testing making change 
            string var = "";
            do
            {
                var = GetInput("Your Input: ");
                Console.WriteLine("No of seconds in " + var + ": " + GetSeconds(var) + "seconds");
                Console.WriteLine("Type Q to exit.");
            } while (!(var.ToUpper().Equals("Q")));
            
                
       
            //Console.ReadLine();
        }

        
    }
    }
