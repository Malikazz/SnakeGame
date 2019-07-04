using System.Numerics;
namespace SnakeGame
{
    public class Snake
    {
        public int PosX { get; set; }
        public int PosY { get; set; }
        public Vector2 Size { get; set; }
        public bool IsHead { get; set; }
        public bool IsActive { get; set; }         
        Snake(int posX, int posY, float sizeX, float sizeY, bool isHead, bool isActive)
        {
            PosX = posX;
            PosY = posY;
            Size = new Vector2(sizeX,sizeY);
            IsHead = isHead;
            IsActive = isActive;
        }
    }
}