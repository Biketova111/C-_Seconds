/* Напишите программу, которая на вход принимает трехзначное число и на выходе показывает последнюю цифру этого числа.
Например:
125 -> 5 */

Console.Write("Введите трехзначное число: ");
string numberSrt = Console.ReadLine();
int namber = Convert.ToInt32(numberSrt);

int result = Math.Abs(namber%10);

Console.WriteLine(result);

