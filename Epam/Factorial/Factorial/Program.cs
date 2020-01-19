//Нахождение факториала числа. Сделано все с Main-е.
using System;

namespace Factorial
{
    class Program
    {
        //так же факториал можно написать через рекурсивный метод
        static void Main(string[] args)
        {
            Console.Write("Введите число, факториал которого нужно посчитать: ");
            int x = int.Parse(Console.ReadLine());
            ulong fact = 1;
            for (int i = 1; i <= x; i++)
            {
                fact = fact * (ulong)i;
            }
            Console.Write("Факториал числа " + x + " равен " + fact);

            Console.ReadLine();
        }
    }
}
