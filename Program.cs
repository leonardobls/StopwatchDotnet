using System;

namespace StopwatchDotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            int time = 10;
            int currentTime = 0;

            while (time != currentTime)
            {
                currentTime++;
                Console.Clear();
                Console.WriteLine(currentTime);

                Thread.Sleep(1000);
            }
        }
    }
}