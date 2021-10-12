using System;

namespace Lab8
{
    class Retailer
    {
        static void Main(string[] args)
        {
            bool again = true;
            string input;
            bool invalid;
            do 
            {
                string userBudget;
                Console.Write("\n\nEnter Budget: ");
                userBudget = Console.ReadLine();

                int userBudgetNum = Convert.ToInt32(userBudget);

                ITV tv = new TVProxy();

                try
                {
                    tv.replenishTV(userBudgetNum).getInfo();
                } catch (NullReferenceException e)
                {
                    Console.WriteLine("Please enter a higher budget");
                }

                do
                {
                    Console.Write("\nWould you like to enter another budget? Y or N: ");
                    input = Console.ReadLine();
                    input = input.ToUpper();
                    if (input == "Y")
                    {
                        again = true;
                        invalid = false;
                    }
                    else if (input == "N")
                    {
                        again = false;
                        invalid = false;
                    }
                    else
                    {
                        Console.Write("\nPlease enter valid input\n");
                        invalid = true;
                    }
                } while (invalid);
                
            } while (again);

            Console.Write("Thanks for using the program.\n\n");
        }
    }
}



