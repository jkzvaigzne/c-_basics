using System;

public class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y) => (X, Y) = (x, y);
}

internal class Program
{
    static void Main(string[] args)
    {
        Point p1 = new Point(5, 3);
        Point p2 = new Point(-3, 6);

        (p1.X, p1.Y, p2.X, p2.Y) = (p2.X, p2.Y, p1.X, 2);

        Console.WriteLine($"({p1.X},{p1.Y})");
        Console.WriteLine($"({p2.X},{p2.Y})");

        Console.Read();
    }
}
