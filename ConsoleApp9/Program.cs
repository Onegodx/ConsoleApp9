// Миньков Владимир 22исп2-1 11 вариант базовый уровень 
double SideLength(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
}

void Main(string[] args)
{
    Console.WriteLine("Введите координаты сторон треугольника в формате x1 y1 x2 ...:");
    try
    {
        double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).Take(6).ToArray();
        double[] sides = new double[] { SideLength(numbers[0], numbers[1], numbers[2], numbers[3]), SideLength(numbers[0], numbers[1], numbers[4], numbers[5]), SideLength(numbers[2], numbers[3], numbers[4], numbers[5]) };
        Console.WriteLine("Периметр: {0}.", sides.Sum());
    }
    catch
    {
        Console.WriteLine("Ошибка, ввод некорректен!");
    }
}
