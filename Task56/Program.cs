// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
int[,] array = new int[4, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 },{ 5, 2, 6, 7 } };
int sum = 0;
int currentArray = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    int tempSum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        tempSum = tempSum + array[i,j]; 
    }
    sum = i == 0 ? tempSum : sum;
    if (tempSum < sum)
    {
        sum = tempSum;
         currentArray = i;
         System.Console.WriteLine(currentArray);
    }
}
System.Console.WriteLine($"Номер строки с наименьшей суммой: {currentArray + 1}");