//Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3

using System;

namespace Sem6
{
    internal class HM41
    {
        internal static void Start()
        {
            int[] numbers = Mass.CreateArray();
            Mass.ShowArray(numbers);
            Checking(numbers);

            void Checking(int[] mass)
            {
                int j = 0;
                for (int i = 0; i < mass.Length; i++)
                {

                    if (mass[i] > 0)
                    {
                        j++;
                    }
                }
                Console.WriteLine($"Всего положительных чисел = {j}");
            }
        }
    }
}