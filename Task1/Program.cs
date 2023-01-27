/* Напишите программу, которая на входе принимает число и выдает ее квадрат (число умноженное на само себя).
Например:
4 -> 16
-3 -> 9
-7 -> 49
*/


Console.Write("Введите число: ");
string numberStr=Console.ReadLine();
int namber=Convert.ToInt32(numberStr);

int result=namber*namber;

Console.WriteLine($"Квадрат числа {namber} = {result}");

