namespace Project1_Paint_TU.Shapes;
[Serializable]
public class Ellipse : Shape
{
    public int Height { get; set; }

    public int Width { get; set; }

    public Ellipse(Point location, Color color, int width, int height) : base(location, color)
    {
        Height = height;
        Width = width;
    }

    public override void Draw(Graphics g)
    {
        using var pen = new Pen(Color);
        g.DrawEllipse(pen, Location.X, Location.Y, Width, Height);
    }

    public override bool ContainsPoint(Point point)
    {
        var centerX = Location.X + Width / 2f;
        var centerY = Location.Y + Height / 2f;
        var radiusX = Width / 2f;
        var radiusY = Height / 2f;

        var normalizedX = (point.X - centerX) / radiusX;
        var normalizedY = (point.Y - centerY) / radiusY;

        return normalizedX * normalizedX + normalizedY * normalizedY <= 1;
    }


    public virtual double CalculateArea()
    {
        return Math.PI * Height * Width;
    }

    public override string GetInfo()
    {
        return $"Ellipse: Center: ({Location.X + Width / 2}, {Location.Y + Height / 2}), Width: {Width}, Height: {Height}\nArea: {CalculateArea():F0}";
    }

}