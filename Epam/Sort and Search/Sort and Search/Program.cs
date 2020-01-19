//Программы 1, 2: Сортировка и поиск. Сортировка Шелла. Поиск - обычный проход по всем элементам. Алгоритм так же находит повторяющиеся искомые элементы.
using System;

namespace Sort_and_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сортировка
            Console.WriteLine("Задание 1. Сортировка");
            Console.Write("Введите размерность массива: ");
            int n = int.Parse(Console.ReadLine());
            int[] mas = new int[n];
            mas = RandMas(mas);
            Console.WriteLine("Рандомный массив из {0} элементов", n);
            ShowMas(mas);
            mas = SortMas(mas);
            Console.WriteLine("Отсортированный массив");
            ShowMas(mas);

            Console.WriteLine();

            //Поиск
            Console.WriteLine("Задание 2. Поиск");
            Console.Write("Введите элемент, который нужно найти: ");
            int search = int.Parse(Console.ReadLine());
            int[] mass = new int[2];
            mass = SearchElements(search, mas);
            ShowSearchElements(mass);

            Console.ReadLine();
        }

        //Метод принимает массив и выводит его на экран
        static void ShowMas(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine();
        }

        //Метод принимает массив. Внутри метода задается размер максимального рандомного числа.
        //Возвращает рандомный массив той же размерности
        static int[] RandMas(int[] mas)
        {
            Random rnd = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(20); // <--20 - макс число
            }

            return mas;
        }

        //Метод принимает массив. 
        //Возвращает отсортированный массив. (Сортировка Шелла)
        static int[] SortMas(int[] mas)
        {

            int h;
            int tmp;
            for (h = mas.Length / 2; h > 0; h /= 2)
            {
                for (int i = h; i < mas.Length; i++)
                {
                    for (int j = i - h; j >= 0 && mas[j] > mas[j + h]; j -= h)
                    {
                        tmp = mas[j];
                        mas[j] = mas[j + h];
                        mas[j + h] = tmp;
                    }
                }
            }
            return mas;
        }

        //Метод принимает искомый элемент и массив, в котором его нужно найти. 
        //Возвращает массив, где 1ый элемент - количество искомых элементов, 2ой - порядковый номер крайнего искомого элемента
        static int[] SearchElements(int search, int[] mas)
        {
            int amountOfEl = 0;
            int itemNumber = 0;
            int[] res = new int[2];
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] == search)
                {
                    itemNumber = i;
                    amountOfEl++;
                    res[0] = itemNumber;//количество искомых элементов
                    res[1] = amountOfEl;//порядковый номер последнего
                }
            }
            return res;
        }

        //Метод принимает массив с количеством и порядковым номером искомого элемента и выводит все порядковые номера элементов, равных искомому
        static void ShowSearchElements(int[] res)
        {
            int k = 0;
            Console.Write("Искомый элемент имеет порядковые номера: ");
            while (k != res[1])
            {
                Console.Write(res[0] + " ");
                res[0]--;
                k++;
            }
            if (res[1] == 0)
                Console.WriteLine("Искомый элемент не найден");

        }


    }
}
