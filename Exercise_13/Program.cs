/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.WriteLine("Enter the number");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);
int count = number.ToString().Length;
int result = 0;
if (count < 3) Console.WriteLine("It's not a three digit number");
else
{
    int degree = 1;
    for (int index = count; index > 3; index--)
    {
        degree = degree * 10;
    }
    result = (number / degree) % 10;    
    }
Console.WriteLine($"Third digit = {result}");
