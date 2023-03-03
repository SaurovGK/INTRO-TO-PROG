// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
// * каждая сторона треугольника меньше сумму двух других сторон

bool CheckTriangle(int a, int b, int c)
{
    return a + b > c && a + c > b && c + b > a; 
}

Console.WriteLine("Введите первое число");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int y = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число");
int z = int.Parse(Console.ReadLine()!);

if(CheckTriangle (x, y, z))
{
    Console.WriteLine("существует");
}
else 
{
   Console.WriteLine("не существует"); 
}

