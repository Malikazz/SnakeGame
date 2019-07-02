namespace SnakeGame
{
    public class Food
    {
        public int PosX { get; set; }
        public int PosY { get; set; }
        public int SizeX { get; set; }
        public int SizeY { get; set; }
        
        Food(int posX, int posY, int sizeX, int sizeY)
        {
            PosX = posX;
            PosY = posY;
            SizeX = sizeX;
            SizeY = sizeY;
        }
    }
}