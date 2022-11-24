Console.Clear();

System.Console.WriteLine("Введите координату X1: ");
double x1 = double.Parse(Console.ReadLine() ?? "");

System.Console.WriteLine("Введите координату X2: ");
double x2 = double.Parse(Console.ReadLine() ?? "");

System.Console.WriteLine("Введите координату Y1: ");
double y1 = double.Parse(Console.ReadLine() ?? "");

System.Console.WriteLine("Введите координату Y2: ");
double y2 = double.Parse(Console.ReadLine() ?? "");

System.Console.WriteLine("Введите координату Z1: ");
double z1 = double.Parse(Console.ReadLine() ?? "");

System.Console.WriteLine("Введите координату Z2: ");
double z2 = double.Parse(Console.ReadLine() ?? "");

double result = distancePoint(x1,y1,x2,y2,z1,z2);
System.Console.WriteLine(result);

static double distancePoint(double x1,double y1,double x2,double y2,double z1,double z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1,2));
}
Console.ReadLine();