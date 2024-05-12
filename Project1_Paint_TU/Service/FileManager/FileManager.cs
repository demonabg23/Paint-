using System.Runtime.Serialization.Formatters.Binary;
using Project1_Paint_TU.Shapes;

namespace Project1_Paint_TU.Service.FileManager;
[Obsolete("Obsolete")]
public class FileManager
{
    public void SaveShapesToFile(List<Shape> shapes, string filePath)
    {
        try
        {
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, shapes);
            }
            Console.WriteLine(@"Shapes saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($@"Error saving shapes: {ex.Message}");
        }
    }

    public List<Shape> LoadShapesFromFile(string filePath)
    {
        var shapes = new List<Shape>();
        try
        {
            using (var stream = new FileStream(filePath, FileMode.Open))
            {
                var formatter = new BinaryFormatter();
                shapes = (List<Shape>)formatter.Deserialize(stream);
            }
            Console.WriteLine(@"Shapes loaded successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($@"Error loading shapes: {ex.Message}");
        }
        return shapes;
    }
}