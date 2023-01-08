/*Задача 15: Напишите программу, которая принимает 
на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.Clear();

string[] week = { "monday", "tuesday", "wednsday", "thursday", "friday", "saturday", "sunday" };

Console.WriteLine("Введите номер дня недели");
int num = int.Parse(Console.ReadLine()?? "wares");

if (num < 1 || num > 7)
{
    Console.WriteLine("Сколько дней в неделе?");
}
else if (num > 5)
{
    Console.WriteLine($"сегодня {week[num - 1]}, выходной!");
}
else
{
    Console.WriteLine($"Сегодня {week[num - 1]}, рабочий день");
}