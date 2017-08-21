using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class IO
    {
        static public int sizeOfSquare = 0; // Размер квадрата
        static public string[] words; // Массив с размером слов

        static void Read()
        {
            sizeOfSquare = ReadSize();
            words = ReadWords(sizeOfSquare*2);
        }

        static int ReadSize()
        {
            int size;

            Console.WriteLine("Введите размер словарного квадрата:");

            do
            {
                size = int.Parse(Console.ReadLine());
                if ((size > 10) || (size < 2)) Console.WriteLine("Размер квадрата должен быть больше 2 и не должен превышать 10. Введите данные ещё раз");
            } while ((size > 10) || (size < 2));

            return size;
        }

        static string[] ReadWords(int numberOfWords)
        {
            string[] newWords = new string[numberOfWords];
            string word;
            bool checkWord = true;

            for (int i = 0; i < numberOfWords; i++)
            {
                do
                {
                    Console.WriteLine("Введите {0}-е слово", i + 1);
                    word = Console.ReadLine();

                    for (int j = 0; j < word.Length; j++)
                    {
                        if (word[j] >= 'A' && word[j] <= 'Z') checkWord = true;
                        else
                        {
                            checkWord = false;
                            Console.WriteLine("В строке должны быть только символы английского алфавита!");
                            break;
                        }
                    }

                    if (word.Length != sizeOfSquare)
                    {
                        Console.WriteLine("Длина слова должна быть равна {0} символам!", sizeOfSquare);
                        checkWord = false;
                    }
                } while (!checkWord);

                newWords[i] = word;
            }

            return newWords;
        }
    }
}
