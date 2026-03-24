namespace Week8_Project;

public abstract class DeliveryItem
{
    protected string TrackingNumber;
    protected double Weight;

    public DeliveryItem(string trackingnumber, double weight)
    {
        TrackingNumber = trackingnumber;
        Weight = weight;
    }

    public abstract double CalculateCost();

    public virtual void PrintInfo()
    {
        Console.WriteLine($"TrackNumber: {TrackingNumber}\nWeight: {Weight}");
    }
}