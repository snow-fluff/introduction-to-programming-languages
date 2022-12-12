// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int sumStructure(int A)
{
    int res = 0;
    if (A < 10)
    {
        res = A;
    }
    else
    {
        while (A > 10)
        {
            res = res + A % 10;
            A = A / 10;
        }
        res = res + A;
    }
    return res;
}

Console.Write("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write(numA + " -> " + sumStructure(A: numA));