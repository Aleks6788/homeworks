// Задача 29
void InputArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 10);
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
}


Console.Clear();
Console.Write("Введите количество элл. массива: ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
InputArray(array);

