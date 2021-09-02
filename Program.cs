using System;

namespace diceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int numDice, numSides, numMod;
            bool gettingNumber = true;
            while(gettingNumber)
            {
                System.Console.Write("Number of Dice: ");
                string line = System.Console.ReadLine();
                if(!Int32.TryParse(line, out numDice)
                {
                    System.Console.WriteLine("Not a valid number of dice");
                } else
                {
                    gettingNumber = false;
                }
            }
            gettingNumber = true;
            while(gettingNumber)
            {
                System.Console.Write("Number of Sides on Dice: ");
                string line = System.Console.ReadLine();
                if(!Int32.TryParse(line, out numSides){
                    System.Console.WriteLine("Not a valid number of dice");
                } else
                {
                    gettingNumber = false;
                }
            }
            gettingNumber = true;
            while(gettingNumber)
            {
                System.Console.Write("Modifier for End Total: ");
                string line = System.Console.ReadLine();
                if(!Int32.TryParse(line, out numMod){
                    System.Console.WriteLine("Not a valid number of dice");
                } else
                {
                    gettingNumber = false;
                }
            }
            Random rnd = new Random()
            List<int>results = new List<int>();
            int result = 0 + numMod;
            System.Console.Write("Results: (");
            for (int i = 0; i <= numDice; i++)
            {
                int randResult = rnd.Next(1, numSides);
                result += randResult;
                results.Add(randResult);
                if(i != numDice)
                {
                    System.Console.Write(randResult + ', ');
                } else
                {
                    System.Console.Write(randResult + ')\n');

                }
            }
            System.Console.WriteLine("Total: " + result);
        }
    }
}
