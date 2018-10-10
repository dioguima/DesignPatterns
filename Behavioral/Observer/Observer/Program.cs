using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Input input = new Input();
            MultiplierObserver multiplierObserver = new MultiplierObserver(input);
            HexObserver hexObserver = new HexObserver(input);

            input.Value = 10;
            input.Value = 90;

            Console.Read();
        }
    }
}
