using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to SnakeAndLadder Game");
            Positions play = new Positions();
            Console.WriteLine(play);
            Console.ReadLine();
        }
    }
}
