using SFML;
namespace SnakeGame
{
    public class SimpleWindow
    {
        public const int WINDOW = 600;
        public void Run()
        {
            
            var mode = new SFML.Window.VideoMode(WINDOW, WINDOW);
            var window = new SFML.Graphics.RenderWindow(mode, "Malikaz Snake");
            window.KeyPressed += Window_KeyPressed;
            

            window.KeyPressed += //Snake Key catcher;

            // Start the game loop
            while (window.IsOpen)
            {
                window.Clear();
                // Process events
                window.DispatchEvents();
                foreach(Snake snakePart in snake)
                {
                    window.Draw(snakePart.SnakeShape);
                }
                
                window.Draw(food.FoodShape);


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