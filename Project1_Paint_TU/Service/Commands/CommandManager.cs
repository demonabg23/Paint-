using Project1_Paint_TU.Shapes;

namespace Project1_Paint_TU.Service.Commands;

public class CommandManager
{
    private readonly List<List<Shape>> _undoHistory = new();
    private readonly List<List<Shape>> _redoHistory = new();
    private List<Shape> _currentShapes = new();

    public void ExecuteCommand(List<Shape> shapes)
    {
        _undoHistory.Add(new List<Shape>(_currentShapes));

        _currentShapes = new List<Shape>(shapes);

        _redoHistory.Clear();
    }

    public bool CanUndo()
    {
        return _undoHistory.Count > 0;
    }

    public bool CanRedo()
    {
        return _redoHistory.Count > 0;
    }

    public List<Shape> Undo()
    {
        if (!CanUndo()) return _currentShapes;

        _redoHistory.Add(new List<Shape>(_currentShapes));
        _currentShapes = new List<Shape>(_undoHistory[^1]);
        _undoHistory.RemoveAt(_undoHistory.Count - 1);

        return _currentShapes;
    }

    public List<Shape> Redo()
    {
        if (!CanRedo()) return _currentShapes;

        _undoHistory.Add(new List<Shape>(_currentShapes));
        _currentShapes = new List<Shape>(_redoHistory[^1]);
        _redoHistory.RemoveAt(_redoHistory.Count - 1);

        return _currentShapes;
    }
}