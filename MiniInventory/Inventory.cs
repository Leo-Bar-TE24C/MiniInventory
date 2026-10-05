public class Inventory
{
    public List<Item> items = new();

    public void Display()
    {
        int x = 0;
        foreach (var item in items)
        {
            Console.WriteLine(items[x]);
            x++;
        }
    }
}
