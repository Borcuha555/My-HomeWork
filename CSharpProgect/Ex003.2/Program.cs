//Задача 21
//Напишите метод, который принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите кординату x точки A: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кординату y точки A: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кординату z точки A: ");
int zA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Введите кординату х точки B: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кординату у точки B: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кординату z точки B: ");
int zB = Convert.ToInt32(Console.ReadLine());
double root = Math.Sqrt((xB - xA) * (xB - xA) + (yB - yA) * (yB - yA) + (zB - zA) *(zB - zA));
Console.WriteLine($"Расстояние межд точкой А и точкой В: {Math.Round(root, 2, MidpointRounding.ToZero)}.");
