// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double Promt(string? message)
{
    System.Console.Write(message + " - > ");
    string? inputValue = Console.ReadLine();
    double result = Convert.ToDouble(inputValue);
    return result;
}

double FindLenth(double n1, double n2, double n3, double n4, double n5, double n6)
{
    double lenth1 = Math.Pow(n1 - n2, 2);
    double lenth2 = Math.Pow(n3 - n4, 2);
    double lenth3 = Math.Pow(n5 - n6, 2);
    double res = Math.Sqrt(lenth1 + lenth2 + lenth3);
    return res;
}

double x1 = Promt("Введите X1");
double x2 = Promt("Введите X2");
double y1 = Promt("Введите Y1");
double y2 = Promt("Введите Y2");
double z1 = Promt("Введите Z1");
double z2 = Promt("Введите Z2");

double lenthBetwDots = FindLenth(x1, x2, y1, y2, z1, z2);

System.Console.WriteLine($"Расстояние между точками = {lenthBetwDots:F2}");