/*
Расчитать значение y при заданном x
Если x > 0, То y = sin2x
Иначе y = 1 - 2sinx
*/
// sin2x = (1 - cos2x) / 2

Console.WriteLine("Введите x: ");
double x = Convert.ToDouble(Console.ReadLine());
double y = 0;

Result(x, y);

void Result(double X, double Y)
{
    if (x > 0)
    {
        y = (1 - Math.Cos(2*x));
    }
    else y = 1 - 2 * Math.Sin(x);
}

Console.WriteLine(y);