// Задача 38
void InputArray(double[] array)
{

    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = rand.Next(1, 10) + rand.NextDouble();
}
double MinNumbers(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
            min = array[i];
    }
    return min;
}
double MaxNumbers(double[] array)
{
    double max = array[0];
     for (int i = 0; i < array.Length; i++)
     {
        if(max < array[i])
        max = array[i];
     }
     return max;
}


Console.Clear();
double[] array = new double[5];
InputArray(array);
Console.WriteLine($"Массив: {string.Join(", ", array)}");
Console.WriteLine($"Наименьшее число {MinNumbers(array)}");
Console.WriteLine($"Наибольшее число {MaxNumbers(array)}");
Console.WriteLine($"Разница: {MaxNumbers(array) - MinNumbers(array)}");