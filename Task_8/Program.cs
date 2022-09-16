/* Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */

using static System.Console;
Console.Clear();

WriteLine("Напишите число:");
int N = Convert.ToInt32(ReadLine());
int i = 2;
while (i < N)
{
    Write($"{i}, ");
    i += 2;
}
