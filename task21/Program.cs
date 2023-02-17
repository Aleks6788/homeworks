// Task 21
Console.Write("Введите число ");
int n = int.Parse(Console.ReadLine());
int a = n % 10;
int a1 = n / 10000;
int b = n / 10 % 10;
int b1 = n / 1000 % 10;
if(a == a1 && b == b1)
Console.Write($"Yes");
else
Console.Write($"No");

