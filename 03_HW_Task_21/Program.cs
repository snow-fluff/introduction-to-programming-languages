// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату X точки A: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y точки A: ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z точки A: ");
int az = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату X точки B: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y точки B: ");
int by = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z точки B: ");
int bz = Convert.ToInt32(Console.ReadLine());

double distanse = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));

Console.WriteLine("A(" + ax + ", " + ay + ", " + az + "); B(" + bx + ", " + by + ", " + bz + ") -> " + "{0: 0.00}", distanse);