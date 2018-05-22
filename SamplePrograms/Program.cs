using System;
using System.Collections.Generic;
using System.Globalization;

namespace SamplePrograms
{
    class Program
    {
        //main

        static void Main(string[] args)
        {
            while (true)
            {
                switch (GetInput("Enter menu:  "))
                {
                    case "exit": return;
                    case "x": return;
                    case "":
                    case "menu":
                        Console.WriteLine(
                            "\tifmax\tenmax\tconverttemp\tfindmax\tfindavg\tgcd\tarray\n" +
                            "\treverse\tphoneword\tfib\tfact\tstringnum\tlongestword\tmakechange\n" +
                            "\tstrings\tguess\tlargernum\tsmallernum\ttouppercase\tlist\\tfill\n" +
                            "\tcentury\tenglish\tmult\tisword\texit");
                        break;
                    case "ifmax":
                        int a, b, c;
                        a = GetNumber("Enter num 1: ");
                        b = GetNumber("Enter num 2: ");
                        c = GetNumber("Enter num 3: ");
                        Maxi(a, b, c); break;
                    case "tenmax":
                        a = GetNumber("Enter num 1: ");
                        b = GetNumber("Enter num 2: ");
                        c = GetNumber("Enter num 3: ");
                        Max(a, b, c); break;
                    case "converttemp":
                        Console.WriteLine(ConvertTemp("FtoC", GetNumber("Enter a num ")));
                        break;
                    case "findmax":
                        int[] array1 = { 1, 4, 6, 1, 3, 9, 0, -1, -6, 11 };
                        int[] array2 = { -9, -7, -11, -7, -88, -5, -10 };
                        Console.WriteLine("Max is " + FindMax(array1));
                        Console.WriteLine("Max is " + FindMax(array2));
                        break;
                    case "findavg":
                        int[] arr = { 1, 4, 6, 1, 3, 9, 0, -1, -6, 11 };
                        Console.WriteLine("Average is " + FindAverage(arr));
                        break;
                    case "gcd": GreatestCommonDivisor(); break;
                    case "array": ParallelArrays(); break;
                    case "reverse":
                        string[] arrayX = { "AAAAA", "BBBB", "CCC", "DD", "E", "A", "B", "C", "E", "F" };
                        ReverseArray(arrayX);
                        for (int i = 0; i < arrayX.Length; i++)
                        {
                            Console.Write(arrayX[i] + " ");
                        }
                        break;
                    case "phoneword":
                        //while (true)
                        // {
                        //    Console.WriteLine("Phone Number: " + ToPhoneNumber(GetInput("Enter a phone word: ")));
                        // }
                        break;
                    case "fib": Fibonacci(); break;
                    case "fact":
                        int num = GetNumber("Enter a number");
                        Console.WriteLine(Fact(num)); break;
                    case "stringnum":
                        string input = GetInput("Enter a string: ");
                        NumberOfWords(input); break;
                    case "longestword":
                        input = GetInput("Enter a string: ");
                        FindLongestWord(input); break;
                    case "makechange": MakeChange(); break;
                    case "strings": FunWithStrings(); break;
                    case "guess": GuessNumber(); break;
                    case "fill": AddNames(GetNumber("Enter a number")); break;
                    case "century": CalculateCentury(GetNumber("Enter a century")); break;
                    case "largernum":
                        int num1 = GetNumber("Enter an Integer: ");
                        int num2 = GetNumber("Enter another Integer: ");
                        LargerNumber(num1, num2); break;
                    case "smallernum":
                        num1 = GetNumber("Enter an Integer: ");
                        num2 = GetNumber("Enter another Integer: ");
                        SmallerNumber(num1, num2); break;
                    case "touppercase":
                        UppercaseWordX(GetInput("Enter a string"),
                                       GetNumber("Enter the number of letter to uppercase"));
                        break;
                    case "list": ListDemo(); break;
                    case "english":
                        for (int i = 0; i < 100; i++)
                        {
                            Console.WriteLine(i + " in english:  " + ConvertToEnglish(i));
                        }
                        break;
                    case "mult":
                        int n;
                        do
                        {
                            n = GetNumber("Enter a number between 2 and 20");
                        }
                        while (n < 2 || n > 20 || !Int32.TryParse(Console.ReadLine(), out n));
                        MultiplicationTable(n); break;
                    case "isword":
                        while (true)
                        {
                            Console.WriteLine("Could this be a word? " + IsThisAWord(GetInput("Enter a string ")));
                        }//break;
                    case "addtolist":
                              AddToList();          break;
                    case "beprepared":
                        BePrepared(30, 10, 10, "sunny");
                        BePrepared(20, 9, 8, "sunny");
                        BePrepared(35, 15, 20, "sunny");
                        BePrepared(50, 35, 25, "cloudy");
                        BePrepared(80, 80, 50, "cloudy");
                        BePrepared(120, 10, 100, "cloudy");  break;
                    case "sortarray":
                        //arr = { 2, 4, 6, 1, 3, 9, 0, -1, -6, 11 };
                        //SortArray(arr);       break;
                    case "reversestring":  ReverseString(GetInput("Enter a string"));     break;
                    case "palindrome": Palindrome(GetInput("Enter a string"));         break;
                       
                    default: break;
                }
                /* DateTime dueDate = CalculateDueDate(Convert.ToDateTime("2017-12-19"), 32);
                * Console.WriteLine(dueDate);
                * Console.WriteLine(dueDate.DayOfWeek);
                * Console.ReadLine();
                */

            }
        }


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

