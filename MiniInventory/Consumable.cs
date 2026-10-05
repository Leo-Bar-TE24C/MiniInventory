public class Consumable:Item
{
    public int usesMax;
    public int usesCurrent;

    public void Use(Character target)
    {
        if (usesCurrent<usesMax)
        {
            target.hp += 10;
        }
    }
}
