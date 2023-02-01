// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3


Console.WriteLine("Сколько чисел будет в масиве?");
int M = Convert.ToInt32(Console.ReadLine());

int count = 0;
int[] array = new int[M];
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите {i + 1} число  ");
    array[i] = Convert.ToInt32(Console.ReadLine());

    if (array[i] > 0)
    {
        count = count + 1;
    }
}
Console.WriteLine($"Вы ввели {count} положительных чисел");