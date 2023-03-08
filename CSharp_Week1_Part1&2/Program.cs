using System;

namespace all_exercises
{
    class Program
    {
        public static void Main(string[] args)
        {
            //PrintUntilNumber(5);

            //Part 1:
            //1 - 10
            //1 - 15
            //1 - 23
            //1 - 33
            //1 - 40
            //Part 2:
            //2 - 4
            //2 - 8
            //2 - 11
            //2 - 17
            //2 - 20
            //2 - 21

            //// 1-10          
            //Console.Write("\nI will tell a story, but I need some information.\n Give a name for main character:\n");
            //string verhaal = Console.ReadLine(); Console.Write("\nGive the character a profession:\n");
            //string verhaal2 = Console.ReadLine(); Console.WriteLine("Here is the story:Once upon a time there was a Data Scientist called " + verhaal +
            //"\nOn her way to work," + verhaal + " often pondered what being Data Scientist meant to them." +
            //"\nWhen you work as a " + verhaal2 + " you meet interesting people." +
            //"\n" + verhaal + " enjoys their work as Data Scientist, The end.");

            ////1 - 15
            //Console.Write("Give a string: ");
            //string inputString = Console.ReadLine();

            //Console.Write("Give an integer: ");
            //int inputInteger = int.Parse(Console.ReadLine());

            //Console.Write("Give a double: ");
            //double inputDouble = double.Parse(Console.ReadLine());

            //Console.Write("Give a boolean: ");
            //bool inputBoolean = bool.Parse(Console.ReadLine());

            //// {0} is om de index van de variabele na de string te bepalen
            //Console.WriteLine("Your string: {0}", inputString);
            //Console.WriteLine("Your integer: {0}", inputInteger);
            //Console.WriteLine("Your double: {0}", inputDouble);
            //Console.WriteLine("Your boolean: {0}", inputBoolean);


            ////1-23
            //Console.WriteLine("Give the first number!");
            //int firstNumber = int.Parse(Console.ReadLine());

            //Console.WriteLine("Give the second number!");
            //int secondNumber = int.Parse(Console.ReadLine());

            //int addition = firstNumber + secondNumber;
            //int subtraction = firstNumber - secondNumber;
            //int multiplication = firstNumber * secondNumber;
            //double division = (double)firstNumber / secondNumber;

            //Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, addition);
            //Console.WriteLine("{0} - {1} = {2}", firstNumber, secondNumber, subtraction);
            //Console.WriteLine("{0} * {1} = {2}", firstNumber, secondNumber, multiplication);
            //Console.WriteLine("{0} / {1} = {2}", firstNumber, secondNumber, division);

            ////1-33
            //Console.WriteLine("Give the first string:");
            //string firstString = Console.ReadLine();

            //Console.WriteLine("Give the second string:");
            //string secondString = Console.ReadLine();

            //if (firstString == secondString)
            //{
            //    Console.WriteLine("Echo!");
            //}
            //else
            //{
            //    Console.WriteLine("Nope");
            //}

            ////1-40
            //Deze while loop runt totdat de gebruiker 0 invoert
            //int sum = 0;
            //int amount = 0;

            //while (true)
            //{
            //    Console.WriteLine("Give a number:");
            //    int number = int.Parse(Console.ReadLine());

            //    if (number == 0)
            //    {
            //        break;
            //    }
            //    else if (number != 0)
            //    {
            //        sum += number;
            //        amount++;
            //    }
            //}

            //Console.WriteLine("Total sum of numbers: " + sum);
            //Console.WriteLine("Total amount of numbers: " + amount);



            //// Part 2
            // 2-4
            // Console.WriteLine("Enter the first number:");
            // int firstNumber = int.Parse(Console.ReadLine());

            // Console.WriteLine("Enter the second number:");
            // int secondNumber = int.Parse(Console.ReadLine());

            // if (firstNumber > secondNumber)
            // {
            //     Console.WriteLine(firstNumber + " is greater than " + secondNumber + ".");
            // }
            // else if (firstNumber < secondNumber)
            // {
            //     Console.WriteLine(firstNumber + " is less than " + secondNumber + ".");
            // }
            // else
            // {
            //     Console.WriteLine(firstNumber + " is equal to " + secondNumber + ".");
            // }

            //// 2-11

            }
            public static void PrintUntilNumber(int number)
                {
                    for (int i = 1; i <= number; i++)
                    {
                        Console.WriteLine(i);
                    }
                }


        }

}

