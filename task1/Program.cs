// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();
Console.WriteLine("Введите полином из 5ти чисел: ");
int n=int.Parse(Console.ReadLine());
int m=n/10000;
int k=(n/1000)%10;
if( m == n%10 && k==(n/10)%10)
 Console.WriteLine($"Полином^ {n}");
 else Console.WriteLine("Введите правильно");

 // Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки А");
double xa = Convert.ToDouble(Console.ReadLine);
double ya = Convert.ToDouble(Console.ReadLine);
Console.WriteLine("Введите координаты точки B");
double xb = Convert.ToDouble(Console.ReadLine);
double yb = Convert.ToDouble(Console.ReadLine);
Console.WriteLine("Введите координаты точки Z");
double xz = Convert.ToDouble(Console.ReadLine);
double yz = Convert.ToDouble(Console.ReadLine);

double result = Math.Sqrt(Math.Pow((xb-xa), 2) + Math.Pow((yb-ya), 2) + Math.Pow((xz-yz), 2));
Console.WriteLine($"Расстояние между точками {result}");

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
Console.Write("Введите число: ");
int n= int.Parse(Console.ReadLine());
for (int i=1; i<=n;i++)
Console.Write($"  {i*i*i}");
