using System.Numerics;
using System;

namespace SnakeGame
{
    public class Food
    {
        static Random rnd = new Random();
        public int PosX { get; set; }
        public int PosY { get; set; }

        public Vector2 Size { get; set; }

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
            PosX = random1;
            PosY = random2;
            Size = new Vector2(sizeX,sizeY);
        }
    }
}