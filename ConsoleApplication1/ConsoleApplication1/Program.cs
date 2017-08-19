// Соловьев Артём Александрович, ПИ-16-1
// acmp.ru, задача №611
// Летняя учебная практика, задача №1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static int size = 0; // Размер словарного квадрата
        static string[] words; // Массив с заданными словами

        static void Read() // Чтение количества слов и самих слов
        {
            Console.WriteLine("Введите размер словарного квадрата:");
            size = Int32.Parse(Console.ReadLine());
            words = new string[size*2];

            for (int i = 0; i < size * 2; i++)
            {
                string word; // Читаемое слово
                Console.WriteLine("Введите {0}-е слово:", i+1);
                while (CheckWord(out word)) words[i] = word;
            }
        }

        static bool CheckWord(out string readWord)
        {
            readWord = Console.ReadLine();
            if (readWord.Length == size)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Длина слова должна быть равна {0} символам", size);
            }
            return false;
        }

        static void Main(string[] args)
        {
            
        }
    }
}
