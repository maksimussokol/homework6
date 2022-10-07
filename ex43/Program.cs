Console.Clear();

void mash(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"tochka peresecheniya ({x}, {y})");
}
Console.WriteLine("enter b1");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("enter k1");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("enter b2");
double c = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("enter k2");
double d = Convert.ToDouble(Console.ReadLine());

mash(a, b, c, d);