// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
double Distance(int xa, int ya, int za, int xb, int yb, int zb)
{
    double result = Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya) + (zb - za) * (zb - za));
    return result;
}
Console.WriteLine("Input point A coordinates");
Console.Write("Xa coordinate = ");
int coordXa = Convert.ToInt32(Console.ReadLine());
Console.Write("Ya coordinate = ");
int coordYa = Convert.ToInt32(Console.ReadLine());
Console.Write("Za coordinate = ");
int coordZa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input point B coordinates");
Console.Write("Xb coordinate = ");
int coordXb = Convert.ToInt32(Console.ReadLine());
Console.Write("Yb coordinate = ");
int coordYb = Convert.ToInt32(Console.ReadLine());
Console.Write("Zb coordinate = ");
int coordZb = Convert.ToInt32(Console.ReadLine());
double DistAB = Distance(coordXa, coordYa, coordZa, coordXb, coordYb, coordZb);
Console.Write("Distance between A and B points -> ");
Console.WriteLine($"{Math.Round(DistAB, 2, MidpointRounding.ToZero)}");