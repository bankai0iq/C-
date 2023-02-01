// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.



bool TriangleCheck(int a , int b, int c)
{
   if (a < (b+c) && b < (a+c) && c < (a+b)) return true;
   else return false;
} 

Console.WriteLine("Введите три стороны треугольника :");
Console.Write("Введите сторону a :");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите сторону b :");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите сторону c :");
int c = Convert.ToInt32(Console.ReadLine());


bool res  = TriangleCheck(a,b,c);
Console.WriteLine(res ? "Да" : "Нет" );