//Напишите программу, которая перевернёт одномерный массив
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]
using System;

namespace Sem6
{
    internal class HM39
    {
        internal static void Start()
        {
            int[] array = Mass.CreateRandomArray(5,0,10);
            Mass.ShowArray(array);
            ChangeArray(array);
            Mass.ShowArray(array);
            void ChangeArray(int[] array)
            {
                int temp = 0;
                for (int i = 0; i < array.Length / 2; i++)
                {
                    temp = array[i];
                    array[i] = array[array.Length - 1 - i];
                    array[array.Length - 1 - i] = temp;
                }
            }
        }
    }
}