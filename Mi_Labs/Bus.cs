namespace Mi_Task_1;

public class Bus : Vehicle
{
    public Bus()
    {
        Speed = 60;
        Capacity = 30;
    }

    public override void Move(Route route)
    {
        Console.WriteLine($"Bus is moving from {route.StartPoint} to {route.EndPoint}");
    }

    public override void BoardPassenger()
    {
        Console.WriteLine("Passenger boarded the bus");
    }

    public override void DisembarkPassenger()
    {
        Console.WriteLine("Passenger disembarked from the bus");
    }
}