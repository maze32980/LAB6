namespace Mi_Task_4;

public abstract class GraphicPrimitive
{
    public int X { get; set; }
    public int Y { get; set; }

    public abstract void Draw();

    public virtual void Move(int x, int y)
    {
        X += x;
        Y += y;
    }

    public abstract void Scale(float factor);
}