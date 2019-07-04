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
                Snake[] snakes = new Snake[200];
                Food food = new Food(10f, 10f, WINDOW);
                snakes = new SFML.Graphics.RectangleShape.()
                {
                    FillColor = SFML.Graphics.Color.Blue
                };

                // Start the game loop
                while (window.IsOpen)
                {
                    // Process events
                    window.DispatchEvents();
                    window.Draw(//Add object to be drawn);

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