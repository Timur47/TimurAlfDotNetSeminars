﻿/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

void Weekend()
{
    int x = Convert.ToInt32(Console.ReadLine());
    if (x <= 5)
    {
        if (x < 1)
        {
            Console.WriteLine("Дней недели всего 7 :)");
        }
        else
        {
            Console.WriteLine("нет");
        }
    }
    else
    {
        if (x > 7)
        {
            Console.WriteLine("Дней недели всего 7 :)");
        }
        else
        {
            Console.WriteLine("Выходной");
        }
    }
}
Weekend();
