namespace Mi_Task_1;

public class Car : Vehicle
{
    public Car()
    {
        Speed = 100;
        Capacity = 5;
    }

    public override void Move(Route route)
    {
        Console.WriteLine($"Car is moving from {route.StartPoint} to {route.EndPoint}");
    }

    public override void BoardPassenger()
    {
        Console.WriteLine("Passenger boarded the car");
    }

    public override void DisembarkPassenger()
    {
        Console.WriteLine("Passenger disembarked from the car");
    }
}