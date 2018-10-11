using System;

namespace practice
{
    class Program
    {
        public static string ValidateUserInput()
        {
            var isGender = false; // use for while loop to check for valid user input 
            string Gender = "";
            while (!isGender)
            {
                // store user input
                Console.Write("Please Select if your male or female:  ");
                Gender = Console.ReadLine();
                switch (Gender)
                {
                    case "m":
                    case "M":
                    case "male":
                    case "Male":
                        Gender = "Male";
                        isGender = true;
                        break;
                    case "f":
                    case "F":
                    case "female":
                    case "Female":
                        Gender = "Female";
                        isGender = true;
                        break;
                    default:
                        Console.WriteLine("Invalid! Please enter your correct gender.");
                        break;
                }
            }
            return Gender;
        }
        static void Main(string[] args)
        {
            double CreditScore = 0;
            decimal AnnualRate = 0;
            double Annualcompoundinterest = 0,
                PrincipleAmount,
                CompondPerYear
                , years;

            Console.WriteLine("Please enter You age:  ");
            int age = int.Parse(Console.ReadLine());

            // validate user input and return selection to store in variable
            string Gender = ValidateUserInput();

            Console.WriteLine(); // create a line break

            Console.WriteLine("Please enter a Credit Score: ");
            CreditScore = Convert.ToInt32(Console.ReadLine());

            if ((CreditScore >= 300) && (CreditScore <= 800))
            {
                Console.WriteLine("Continue: ");
                if ((CreditScore <= 750) && (CreditScore <= 800))
                {
                    AnnualRate = 10 / 100;

                    Console.WriteLine("");
                    if ((CreditScore <= 750) && (CreditScore <= 800))
                    {
                        AnnualRate = 28 / 100;
                    }
                }
            }
            else
            {
                Console.WriteLine("Error, value not accepted, please restart the application and try again.");
            }
            Console.WriteLine("Please Enter the Amount You Would Like to deposit: ");
            PrincipleAmount = Convert.ToDouble(Console.ReadLine());
            // store user input
            Console.Write("Your annual interest rate based on your Credit Score is: {0}", AnnualRate);
            AnnualRate = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Please enter the year you would like to compound:  ");
            CompondPerYear = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.Write("Please enter the number of years you would like to pay this off: ");
            years = Convert.ToDouble(Console.ReadLine());
            for (int t = 1; t < years + 1; t++)
            {
                Annualcompoundinterest = PrincipleAmount * (1 + (Convert.ToInt32(AnnualRate) / CompondPerYear) * (Math.Pow(years, t)));
                Console.Write("Your Total for Year {0} "
                            + "is {1:F0}. \n", t, Annualcompoundinterest);
            }
            Console.ReadLine();
        }


    }
}