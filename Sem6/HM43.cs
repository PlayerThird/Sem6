//Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//значения b1, k1, b2 и k2 задаются пользователем.

using System;
using System.Collections.Generic;

namespace Sem6
{
    internal class HM43
    {
        internal static void Start()
        {
            Console.WriteLine("Введите координаты двух прямых");
            Console.WriteLine("Введите координаты 1й прямой");
            double[] a = CreateArray(2,0);
            double[] b = CreateArray(2,2);
            if (a[1] == b[1])
            {
                Console.WriteLine("Прямые паралельны");
                return;
            }
            double x = 0;
            double y = 0;
            x = (b[0] - a[0]) / (a[1] - b[1]);
            y = b[1] * x + b[0];
            Console.WriteLine($"Координата точки соприкосновения х = {x}");
            Console.WriteLine($"Координата точки соприкосновения y = {y}");











            double[] CreateArray(int size, int pos)
            {
                string[] strok = { "b1", "k1", "b2", "k2" };
                double[] array = new double[size];
                for (int i = 0; i < size; i++)
                {
                    array[i] = Checker.CheckInput<double>(x => x == 666, $"Введите значение {strok[pos]}", "Так, без вызова всякого дъявольского");
                    pos++;
                }
                return array;
            }
        }
    }
}