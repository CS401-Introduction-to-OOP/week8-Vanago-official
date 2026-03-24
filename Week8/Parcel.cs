namespace Week8_Project;

public class Parcel : DeliveryItem
{
    private string dimensions;
    
    public Parcel(string trackingnumber, double weight, string Dimensions) : base(trackingnumber, weight)
    {
        TrackingNumber = trackingnumber;
        Weight = weight;
        dimensions = Dimensions;
    }

    public override double CalculateCost()
    {
        return 50 + Weight * 25;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Dimensions: {dimensions}");
    }
}