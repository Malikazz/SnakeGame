using System.Numerics;
using System.Diagnostics;
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
            SnakeShape = new RectangleShape(Size);
            SnakeShape.Position = Position;
            SnakeShape.FillColor = Color.Magenta;
        }

        public void MoveSnake(Snake[] snakeArray, SFML.Window.KeyEvent keyboard)
        {
            
        }

        public void AddTail (Snake[] snakeArray)
        {
            //last position = new pos for create tail
        }

        public void CheckForColision(Snake[] snakeArray, Food food)
        {
            //counter = 1 to skip head
            for (int counter1 = 1; counter1 < snakeArray.Length; counter1++)
            {
                if(snakeArray[0] == snakeArray[counter1])
                {
                    Debug.WriteLine("Colision happened");
                }
            }
        }
    }

}