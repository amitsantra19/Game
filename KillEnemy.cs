using System;

namespace KillEnemy
{
    class KillEnemy
    {
        public static void Main()
        {
            Console.WindowHeight = 20;
            Console.WindowWidth = 40;
            int screenHeight = Console.WindowHeight;
            int screenWidth = Console.WindowWidth;
            int scoreCount = 0;
            Console.WriteLine("Enemy- SpaceBar, fire- Enter");
            Console.Write("Movement- left/right Arrow");
            System.Threading.Thread.Sleep(1500);
            Console.Clear();
            ConsoleKeyInfo keyInfo;
            while (true)
            {
                
                keyInfo = Console.ReadKey(true);
                //Console.Clear();
                Console.SetCursorPosition(screenWidth / 2, screenHeight);
                Console.Write("#");
                switch (keyInfo.Key)
                {
                    case ConsoleKey.Spacebar:
                        SetEnemy();
                        break;
                    case ConsoleKey.RightArrow: 
                        if (screenWidth <= 76)
                        {
                            //ClearCurrentConsoleLine();
                            //Console.Write(" ");
                            //Console.Write("\b");
                            screenWidth++;
                            Console.SetCursorPosition(screenWidth / 2, screenHeight);
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                            Console.Write(" ");
                            //Console.Write("#");
                            //ClearCurrentConsoleLine();
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (screenWidth > 0)
                        {
                            //ClearCurrentConsoleLine();
                            //Console.Write("\b");
                            screenWidth--;
                            Console.SetCursorPosition(screenWidth / 2, screenHeight);
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                            Console.Write(" ");
                            //ClearCurrentConsoleLine();
                            //Console.Write("#");
                        }
                        break;
                    case ConsoleKey.Enter:
                        do
                        {
                            screenHeight--;
                            Console.SetCursorPosition(screenWidth / 2, screenHeight);
                        } while (screenHeight > 4);
                        Console.Write("^");
                        Console.Beep();
                        CountScore(scoreCount);
                        screenHeight = Console.WindowHeight;
                        screenWidth = Console.WindowWidth;
                        System.Threading.Thread.Sleep(2000);
                        Console.Clear();
                        SetEnemy();
                        break;
                }
                //ClearCurrentConsoleLine();
            } 
            
           
           
        }

        public static void CountScore(int score = 0)
        {
            Console.SetCursorPosition(0,0);
            score = score + 10;
            Console.Write($"Total Score is : {score.ToString()}");
        }

        public static void SetEnemy()
        {
            Random enemy = new Random();
            int enemyPosition = enemy.Next(3, 38);
            Console.SetCursorPosition(enemyPosition, 4);
            Console.Write("@");
        }

        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
    }
}
