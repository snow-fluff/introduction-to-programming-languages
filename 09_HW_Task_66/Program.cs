// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.Write("Введите натураьное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натураьное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("M = " + m + "; N = " + n + " -> " + FindNaturalNumbersSumm(m, n));

int FindNaturalNumbersSumm(int numM, int numN)
{
    if (numM == (numN - 1)) return (numM + numN);
    else return (numM + FindNaturalNumbersSumm(numM + 1, numN));
}