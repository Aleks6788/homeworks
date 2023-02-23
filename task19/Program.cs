// Задача 19
string palindrome(int n)
{
    int a = n % 10;
    int a1 = n / 10000;
    int b = n / 10 % 10;
    int b1 = n / 1000 % 10;
    if (a == a1 && b == b1)
   return "Да";
else
return "Нет";
}

Console.Clear();
Console.Write("Введите пятизначное число ");
int n = Convert.ToInt32(Console.ReadLine());
palindrome(n);
Console.Write($"Введенное число палиндром ? - {palindrome(n)}");