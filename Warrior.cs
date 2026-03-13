using System;

public class Warrior : BaseHero
{
    public Warrior(string name,int health,int power) : base(name, health, power)
    {
    }

    public override void Attack(BaseHero enemy)
    {
        Console.WriteLine(name + " attacks with a sword!");
        enemy.Health -= Power;
    }
}