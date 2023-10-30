namespace Mi_Task_1;

public abstract class Vehicle
{
    public int Speed { get; set; }
    public int Capacity { get; set; }

    public abstract void Move(Route route);
    public abstract void BoardPassenger();
    public abstract void DisembarkPassenger();
}