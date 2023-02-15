// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();

Console.Write("Введите число 1: ");
int x = int.Parse(Console.ReadLine()!);

Console.Write("Введите число 2: ");
int y = int.Parse(Console.ReadLine()!);

if (x > y){
    Console.WriteLine($"max = {x}");
    Console.WriteLine($"min = {y}");
}
else{
   Console.WriteLine($"max = {y}");
   Console.WriteLine($"min = {x}");  
}

