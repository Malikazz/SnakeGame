using System;

namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press ESC key to close window");
            var window = new SimpleWindow();
            window.Run();

            Console.WriteLine("All done");
        }
    }
}
