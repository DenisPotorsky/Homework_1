Console.Clear();

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

int min = a;
int max = a;

if (a > b)
{
    min = b;
}
else max = b;

Console.WriteLine($"Максимальное число {max}, минимальное число {min}.");
