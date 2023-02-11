// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] array = new int[2, 2, 2];
var checkArray = new List<int>();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            int count = 0;
            while (count == 0)
            {
                int tempNum;
                tempNum = new Random().Next(10, 100);

                if (!checkArray.Contains(tempNum))
                {
                    array[i, j, k] = tempNum;
                    checkArray.Add(tempNum);
                    count++;

                }

            }
        }
    }
}
for (int k = 0; k < array.GetLength(0); k++)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(2); j++)
        {
            System.Console.Write(j == array.GetLength(2) - 1 ?
                    array[i, j, k] + " (" + i + ", " + j + ", " + k + ")\n" :
                    array[i, j, k] + " (" + i + ", " + j + ", " + k + ") ");
        }
    }
}
