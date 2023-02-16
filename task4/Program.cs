// Task 4

Console.Write("Введите 1 число ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите 2 число ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите  3 число ");
int c = int.Parse(Console.ReadLine());
int max = n;
if(m > max) max = m;
if(c > max) max = c;
    Console.Write($"Максимальное число = {max}");    