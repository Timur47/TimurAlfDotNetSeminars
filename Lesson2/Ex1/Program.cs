﻿//Напишите программу, которая выводит случайное число из отрезка [10, 99] 
//и показывает наибольшую цифру числа.
//78 -> 8
//12-> 2
//85 -> 8

void Ex1()
{
int val = new Random().Next(10, 100);
int a = val / 10;
int b = val % 10;
Console.WriteLine(val);

if (a > b)
{
    Console.WriteLine(a);
}
else
{
    Console.WriteLine(b);
}
}
Ex1();