        //Heres where we test if guess is right or wrong
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
            foreach (string word in words) {
                if (word.Length > longestWord.Length)
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
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = GetInput("Enter name " + (i + 1) + ": ");
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
            if (a > b)
            {
                if (a > c)
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
                if (anArray[i] > max)
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
            for (int i = 0; i < length; i++)
            {
                if (size >= (length / 2))
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
            for (int i = 0; i < anArray.Length / 2; i++)
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
                    temperature = (temperature - 32) * 5.0f / 9.0f;
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

            return total / anArray.Length;
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
                string change = MakingChange(tendered, price);
                exit = GetInput(change);
            }
        }

        //method to calculate the change due for an amt tendered and price of an item
        public static string MakingChange(int amtTendered, decimal price)
        {
            string[] money = { "$50", "$20", "$10", "$5", "$1", "Quater", "Dime", "Nickel", "Cent" };
            decimal[] denom = { 50.00M, 20.00M, 10.00M, 5.00M, 1.00M, .25M, .10M, 0.05M, 0.01M };
            decimal coin;
            decimal remainder = amtTendered - price;
            string change = String.Format("Change from {0:F2} for {1:F2} = {2:F2}\n\t", amtTendered,
                price, remainder);

            for (int i = 0; i < denom.Length; i++)
            {
                coin = (int)(remainder / denom[i]);
                remainder %= denom[i];
                change += money[i] + (coin != 1 ? "s " : "  ") + coin + " ";
            }

            return change;
        }

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

        //convert a number between 0 and 99 to the english equivalence
        public static string ConvertToEnglish(int num)
        {
            int tens = num / 10;
            int ones = num % 10;
            string[] atens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
            string[] aOnes = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string toEnglish = "";

            //if tens > 1 & ones is zero then return the value of tens in the aTens array
            //else if tens is 0 then we have a single digit so return only the Ones array
            //else if tens is > 1 and ones > 0 then concatenate the values of the atens and aOnes array
            //I added this last stmt seperately so i can use hypen in between
            toEnglish = (tens > 1 && ones == 0) ? atens[tens] : (tens == 0) ? aOnes[ones] : atens[tens] + "-" + aOnes[ones];

            //this switch takes care of the special number cases
            switch (num)
            {
                case 10: toEnglish = "Ten"; break;
                case 11: toEnglish = "Eleven"; break;
                case 12: toEnglish = "Twelve"; break;
                case 13: toEnglish = "Thirteen"; break;
                case 14: case 16: case 17: case 19:
                    toEnglish = aOnes[ones] + "teen"; break;
                case 15: toEnglish = "Fifteen"; break;
                case 18: toEnglish = "Eighteen"; break;
            }
            return toEnglish;
        }

        //working with collections (List demo)
        public static void ListDemo()
        {
            string userResponse;
            Console.WriteLine("Enter empty line to stop entering names");
            List<string> names = new List<string>() { "Rick", "David", "John", "Albert" };
            while (true)
            {
                userResponse = GetInput("Add to List ");
                if (userResponse.Length == 0)
                    break;
                names.Add(userResponse);
            }
            foreach (string name in names)
            {
                Console.Write("\t{0}", name);
            }

            Console.WriteLine();

            //while (true)
            //{
            //    userResponse = GetInput("Search for name: ");
            //    if (userResponse.Length == 0)
            //        break;
            //   bool found =  names.Contains(userResponse);
            //}

        }

        //Build a multiplication table
        public static void MultiplicationTable(int n)
        {
            Console.Write("    |");
            for (int j = 0; j <= n; j++)
            {
                Console.Write("{0,4}", j);
            }
            Console.WriteLine();

            for (int i = 0; i <= n; i++)
            {
                Console.Write("{0,4}|", i);
                for (int j = 0; j <= n; j++)
                {
                    Console.Write("{0,4}", i * j);
                }
                Console.WriteLine();
            }
        }

    //Given a string, determine if it could be a word 

        public static bool IsThisAWord(string aString)
        {
            bool isWord = false;
            string[] arrVowels = { "a","A", "e","E" ,"i","I" ,"o","O", "u","U" };
            string[] arrConsonants = { "b","B", "c", "C","d","D", "f","F", "g","G","h","H","j","J","k","K",
                "l","L","m","M","n","N","p","P","q","Q","r","R","s","S","t","T","v","V","w","W","x","X","y",
                "Y","z","Z" };

            //check if string contains a  number
            for (int i = 0; i < aString.Length; i++)
            {
                if (aString[i] >= '0' && aString[i] <= '9')
                {
                    //isWord = false;
                    return false;           //if string contains a number at this point then itcannot be a word
                }
            }
            
            //check if string contains an uppercase
            for (int i = 1; i < aString.Length; i++)
            {
                if (aString[i] >= 'A' && aString[i] <= 'Z')
                {
                    return false;            //if string contains uppercase letter then it is not a word
                }
            }

            // check if string contains a vowel
            foreach (string vowel in arrVowels)
            {
                if (aString.Contains(vowel))
                {
                    isWord = true;
                    break;
                }
            }
            if (isWord == true) {
                //check if string contains a consonant
                foreach (string consonant in arrConsonants)
                {
                    if (aString.Contains(consonant))
                    {
                        return true;
                    }                
                }
                if(aString.Equals("I") || aString.Equals("a"))
                {
                    return true;
                }
                else
                {
                    return false;
                }                   
            }
            return isWord;
        }

    //working with lists
    private static void AddToList()
        {
            List<string> grocery = new List<string>();
            List<string> bigstuff = new List<string>();
            long num = GetNumber("Enter a number: ");
            while (true)
            {
                string input = GetInput("Enter grocery items: ");
                //if user input is null i.e length is 0, then break out of the loop
                if (input.Length == 0)
                    break;
                //add user input to list
                if (input.Length >= num)
                    bigstuff.Add(input);
                else
                    grocery.Add(input);
            }
            //print out the content of your list
            Console.WriteLine("Your grocery list: ");
            foreach (var item in grocery)
            {
                Console.Write (item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Your big list: ");
            foreach (var item in bigstuff)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

    //another list method
    private static void BePrepared(int temp, int wind, int rain, string forecast)
        {
            List<string> prepItems = new List<string>();

            //testing the temp conditions
            if(temp < 30) {                      prepItems.Add("put on a heavy coat"); }
            else if (temp > 30 && temp < 40) {   prepItems.Add("Wear your mittens"); }
            else if (temp >= 40 && temp <= 70) { prepItems.Add("Do you have a long sleeve shirt");}
            else if (temp > 70)
            {
                 if (temp > 110)    { prepItems.Add("Move out of Texas"); }
                 else {               prepItems.Add("Put on a t-shirt"); }
            }
            //testing the wind conditions
            if (wind < 10) {                       prepItems.Add("nothing"); }
                else if (wind > 10 && wind < 45) { prepItems.Add("Put on a wind breaker"); }
                else if (wind > 45 && wind < 75) { prepItems.Add("Stay indoors"); }
                else if (wind > 75)              { prepItems.Add("Get to the storm cellar"); }

            //testing the rain conditions
            if (rain < 10) { prepItems.Add("Dont worry about it"); }
            if (rain > 10 && rain < 35) { prepItems.Add("wear a hat"); }
            else if (rain > 35)
            {
                if (rain > 80) { prepItems.Add("stay home and read a book"); }
                else { prepItems.Add("take an umbrella"); }
            }

            //testing the forecase conditions
            if (forecast.Equals("sunny")) { prepItems.Add("put on your glasses and put on sun screen"); }
            else if (forecast.Equals("cloudy")) { }
         
            foreach(var item in prepItems)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();
        }

    //Convert a word to a phoneNumber
    public static string ToPhoneNumber(string phoneWord)
    {
        phoneWord = phoneWord.ToLower();
        string phoneNumber = "";
        for (int i = 0; i < phoneWord.Length; i++)
        {
            switch (phoneWord[i])
            {
                case 'a': case 'b': case 'c': phoneNumber += "2"; break;
                case 'd': case 'e': case 'f': phoneNumber += "3"; break;
                case 'g': case 'h': case 'i': phoneNumber += "4"; break;
                case 'j': case 'k': case 'l': phoneNumber += "5"; break;
                case 'm': case 'n': case 'o': phoneNumber += "6"; break;
                case 'p': case 'q': case 'r': case 's': phoneNumber += "7"; break;
                case 't': case 'u': case 'v': phoneNumber += "8"; break;
                case 'w': case 'x': case 'y': case 'z': phoneNumber += "9"; break;
                default: phoneNumber += phoneWord[i]; break;
            }
            if (i == 2 || i == 5) { phoneNumber += "-"; }
        }
        return phoneNumber;
    }


    //sort array in descending order
    public static int[] SortArray(int[] arr)
        {
            int temp = arr[0];
            int[] arr2 = { };
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i + 1] > temp)
                {
                    temp = arr[i];
                }
                arr2[i] = temp;
            }
            return arr2;
        }

        //reverse a string
        public static string ReverseString(string aString)
        {
            string newString = " ";
            for (int i = aString.Length - 1; i >= 0; i--)
            {
               //newString += aString.Substring(i,0);
                newString += aString[i];
            }
            return newString;
        }

        //check if a word is a palindrome
        public static bool Palindrome(string word)
        {
            if (word.Equals(ReverseString(word)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //another way
        public static bool Palindrome1(string word)
        {
           // string[] arrWord = word.Split("");
            int count = word.Length;
            bool result = false;
            for (int i = 0; i < count/2; i++)
            {
                if (word[i] == word[count--])
                {
                    result = true;
                }
                else { break; }
            }
            return result;
        }

    }



}

 

