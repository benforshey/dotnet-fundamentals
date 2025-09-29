using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a new survivor
        ZombieSimulation survivor = new ZombieSimulation("Sam");

        // Simulate a day in the apocalypse
        survivor.SimulateDay();
    }
}

public class ZombieSimulation
{
    public string Name { get; set; }
    public int Health { get; private set; }
    public List<string> Inventory { get; private set; }
    public int Morale { get; private set; }

    private int hungerLevel;
    private Random random;

    public ZombieSimulation(string name)
    {
        Name = name;
        Health = 100;
        Morale = 100;
        Inventory = new List<string>();
        hungerLevel = 0;
        random = new Random();
    }

    public void SimulateDay()
    {
        Console.WriteLine($"A new day begins for {Name} in the zombie apocalypse...");
        // Loop to perform three actions in a day
        for (int i = 0; i < 3; i++)
        {
            int actionChoice = random.Next(1, 4);

            switch (actionChoice)
            {
                case 1:
                    Loot();
                    break;
                case 2:
                    Fight();
                    break;
                case 3:
                    Rest();
                    break;
                default:
                    break;
            }

            // If health is 0 or below, end the simulation
            if (Health <= 0)
            {
                Console.WriteLine($"{Name} has perished... Game over.");

                break;
            }
        }
    }

    public void Loot()
    {
        Console.WriteLine($"{Name} is looting the area...");
        Inventory.Add(GetRandomItem());

        hungerLevel += 5;

        CheckStatus();
    }

    private string GetRandomItem()
    {
        string[] items = { "Bandages", "Machete", "Water", "Canned Food", "Ammunition" };

        return items[random.Next(0, items.Length)];
    }

    // score: +0 we missed collapsing the vertical whitespace here
    public void Fight()
    {
        Console.WriteLine($"{Name} is fighting zombies!");

        // Random damage between 10 and 30
        int damageTaken = random.Next(10, 30);

        Health -= damageTaken;

        MoraleChangeAfterFight(damageTaken);

        if (Health <= 0)
        {
            Console.WriteLine($"{Name} has been overwhelmed by the zombies...");
        }

        else
        {
            Console.WriteLine($"{Name} fought off the zombies, but lost {damageTaken} health.");
        }

        // Check status of the survivor
        CheckStatus();
    }

    private void MoraleChangeAfterFight(int damageTaken)
    {
        if (damageTaken > 20)
        {
            Morale -= 10;
        }
        else
        {
            Morale -= 5;
        }
    }

    // score: +3?
    public void Rest()
    {
        int healthRecovered = random.Next(5, 15);
        Console.WriteLine($"{Name} is resting...");

        if (Health < 100)
        {
            Health += healthRecovered;
        }

        if (hungerLevel > 0)
        {
            hungerLevel -= 2;
        }

        if (Morale < 100)
        {
            Morale += 3;
        }

        CheckStatus();
    }

    private void CheckStatus()
    {
        Console.WriteLine($"Status: Health = {Health}, Morale = {Morale}, Hunger Level = {hungerLevel}");
        Console.WriteLine($"Inventory: {string.Join(", ", Inventory)}");
    }
}
