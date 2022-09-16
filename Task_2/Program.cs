using static System.Console;
Console.Clear();

WriteLine("Введите первое число: ");
int a = Convert.ToInt32(ReadLine());

WriteLine("Введите второе число: ");
int b = Convert.ToInt32(ReadLine());

int min = a;
int max = a;

if (a > b)
{
    min = b;
}
else max = b;

WriteLine($"Максимальное число {max}, минимальное число {min}.");
