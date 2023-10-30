namespace Mi_Task_4;

public class Group : GraphicPrimitive
{
    public List<GraphicPrimitive> Primitives { get; } = new();

    public override void Draw()
    {
        Console.WriteLine($"Drawing a group at ({X}, {Y}):");
        foreach (var primitive in Primitives) primitive.Draw();
    }

    public override void Move(int x, int y)
    {
        base.Move(x, y);
        foreach (var primitive in Primitives) primitive.Move(x, y);
    }

    public override void Scale(float factor)
    {
        foreach (var primitive in Primitives) primitive.Scale(factor);
    }
}