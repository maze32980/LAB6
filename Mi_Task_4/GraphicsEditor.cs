namespace Mi_Task_4;

public class GraphicsEditor
{
    public List<GraphicPrimitive> Primitives { get; } = new();

    public void Display()
    {
        Console.WriteLine("Displaying graphics:");
        foreach (var primitive in Primitives) primitive.Draw();
    }
}