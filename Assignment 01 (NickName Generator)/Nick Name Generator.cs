using System;

namespace Nickname_Generator
{
    class Program
    {
        static string fName;

        public static string[][] getWords()
        {
           
            string[][] words = // "words" or synonyms.
            {            
                new string[] {"Awesome", "Superiorly Rad", "Chill", "The Bomb", "Occasionally Rad", "Sometimes Rad", "Normally Rad", "Super Rad", "Rad", "Totally Rad" },
                new string[] {"Lil", "Kinda", "Really", "Super", "Hyper", "Uber"},
                new string[] {"Lil Salty", "Kinda Salty", "Really Salty", "Super Salty", "Hyper Salty", "Uber Salty"},
                new string[] {"Lil Dumb", "Kinda Dumb", "Really Dumb", "Super Dumb", "Hyper Dumb", "Uber Dumb"},
                new string[] {"Lil Happy", "Kinda Happy", "Really Happy", "Super Happy", "Hyper Happy", "Uber Happy" },
                new string[] {"Lil Crazy", "Kinda Crazy", "Really Crazy", "Super Crazy", "Hyper Crazy", "Uber Crazy"},
                new string[] {"Lil Serious", "Kinda Serious", "Really Serious", "Super Serious", "Hyper Serious", "Uber Serious"},
                new string[] {"Lil Disturbed", "Kinda Disturbed", "Really Disturbed", "Super Disturbed", "Hyper Disturbed", "Uber Disturbed"},
                new string[] {"Lil Aggressive", "Kinda Aggressive", "Really Agrressive", "Super Aggressive", "Hyper Agressive", "Uber Agressive"},
                new string[] {"Lil Annoyed", "Kinda Annoyed", "Really Annoyed", "Super Annoyed", "Hyper Annoyed", "Uber Annoyed"},
            };
            return words;
        }
  public static void DisplayNickName(string[][] getWords, int choice, string fName)
        {
            for (int i = choice; i < getWords.Length; i++)
            {
                for (int j = 0; j < getWords[i].Length; j++)
                {
                    if (getWords[i][j] == getWords[choice][j])
                    {
                            Console.WriteLine($"\t{getWords[i][j]} {fName}\n");
                    }
                }
            }
        }
                public static int getChoice()
        {
            int choice = 0;
            bool validChoice;
            bool keepGoing;
            int traitCount = 0;
            do
            {
                keepGoing = true;
                Console.WriteLine("Choose what describes you.");
                Console.WriteLine();
                Console.WriteLine("\t1.\tHappy");
                Console.WriteLine("\t2.\tSad");
                Console.WriteLine("\t3.\tBoring");
                Console.WriteLine("\t4.\tShy");
                Console.WriteLine("\t5.\tMad");
                Console.WriteLine("\t6.\tDetermined");
                Console.WriteLine("\t7.\tAnxious");
                Console.WriteLine("\t8.\tObsessed");
                Console.WriteLine("\t9.\tTired");
                Console.WriteLine("\t10.\tCool");

                do
                {
                    validChoice = true;
                    Console.Write("\nPlease pick one number: ");
                    try
                    {
                        choice = Convert.ToInt16(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:     // allows for a choice
                                choice = 0;
                                traitCount++;
                                return choice;
                            case 2:
                                choice = 1;
                                traitCount++;
                                return choice;
                            case 3:
                                choice = 2;
                                traitCount++;
                                return choice;
                            case 4:
                                choice = 3;
                                traitCount++;
                                return choice;
                            case 5:
                                choice = 4;
                                traitCount++;
                                return choice;
                            case 6:
                                choice = 5;
                                traitCount++;
                                return choice;
                            case 7:
                                choice = 6;
                                traitCount++;
                                return choice;
                            case 8:
                                choice = 7;
                                traitCount++;
                                return choice;
                            case 9:
                                choice = 8;
                                traitCount++;
                                return choice;
                            case 10:
                                choice = 9;
                                traitCount++;
                                return choice;
                            default:
                                validChoice = false; // error checking
                                Console.WriteLine("Invalid choice. Please try again.");
                                return default;
                        }
                    }
                    catch (FormatException)
                    {
                        // more error checking
                        validChoice = false;
                        Console.WriteLine("Invalid choice. Please try again.");
                    }

                    return choice;

                } while (validChoice == false); 
            } while (keepGoing); // ends
        }
        static void Main(string[] args) // code to take input
        {

            Console.Write("Welcome to the 'Nickname Generator' Console Application!\nPlease enter your name: ");
            fName = Convert.ToString(Console.ReadLine());

            Console.Write("\nHello, {0}! Thank you for using this application.", fName);
            Console.WriteLine();
 
            string[][] words = getWords(); // Instantiate jagged array

            for(int i = 0; i < 3; i++)
            {
                int choice = getChoice();

                
                DisplayNickName(words, choice, fName); // output of input and nickname
            }
        }
    }
}
