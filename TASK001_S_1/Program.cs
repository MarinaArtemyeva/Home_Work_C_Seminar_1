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