using System;
using ConsoleApplication1;
using Snake.Properties;
//Done with help https://www.youtube.com/watch?v=a64MEitlvQY
namespace Snake
{

    class Program
    {
        static void Main()
        {
            int Framerate=250;
            Console.CursorVisible = false;
            bool Game = true;
            PlayerSnake Player = new PlayerSnake();
            Fruit Test = new Fruit();
            while (Game)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo input = Console.ReadKey();
                    switch (input.Key)
                    {
                        case ConsoleKey.UpArrow:
                            if(Player.direction!=PlayerSnake.Direction.down)
                            Player.direction = PlayerSnake.Direction.up;
                            break;
                        case ConsoleKey.DownArrow:
                            if(Player.direction!=PlayerSnake.Direction.up)
                            Player.direction = PlayerSnake.Direction.down;
                            break;
                        case ConsoleKey.LeftArrow:
                            if(Player.direction!=PlayerSnake.Direction.right)
                            Player.direction = PlayerSnake.Direction.left;
                            break;
                        case ConsoleKey.RightArrow:
                            if(Player.direction!=PlayerSnake.Direction.left)
                            Player.direction = PlayerSnake.Direction.right;
                            break;
                    }
                }

                if (Player.Head.x == Test.Target.x && Player.Head.y==Test.Target.y)
                {
                    Player.Eat();
                    Test = new Fruit();
                    Framerate -=25;
                }

                if (Player.GameOver() || Player.outOfRange)
                {
                    Console.WriteLine($"Koniec Gry, Twój wynik:"+Player.length);
                    Console.ReadLine();
                    Game = false;
                }
                Player.Move();
                System.Threading.Thread.Sleep(Framerate);

            }
        }
    }
}