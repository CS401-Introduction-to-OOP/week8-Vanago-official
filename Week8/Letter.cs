namespace Week8_Project;

public class Letter : DeliveryItem
{
    public Letter(string trackingnumber, int weight) : base(trackingnumber, weight)
    {
        TrackingNumber = trackingnumber;
        Weight = weight;
    }

    public override double CalculateCost()
    {
        return 15 + Weight * 10;
    }
}