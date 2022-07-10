/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/
Console.WriteLine("Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
Console.WriteLine("Введите координаты первой точки: ");

Console.WriteLine("Введите x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"({x1},{y1},{z1}) | ({x2},{y2},{z2})");

Coordinates(x1, y1, z1, x2, y2, z2);

void Coordinates(int X1, int Y1, int Z1, int X2, int Y2, int Z2)
{
    int x = x2 - x1;
    int y = y2 - y1;
    int z = z2 - z1;
    resultDistance(x, y, z);

    void resultDistance (int X, int Y, int Z)
    {
        double distance = x*x + y*y + z*z;
        double result = Math.Sqrt(distance);
        Console.WriteLine(result);
    }
}


