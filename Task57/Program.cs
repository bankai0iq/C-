// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.


// void IncorrectValue()
// {
// Console.WriteLine("Введено некорректное значение.");
// Environment.Exit(0);
// }

// int UserInput()
// {
// if (!int.TryParse(Console.ReadLine(), out int temp)) IncorrectValue();
// return temp;
// }

// int[,] MatrixCreate(int rows, int columns, int min, int max)
// {
// int[,] array = new int[rows, columns];
// Random rnd = new Random();
// for (int i = 0; i < rows; i++)
// {
// for (int j = 0; j < columns; j++)
// {
// array[i, j] = rnd.Next(min, max + 1);
// }
// }
// return array;
// }

// void PrintMatrix(int[,] array)
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
// Console.Write("[");
// for (int j = 0; j < array.GetLength(1); j++)
// {
// if (j < array.GetLength(1) - 1)
// Console.Write($"{array[i, j],4} |");
// else Console.WriteLine($"{array[i, j],4}]");
// }
// }
// }

// int[] AllNumbersArray(int[,] array2D)
// {
// int arraySize = array2D.GetLength(0) * array2D.GetLength(1);
// int[] array = new int[ar