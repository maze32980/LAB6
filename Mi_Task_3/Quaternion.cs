/// <summary>
/// Represents a quaternion, a mathematical concept used to represent rotations in 3D space.
/// </summary>

namespace Mi_Task_3;

public class Quaternion
{
    private const double Tolerance = 1e-10;

    public Quaternion(double w, double x, double y, double z)
    {
        W = w;
        X = x;
        Y = y;
        Z = z;
    }

    public double W { get; }
    public double X { get; }
    public double Y { get; }
    public double Z { get; }

    public static Quaternion operator +(Quaternion q1, Quaternion q2)
    {
        return new Quaternion(q1.W + q2.W, q1.X + q2.X, q1.Y + q2.Y, q1.Z + q2.Z);
    }

    public static Quaternion operator -(Quaternion q1, Quaternion q2)
    {
        return new Quaternion(q1.W - q2.W, q1.X - q2.X, q1.Y - q2.Y, q1.Z - q2.Z);
    }

    public static Quaternion operator *(Quaternion q1, Quaternion q2)
    {
        return new Quaternion(
            q1.W * q2.W - q1.X * q2.X - q1.Y * q2.Y - q1.Z * q2.Z,
            q1.W * q2.X + q1.X * q2.W + q1.Y * q2.Z - q1.Z * q2.Y,
            q1.W * q2.Y - q1.X * q2.Z + q1.Y * q2.W + q1.Z * q2.X,
            q1.W * q2.Z + q1.X * q2.Y - q1.Y * q2.X + q1.Z * q2.W
        );
    }

    public static bool operator ==(Quaternion q1, Quaternion q2)
    {
        return Math.Abs(q1.W - q2.W) < Tolerance && Math.Abs(q1.X - q2.X) < Tolerance &&
               Math.Abs(q1.Y - q2.Y) < Tolerance && Math.Abs(q1.Z - q2.Z) < Tolerance;
    }

    public static bool operator !=(Quaternion q1, Quaternion q2)
    {
        return !(q1 == q2);
    }

    public double Norm()
    {
        return Math.Sqrt(W * W + X * X + Y * Y + Z * Z);
    }

    public Quaternion Conjugate()
    {
        return new Quaternion(W, -X, -Y, -Z);
    }

    public Quaternion Inverse()
    {
        var normSquared = W * W + X * X + Y * Y + Z * Z;
        return new Quaternion(W / normSquared, -X / normSquared, -Y / normSquared, -Z / normSquared);
    }

    public double[,] ToRotationMatrix()
    {
        var matrix = new double[3, 3];

        matrix[0, 0] = 1 - 2 * (Y * Y + Z * Z);
        matrix[0, 1] = 2 * (X * Y - Z * W);
        matrix[0, 2] = 2 * (X * Z + Y * W);

        matrix[1, 0] = 2 * (X * Y + Z * W);
        matrix[1, 1] = 1 - 2 * (X * X + Z * Z);
        matrix[1, 2] = 2 * (Y * Z - X * W);

        matrix[2, 0] = 2 * (X * Z - Y * W);
        matrix[2, 1] = 2 * (Y * Z + X * W);
        matrix[2, 2] = 1 - 2 * (X * X + Y * Y);

        return matrix;
    }

    public static Quaternion FromRotationMatrix(double[,] matrix)
    {
        var trace = matrix[0, 0] + matrix[1, 1] + matrix[2, 2];
        double qw, qx, qy, qz;

        if (trace > 0)
        {
            var s = 0.5 / Math.Sqrt(trace + 1.0);
            qw = 0.25 / s;
            qx = (matrix[2, 1] - matrix[1, 2]) * s;
            qy = (matrix[0, 2] - matrix[2, 0]) * s;
            qz = (matrix[1, 0] - matrix[0, 1]) * s;
        }
        else
        {
            if (matrix[0, 0] > matrix[1, 1] && matrix[0, 0] > matrix[2, 2])
            {
                var s = 2.0 * Math.Sqrt(1.0 + matrix[0, 0] - matrix[1, 1] - matrix[2, 2]);
                qw = (matrix[2, 1] - matrix[1, 2]) / s;
                qx = 0.25 * s;
                qy = (matrix[0, 1] + matrix[1, 0]) / s;
                qz = (matrix[0, 2] + matrix[2, 0]) / s;
            }
            else if (matrix[1, 1] > matrix[2, 2])
            {
                var s = 2.0 * Math.Sqrt(1.0 + matrix[1, 1] - matrix[0, 0] - matrix[2, 2]);
                qw = (matrix[0, 2] - matrix[2, 0]) / s;
                qx = (matrix[0, 1] + matrix[1, 0]) / s;
                qy = 0.25 * s;
                qz = (matrix[1, 2] + matrix[2, 1]) / s;
            }
            else
            {
                var s = 2.0 * Math.Sqrt(1.0 + matrix[2, 2] - matrix[0, 0] - matrix[1, 1]);
                qw = (matrix[1, 0] - matrix[0, 1]) / s;
                qx = (matrix[0, 2] + matrix[2, 0]) / s;
                qy = (matrix[1, 2] + matrix[2, 1]) / s;
                qz = 0.25 * s;
            }
        }

        return new Quaternion(qw, qx, qy, qz);
    }


    public override bool Equals(object? obj)
    {
        if (obj is Quaternion q)
            return this == q;
        return false;
    }

    public override int GetHashCode()
    {
        return W.GetHashCode() ^ X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode();
    }

    public override string ToString()
    {
        return $"({W}, {X}, {Y}, {Z})";
    }
}