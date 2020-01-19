using System;

namespace Skobki
{
    class Program
    {
        static void Main(string[] args)
        {
            //()[()]{()()[]} - хорошая   [()]([[()]])[][[[(())]]]
            //[(]{}) - плохая   (][)   ]][[))()((

            //Преобразуем строку в массив символов
            string str1 = "]][[))()((";    //                      <---СЮДА строку для проверки
            char[] str2 = new char[2 * str1.Length];
            for (int j = 0; j < 2 * str1.Length; j++)
            {
                if (j < str1.Length) str2[j] = str1[j];
                else str2[j] = ' ';
            }
            int length = str2.Length;
            int l = length;
            char[] strMas = new char[length];
            int i;

            //Вывод массива символов на экран
            Console.Write("Задана последовательность скобок: ");
            for (i = 0; i < length; i++)
            {
                strMas[i] = str2[i];
                Console.Write(strMas[i]);
            }
            Console.WriteLine();

            i = 0;
            //Начинаем с самых внутренних скобок. Если они существуют и они парные - то вычеркиваем их из дальнейшего рассмотрения. Проверяем все остальные скобки.
            while (length >= 2)
            {
                int z = length;
                for (int j = 0; j < length - 1; j++)
                {
                    int k = j + 1;
                    while (strMas[k] == '_') k++;
                    if (strMas[j] == '{' && strMas[k] == '}')
                    {
                        strMas[j] = '_';
                        strMas[k] = '_';
                        length = length - 2;
                    }
                    //  Console.Write(strMas[j]);
                }
                // Console.WriteLine();

                for (int j = 0; j < length - 1; j++)
                {
                    int k = j + 1;
                    while (strMas[k] == '_') k++;
                    if (strMas[j] == '(' && strMas[k] == ')')
                    {
                        strMas[j] = '_';
                        strMas[k] = '_';
                        length = length - 2;
                    }
                    //   Console.Write(strMas[j]);
                }
                //   Console.WriteLine();

                for (int j = 0; j < length - 1; j++)
                {
                    int k = j + 1;
                    while (strMas[k] == '_') k++;
                    if (strMas[j] == '[' && strMas[k] == ']')
                    {
                        strMas[j] = '_';
                        strMas[k] = '_';
                        length = length - 2;
                    }
                    // Console.Write(strMas[j]);
                }
                //Console.WriteLine();
                if (z == length) break;
            }


            //Console.WriteLine(length);  // -- Если последовательность правильная, то полчаетя равной str1/2. 


            //Если все символы заменились "_" - то последовательность правильная
            int prpr = 0;
            for (i = 0; i < l; i++)
            {
                if (strMas[i] != '{' && strMas[i] != '}' && strMas[i] != '[' && strMas[i] != ']' && strMas[i] != '(' && strMas[i] != ')')
                {
                    prpr++;
                }
            }
            if (prpr == l) Console.WriteLine("Правильная скобочная последовательность");
            else Console.WriteLine("Неправильная скобочная последовательность");

            Console.ReadLine();
        }
    }
}
