Character player = new();

player.backpack.Display();

Armor helm = new();
Console.WriteLine("you find a helm");
Console.WriteLine("would you like to take it? (Y/N)");

string answer = Console.ReadLine().ToUpper();

if (answer == "Y")
{
    player.backpack.items.Add(helm);
}

player.backpack.Display();
Console.ReadLine();