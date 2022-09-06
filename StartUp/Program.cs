namespace StartUp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool keepLooping = true;

            while (keepLooping)
            {
                Console.Clear();

                PrintMenu();

                int userPick = AskUserForNumber("menu selection");

                switch (userPick)
                {
                    case 1:
                        for (int i = 3; i > 0; i--)
                        {
                            Console.WriteLine("Counting down: " + i);
                        }
                        break;
                    case 2:
                        CodeLove();
                        break;
                    case 3:
                        GreetUser();
                        break;
                    case 4:
                        TheBar();
                        break;
                    case 9:
                        keepLooping = false;
                        break;
                    default:
                        Console.WriteLine("Not a valid option.");
                        break;
                }

                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();

            } //end of while loop



            // End of Main method

            static void PrintMenu()
            {
                Console.WriteLine("----- Menu -----");
                Console.WriteLine("1: Count down from 3");
                Console.WriteLine("2: Give me code love");
                Console.WriteLine("3: Greet user");
                Console.WriteLine("4: The bar");
                Console.WriteLine("9: Exit program");
            }

            static string? AskUserFor(string what)
            {
                Console.Write("Please enter " + what + ": ");
                /* Console.Write("Please enter {0}: ", what);
                   Console.Write($"Please enter {what}: "); */
                return Console.ReadLine();
            }

            static int AskUserForNumber(string what)
            {
                string? inputed = AskUserFor(what);

                int number = Convert.ToInt32(inputed);

                return number;
            }

            static void CodeLove()
            {
                int amount = AskUserForNumber("how mush code love do you need?");

                while (amount > 0)
                {
                    Console.WriteLine("Code loves you!");
                    amount--;
                }
            }

            static void GreetUser()
            {
                //string userName = Console.ReadLine();
                string? userName = AskUserFor("your name");

                Console.WriteLine("Hello " + userName);
            }

            static void TheBar()
            {
                //int userAge = Convert.ToInt32( AskUserFor("your age") );
                int userAge = AskUserForNumber("your age");

                if (userAge > 17)
                {
                    Console.WriteLine("Do you want a Beer?");
                }
                else
                {
                    Console.WriteLine("Do you want a Soda?");
                }



            }
            // if int or a string is null to the program use the ? behind the variable type
            //string? message = "Alex";
            //Console.WriteLine(message);

            //int numA = 2;
            //int numB = 2;
            //bool isEqual = numA == numB;
            //Console.WriteLine(isEqual);
            //Console.ReadKey();

            // comment out ctrl+k+c
            // comment In ctrl+k+U
            //int number = Convert.ToInt32(Console.ReadLine());
            // number = 6;
            //while (number > 0)
            //{
            //    Console.WriteLine(number);
            //    number--;
            //}
            //do
            //{
            //    Console.WriteLine(number);
            //    number--;
            //}
            //while (number > 0);

            //for(int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine("written 10 time" + i);

            //}



            //********************************** Data Literales Variables *****************************************************


            //string message = "Happy Coding!";
            //Console.WriteLine(message);
            //Console.ReadKey();

            //*********************************** Data Variables **************************************************************

            //int numA;                                 // Declaration
            //numA = 64;                                // Assingment
            //Console.WriteLine(numA);
            //// Both at once (Initialization)

            //string message = "Hello, World ";
            //Console.WriteLine(message);
            //Console.ReadKey();

            //*********************************** Data – Evaluation Order*****************************************************


            //int numA;                                 // Declaration
            //int numB = (numA=64)* 3;
            //// this sets numA to 64 and numB to numA * 3, in on line
            //Console.WriteLine(numA);
            //Console.WriteLine(numB);
            //Console.ReadKey();



            //************************************ Control Flow Statements - Selections ***************************************

            //int numA = 2;
            //int numB = 2;
            //bool isEqual = numA == numB;
            //Console.WriteLine(isEqual);
            //Console.ReadKey();

            //************************************ Selections – if-statements *************************************************

            //bool Condition=false;
            //bool otherCondition=false;

            //if (Condition) {
            //    Console.WriteLine("Happy Hacker!");
            //    // if Condition is true
            //}
            //else if (otherCondition) {

            //    Console.WriteLine("Nice Hacker!");
            //    // if Condition is false
            //    // and if otherCondition is true

            //}
            //else {
            //    // if neither Conditions is true
            //    Console.WriteLine("Just Hacking");

            //}


            //********************************* Selections – switch-statements **************************************************
            //int number = Convert.ToInt32(Console.ReadLine());


            //switch (number)
            //{
            //    case 1:
            //        Console.WriteLine("number is equal to 1 ");
            //        break;
            //    case 2:
            //    case 3:
            //        Console.WriteLine("number is equal to 2 and 3 ");
            //        break;
            //    case 4:
            //        Console.WriteLine("number is equal to 4 ");
            //        break;

            //    default:
            //        Console.WriteLine("Hello fellow hackers");
            //        break;
            //}Console.ReadKey();


            //********************************** Selections – ternary operator *****************************************************
            //int number = Convert.ToInt32(Console.ReadLine());

            //int number = 6;

            //string response = (number > 5) ? "Value is above 5"
            //                               : "Value is not above 5";



            //********************************** Flow Chart - Iterative Statements do while-loops  *********************************


            //int number = Convert.ToInt32(Console.ReadLine());
            ////int number = 6;
            ////"Flow Chart" Iterative Statements

            //while (number > 0)
            //{
            //    Console.WriteLine(number);
            //    number--;
            //}

            //Console.WriteLine("Value is now 0");
            //do
            //{
            //    Console.WriteLine(number);
            //    number--;

            //} while (number > 0);

            //Console.WriteLine("Value is now 0");


            //********************************** Flow Chart - Iterative Statements for-loops ******************************************

            //for(int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("this will be written 10 times- this is #"+ i);   
            //}
        }// end of Main
    }// end of program
}