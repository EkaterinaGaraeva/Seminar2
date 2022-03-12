/*
12. Напишите программу, которая будет принимать на вход два числа 
и выводить, является ли второе число кратным первому. 
Если число 2 не кратно числу 1, то программа выводит остаток от деление.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно
*/

int number1 = new int();
Console.Write("Введите первое число: ");
number1 = Convert.ToInt32(Console.ReadLine());

int number2 = new int ();
Console.Write("Введите второе число: ");
number2 = Convert.ToInt32(Console.ReadLine());

int remainder = number1 % number2;

if (remainder == 0)
{
    Console.WriteLine("Второе число кратно первому");
}

else
{
    Console.Write("Второе число не кратно первому, остаток: ");
    Console.WriteLine(remainder);
}
