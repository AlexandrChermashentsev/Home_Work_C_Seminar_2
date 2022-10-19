/* Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Enter the number of the day of the week");
string numberStr = Console.ReadLine();
int numberWeek = Convert.ToInt32(numberStr);

if (numberWeek < 1 || numberWeek > 7) Console.WriteLine("there is no such day, joker");
else
{
    if (numberWeek == 6 || numberWeek == 7) Console.WriteLine("This day is a holiday");
    else Console.WriteLine("This day is weekday");
}