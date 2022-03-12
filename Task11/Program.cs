// Напишите программу, которая принимает на вход трехзначное число
// и на выходе показывает вторую цифру этого числа

int number = new int();
Console.Write("Введите трехзначное число: ");
number = Convert.ToInt32(Console.ReadLine());

number = number / 10;
int letter2 = number % 10;

Console.WriteLine($"Вторая цифра числа: {letter2}");
