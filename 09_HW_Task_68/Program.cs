// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.Write("Введите неотрицательное целое число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите неотрицательное целое число n: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m >= 0 & n >= 0)
    Console.WriteLine("m = " + m + ", n = " + n + " -> A(m,n) = " + Akkerman(m, n));
else
    Console.WriteLine("Числа m и n должны быть неотрицательными и целыми!");

int Akkerman(int numm, int numn)
{
    if (numm == 0)
        return (numn + 1);
    else if ((numm > 0) & (numn == 0))
        return Akkerman((numm - 1), 1);
    else if ((numm > 0) & (numn > 0))
        return Akkerman((numm - 1), Akkerman(numm, (numn - 1)));
    else 
        return 0;
}

