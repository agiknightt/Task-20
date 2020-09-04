using System;

namespace Task_20
{
    class Program
    {
        static void Main(string[] args)
        {
            float health = 5, maxHealth = 100;
            bool enterOrExit = true;           

            while (enterOrExit)
            {
                Console.Write("Введите процент заполнения шкалы : ");
                health = Convert.ToSingle(Console.ReadLine());

                DrawBar(health, maxHealth, 0);

                Console.ReadKey();
                Console.Clear();
            }            
        }

        static void DrawBar(float value, float maxValue,  int position, char symbol = '#',  char emptySymbol = '_')
        {
            string bar = "";

            Console.SetCursorPosition(0, position);
            Console.Write('[');

            value *= maxValue / 100;

            for (int i = 0; i < value; i++)
            {
                bar += symbol;
            }

            for (float i = value; i < maxValue; i++)
            {
                bar += emptySymbol;
            }
            Console.Write(bar + ']');
        }
    }
}
