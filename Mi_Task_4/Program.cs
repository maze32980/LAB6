namespace Mi_Task_4;

public class Program
{
    public static void Main()
    {
        var circle = new Circle { X = 5, Y = 5, Radius = 10 };
        var rectangle = new Rectangle { X = 10, Y = 10, Width = 15, Height = 20 };
        var triangle = new Triangle { X = 20, Y = 20, SideLength = 25 };

        var group = new Group();
        group.Primitives.Add(circle);
        group.Primitives.Add(rectangle);
        group.Primitives.Add(triangle);

        var editor = new GraphicsEditor();
        editor.Primitives.Add(group);

        editor.Display();

        Console.WriteLine("Збільшення групи на 50% та зсув на (5, 5): ");
        group.Scale(1.5f);
        group.Move(5, 5);

        editor.Display();
    }
}