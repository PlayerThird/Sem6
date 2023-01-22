//Напишите программу, которая принимает на вход три числа и проверяет,
//может ли существовать треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
using System;

namespace Sem6
{
    internal class HM40
    {
        internal static void Start()
        {
            Console.WriteLine("Введите 3 стороны");
            int[] stor = Mass.CreateArray();
            int max = 0;
            int sum = 0;
            int j = 1;
            int k = 2;
            int itog = 0;
            for (int i = 0; i < stor.Length; i++)
            {
                if (j == stor.Length)
                {
                    j = 0;
                }
                if (k == stor.Length)
                {
                    k = 0;
                }
                max = stor[i];
                sum = stor[j] + stor[k];
                if (max < sum)
                {
                    itog++;
                }
                
                j++;
                k++;
            }
            if (itog == 3)
            {
                Console.WriteLine("Теорема о неравенстве работает");
            }
            else
            {
                Console.WriteLine("Теорема о неравенстве не работает");
            }
        }
    }
}