// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int inPower(int A, int B)
{
    int res = A;
    for (int i = 2; i <= B; i++)
    {
        res = res * A;
    }
    return res;
}

Console.Write("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.Write(numA + " в степени " + numB + " -> ");

Console.Write(inPower(A: numA, B: numB));