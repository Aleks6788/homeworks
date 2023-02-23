// Задача 21
void coordinates(int x, int y, int z, int x1, int y1, int z1)
{
    Console.WriteLine(Math.Sqrt(Math.Pow(x - x1, 2) + Math.Pow(y - y1, 2) + Math.Pow(z -z1, 2)));
}

Console.Clear();
Console.Write("Введите x  ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите y  ");
int y = int.Parse(Console.ReadLine());
Console.Write("Введите z  ");
int z = int.Parse(Console.ReadLine());
Console.Write("Введите x1  ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите y1  ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите z1  ");
int z1 = int.Parse(Console.ReadLine());
coordinates( x, y, z, x1, y1, z1);



