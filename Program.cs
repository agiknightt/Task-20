using System;

namespace Task_20
{
    class Program
    {
        static void Main(string[] args)
        {
            float health = 5;
            bool enterOrExit = true;           

            while (enterOrExit)
            {
                Console.Write("Введите процент заполнения шкалы : ");
                health = Convert.ToSingle(Console.ReadLine());

                DrawBar(health, 0);

                Console.ReadKey();
                Console.Clear();
            }            
        }

        static void DrawBar(float percent,  int position, char symbol = '#',  char emptySymbol = '_')
        {
            string bar = "";
            float maxLongBar = 50;

            Console.SetCursorPosition(0, position);
            Console.Write('[');

            percent *= maxLongBar / 100;

            for (int i = 0; i < percent; i++)
            {
                bar += symbol;
            }

            for (float i = percent; i < maxLongBar; i++)
            {
                bar += emptySymbol;
            }
            Console.Write(bar + ']');
        }
    }
}
