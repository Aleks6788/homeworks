//Task 2

Console.Write("Введите первое число ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите второе число ");
int m = int.Parse(Console.ReadLine());
int max = n;
if(m > max)
    Console.Write($"max = {m}");
else
    Console.Write($"max = {n}");