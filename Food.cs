using System;
using SFML.System;
using SFML.Graphics;

namespace SnakeGame

{
    public class Food
    {
        static Random rnd = new Random();
        public Vector2f Position { get; set; }
        public RectangleShape FoodShape { get; set; }
        public Vector2f Size { get; set; }

        /// <summary>
        /// Will Create a food object with random values 0 - windowsize + 1 
        /// </summary>
        /// <param name="sizeX"></param>
        /// <param name="sizeY"></param>
        /// <param name="constWindowSize"></param>
        public Food(float sizeX, float sizeY, int constWindowSize)
        {
            float random1 = rnd.Next(0, constWindowSize + 1);
            float random2 = rnd.Next(0, constWindowSize + 1);
            Position = new Vector2f(random1, random2);
            Size = new Vector2f(sizeX,sizeY);
            FoodShape = new RectangleShape(Size);
            FoodShape.Position = Position;
            FoodShape.FillColor = Color.Blue;
        }
    }
}