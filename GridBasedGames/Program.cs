using System;

namespace GridBasedGames
{

    class Program
    {
        public static Grid grid = new Grid(20, 20);
        public static int fpsTarget = 1;
        public static double RenderSpeedInMilliseconds { get; private set; } = Math.Ceiling(1000.00 / fpsTarget);
        public static bool GameIsRunning { get; private set; }


        static void Main(string[] args)
        {
            grid.Init();

            GameLoop();
        }

        static void GameLoop()
        {
            DateTime frameCompletedTimeStamp = DateTime.Now;
            TimeSpan deltaTime;

            GameIsRunning = true;

            // test code
            GameObject testGo = new GameObject();
            testGo.Position = new Vector2(1, 3);
            testGo.ArtMatrix = Art.TestArt3x3;

            GameObject testGo2 = new GameObject();
            testGo2.Position = new Vector2(2, 5);
            testGo2.ArtMatrix = Art.TestArt4x4;
            int move = 1;
            while (GameIsRunning)
            {
                deltaTime = DateTime.Now - frameCompletedTimeStamp;

                

                if (deltaTime.TotalMilliseconds >= RenderSpeedInMilliseconds)
                {
                    Console.SetCursorPosition(0, 0);
                    grid.DisplayGameObject(testGo);
                    grid.DisplayGameObject(testGo2);

                    testGo.MoveTo(new Vector2(move, 10));

                    move = move + 1;
                    grid.Print();

                    frameCompletedTimeStamp = DateTime.Now;
                }

                
            }
        }
    }
}
