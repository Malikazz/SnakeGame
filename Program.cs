using System;

namespace SnakeGame
{
    class Program
    {
        
        static void Main(string[] args)
        {
           Snake[] snakes = new Snake[200];
           Food food = new Food(10f,10f,SimpleWindow.WINDOW);
           var window = new SimpleWindow();
           window.Run();

           
            
        }
    }
}
