//Напишите программу, которая будет создавать копию заданного массива
//с помощью поэлементного копирования.
using System;

namespace Sem6
{
    internal class HM45
    {
        internal static void Start()
        {
            Console.WriteLine("Заполните массив");
            int[] oldmas = Mass.CreateArray();
            Mass.ShowArray(oldmas);
            int[] newmas = CopyCenter(oldmas);
            Mass.ShowArray(newmas);
        }

        private static int[] CopyCenter(int[] oldmas)
        {
            int[] copymas = new int[oldmas.Length];
            for (int i = 0; i < oldmas.Length; i++)
            {
                copymas[i] = oldmas[i];
            }
            return copymas;
        }
    }
}