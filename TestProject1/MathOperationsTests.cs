using Mi_Task_2;

namespace TestProject1;

/// <summary>
///     Contains unit tests for the <see cref="MathOperations" /> class.
/// </summary>
public class MathOperationsTests
{
    [Test]
    public void Add_TwoDoubles_ReturnsCorrectResult()
    {
        var a = 5.0;
        var b = 3.0;

        var result = MathOperations.Add(a, b);

        Assert.That(result, Is.EqualTo(8.0));
    }

    [Test]
    public void Subtract_TwoDoubles_ReturnsCorrectResult()
    {
        var a = 5.0;
        var b = 3.0;

        var result = MathOperations.Subtract(a, b);

        Assert.That(result, Is.EqualTo(2.0));
    }

    [Test]
    public void Add_TwoDoubleArrays_ReturnsCorrectResult()
    {
        double[] a = { 1.0, 2.0, 3.0 };
        double[] b = { 4.0, 5.0, 6.0 };

        var result = MathOperations.Add(a, b);

        Assert.That(result, Is.EqualTo(new[] { 5.0, 7.0, 9.0 }));
    }

    [Test]
    public void Subtract_TwoDoubleArrays_ReturnsCorrectResult()
    {
        double[] a = { 1.0, 2.0, 3.0 };
        double[] b = { 4.0, 5.0, 6.0 };

        var result = MathOperations.Subtract(a, b);

        Assert.That(result, Is.EqualTo(new[] { -3.0, -3.0, -3.0 }));
    }

    [Test]
    public void Multiply_TwoDoubleArrays_ReturnsCorrectResult()
    {
        double[] a = { 1.0, 2.0, 3.0 };
        double[] b = { 4.0, 5.0, 6.0 };

        var result = MathOperations.Multiply(a, b);

        Assert.That(result, Is.EqualTo(new[] { 4.0, 10.0, 18.0 }));
    }

    [Test]
    public void Add_TwoDoubleMatrices_ReturnsCorrectResult()
    {
        double[,] a = { { 1.0, 2.0 }, { 3.0, 4.0 } };
        double[,] b = { { 5.0, 6.0 }, { 7.0, 8.0 } };

        var result = MathOperations.Add(a, b);

        Assert.That(result, Is.EqualTo(new[,] { { 6.0, 8.0 }, { 10.0, 12.0 } }));
    }

    [Test]
    public void Subtract_TwoDoubleMatrices_ReturnsCorrectResult()
    {
        double[,] a = { { 1.0, 2.0 }, { 3.0, 4.0 } };
        double[,] b = { { 5.0, 6.0 }, { 7.0, 8.0 } };

        var result = MathOperations.Subtract(a, b);

        Assert.That(result, Is.EqualTo(new[,] { { -4.0, -4.0 }, { -4.0, -4.0 } }));
    }

    [Test]
    public void Multiply_TwoDoubleMatrices_ReturnsCorrectResult()
    {
        double[,] a = { { 1.0, 2.0 }, { 3.0, 4.0 } };
        double[,] b = { { 5.0, 6.0 }, { 7.0, 8.0 } };

        var result = MathOperations.Multiply(a, b);

        Assert.That(result, Is.EqualTo(new[,] { { 5.0, 12.0 }, { 21.0, 32.0 } }));
    }

    [Test]
    public void Add_TwoTripleDoubleArrays_ReturnsCorrectResult()
    {
        double[,,] a = { { { 1.0, 2.0 }, { 3.0, 4.0 } }, { { 5.0, 6.0 }, { 7.0, 8.0 } } };
        double[,,] b = { { { 9.0, 10.0 }, { 11.0, 12.0 } }, { { 13.0, 14.0 }, { 15.0, 16.0 } } };

        var result = MathOperations.Add(a, b);

        Assert.That(result,
            Is.EqualTo(new[,,] { { { 10.0, 12.0 }, { 14.0, 16.0 } }, { { 18.0, 20.0 }, { 22.0, 24.0 } } }));
    }

    [Test]
    public void Subtract_TwoTripleDoubleArrays_ReturnsCorrectResult()
    {
        double[,,] a = { { { 1.0, 2.0 }, { 3.0, 4.0 } }, { { 5.0, 6.0 }, { 7.0, 8.0 } } };
        double[,,] b = { { { 9.0, 10.0 }, { 11.0, 12.0 } }, { { 13.0, 14.0 }, { 15.0, 16.0 } } };

        var result = MathOperations.Subtract(a, b);

        Assert.That(result,
            Is.EqualTo(new[,,] { { { -8.0, -8.0 }, { -8.0, -8.0 } }, { { -8.0, -8.0 }, { -8.0, -8.0 } } }));
    }

    [Test]
    public void Multiply_TwoTripleDoubleArrays_ReturnsCorrectResult()
    {
        double[,,] a = { { { 1.0, 2.0 }, { 3.0, 4.0 } }, { { 5.0, 6.0 }, { 7.0, 8.0 } } };
        double[,,] b = { { { 9.0, 10.0 }, { 11.0, 12.0 } }, { { 13.0, 14.0 }, { 15.0, 16.0 } } };

        var result = MathOperations.Multiply(a, b);

        Assert.That(result,
            Is.EqualTo(new[,,] { { { 9.0, 20.0 }, { 33.0, 48.0 } }, { { 65.0, 84.0 }, { 105.0, 128.0 } } }));
    }
}