// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// c11 = a11 · b11 + a12 · b21 = 2 · 3 + 4 · 3 = 6 + 12 = 18
// c12 = a11 · b12 + a12 · b22 = 2 · 4 + 4 · 3 = 8 + 12 = 20
// c21 = a21 · b11 + a22 · b21 = 3 · 3 + 2 · 3 = 9 + 6 = 15
// c22 = a21 · b12 + a22 · b22 = 3 · 4 + 2 · 3 = 12 + 6 = 18
int[,] matrixA = new int[2, 2] { { 2, 4 }, { 3, 2 } };
int[,] matrixB = new int[2, 2] { { 3, 4 }, { 3, 3 } };
int[,] matrixC = new int[2, 2];
for (int i = 0; i < matrixA.GetLength(0); i++)
{
    for (int j = 0; j < matrixB.GetLength(0); j++)
    {
        matrixC[i, j] = 0;

        for (int k = 0; k < matrixA.GetLength(1); k++)
        {
            matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
        }
    }
}
System.Console.WriteLine("Произведение двух матриц:");
for (int i = 0; i < matrixC.GetLength(0); i++)
{
    for (int j = 0; j < matrixC.GetLength(1); j++)
    {
        System.Console.Write(j == matrixC.GetLength(1) - 1 ? matrixC[i, j] + "\n" : matrixC[i, j] + " ");
    }
}