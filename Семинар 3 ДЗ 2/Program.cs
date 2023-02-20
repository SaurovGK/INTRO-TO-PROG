// Напишите программу, которая принимает на ввод число (N) 
// и выдает таблицу кубов чисел от 1 до N.

Console.Clear();

Console.Write("введите число: ");
int a = int.Parse(Console.ReadLine());
int count = 1;

while (count <= a)
{
    Console.Write(Math.Pow(count,3));
    if (count != a)
    {
      Console.Write(", ");  
    }
count++;
}
