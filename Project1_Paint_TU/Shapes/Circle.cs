namespace Project1_Paint_TU.Shapes;
[Serializable]
public class Circle : Shape
{
    public int Radius { get; set; }

    public Circle(Point location, Color color, int radius) : base(location, color)
    {
        Radius = radius;
    }

    public override void Draw(Graphics g)
    {
        var pen = new Pen(Color, 1);
        g.DrawEllipse(pen, Location.X - Radius, Location.Y - Radius, 2 * Radius, 2 * Radius);
        pen.Dispose();
    }

    public override bool ContainsPoint(Point point)
    {
        float centerX = Location.X + Radius;
        float centerY = Location.Y + Radius;
        var distance = (float)Math.Sqrt(Math.Pow(point.X - centerX, 2) + Math.Pow(point.Y - centerY, 2));
        return distance <= Radius;
    }

    public virtual double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override string GetInfo()
    {
        return $"Circle: Center: ({Location.X + Radius}, {Location.Y + Radius}), Radius: {Radius}\nArea: {CalculateArea():f0}";
    }
}