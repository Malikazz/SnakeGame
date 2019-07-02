namespace SnakeGame
{
    public class Snake
    {
        public int PosX { get; set; }
        public int PosY { get; set; }
        public int SizeX { get; set; }
        public int SizeY { get; set; }
        public bool IsHead { get; set; }
        public bool IsActive { get; set; }         
        Snake(int posX, int posY, int sizeX, int sizeY, bool isHead, bool isActive)
        {
            PosX = posX;
            PosY = posY;
            SizeX = sizeX;
            SizeY = sizeY;
            IsHead = isHead;
            IsActive = isActive;
        }
    }
}