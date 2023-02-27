// Задача 27
int Sumnumbers(int n)
{
    int sum = 0;
    while (n > 0)
    {
        sum = sum + n % 10;
        n = n / 10;
    }
    return sum;
}

Console.Clear();
Console.Write("Введите число ");
int n = int.Parse(Console.ReadLine());
Console.Write(Sumnumbers(n));
