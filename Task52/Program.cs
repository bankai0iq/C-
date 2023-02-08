// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] arr = new int[3, 4];
double temp = 0;
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(1, 10);
        Console.Write($"{arr[i, j]}  ");
    }
    Console.WriteLine();
}
Console.Write("Среднее арифметическое каждого столбца: ");
for (int j = 0; j < arr.GetLength(1); j++)
{
    temp = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        temp = temp + arr[i, j];
    }
    Console.Write($"{Math.Round(temp / arr.GetLength(0),2)}; ");
}
