// Задача 41
Console.Write("Введите числа ");
string[] n = Console.ReadLine().Split(" ");
int count = 0;
foreach (string i in n) 
{
    if (int.Parse(i) > 0)
        count++;
}
Console.Write($"Чисел больше нуля: {count}");
