// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число: ");
int a1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int a2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число: ");
int a3 = int.Parse(Console.ReadLine()!);

if (a1 >= a2 & a1 >= a3)
{
    Console.WriteLine(a1 + ", " + a2 + ", " + a3 + " -> " + a1);
}
if (a2 >= a1 & a2 >= a3)
{
    Console.WriteLine(a1 + ", " + a2 + ", " + a3 + " -> " + a2);
}
if (a3 >= a1 & a3 >= a2)
{
    Console.WriteLine(a1 + ", " + a2 + ", " + a3 + " -> " + a3);
}