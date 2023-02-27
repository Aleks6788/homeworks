// Задача 25
int Numbers(int a, int b)
{
    int result = 1;
    int count = 1;
    while (count <= b)
    {
        result = result * a;
        count++;
    }
    return result;
}


Console.Write("Введите а -  ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите b -  ");
int b = int.Parse(Console.ReadLine());
Console.Write($"a в нвтуральной степени b = {Numbers(a, b)}");