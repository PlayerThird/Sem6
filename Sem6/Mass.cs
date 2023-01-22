using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Идёт вместе с Checker
namespace Sem6
{
    internal class Mass
    {
        // Создание и вывод массива

        //Создание рандомного массива
        public static int[] CreateRandomArray(int N, int start, int end)
        {
            int[] RandomArray = new int[N];
            for (int i = 0; i < N; i++)
            {
                RandomArray[i] = new Random().Next(start, end + 1);
            }
            return RandomArray;
        }
        //Создание массива
        //Тут используется Checker
        public static int[] CreateArray()
        {
            Console.WriteLine("Введите количество элементов массива");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = Checker.CheckInput<int>(x=> x == 666, $"Введите {i + 1} элемент массива", "Так, без вызова всякого дъявольского");
            }
            return array;
        }
        //Печать массива
        public static void ShowArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

    }
}
