namespace Mi_Task_1;

public class TransportNetwork
{
    private readonly List<Vehicle> vehicles = new();

    public void AddVehicle(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
    }

    public void MoveAllVehicles(Route route)
    {
        foreach (var vehicle in vehicles)
        {
            var optimalRoute = vehicle switch
            {
                Car => Route.CalculateOptimalRouteForCar(route.StartPoint, route.EndPoint),
                Bus => Route.CalculateOptimalRouteForBus(route.StartPoint, route.EndPoint),
                Train => Route.CalculateOptimalRouteForTrain(route.StartPoint, route.EndPoint),
                _ => throw new InvalidOperationException("Unknown vehicle type")
            };

            Console.WriteLine(
                $"Moving {vehicle.GetType().Name} from {optimalRoute.StartPoint} to {optimalRoute.EndPoint}");
            vehicle.Move(optimalRoute);
            vehicle.BoardPassenger();
            vehicle.DisembarkPassenger();
        }
    }
}