using static System.Console;
Console.Clear();

WriteLine ("Введите первое число: ");
int numbers1 = Convert.ToInt32(ReadLine());

WriteLine ("Введите второе число: ");
int numbers2 = Convert.ToInt32(ReadLine());

WriteLine ("Введите третье число: ");
int numbers3 = Convert.ToInt32(ReadLine());

int max = numbers1;

if (numbers2 > max)
{
    max = numbers2;
}
if (numbers3 > max)
{
    max = numbers3;
}

WriteLine();
WriteLine("Максимальное число " + max);
