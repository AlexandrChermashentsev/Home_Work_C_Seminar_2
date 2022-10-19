/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Enter a three digit number");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);
int secondDigit = 0;
if (number < 1000 && number > 99 || number > -1000 && number < -99)
{
    secondDigit = Math.Abs(number % 100);
    secondDigit = secondDigit / 10;
    Console.WriteLine($"The second digit number {number} is {secondDigit}");
}
else Console.WriteLine ("This number is not three digit");
