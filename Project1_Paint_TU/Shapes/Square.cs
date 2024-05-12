namespace Project1_Paint_TU.Shapes
{
    [Serializable]
    public class Square : Shape
    {
        public int SideLength { get; set; }

        public Square(Point location, Color color, int sideLength) : base(location, color)
        {
            SideLength = sideLength;
        }

        public override bool ContainsPoint(Point point)
        {
            return (point.X >= Location.X && point.X <= Location.X + SideLength &&
                    point.Y >= Location.Y && point.Y <= Location.Y + SideLength);
        }

        public virtual double CalculateArea()
        {
            return SideLength * SideLength;
        }

        public override void Draw(Graphics g)
        {
            using var pen = new Pen(Color);
            g.DrawRectangle(pen, Location.X, Location.Y, SideLength, SideLength);
        }

        public override string GetInfo()
        {
            return $"Square: Top-Left Corner: ({Location.X}, {Location.Y}), Side Length: {SideLength}, Area: {CalculateArea()}";
        }
    }
}
