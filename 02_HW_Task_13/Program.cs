// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int a1 = int.Parse(Console.ReadLine()!);

if (a1 < 99)
{
    Console.WriteLine("Третьей цифры нет!");
}
else
{
    Console.Write(a1 + " -> ");
    if (a1 > 999)
    {
        while (a1 > 999)
        {
            a1 = a1 / 10;
        }
        Console.WriteLine(a1 % 10);
    }
    else
    {
        Console.WriteLine(a1 % 10);
    }
}
