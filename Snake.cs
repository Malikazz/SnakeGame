using System.Numerics;
using SFML.Graphics;
using SFML.System;
namespace SnakeGame
{
    public class Snake
    {
        public Vector2f Position { get; set; }
        public  Vector2f Size { get; set; }
        public bool IsHead { get; set; }
        public bool IsActive { get; set; }
        public  RectangleShape SnakeShape { get; set; }
        /// <summary>
        /// Makes a new snake with contains a SFML Rectangle object
        /// </summary>
        /// <param name="posX"></param>
        /// <param name="posY"></param>
        /// <param name="sizeX"></param>
        /// <param name="sizeY"></param>
        /// <param name="isHead"></param>
        /// <param name="isActive"></param>
        public Snake(float posX, float posY, float sizeX, float sizeY, bool isHead, bool isActive)
        {
            Position = new Vector2f(posX, posY);
            Size = new Vector2f (sizeX,sizeY);
            IsHead = isHead;
            IsActive = isActive;
            SnakeShape = new RectangleShape(Size)
            {
                
                FillColor = Color.Blue
            };
        }

    }

}