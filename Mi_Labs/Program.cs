namespace Mi_Task_1;

internal sealed class Program
{
    private static void Main(string[] args)
    {
        var car = new Car();
        var bus = new Bus();
        var train = new Train();

        var network = new TransportNetwork();
        network.AddVehicle(car);
        network.AddVehicle(bus);
        network.AddVehicle(train);

        var route = new Route("City A", "City B");

        network.MoveAllVehicles(route);

        Console.ReadKey();
    }
}