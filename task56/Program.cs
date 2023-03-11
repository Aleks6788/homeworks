// Залача 56

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
        }
        Console.WriteLine();
    }
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
void ArrangeMatrix(int[,] matrix)
{
    int[] res1 = new int[matrix.GetLength(0)];  
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];   
        }
        res1[i] = sum; 
        sum = 0; 
    }

    int min = 0;    
    for (int j = 1; j < matrix.GetLength(1); j++)
    {
        if (res1[j] < res1[min])   
            min = j;
    }
    Console.WriteLine("Номер строки с минимальной суммой элементов: " + min);
   

}


Console.Clear();
Console.Write("Введите размер прямоугольной матрицы ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
while (size[0] == size[1])
{
    Console.WriteLine("Вы ввели не те размеры. \n Введите размер прямоугольной матрицы ");
    size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Исходный массив ");
PrintMatrix(matrix);
Console.WriteLine();
ArrangeMatrix(matrix);
