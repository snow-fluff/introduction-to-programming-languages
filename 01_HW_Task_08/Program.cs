// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int a1 = Convert.ToInt32(Console.ReadLine());

Console.Write(a1 + " -> ");

for (int index = 1; index < (a1 + 1); index++)
{
    if (index % 2 == 0)
    {
        Console.Write(index + " ");
    }
}