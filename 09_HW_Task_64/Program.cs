// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
Console.Write("Введите натураьное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("N = " + n + " -> " + FindNaturalNumbers(n));

string FindNaturalNumbers(int num)
{
    if (num == 1) return num.ToString();
    else return (num + ", " + FindNaturalNumbers(num-1));
}