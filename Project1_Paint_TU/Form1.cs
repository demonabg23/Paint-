using Project1_Paint_TU.Service.Commands;
using Project1_Paint_TU.Service.Enum;
using Project1_Paint_TU.Service.FileManager;
using Project1_Paint_TU.Shapes;
using Rectangle = Project1_Paint_TU.Shapes.Rectangle;


namespace Project1_Paint_TU;

[Obsolete("Obsolete")]
public partial class Bgr : Form
{
    private readonly Pen _p = new(Color.Black, 1);
    private List<Shape> _shapes = new();

    private readonly Point[] _trianglePoints = new Point[3];
    private Point _location;
    private bool _paint;
    private Indexes _index;

    private readonly CommandManager _commandManager = new();
    private readonly FileManager _fileHandler = new();

    [Obsolete("Obsolete")]
    public Bgr()
    {
        InitializeComponent();
        KeyPreview = true;
        KeyDown += Bgr_KeyDown;
    }

    private void AddToShapes(Shape shape)
    {
        var shapes = new List<Shape>(_shapes) { shape };
        _commandManager.ExecuteCommand(shapes);
        _shapes = shapes;
        RefreshDrawing();
    }

    private void Undo()
    {
        if (!_commandManager.CanUndo()) return;
        _shapes = _commandManager.Undo();
        RefreshDrawing();
    }

    private void Redo()
    {
        if (!_commandManager.CanRedo()) return;
        _shapes = _commandManager.Redo();
        RefreshDrawing();
    }

    private void RefreshDrawing()
    {
        using var g = bgr_main.CreateGraphics();
        g.Clear(Color.White);

        foreach (var shape in _shapes)
        {
            shape.Draw(g);
        }
    }

    private void Bgr_KeyDown(object? sender, KeyEventArgs e)
    {
        switch (e.KeyCode)
        {
            case Keys.Z when e.Control:
                Undo();
                break;
            case Keys.Y when e.Control:
                Redo();
                break;
        }
    }

    private void ShowAllShapesInfo()
    {
        var allShapesInfo = _shapes
            .Select(shape => shape.GetInfo())
            .Aggregate((current, next) => $"{current}\n{next}");

        MessageBox.Show(allShapesInfo, @"All Shapes Information");
    }

