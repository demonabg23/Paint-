namespace Project1_Paint_TU.Shapes;

[Serializable]
public class Triangle : Shape
{
    private readonly Point _point1;
    private readonly Point _point2;
    private readonly Point _point3;

    public Triangle(Point point1, Color color, Point point2, Point point3) : base(point1, color)
    {
        _point1 = point1;
        _point2 = point2;
        _point3 = point3;
    }

    public override void Draw(Graphics g)
    {
        var pen = new Pen(Color, 1);
        Point[] points = { _point1, _point2, _point3 };
        g.DrawPolygon(pen, points);
        pen.Dispose();
    }

    public override bool ContainsPoint(Point point)
    {
        float a = (Location.Y - _point3.Y) * (point.X - _point3.X) + (_point3.X - Location.X) * (point.Y - _point3.Y);
        float b = (_point3.Y - _point1.Y) * (point.X - _point3.X) + (_point1.X - _point3.X) * (point.Y - _point3.Y);
        float c = (_point1.Y - Location.Y) * (point.X - _point1.X) + (Location.X - _point1.X) * (point.Y - _point1.Y);
        return (a >= 0 && b >= 0 && c >= 0) || (a <= 0 && b <= 0 && c <= 0);
    }

    public virtual double CalculateArea()
    {
        var a = Distance(_point1, _point2);
        var b = Distance(_point2, _point3);
        var c = Distance(_point3, _point1);
        var s = (a + b + c) / 2;
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }

    private static double Distance(Point p1, Point p2)
    {
        return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
    }

    public override string GetInfo()
    {
        return $"Triangle: Points: ({_point1.X}, {_point1.Y}), ({_point2.X}, {_point2.Y}), ({_point3.X}, {_point3.Y})\nArea: {CalculateArea()}";
    }
}