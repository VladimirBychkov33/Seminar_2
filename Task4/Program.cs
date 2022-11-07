// Найти расстояние между точками в пространстве 2D/3D
Console.Clear();
Console.WriteLine("Введите координаты первой точки по оси X: ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки по оси Y: ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки по оси X: ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки по оси Y: ");
int y2 = int.Parse(Console.ReadLine());
double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine($"Растояние между точками равно {result}");


