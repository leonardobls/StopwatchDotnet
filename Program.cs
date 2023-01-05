using System;

namespace StopwatchDotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Menu();
        }

        static void Menu()
        {

            Console.WriteLine("Insira o tempo a ser contado + a forma de contagem:\n\n\tS - Segundos\n\tM - Minutos\n\t0 - Sair");

            string input = Console.ReadLine().ToLower();
            char type = char.Parse(input.Substring(input.Length - 1, 1));

            input = input.Substring(0, input.Length - 1);
            int time;

            if (type == 'm')
                time = int.Parse(input) * 60;
            else
                time = int.Parse(input);

            if (input == "0")
                System.Environment.Exit(0);

            Start(time);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (time != currentTime)
            {
                currentTime++;
                Console.Clear();
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Cronometro Finalizado!");
            // Menu();
        }
    }
}