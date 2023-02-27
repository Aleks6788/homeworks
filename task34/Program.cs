// Задача 34
void InputArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(100, 1000);
    Console.WriteLine($"Массив: [{string.Join(", ",array)}]");
}
void Evennumbers(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
    if(array[i] % 2 == 0)
    count ++;
    }
    Console.WriteLine($"Количество положительных элл. - {count}");
}


Console.Clear();
Console.Write("Введите кол-во эллиментов ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Evennumbers(array);
