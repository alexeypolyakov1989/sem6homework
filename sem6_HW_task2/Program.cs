//Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем."

Console.WriteLine("Введите значения k1; b1; k2; b2 для уравнений двух прямых y = k1 * x + b1, y = k2 * x + b2: ");
CoefsInput(out double k1, out double b1, out double k2, out double b2);
CoefsAnalysis(k1, b1, k2, b2, out string res);  
Console.WriteLine(res); 

static void CoefsInput(out double k1, out double b1, out double k2, out double b2)
{
    Console.Write("k1 = ");
    k1 = Convert.ToDouble(Console.ReadLine()); 
    Console.Write("b1 = ");
    b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("k2 = ");
    k2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("b2 = ");
    b2 = Convert.ToDouble(Console.ReadLine());
}

static void CoefsAnalysis(double k1, double b1, double k2, double b2, out string result)
{
    if (k1 == k2 && b1 == b2)
        result = "Прямые полностью совпадают";
    else if (k1 == k2)
        result = "Прямые параллельны";
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        result =
            "Точка пересечения прямых: (" + x + "; " + y + ") ";
    }
}