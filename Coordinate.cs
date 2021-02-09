namespace Snake
{
    public class Coordinate
    {
        public Coordinate()
        {
            x = 0;
            y = 0;
        }

        public Coordinate(int X, int Y)
        {
            x = X;
            y = Y;
        }

        public int x { get; set; }
        public int y { get; set; }
    }

}