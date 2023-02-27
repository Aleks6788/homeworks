// Задача 36
void InputArrat(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 11);
    Console.WriteLine($"Массив [{string.Join(", ", array)}])");
}
int Evenposition(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0)
        sum = sum + array[i];
    }
    return sum;
}


Console.Clear();
Console.Write("Введите кол-во элл. ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
InputArrat(array);
Console.Write($"Сумма элл. стоящих на нечет. порзициях = {Evenposition(array)}");