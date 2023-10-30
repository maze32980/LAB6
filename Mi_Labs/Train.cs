namespace Mi_Task_1;

public class Train : Vehicle
{
    public Train()
    {
        Speed = 120;
        Capacity = 200;
    }

    public override void Move(Route route)
    {
        Console.WriteLine($"Train is moving from {route.StartPoint} to {route.EndPoint}");
    }

    public override void BoardPassenger()
    {
        Console.WriteLine("Passenger boarded the train");
    }

    public override void DisembarkPassenger()
    {
        Console.WriteLine("Passenger disembarked from the train");
    }
}