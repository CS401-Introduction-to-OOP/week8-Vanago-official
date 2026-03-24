namespace Week8_Project;

public class CargoContainer<T> where T : DeliveryItem
{
    private List<T> objList = new();

    public void AddItem(T item)
    {
        objList.Add(item);
    }

    public double GetTotalCost()
    {
        double totalCoast = 0;

        foreach (var obj in objList)
        {
            totalCoast += obj.CalculateCost();
        }

        return totalCoast;
    }
}