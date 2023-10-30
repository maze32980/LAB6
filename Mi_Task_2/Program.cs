using System.Text;

namespace Mi_Task_2;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        double[,,] tensor1 =
        {
            {
                { 1, 2 },
                { 3, 4 }
            },
            {
                { 5, 6 },
                { 7, 8 }
            }
        };
        double[,,] tensor2 =
        {
            {
                { 9, 10 },
                { 11, 12 }
            },
            {
                { 13, 14 },
                { 15, 16 }
            }
        };

        var addedTensor = MathOperations.Add(tensor1, tensor2);
        var subtractedTensor = MathOperations.Subtract(tensor1, tensor2);
        var multipliedTensor = MathOperations.Multiply(tensor1, tensor2);

        Console.WriteLine("Перший тензор:");
        PrintTensor(tensor1);

        Console.WriteLine("Другий тензор:");
        PrintTensor(tensor2);

        Console.WriteLine("Додавання тензорів:");
        PrintTensor(addedTensor);

        Console.WriteLine("Віднімання тензорів:");
        PrintTensor(subtractedTensor);

        Console.WriteLine("Множення тензорів:");
        PrintTensor(multipliedTensor);
    }


    private static void PrintTensor(double[,,] tensor)
    {
        var depth = tensor.GetLength(0);
        var rows = tensor.GetLength(1);
        var cols = tensor.GetLength(2);
        for (var d = 0; d < depth; d++)
        {
            Console.WriteLine($"Depth {d}");
            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < cols; j++)
                    Console.Write($"{tensor[d, i, j]} ");
                Console.WriteLine();
            }
        }
    }
}