//Вывод только неповторяющихся слов
using System;

namespace Stroki
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cтроки
            Console.WriteLine("Задание 3. Строки");

            //Символ-разделитель между словами - "!". В конце строки знак препинания не ставится.
            string str = "hello!world!how!are!how!you!good!how!are";
            Console.WriteLine(str);

            int amt = 0;//Количество слов в строке. Чтобы создать массив, содержащий все слова строки
            int length = str.Length;
            for (int i = 0; i < length; i++)
            {
                if (str[i] == '!') amt++;
            }
            amt++;


            string[] word = new string[amt];//массив слов. Для этого существует встроенный метод Split, но делаем все вручную.
            for (int i = 0; i < amt; i++)
            {
                word[i] = "";
            }

            //заполнение массива слов
            int ch = 0;
            for (int i = 0; i < length; i++)
            {
                if (str[i] != '!')
                {
                    word[ch] = word[ch] + str[i];
                }
                else
                    ch++;
            }

            Console.WriteLine();

            int abc = 0;//порядковый номер второго повторяющегося слова
            string repeatWord = "";
            for (int i = 0; i < amt; i++)
            {
                for (int j = 0; j < amt; j++)
                {
                    if (i != j && word[i] == word[j])
                    {
                        repeatWord = word[i];
                        abc = j;
                    }
                }
                //выводим не повторяющиеся слова
                if (word[i] != repeatWord)
                    Console.Write(word[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
