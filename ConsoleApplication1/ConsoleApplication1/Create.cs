using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Create
    {
        public static void TwoMas(int sizeOfSquare, string[] words)
        {
            char[] useWord = new char[sizeOfSquare]; // Массив с символами определённого слова

            for (int i = 0; i < words.Length; i++)
            {
                string wordToChar = words[i];
                for (int j = 0; j < sizeOfSquare; j++)
                {
                    useWord[j] = wordToChar[j];
                }

                for (int k = 0; k < words.Length; k++)
                {
                    
                }

            }
        }
    }
}
