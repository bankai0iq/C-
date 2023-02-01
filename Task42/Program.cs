// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int NumBinary(int number)
{
    int numberBin = 0;
    int count = 1;

   while (number > 0)
     {
        number /= 2; 
        count*=10;
     }
     return numberBin;
}

Console.WriteLine("Введите число :");
int num = Convert.ToInt32(Console.ReadLine());
int result = NumBinary(num);
Console.WriteLine(result);

