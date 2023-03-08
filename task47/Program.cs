// Задача 47
void InputMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Random rand = new Random();
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            // matrix[i, j] = 5 - rand.Next(11) 
            matrix[i, j] = new Random().Next(1, 11) + rand.NextDouble();
            Console.Write($"{matrix[i, j]} \t");

        }
        Console.WriteLine();
    }
}
Console.Clear();
Console.Write("Введите размер матрицы ");
string[] numbers = Console.ReadLine().Split(" ");
double[,] matrix = new double[int.Parse(numbers[0]), int.Parse(numbers[1])];
InputMatrix(matrix);
