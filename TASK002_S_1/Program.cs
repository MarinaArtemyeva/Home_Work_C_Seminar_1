// Напишите программу, которая принимает на вход 
// три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


double a;
Console.WriteLine("Введите а: ");
a = Convert.ToDouble(Console.ReadLine());

double b;
Console.WriteLine("Введите b: ");
b = Convert.ToDouble(Console.ReadLine());

double c;
Console.WriteLine("Введите c: ");
c = Convert.ToDouble(Console.ReadLine());

double max;
max = 0;

if (a > b)
{
    max = a;
}
else
{
    max = b;
}
if (max > c)
{
}
else
{
    max = c;
}
Console.WriteLine(max);