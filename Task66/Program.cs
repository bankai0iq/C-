// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

int sum(int M, int N)
{
    int summa = M;
    if (M == N)
    {
        return 0;
    }
    else
    {
        M++;
        summa = M + sum(M, N);
        return summa;
    }
}

Console.Write (sum (M-1,N));