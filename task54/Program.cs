// Задача 54

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
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
void SortMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if(matrix[i, k] < matrix[i, k + 1])
                {
                    int temp = matrix[i, k + 1];                
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = temp;
                    
                }
            }
        }
    }
}


Console.Clear();
Console.Write("Введите размер матрицы ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Начальный массив:");
PrintMatrix(matrix);
Console.WriteLine();
SortMatrix(matrix);
Console.WriteLine("Отсортированный массив:");
PrintMatrix(matrix);