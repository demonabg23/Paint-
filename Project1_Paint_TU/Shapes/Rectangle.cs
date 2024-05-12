namespace Project1_Paint_TU.Shapes
{
    [Serializable]
    public class Rectangle : Shape
    {
        public int Height { get; set; }

        public int Width { get; set; }

        public Rectangle(Point location, Color color, int width, int height) : base(location, color)
        {
            Height = height;
            Width = width;
        }

        public override void Draw(Graphics g)
        {
            using var pen = new Pen(Color);
            g.DrawRectangle(pen, Location.X, Location.Y, Width, Height);
        }

        public override bool ContainsPoint(Point point)
        {
            return (point.X >= Location.X && point.X <= Location.X + Width &&
                    point.Y >= Location.Y && point.Y <= Location.Y + Height);
        }

        public virtual double CalculateArea()
        {
            return Height * Width;
        }

        public override string GetInfo()
        {
            return $"Rectangle: Top-Left Corner: ({Location.X}, {Location.Y}), Width: {Width}, Height: {Height}, Area: {CalculateArea()}";
        }
    }
}
