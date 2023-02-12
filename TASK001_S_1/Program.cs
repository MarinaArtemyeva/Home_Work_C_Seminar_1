// Напишите программу, которая на вход принимает 
// два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


double a;
Console.WriteLine("Введите а: ");
a = Convert.ToDouble(Console.ReadLine());
double b;
Console.WriteLine("Введите b: ");
b = Convert.ToDouble(Console.ReadLine());
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
Console.WriteLine(max);