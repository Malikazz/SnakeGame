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
                System.Threading.Thread.Sleep(5);
                //Clear Window
                window.Clear();
                DateTime timer2 = DateTime.Now;

                // Process events
                window.DispatchEvents();
                TimeSpan timeSinceLastUpdate = timer2 - timer1;
                if (timeSinceLastUpdate.TotalSeconds >= .1 && gameManager.GameIsActive == true)
                {

                    gameManager.MoveSnake(ref gameManager.snakeArray);
                    gameManager.CheckForColision(ref gameManager.snakeArray, ref gameManager.food);
                    timer1 = DateTime.Now;
                    Console.WriteLine(gameManager.snakeArray[0].Position);
                }
                for (int counter = 0; counter < gameManager.snakeArray.Length; counter++)
                {
                    if (gameManager.snakeArray[counter].IsActive == true)
                    {
                        window.Draw(gameManager.snakeArray[counter].SnakeShape);
                    }
                }
                window.Draw(gameManager.food.FoodShape);


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
        private void Window_Close(object sender, EventArgs e)
        {
            var window = (SFML.Window.Window)sender;
            window.Close();
        }
    }
}