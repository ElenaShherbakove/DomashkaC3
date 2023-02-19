// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance3D(double xA, double yA, double zA, double xB, double yB, double zB)
{
    double Distance3D = Math.Sqrt(Math.Pow((xA - xB), 2)+ Math.Pow((yA - yB),2) + Math.Pow((zA - zB),2));
    // d = √ (х А – х В) 2 + (у А – у В) 2+(z А – z В) 2     
    return Math.Round(Distance3D, 2);
}

Console.Write("Введите координату Х точки А: ");
double Ax = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y точки А: ");
double Ay = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z точки А: ");
double Az = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Х точки B: ");
double Bx = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y точки B: ");
double By = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z точки B: ");
double Bz = Convert.ToDouble(Console.ReadLine());

double result = Distance3D(Ax, Ay, Az, Bx, By, Bz);
System.Console.WriteLine(result);
