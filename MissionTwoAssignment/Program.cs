using System;

namespace MissionTwoAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] diceArray = new double[11];
            Random rand = new Random();

            Console.WriteLine("Welcome to the dice throwing simulator!\nHow many dice rolls would you like to simulate?");
            int numRolls = Convert.ToInt32(Console.ReadLine());

            for (int i =0; i < numRolls; i++)
            {
                int rando1 = rand.Next(0, 6); //instantiate die #1
                int rando2 = rand.Next(0, 6); //instantiate die #2

                int rando = rando1 + rando2; //add die #1 and die #2 totals together 

                diceArray[rando] = diceArray[rando] + 1; //add 1 to array according to dice total value
            }

            Console.WriteLine("DICE ROLLING SIMULATION RESULTS\nEach \"*\" represents 1% total number of rolls.\nTotal number of rolls = " + numRolls);

            for (int i = 0; i < diceArray.Length; i++)
            {
                string stars = "";
                for (int j=0; j<((diceArray[i]/numRolls)*100); j++) //change total count of dice values to percentage
                {
                    stars += "*"; //for every percentage, add a star
                }
                Console.WriteLine((i + 2) + ": " + stars); //i+2 changes output from 2-12 rather than 0-10
            }

            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!"); // :)

        }
    }
}
