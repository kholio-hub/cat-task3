using System;

public abstract class BaseHero
{
    protected string name;
    private int health;
    private int power;

    public int Health
    {
        get { return health; }
        set { health = value; }
    }

    public int Power
    {
        get { return power; }
        set { power = value; }
    }

    public BaseHero(string name, int health, int power)
    {
        this.name = name;
        Health = health;
        Power = power;
    }

    public void Introduce()
    {
        Console.WriteLine("Hero: " + name + " | Health: " + Health + " | Power: " + Power);
    }

    public abstract void Attack(BaseHero enemy);

    public void Heal()
    {
        Health+=20;
        Console.WriteLine(name + " healed 20 HP.");
    }

    public void Heal(int amount)
    {
        Health+=amount;
        Console.WriteLine(name + " healed " + amount + " HP.");
    }
}