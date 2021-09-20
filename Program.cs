using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to SnakeAndLadder Game");
            Positions start = new Positions();
            Console.WriteLine(start);
            start.Play();
            Console.ReadLine();
        }
    }
}
