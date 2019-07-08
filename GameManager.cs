using System;
using System.Collections.Generic;
using System.Text;
using SFML.System;
using SFML.Graphics;
using SFML.Window;

namespace SnakeGame
{
    public class GameManager
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
        public Snake[] snakeArray = new Snake[200];
        public Food food;
        


        public GameManager()
        {
            snakeArray[0] = new Snake(300f,300f,10f,10f,true,true);
            food = new Food(10f, 10f, SimpleWindow.WINDOW);
        }


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
    }
}
