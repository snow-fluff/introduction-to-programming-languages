// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("Для первой прямой, заданной уравнением y = k1 * x + b1");
Console.Write("введите k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Для второй прямой, заданной уравнением y = k2 * x + b2");
Console.Write("введите k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

double[] crossPoint = new double[2];
FindCrossingPoint(k1, b1, k2, b2, crossPoint);

Console.Write("Точка пересечения прямых -> (" + crossPoint[0] + " ;" + crossPoint[1] + ")");

void FindCrossingPoint(double ik1, double ib1, double ik2, double ib2, double[] point)
{
    point[0] = (ib1 - ib2) / (ik2 - ik1);
    point[1] = ik1 * point[0] + ib1;    
}