    private void Bgr_Main_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Right)
        {
            ShowAllShapesInfo();
        }
    }

    private void Button_ellipse_Click(object sender, EventArgs e)
    {
        _index = Indexes.Ellipse;
    }
    private void Button_circle_Click(object sender, EventArgs e)
    {
        _index = Indexes.Circle;
    }
    private void Button_triangle_Click(object sender, EventArgs e)
    {
        _index = Indexes.Triangle;
    }
    private void Button_square_Click(object sender, EventArgs e)
    {
        _index = Indexes.Square;
    }

    private void Button_rectangle_Click(object sender, EventArgs e)
    {
        _index = Indexes.Rectangle;
    }

    private void Button1_Click(object sender, EventArgs e)
    {
        _shapes.Clear();
        RefreshDrawing();
    }

    [Obsolete("Obsolete")]
    private void Button_save_Click(object sender, EventArgs e)
    {
        SaveFileDialog saveFileDialog = new()
        {
            Filter = @"Binary files (*.bin)|*.bin",
            Title = @"Save"
        };
        saveFileDialog.ShowDialog();

        if (saveFileDialog.FileName == "") return;
        try
        {
            _fileHandler.SaveShapesToFile(_shapes, saveFileDialog.FileName);
        }
        catch (Exception ex)
        {
            MessageBox.Show(@"Error saving image: " + ex.Message);
        }
    }

    [Obsolete("Obsolete")]
    private void Button_load_Click(object sender, EventArgs e)
    {
        var openFileDialog = new OpenFileDialog
        {
            Filter = @"Binary files (*.bin)|*.bin",
            Title = @"Open"
        };
        openFileDialog.ShowDialog();

        if (openFileDialog.FileName == "") return;
        try
        {
            _shapes = _fileHandler.LoadShapesFromFile(openFileDialog.FileName);
            RefreshDrawing();
        }
        catch (Exception ex)
        {
            MessageBox.Show(@"Error loading image: " + ex.Message);
        }
    }

    private void Bgr_main_MouseUp(object sender, MouseEventArgs e)
    {
        if (!_paint) return;

        using var g = bgr_main.CreateGraphics();

        switch (_index)
        {
            case Indexes.Ellipse:

                _paint = false;

                var width = Math.Abs(e.X - _location.X);
                var height = Math.Abs(e.Y - _location.Y);
                var x = Math.Min(e.X, _location.X);
                var y = Math.Min(e.Y, _location.Y);

                var ellipse = new Ellipse(new Point(x, y), Color.Black, width, height);
                AddToShapes(ellipse);

                break;

            case Indexes.Circle:

                _paint = false;

                var diameter = Math.Min(e.X - _location.X, e.Y - _location.Y);
                var radius = diameter / 2;
                x = _location.X - radius;
                y = _location.Y - radius;

                var circle = new Circle(new Point(x, y), Color.Black, 2 * radius);
                AddToShapes(circle);

                break;

            case Indexes.Triangle:

                _paint = false;

                _trianglePoints[1] = e.Location;
                _trianglePoints[2] = new Point(_trianglePoints[0].X, e.Y);

                var triangle = new Triangle(_trianglePoints[0], Color.Black, _trianglePoints[1], _trianglePoints[2]);
                AddToShapes(triangle);

                break;
            case Indexes.Square:

                _paint = false;

                var sideLength = Math.Min(e.X - _location.X, e.Y - _location.Y);
                x = _location.X;
                y = _location.Y;

                var square = new Square(new Point(x, y), Color.Black, sideLength);
                AddToShapes(square);

                break;

            case Indexes.Rectangle:

                _paint = false;

                width = Math.Abs(e.X - _location.X);
                height = Math.Abs(e.Y - _location.Y);
                x = Math.Min(e.X, _location.X);
                y = Math.Min(e.Y, _location.Y);

                var rectangle = new Rectangle(new Point(x, y), Color.Black, width, height);
                AddToShapes(rectangle);

                break;
        }
    }

    private void Bgr_main_MouseMove(object sender, MouseEventArgs e)
    {
        if (!_paint) return;

        using var g = bgr_main.CreateGraphics();

        switch (_index)
        {
            case Indexes.Ellipse:

                g.Clear(Color.White);

                var width = Math.Abs(e.X - _location.X);
                var height = Math.Abs(e.Y - _location.Y);
                var x = Math.Min(e.X, _location.X);
                var y = Math.Min(e.Y, _location.Y);

                RefreshDrawing();

                var ellipse = new Ellipse(new Point(x, y), Color.Black, width, height);
                ellipse.Draw(g);

                break;

            case Indexes.Circle:

                g.Clear(Color.White);

                var diameter = Math.Min(e.X - _location.X, e.Y - _location.Y);
                var radius = diameter / 2;
                x = _location.X - radius;
                y = _location.Y - radius;

                RefreshDrawing();

                var circle = new Circle(new Point(x, y), Color.Black, diameter);
                circle.Draw(g);

                break;

            case Indexes.Triangle:

                g.Clear(Color.White);

                _trianglePoints[1] = e.Location;
                _trianglePoints[2] = new Point(_trianglePoints[0].X, e.Y);

                RefreshDrawing();

                g.DrawPolygon(_p, _trianglePoints);

                break;
            case Indexes.Square:

                g.Clear(Color.White);

                var sideLength = Math.Min(e.X - _location.X, e.Y - _location.Y);
                x = _location.X;
                y = _location.Y;

                RefreshDrawing();

                var square = new Square(new Point(x, y), Color.Black, sideLength);
                square.Draw(g);

                break;

            case Indexes.Rectangle:

                g.Clear(Color.White);

                width = Math.Abs(e.X - _location.X);
                height = Math.Abs(e.Y - _location.Y);
                x = Math.Min(e.X, _location.X);
                y = Math.Min(e.Y, _location.Y);

                RefreshDrawing();

                var rectangle = new Rectangle(new Point(x, y), Color.Black, width, height);
                rectangle.Draw(g);
                break;
        }
    }

    private void Bgr_main_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button != MouseButtons.Left) return;

        switch (_index)
        {
            case Indexes.Ellipse:
                _paint = true;
                break;
            case Indexes.Circle:
                _paint = true;
                _location = e.Location;
                break;
            case Indexes.Triangle:
                _paint = true;
                _trianglePoints[0] = e.Location;
                break;
            case Indexes.Square:
            case Indexes.Rectangle:
                _paint = true;
                _location = e.Location;
                break;
        }
    }
}