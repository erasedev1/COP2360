using System;

class Bunny
{
    public string Name;
    public bool LikesCarrots;
    public bool LikesHumans;

    public Bunny() {}
    public Bunny(string n) { Name = n; }
    public Bunny(string n, bool likesCarrots, bool likesHumans)
    {
        Name = n;
        LikesCarrots = likesCarrots;
        LikesHumans = likesHumans;
    }
}

class PetBunny : Bunny
{
    //overloaded
    public PetBunny(string n) 
    {
        Name = n;
    }

    public PetBunny(string n, int a, bool likesCarrots, bool likesHumans) 
    {
        Name = n;
        Age = a;
        LikesCarrots = likesCarrots;
        LikesHumans = likesHumans;
    }
}

public class Program
{
    public static void Main()
    {
        PetBunny b1 = new PetBunny("Fluffy", 2, true, true);
        PetBunny b2 = new PetBunny("Thumper", 1, false, true);

        Console.WriteLine($"{b1.Name} is {b1.Age} years old, Likes Carrots: {b1.LikesCarrots}, Likes Humans: {b1.LikesHumans}");
        Console.WriteLine($"{b2.Name} is {b2.Age} years old, Likes Carrots: {b2.LikesCarrots}, Likes Humans: {b2.LikesHumans}");

        Console.WriteLine($"All bunnies have {Bunny.Legs} legs!");
    }
}
