//Не используя рекурсию, выведите первые N чисел Фибоначчи.
//Первые два числа Фибоначчи: 0 и 1.
//Если N = 5-> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8
using System;

namespace Sem6
{
    internal class HM44
    {
        internal static void Start()
        {
            var mc = new HM44();
            Console.WriteLine("Введите число");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] array = mc.Fibonachi(number);
            Mass.ShowArray(array);

        }

        public int[] Fibonachi(int num)
        {
            int[] array = new int[num];
            array[0] = 0;
            array[1] = 1;
            array[2] = 1;
            for (int i = 3; i < num; i++)
            {
                array[i] = array[i-1] + array[i-2];

            }
            return array;
        }
    }
}