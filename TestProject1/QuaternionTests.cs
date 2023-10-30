using Mi_Task_3;

namespace TestProject1;

public class QuaternionTests
{
    [Test]
    public void Addition_ShouldReturnCorrectResult()
    {
        var q1 = new Quaternion(1, 2, 3, 4);
        var q2 = new Quaternion(5, 6, 7, 8);

        var result = q1 + q2;
        Assert.Multiple(() =>
        {
            Assert.That(result.W, Is.EqualTo(6));
            Assert.That(result.X, Is.EqualTo(8));
            Assert.That(result.Y, Is.EqualTo(10));
            Assert.That(result.Z, Is.EqualTo(12));
        });
    }

    [Test]
    public void Subtraction_ShouldReturnCorrectResult()
    {
        var q1 = new Quaternion(1, 2, 3, 4);
        var q2 = new Quaternion(5, 6, 7, 8);

        var result = q1 - q2;
        Assert.Multiple(() =>
        {
            Assert.That(result.W, Is.EqualTo(-4));
            Assert.That(result.X, Is.EqualTo(-4));
            Assert.That(result.Y, Is.EqualTo(-4));
            Assert.That(result.Z, Is.EqualTo(-4));
        });
    }

    [Test]
    public void Multiplication_ShouldReturnCorrectResult()
    {
        var q1 = new Quaternion(1, 2, 3, 4);
        var q2 = new Quaternion(5, 6, 7, 8);

        var result = q1 * q2;
        Assert.Multiple(() =>
        {
            Assert.That(result.W, Is.EqualTo(-60));
            Assert.That(result.X, Is.EqualTo(12));
            Assert.That(result.Y, Is.EqualTo(30));
            Assert.That(result.Z, Is.EqualTo(24));
        });
    }

    [Test]
    public void Equality_ShouldReturnTrueForEqualQuaternions()
    {
        var q1 = new Quaternion(1, 2, 3, 4);
        var q2 = new Quaternion(1, 2, 3, 4);

        var result = q1 == q2;

        Assert.That(result, Is.True);
    }

    [Test]
    public void Equality_ShouldReturnFalseForDifferentQuaternions()
    {
        var q1 = new Quaternion(1, 2, 3, 4);
        var q2 = new Quaternion(5, 6, 7, 8);

        var result = q1 == q2;

        Assert.That(result, Is.False);
    }

    [Test]
    public void Norm_ShouldReturnCorrectResult()
    {
        var q = new Quaternion(1, 2, 3, 4);

        var result = q.Norm();

        Assert.That(result, Is.EqualTo(5.477225575051661));
    }

    [Test]
    public void Conjugate_ShouldReturnCorrectResult()
    {
        var q = new Quaternion(1, 2, 3, 4);

        var result = q.Conjugate();
        Assert.Multiple(() =>
        {
            Assert.That(result.W, Is.EqualTo(1));
            Assert.That(result.X, Is.EqualTo(-2));
            Assert.That(result.Y, Is.EqualTo(-3));
            Assert.That(result.Z, Is.EqualTo(-4));
        });
    }

    [Test]
    public void Inverse_ShouldReturnCorrectResult()
    {
        var q = new Quaternion(1, 2, 3, 4);

        var result = q.Inverse();
        Assert.Multiple(() =>
        {
            Assert.That(result.W, Is.EqualTo(0.03333333333333333));
            Assert.That(result.X, Is.EqualTo(-0.06666666666666667));
            Assert.That(result.Y, Is.EqualTo(-0.1));
            Assert.That(result.Z, Is.EqualTo(-0.13333333333333333));
        });
    }
}