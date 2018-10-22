using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reference: https://sourcemaking.com/design_patterns/state
            string input = "0";
            Fan fan = new Fan();
            Console.WriteLine("The fan is turned off please insert the commands");
            while (input.Equals("0") || input.Equals("1"))
            {
                Console.WriteLine("\nPress 0 to decrease the fan velocity or 1 to increase the fan velocity");
                input = Console.ReadLine();

                if (input.Equals("0"))
                {
                    fan.DecreaseVelocity();
                }
                else if (input.Equals("1"))
                {
                    fan.IncreaseVelocity();
                }
            }
            Console.WriteLine("Exiting the application ...");
            Console.Read();
        }
    }
}
