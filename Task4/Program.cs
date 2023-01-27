/* Напишите программу, которая на вход принимает одно число (N), а на выход показывает в се числа в промежутке от -N  до N.
Например:
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" */

Console.Write("Введите число N: ");
string namberStr=Console.ReadLine();
int namber=Math.Abs(Convert.ToInt32(namberStr));

for (int i = -namber; i <= namber; i++)
{
    Console.Write($"{i}, ");
}
