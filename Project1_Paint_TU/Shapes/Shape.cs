namespace Project1_Paint_TU.Shapes;
[Serializable]
public abstract class Shape
{
    public Point Location { get; set; }

    public Color Color { get; set; }

    protected Shape(Point location, Color color)
    {
        Location = location;
        Color = color;
    }

    public abstract void Draw(Graphics g);
    public abstract bool ContainsPoint(Point point);
    public abstract string GetInfo();
}