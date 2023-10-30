using Mi_Task_4;

namespace TestProject1;

public class GraphicsEditorTests
{
    [Test]
    public void Display_ShouldWriteToConsole()
    {
        var editor = new GraphicsEditor();
        var circle = new Circle { X = 5, Y = 5, Radius = 10 };
        editor.Primitives.Add(circle);
        ConsoleOutput.Clear();

        ConsoleOutput.WriteLine("Displaying graphics:");
        ConsoleOutput.WriteLine("Drawing a circle at (5, 5) with radius 10");


        editor.Display();


        Assert.That(ConsoleOutput.GetOutput(),
            Is.EqualTo("Displaying graphics:\nDrawing a circle at (5, 5) with radius 10\n"));
    }

    [Test]
    public void Group_Move_ShouldMoveAllPrimitives()
    {
        var group = new Group();
        var circle = new Circle { X = 5, Y = 5, Radius = 10 };
        var rectangle = new Rectangle { X = 10, Y = 10, Width = 15, Height = 20 };
        group.Primitives.Add(circle);
        group.Primitives.Add(rectangle);

        group.Move(5, 5);

        Assert.That(circle.X, Is.EqualTo(10));
        Assert.That(circle.Y, Is.EqualTo(10));
        Assert.That(rectangle.X, Is.EqualTo(15));
        Assert.That(rectangle.Y, Is.EqualTo(15));
    }

    [Test]
    public void Group_Scale_ShouldScaleAllPrimitives()
    {
        var group = new Group();
        var circle = new Circle { X = 5, Y = 5, Radius = 10 };
        var rectangle = new Rectangle { X = 10, Y = 10, Width = 15, Height = 20 };
        group.Primitives.Add(circle);
        group.Primitives.Add(rectangle);

        group.Scale(2);

        Assert.That(circle.Radius, Is.EqualTo(20));
        Assert.That(rectangle.Width, Is.EqualTo(30));
        Assert.That(rectangle.Height, Is.EqualTo(40));
    }
}