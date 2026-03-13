using System;

public class Archer : BaseHero
{
    public Archer(string name,int health,int power) : base(name, health, power)
    {
    }

    public override void Attack(BaseHero enemy)
    {
        Console.WriteLine(name + " shoots an arrow!");
        enemy.Health -= Power;
    }
}