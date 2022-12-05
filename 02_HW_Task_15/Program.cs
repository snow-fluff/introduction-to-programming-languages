﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер дня недели: ");
int a1 = int.Parse(Console.ReadLine()!);

if (a1 < 1 || a1 > 7)
{
    Console.WriteLine("В неделе всео 7 дней! Введите цифру от 1 до 7!");

}
else
{
    if (a1 == 6 || a1 == 7)
    {
        Console.WriteLine("Выходной день");
    }
    else
    {
        Console.WriteLine("Будний день");
    }
}