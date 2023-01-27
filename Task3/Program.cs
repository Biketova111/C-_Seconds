/* Напишите программу, которая будет выдавать название дня недели по заданному номеру.
Напимер:
3->Среда */

Console.Write("Введите номер дня недели: ");
string namberStr = Console.ReadLine();
int namber = Convert.ToInt32(namberStr);

if (namber == 1)
{
    Console.WriteLine("Понедельник");
}

if (namber == 2)
{
    Console.WriteLine("Вторник");
}

if (namber == 3)
{
    Console.WriteLine("Среда");
}

if (namber == 4)
{
    Console.WriteLine("Четверг");
}
if (namber == 5)
{
    Console.WriteLine("Пятница");
}

if (namber == 6)
{
    Console.WriteLine("Суббота");
}
if (namber == 7)
{
    Console.WriteLine("Воскресенье");
}
if (namber>7)
{
  Console.WriteLine("Нет такого дня недели");  
}