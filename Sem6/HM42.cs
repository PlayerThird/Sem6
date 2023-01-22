//Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3  -> 11
//2  -> 10
//Логика: постоянно находить остаток от деления на 2
//А потом развернуть
using Sem6;
using System;

namespace Sem6
{
    internal class HM42
    {
        internal static void Start()
        {
            string DecimalToBinary(int number)
            {
                string res = "";
                while (number > 0)
                {
                    string x1 = (number % 2).ToString();
                    res += x1;
                    number = number / 2;
                }
                char[] strChar = res.ToCharArray();
                Array.Reverse(strChar);
                res = string.Join("", strChar);
                return res;
            }

            int x = Checker.CheckInput<int>(x => x < 0, "Введите число в десятичной системе:   ", "Введите еще раз");
            Console.WriteLine(DecimalToBinary(x));
        }
    }
}