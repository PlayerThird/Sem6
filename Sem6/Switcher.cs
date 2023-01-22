using System;

namespace Sem6
{
    internal class Switcher
    {
        internal static void Start()
        {
            int y = Checker.CheckInput<int>(x => x < 39 || x > 45, "Введите номер программы: ", "Такой программы нет");
            bool check = false;
            switch (y)
            {
                case 39:
                    DiscriptionTasks(y);
                    check = UnlockTasks();
                    CheckContinue(check);
                    Console.Clear();
                    DiscriptionTasks(y);
                    HM39.Start();
                    break;
                case 40:
                    DiscriptionTasks(y);
                    check = UnlockTasks();
                    CheckContinue(check);
                    Console.Clear();
                    DiscriptionTasks(y);
                    HM40.Start();
                    break;
                case 41:
                    DiscriptionTasks(y);
                    check = UnlockTasks();
                    CheckContinue(check);
                    Console.Clear();
                    DiscriptionTasks(y);
                    HM41.Start();
                    break;
                case 42:
                    DiscriptionTasks(y);
                    check = UnlockTasks();
                    CheckContinue(check);
                    Console.Clear();
                    DiscriptionTasks(y);
                    HM42.Start();
                    break;
                case 43:
                    DiscriptionTasks(y);
                    check = UnlockTasks();
                    CheckContinue(check);
                    Console.Clear();
                    DiscriptionTasks(y);
                    HM43.Start();
                    break;
                case 44:
                    DiscriptionTasks(y);
                    check = UnlockTasks();
                    CheckContinue(check);
                    Console.Clear();
                    DiscriptionTasks(y);
                    HM44.Start();
                    break;
                case 45:
                    DiscriptionTasks(y);
                    check = UnlockTasks();
                    CheckContinue(check);
                    Console.Clear();
                    DiscriptionTasks(y);
                    HM45.Start();
                    break;
                default:
                    Console.WriteLine("Такой программы нет");
                    Console.ReadLine();
                    CheckContinue(check);
                    break;
            }

            bool UnlockTasks()
            {
                bool check = false;
                Console.WriteLine("Это та программа, которая вам нужна?( + или - )");
                string answer = Console.ReadLine();
                string v = "+";
                if (answer == v)
                {
                    check = true;
                }
                return check;
            }
            void DiscriptionTasks(int y)
            {
                switch (y)
                {
                    case 39:
                        Console.WriteLine("Напишите программу, которая перевернёт одномерный массив" +
                            "\r\n(последний элемент будет на первом месте, а первый - на последнем и т.д.)" +
                            "\r\n[1 2 3 4 5] -> [5 4 3 2 1]" +
                            "[6 7 3 6] -> [6 3 7 6]");
                        break;
                    case 40:
                        Console.WriteLine("//Напишите программу, которая принимает на вход три числа и проверяет," +
                            "\r\n//может ли существовать треугольник с сторонами такой длины.");
                        break;
                    case 41:
                        Console.WriteLine("//Пользователь вводит с клавиатуры M чисел." +
                            "\r\n//Посчитайте, сколько чисел больше 0 ввёл пользователь." +
                            "\r\n//0, 7, 8, -2, -2 -> 2" +
                            "\r\n//-1, -7, 567, 89, 223-> 3");
                        break;
                    case 42:
                        Console.WriteLine("//Напишите программу, которая будет преобразовывать десятичное число в двоичное." +
                            "\r\n//45 -> 101101" +
                            "\r\n//3  -> 11" +
                            "\r\n//2  -> 10");
                        break;
                    case 43:
                        Console.WriteLine("//Напишите программу, которая найдёт точку пересечения двух прямых," +
                            "\r\n//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;" +
                            "\r\n//значения b1, k1, b2 и k2 задаются пользователем.");
                        break;
                    case 44:
                        Console.WriteLine("//Не используя рекурсию, выведите первые N чисел Фибоначчи." +
                            "\r\n//Первые два числа Фибоначчи: 0 и 1." +
                            "\r\n//Если N = 5-> 0 1 1 2 3" +
                            "\r\n//Если N = 3 -> 0 1 1" +
                            "\r\n//Если N = 7 -> 0 1 1 2 3 5 8");
                        break;
                    case 45:
                        Console.WriteLine("//Напишите программу, которая будет создавать копию заданного массива" +
                            "\r\n//с помощью поэлементного копирования.");
                        break;
                }
            }

            void CheckContinue(bool check)
            {
                if (check == false)
                {
                    Start();
                }
            }


        }
    }
}
