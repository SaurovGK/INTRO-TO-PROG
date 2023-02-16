// Напишите программу, которая принимает на вход случайное трехзначное число и на выходе показывает 
// вторую цифру этого числа 

Console.Clear();

int a = new Random().Next(100, 1000);
int result1 = a / 10;
int result2 = result1 % 10;
// 120 / 10 = 12; 12 % 10 = 2


Console.WriteLine($"Рандомное число: {a}");
Console.WriteLine($"Получилось число: {result2}");

