using System;

namespace Snake.Properties
{
    public class Fruit
    {
        public Fruit()
        {
            Random rand = new Random();
            var x = rand.Next(1, 20);
            var y = rand.Next(1, 20);
            Target = new Coordinate(x, y);
            Draw();
        }
        public Coordinate Target { get; set; }

        void Draw()
        {
            Console.SetCursorPosition(Target.x,Target.y);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("o");
        }
    }
}