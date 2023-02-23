// Задача 23
void Numbers(int n)
{
    for(int i = 1; i <= n; i++)
    Console.WriteLine(Math.Pow(i, 3));
}

Console.Clear();
Console.Write("Введите число  ");
int n = int.Parse(Console.ReadLine());
Numbers( n);


