namespace Week8_Project;

class Program
{
    static void Main(string[] args)
    {
        // 1
        Letter letterForSanta = new("2XX462F", 5);
        Letter letterForSatana = new("666X666", 666);

        Parcel ParcelForTest = new("99D8X53", 2, "20x15x2");
        Parcel ParcelForTest2 = new("12A5D68R", 13, "11x8x6");
        
        // 2
        letterForSatana.PrintInfo();
        ParcelForTest.PrintInfo();
        
        // 3
        CargoContainer<DeliveryItem> myCargo = new();
        
        // 4
        myCargo.AddItem(letterForSanta);
        myCargo.AddItem(letterForSatana);
        myCargo.AddItem(ParcelForTest);
        myCargo.AddItem(ParcelForTest2);
        
        // 5
        Console.WriteLine(myCargo.GetTotalCost());
    }
}