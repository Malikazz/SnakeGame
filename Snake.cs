using System;
using System.Numerics;
using System.Diagnostics;
using SFML.Graphics;
using SFML.System;
namespace SnakeGame
{

    public class Snake
    {
        private enum MoveDirection
        {
            LEFT, RIGHT, UP, DOWN
        };
        private MoveDirection? _currentMoveDirection = null;
        private Vector2f _moveLeft = new Vector2f(-10, 0);
        private Vector2f _moveRight = new Vector2f(10, 0);
        private Vector2f _moveUp = new Vector2f(0, -10);
        private Vector2f _moveDown = new Vector2f(0, 10);
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

        public Snake() { }
        public void MoveSnake(Snake[] snakeArray)
        {
            foreach (Snake snakeP in snakeArray)
            {
                if (_currentMoveDirection != null)
                {
                    snakeP.Position = snakeP.SnakeShape.Position;
                    switch (_currentMoveDirection)
                    {
                        case MoveDirection.LEFT:
                            {
                                Vector2f newPosition = snakeP.Position + _moveLeft;
                                snakeP.SnakeShape.Position = newPosition;
                                break;
                            }
                        case MoveDirection.RIGHT:
                            {
                                Vector2f newPosition = snakeP.Position + _moveRight;
                                snakeP.SnakeShape.Position = newPosition;
                                break;
                            }
                        case MoveDirection.UP:
                            {
                                Vector2f newPosition = snakeP.Position + _moveUp;
                                snakeP.SnakeShape.Position = newPosition;
                                break;
                            }
                        case MoveDirection.DOWN:
                            {
                                Vector2f newPosition = snakeP.Position + _moveDown;
                                snakeP.SnakeShape.Position = newPosition;
                                break;
                            }
                    }

                }
            }
            }
        public void SetMoveDirection(object sender, SFML.Window.KeyEventArgs e)
        {
            switch (e.Code)
            {
                case SFML.Window.Keyboard.Key.Left:
                    _currentMoveDirection = MoveDirection.LEFT;
                    break;
                case SFML.Window.Keyboard.Key.Down:
                    _currentMoveDirection = MoveDirection.DOWN;
                    break;
                case SFML.Window.Keyboard.Key.Right:
                    _currentMoveDirection = MoveDirection.RIGHT;
                    break;
                case SFML.Window.Keyboard.Key.Up:
                    _currentMoveDirection = MoveDirection.UP;
                    break;

            }
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