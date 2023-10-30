namespace Mi_Task_1;

public class Route
{
    public Route(string startPoint, string endPoint)
    {
        StartPoint = startPoint;
        EndPoint = endPoint;
    }

    public string StartPoint { get; set; }
    public string EndPoint { get; set; }

    public static Route CalculateOptimalRouteForCar(string startPoint, string endPoint)
    {
        return new Route(startPoint, endPoint);
    }

    public static Route CalculateOptimalRouteForBus(string startPoint, string endPoint)
    {
        return new Route(startPoint, endPoint);
    }

    public static Route CalculateOptimalRouteForTrain(string startPoint, string endPoint)
    {
        return new Route(startPoint, endPoint);
    }
}