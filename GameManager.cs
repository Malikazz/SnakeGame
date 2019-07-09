using System;
using System.Collections.Generic;
using System.Text;
using SFML.System;
using SFML.Graphics;
using SFML.Window;
using System.Diagnostics;

namespace SnakeGame
{
    /// <summary>
    /// Builds objects needed to run game and manages there states and movements.
    /// </summary>
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
            snakeArray[0] = new Snake(300f, 300f, 10f, 10f, true, true);
            for (int counter = 1; counter < snakeArray.Length; counter++)
            {
                snakeArray[counter] = new Snake(300f, 300f, 10f, 10f, false, false);
            }
            food = new Food(10f, 10f, SimpleWindow.WINDOW);
        }

        /// <summary>
        /// Starts at back of tail and moves all Position data down the array one spot
        /// </summary>
        /// <param name="snakeArray"></param>
        public void MoveSnake(Snake[] snakeArray)
        {

            if (_currentMoveDirection != null)
            {
                for (int counter = snakeArray.Length - 1; counter >= 1; counter--)
                {
                    snakeArray[counter].Position = snakeArray[counter - 1].Position;
                }

                switch (_currentMoveDirection)
                {
                    case MoveDirection.LEFT:
                        {
                            Vector2f newPosition = snakeArray[0].Position + _moveLeft;
                            snakeArray[0].Position = newPosition;
                            break;
                        }
                    case MoveDirection.RIGHT:
                        {
                            Vector2f newPosition = snakeArray[0].Position + _moveRight;
                            snakeArray[0].Position = newPosition;
                            break;
                        }
                    case MoveDirection.UP:
                        {
                            Vector2f newPosition = snakeArray[0].Position + _moveUp;
                            snakeArray[0].Position = newPosition;
                            break;
                        }
                    case MoveDirection.DOWN:
                        {
                            Vector2f newPosition = snakeArray[0].Position + _moveDown;
                            snakeArray[0].Position = newPosition;
                            break;
                        }
                }


            }
        }

        /// <summary>
        /// Set a field that determines the heads next move direction based on input from keyboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Flips a bool on the next element that it finds to be flipable to cause that Snake to be drawn
        /// </summary>
        /// <param name="snakeArray"></param>
        public void AddTail(Snake[] snakeArray)
        {
            bool NotFoundUnActiveSnake = true;
            int counter = 1;
            while(NotFoundUnActiveSnake)
            {
                if (snakeArray[counter].IsActive == false)
                {
                    snakeArray[counter].IsActive = true;
                    NotFoundUnActiveSnake = false;
                }
                else
                {
                    counter++;
                }
            }
        }

        /// <summary>
        /// Checks for Head to tail colision as well as head to food
        /// </summary>
        /// <param name="snakeArray"></param>
        /// <param name="food"></param>
        public void CheckForColision(Snake[] snakeArray, Food food)
        {
            //counter = 1 to skip head
            for (int counter1 = 1; counter1 < snakeArray.Length; counter1++)
            {
                if (snakeArray[0] == snakeArray[counter1] && snakeArray[counter1].IsActive == true)
                {
                    Debug.WriteLine("Colision Happened with head to tail");
                }
            }
            if (snakeArray[0].Position == food.Position)
            {
                AddTail(snakeArray);
            }
        }
    }
}
