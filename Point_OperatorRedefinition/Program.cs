/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте класс, который будет описывать точку в трехмерной системе координат (X, Y, Z). В теле
класса переопределите операторы сложения (+), вычитания (-), умножения (*), деления (/),
декремента (++), инкремента (--), также переопределите метод ToString(), таким образом, чтоб он
отображал полную информацию о точке (ее координаты), метод Equals для сравнения 2-х точек,
а также метод GetHashCode. В методе Main() создайте 2 экземпляря класса точка, выполните
для 2-х точек все переопределенные методы, результат выполнения операция вывидите на
консоль.
*/
Point p1 = new(10, 5, 20);
Point p2 = new(34, 14, 10);
Point sum = p1 + p2;
Point subtract = p1 - p2;
Point divide = p1 / p2;
Point multiply = p2 * p2;
Point increment = p1++;
Point decrement = p2--;

Console.WriteLine(sum.ToString());
Console.WriteLine(subtract.ToString());
Console.WriteLine(divide.ToString());
Console.WriteLine(multiply.ToString());
Console.WriteLine(increment.ToString());
Console.WriteLine(decrement.ToString());
Console.WriteLine(p1.Equals(p2));
Console.WriteLine(p1.GetHashCode());
Console.WriteLine(p2.GetHashCode());
class Point
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }
    public Point(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }
    public static Point operator +(Point p1, Point p2)
    {
        return new Point(p1.X + p2.X, p1.Y + p2.Y, p1.Z + p2.Z);
    }
    public static Point operator -(Point p1, Point p2)
    {
        return new Point(p1.X - p2.X, p1.Y - p2.Y, p1.Z - p2.Z);
    }
    public static Point operator *(Point p1, Point p2)
    {
        return new Point(p1.X * p2.X, p1.Y * p2.Y, p1.Z * p2.Z);
    }
    public static Point operator /(Point p1, Point p2)
    {
        return new Point(p1.X /+ p2.X, p1.Y / p2.Y, p1.Z / p2.Z);
    }
    public static Point operator ++(Point point)
    {
        return new Point(point.X + 1, point.Y + 1, point.Z + 1);
    }
    public static Point operator --(Point point)
    {
        return new Point(point.X - 1, point.Y - 1, point.Z - 1);
    }
    public override string ToString()
    {
        return string.Format($"{X},{Y},{Z}");
    }
    public override bool Equals(object o)
    {
        if (o is Point)
        {
            if (((Point)o).X == X && ((Point)o).Y == Y && ((Point)o).Z == Z)
                return true;
        }
        return false;
    }
    public override int GetHashCode()
    {
        return ToString().GetHashCode();
    }
}