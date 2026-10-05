public class Character
{
    public int hp;
    public string name;
    public Inventory backpack = new();

    public Character()
    {
        Weapon sword = new();
        Consumable healPotion = new();
        backpack.items.Add(sword);
        backpack.items.Add(healPotion);
    }
}
