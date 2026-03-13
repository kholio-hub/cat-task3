using System;

public class Mage : BaseHero
{
    public Mage(string name,int health,int power) : base(name, health, power)
    {
    }

    public override void Attack(BaseHero enemy)
    {
        Console.WriteLine(name + " casts a fire spell!");
        enemy.Health -= Power;
    }
}