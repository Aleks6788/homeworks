// Задача 2: Создать массив, найти кол-во каждого элл. массива.
void InputArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 11);    
}
void ReleasArray(int[] array) 
{
     for (int i = 0; i < array.Length; i++) 
        {
            int count = 0; 
            for (int j = 0; j < array.Length; j++)
            {

                if (array[i] == array[j])
                    count ++;
            }
            Console.WriteLine($"Эллимент {array[i]} встречается {count} раз");
        }
}

Console.Clear();
Console.Write("Введите колич. элл. массива ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Исходный массив: {string.Join(", ", array)}");
ReleasArray(array);
