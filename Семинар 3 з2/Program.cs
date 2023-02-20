// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 2D пространстве.

Console.Clear();

double matchx;
double matchy;

Console.Write("Введите x1:  ");
int x1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите y1:  ");
int y1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите x2:  ");
int x2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите y2:  ");
int y2 = int.Parse(Console.ReadLine()!);

matchx = Math.Pow(x1 - x2, 2);
matchy = Math.Pow(y1 - y2, 2);
double match = Math.Sqrt(matchx + matchy);
match = Math.Round(match, 2); 
// округление

Console.WriteLine(match);




