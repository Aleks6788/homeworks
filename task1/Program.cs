// Задача: Создать и перемешать одномерный массив.
void InputArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 11);
}
int[] MixArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        int j = new Random().Next(i + 1);
        int temp = array[j];
        array[j] = array[i];
        array[i] = temp;
    }
    return array;
}


Console.Clear();
Console.Write("Введите количество эллиментов ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.Write($"Исходный массив {string.Join(", ", array)}");
Console.WriteLine();
Console.Write($"Новый массив {string.Join(", ", MixArray(array))}");
