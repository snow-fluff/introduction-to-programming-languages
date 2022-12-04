// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число: ");
int a1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int a2 = int.Parse(Console.ReadLine()!);

if (a1 > a2)
{
    Console.WriteLine("Число " + a1 + " больше чем число " + a2);
}
else
{
    Console.WriteLine("Число " + a2 + " больше чем число " + a1);
}