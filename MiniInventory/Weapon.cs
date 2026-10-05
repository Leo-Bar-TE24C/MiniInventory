public class Weapon:Item
{
    public int maxDamage;
    public int minDamage;

    public int Attack()
    {
        return Random.Shared.Next(minDamage,maxDamage);
    }
}
