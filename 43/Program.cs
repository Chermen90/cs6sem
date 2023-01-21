using static System.Console;
Write("Введите число b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
//WriteLine(b1);
Write("Введите число k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Write("Введите число b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Write("Введите число k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
double x = GetX(b1, k1, b2, k2);
double y = GetY(b1, k1, b2, k2);
WriteLine($"Прямые пересекаются в точках X равной {x} и Y равной {y}");

double GetX(double beone, double keyone, double betwo, double keytwo)
{
    double resultx = (betwo - beone) / (keyone - keytwo);
    return resultx;
}

double GetY(double beone, double keyone, double betwo, double keytwo)
{
    double resulty = ((betwo * keyone)- (beone * keytwo)) / (keyone - keytwo);
    return resulty;
}