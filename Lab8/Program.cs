using System;

namespace Lab8
{
    class Program
    {
        public static string[] names = new string[100];
        public static string[] foods = new string[100];
        public static string[] towns = new string[100];

        static void Main(string[] args)
        {

            AddStudent("Tommy", "Raleigh", "chicken curry", 0);
            string studentInfo = GetStudent(0);
            AddStudent("Callista", "Traverse City", "crab rangoon", 1);
            string studentInfo1 = GetStudent(1);
            AddStudent("Andre", "St. Catherine's", "veggie burgers", 2);
            string studentInfo2 = GetStudent(2);
            AddStudent("Brad", "Kentwood", "sushi", 3);
            GetInput();
        }

        public static void AddStudent(string name, string town, string food, int index)
        {
            names[index] = name;
            foods[index] = food;
            towns[index] = town;
        }

        public static string GetStudent(int index)
        {
            string output = $"{names[index]} {foods[index]} {towns[index]}";
            return output;
        }

        public static void PrintMenu()
        {
            for (int i = 0; i < names.Length; i++)
            {
                string name = names[i];
                if (name != null)
                {
                    Console.WriteLine(i + ") " + names[i]);
                }
            }
        }

        public static void GetInput()
        {
            Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about?");
            PrintMenu();
            Console.WriteLine("Select 0 to 3.");
            int index = 0;
            //int studentNumber;
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    index = int.Parse(input);
                    if (index >= 0)
                        break;
                    throw new Exception("That student doesn't exist. Please enter a number from 0 to 3.");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            if (index == 0)
            {
                Console.Write("Student 0 is Tommy Waalkes. ");
            }
            else if (index == 1)
            {
                Console.Write("Student 1 is Callista Gloss. ");
            }
            else if (index == 2)
            {
                Console.Write("Student 2 is Andre Otte. ");
            }
            else if (index == 3)
            {
                Console.Write("Student 3 is Brad Kapteyn. ");
            }
            else
            {
                Console.WriteLine("That student doesn't exist. Please enter a number from 0 to 3.\n");
                GetInput();
            }
            if (index >= 0 && index <= 3)
            
                Console.WriteLine("What would you like to know about {0}? Please enter 'hometown' or 'favorite food.' ", names[index]);
                string userInput = (Console.ReadLine());

            if (userInput == "hometown")
            {
                Console.Write("{0} is from ", names[index]);
                Console.WriteLine(towns[index]);
                //Console.WriteLine("Would you like to know more? (y/n)");
                Continue();
            }
            else if (userInput == "favorite food")
            {
                Console.Write("{0}'s favorite food is ", names[index]);
                Console.WriteLine(foods[index]);
                //Console.WriteLine("Would you like to know more?(y/n)");
                Continue();
            }
            else
            {
                Console.WriteLine("That data does not exist.");
                Continue();
            }


        }
        public static void Continue()
        {
            bool play = true;

            while (play)
            {
                Console.WriteLine("Would you like to know more? (y/n)");
                string input = Console.ReadLine().ToLower();

                if (input == "y" || input == "yes")
                {
                    GetInput();
                }

                else if (input == "n" || input == "no")
                {
                    Console.WriteLine("Thanks!");
                    play = false;
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("I'm sorry that I didn't understand your input. Goodbye.");
                    System.Environment.Exit(0);
                }

            }

            
        }
    }
}