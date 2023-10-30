namespace Mi_Task_4;

public class Circle : GraphicPrimitive
{
    public int Radius { get; set; }

    public override void Draw()
    {
        Console.WriteLine($"Drawing a circle at ({X}, {Y}) with radius {Radius}");
    }

    public override void Scale(float factor)
    {
        Radius = (int)(Radius * factor);
    }
}