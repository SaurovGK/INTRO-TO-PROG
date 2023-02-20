// Напишите программу, которая принимает на ввод число (N) 
// и выдает таблицу квадратов чисел от 1 до N.

Console.Clear();

Console.Write("введите число: ");
int a = int.Parse(Console.ReadLine());
int count = 1;

while (count <= a)
{
    Console.Write(count * count);
    if (count != a)
    {
      Console.Write(", ");  
    }
count++;
}

