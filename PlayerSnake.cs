using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Snake;
using Snake.Properties;
namespace ConsoleApplication1
{
    public class PlayerSnake
    {
        public enum Direction
        {
            left,
            right,
            up,
            down
        }

        public Coordinate Head { get; set; } = new Coordinate();
        List<Coordinate> Tail { get; set; } = new List<Coordinate>();
        public Direction direction { get; set; }=Direction.right;
        public bool outOfRange = false;
        public int length = 1;

        public bool GameOver()
        {
            return Tail.Where(c => c.x == Head.x &&
                                   c.y == Head.y).ToList().Count > 1;
        }
        public void Move()
        {
            switch (direction)
            {
                case Direction.right:
                    Head.x++;
                    break;
                case Direction.left:
                    Head.x--;
                    break;
                case Direction.up:
                    Head.y--;
                    break;
                case Direction.down:
                    Head.y++;
                    break;
            }

            try
            {
                Console.SetCursorPosition(Head.x, Head.y);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("X");
                Tail.Add(new Coordinate(Head.x, Head.y));
                if (Tail.Count > this.length)
                {
                    var endTail = Tail.First();
                    Console.SetCursorPosition(endTail.x,endTail.y);
                    Console.Write(" ");
                    Tail.Remove(endTail);
                }
            }
            catch(ArgumentOutOfRangeException)
            {
                outOfRange = true;
            }
        }
        public void Eat()
        {
            length++;
        }
    }
}