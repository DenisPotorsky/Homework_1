Console.Clear();

Console.WriteLine ("Введите первое число: ");
int numbers1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите второе число: ");
int numbers2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите третье число: ");
int numbers3 = Convert.ToInt32(Console.ReadLine());

int max = numbers1;

if (numbers2 > max)
{
    max = numbers2;
}
if (numbers3 > max)
{
    max = numbers3;
}

Console.WriteLine();
Console.WriteLine("Максимальное число " + max);
