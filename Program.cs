using System;

namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Press any key to exit");
            var window = new SimpleWindow();
            window.Run();
            Console.WriteLine("All Done");
        }
    }
}
