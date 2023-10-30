namespace Mi_Task_4;

public class Triangle : GraphicPrimitive
{
    public int SideLength { get; set; }

    public override void Draw()
    {
        Console.WriteLine($"Drawing an equilateral triangle at ({X}, {Y}) with side length {SideLength}");
    }

    public override void Scale(float factor)
    {
        SideLength = (int)(SideLength * factor);
    }
}