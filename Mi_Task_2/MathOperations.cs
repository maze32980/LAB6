namespace Mi_Task_2;

public static class MathOperations
{
    public static double Add(double a, double b)
    {
        return a + b;
    }

    public static double Subtract(double a, double b)
    {
        return a - b;
    }

    public static double[] Add(double[] a, double[] b)
    {
        return Operate(a, b, (x, y) => x + y);
    }

    public static double[] Subtract(double[] a, double[] b)
    {
        return Operate(a, b, (x, y) => x - y);
    }

    public static double[] Multiply(double[] a, double[] b)
    {
        return Operate(a, b, (x, y) => x * y);
    }

    public static double[,] Add(double[,] a, double[,] b)
    {
        return Operate(a, b, (x, y) => x + y);
    }

    public static double[,] Subtract(double[,] a, double[,] b)
    {
        return Operate(a, b, (x, y) => x - y);
    }

    public static double[,] Multiply(double[,] a, double[,] b)
    {
        return Operate(a, b, (x, y) => x * y);
    }

    public static double[,,] Add(double[,,] a, double[,,] b)
    {
        return Operate(a, b, (x, y) => x + y);
    }

    public static double[,,] Subtract(double[,,] a, double[,,] b)
    {
        return Operate(a, b, (x, y) => x - y);
    }

    public static double[,,] Multiply(double[,,] a, double[,,] b)
    {
        return Operate(a, b, (x, y) => x * y);
    }

    private static T[] Operate<T>(T[] a, T[] b, Func<T, T, T> operation)
    {
        ValidateSameLength(a, b);
        var result = new T[a.Length];
        for (var i = 0; i < a.Length; i++)
            result[i] = operation(a[i], b[i]);
        return result;
    }

    private static T[,] Operate<T>(T[,] a, T[,] b, Func<T, T, T> operation)
    {
        ValidateSameDimensions(a, b);
        var rows = a.GetLength(0);
        var cols = a.GetLength(1);
        var result = new T[rows, cols];
        for (var i = 0; i < rows; i++)
        for (var j = 0; j < cols; j++)
            result[i, j] = operation(a[i, j], b[i, j]);
        return result;
    }

    private static T[,,] Operate<T>(T[,,] a, T[,,] b, Func<T, T, T> operation)
    {
        ValidateSameDimensions(a, b);
        var depth = a.GetLength(0);
        var rows = a.GetLength(1);
        var cols = a.GetLength(2);
        var result = new T[depth, rows, cols];
        for (var d = 0; d < depth; d++)
        for (var i = 0; i < rows; i++)
        for (var j = 0; j < cols; j++)
            result[d, i, j] = operation(a[d, i, j], b[d, i, j]);
        return result;
    }

    private static void ValidateSameLength<T>(T[] a, T[] b)
    {
        if (a.Length != b.Length)
            throw new ArgumentException("Масиви повинні мати однаковий розмір.");
    }

    private static void ValidateSameDimensions(Array a, Array b)
    {
        if (a.Rank != b.Rank)
            throw new ArgumentException("Масиви повинні мати однакову кількість вимірів.");
        for (var i = 0; i < a.Rank; i++)
            if (a.GetLength(i) != b.GetLength(i))
                throw new ArgumentException($"Розміри масивів в {i}-му вимірі не співпадають.");
    }
}