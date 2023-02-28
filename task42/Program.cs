// Задача 42
Console.Write("Введите координаты первой прямой ");
string[] numbersFirst = Console.ReadLine().Split(" ");
double k1 = Convert.ToDouble(numbersFirst[0]); 
double b1 = Convert.ToDouble(numbersFirst[1]);
Console.Write("Введите координаты второй прямой ");
string[] numbersSecond = Console.ReadLine().Split(" ");
double k2 = Convert.ToDouble(numbersSecond[0]);
double b2 = Convert.ToDouble(numbersSecond[1]);
Console.WriteLine((b2 - b1) / (k1 - k2) );
Console.Write(k2 * (b2 - b1) / (k1 - k2) + b2);

