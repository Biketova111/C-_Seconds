/* Напишите программу, которая на входе принимает два числа 
и проверяет является ли первое число квадратом второго.
Например:
а = 25, b = 5 -> да
а = 2, b = 5 -> нет */

Console.Write("Введите первое число, a = ");
string namberStr1 = Console.ReadLine();
int namber1=Convert.ToInt32(namberStr1);

Console.Write("Введите второе число, b = ");
string namberStr2 = Console.ReadLine();
int namber2=Convert.ToInt32(namberStr2);

int result = namber1/namber2;

if(result==namber2)
{
    Console.WriteLine("а является квадратом b");
}
else
{
    Console.WriteLine("а неявляется квадратом b");
}