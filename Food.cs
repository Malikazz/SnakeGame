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
            int random1 = rnd.Next(0, constWindowSize + 1);
            int random2 = rnd.Next(0, constWindowSize + 1);
            if (random1 % 10 != 0)
            {
                if (random1 % 10 < 5)
                {
                    random1 -= random1 % 10;
                }
                else
                {
                    random1 += 5;
                    random1 -= random1 % 10;
                }
            }
            if (random2 % 10 != 0)
            {
                if (random2 % 10 < 5)
                {
                    random2 -= random2 % 10;
                }
                else
                {
                    random2 += 5;
                    random2 -= random2 % 10;
                }
            }
            Position = new Vector2f(random1, random2);
            Size = new Vector2f(sizeX,sizeY);
            FoodShape = new RectangleShape(Size);
            FoodShape.Position = Position;
            FoodShape.FillColor = Color.Blue;
        }
    }
}