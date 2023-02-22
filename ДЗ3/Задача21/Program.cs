// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.WriteLine("Введите X1:");
int X1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Y1:");
int Y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Z1:");
int Z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите X2:");
int X2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Y2:");
int Y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Z2:");
int Z2 = int.Parse(Console.ReadLine());

double matchX;
double matchY;
double matchZ;

matchX = Math.Pow(X1 - X2, 2);
matchY = Math.Pow(Y1 - Y2, 2);
matchZ = Math.Pow(Z1 - Z2, 2);
double match = Math.Sqrt(matchX + matchY + matchZ);

Console.WriteLine($"{match:f2}");