﻿// Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа

int GetMaxLetterOfNumber(int number)
{
    int result = number % 10;
    int letter2 = number / 10;
    if (result < letter2)
    {
        result = letter2;
    }
    return result;
}

int randNumber = new Random().Next(10, 100);
int result = GetMaxLetterOfNumber(randNumber);

Console.WriteLine($"У числа {randNumber} наибольшая цифра {result}");

Console.WriteLine("У числа " + randNumber + " наибольшая цифра " + result);
