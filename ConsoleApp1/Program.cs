using System;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.CursorVisible = false;
            int lastTick = 0;
            const int WAIT_TICK = 1000 / 30;
            const char CIRCLE = '\u25CF';

            while (true)
            {
                #region 프레임 관리

                int currentTick = System.Environment.TickCount;
                // 만약 경과한 시간이 1/30 보다 작다면
                if (currentTick - lastTick < WAIT_TICK)
                    continue;
                lastTick = currentTick;

                #endregion

                // 입력

                // 로직

                // 렌더링

                Console.SetCursorPosition(0, 1);
                // Console.WriteLine("hello world");

                for (int i = 0; i < 25; i++)
                {
                    for (int j = 0; j < 25; j++)
                    {
                        // Console.Write(CIRCLE);
                        Console.Write("" + CIRCLE + " ");
                    }
                    // Console.WriteLine();
                    Console.Write('\n');
                }

                // break;
            }
        }
    }
}