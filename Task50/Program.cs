// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите индекс строки ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца ");
int n = Convert.ToInt32(Console.ReadLine());

    int [,] arr = new int [10, 10];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1,10);
            Console.Write($"{arr[i, j]}  ");
        }
        Console.WriteLine();
    }
if (m < arr.GetLength(0) && n < arr.GetLength(1))
{
    Console.WriteLine($"Значение элемента {m}{n} -> {arr[m, n]}");
}
else Console.WriteLine($"{m}{n} -> такого элемента в массиве нет");