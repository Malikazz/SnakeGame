using SFML;
using System;
namespace SnakeGame
{
    public class SimpleWindow
    {
        public const int WINDOW = 600;
        public void Run()
        {
            GameManager gameManager = new GameManager();
            //Window Options
            var mode = new SFML.Window.VideoMode(WINDOW, WINDOW);
            var window = new SFML.Graphics.RenderWindow(mode, "Malikaz Snake");
            //Keyboard Event Handlers
            window.KeyPressed += Window_KeyPressed;
            window.KeyPressed += gameManager.SetMoveDirection;
            //Time
            DateTime timer1 = DateTime.Now;

            // Start the game loop
            while (window.IsOpen)
            {
                DateTime timer2 = DateTime.Now;

                // Process events
                window.DispatchEvents();
                if (timer2.Millisecond - timer1.Millisecond == 1000)
                {
                    //Clear Window
                    window.Clear();
                    gameManager.MoveSnake(gameManager.snakeArray);
                    gameManager.CheckForColision(gameManager.snakeArray, gameManager.food);

                    for (int counter = 0; counter < gameManager.snakeArray.Length; counter++)
                    {
                        if (gameManager.snakeArray[counter].IsActive == true)
                        {
                            window.Draw(gameManager.snakeArray[counter].SnakeShape);
                        }
                    }
                    window.Draw(gameManager.food.FoodShape);
                    Console.WriteLine(gameManager.snakeArray[0].Position);
                }
                // Finally, display the rendered frame on screen
                window.Display();
            }
        }

        /// <summary>
        /// Function called when a key is pressed
        /// </summary>
        private void Window_KeyPressed(object sender, SFML.Window.KeyEventArgs e)
        {
            var window = (SFML.Window.Window)sender;
            if (e.Code == SFML.Window.Keyboard.Key.Escape)
            {
                window.Close();
            }
        }
    }
}