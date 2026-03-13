// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Warrior warrior=new Warrior("Thor",150,30);
        Mage mage=new Mage("Merlin",100,25);
        Archer archer=new Archer("Legolas",90,20);
        List<BaseHero> heroes=new List<BaseHero>() { warrior, mage, archer };
        Console.WriteLine("HERO ROSTER");
        foreach(BaseHero hero in heroes)
        {
            hero.Introduce();
        }

        Console.WriteLine("\n=== BATTLE START ===");
        while(true)
        {
            if(warrior.Health>0&&mage.Health>0)
            {
                warrior.Attack(mage);
                Console.WriteLine("Mage Health: " + mage.Health);
                if(mage.Health<=0)
                {
                    Console.WriteLine("Mage is defeated!");
                    break;
                }
            }
            if(mage.Health>0&&warrior.Health>0)
            {
                mage.Attack(warrior);
                Console.WriteLine("Warrior Health: " + warrior.Health);
                if(warrior.Health<=0)
                {
                    Console.WriteLine("Warrior is defeated!");
                    break;
                }
            }
            if(archer.Health>0)
            {
                if(warrior.Health>0)
                {
                    archer.Attack(warrior);
                    Console.WriteLine("Warrior Health: " + warrior.Health);
                    if(warrior.Health<=0)
                        Console.WriteLine("Warrior is defeated!");
                }
                else if(mage.Health>0)
                {
                    archer.Attack(mage);
                    Console.WriteLine("Mage Health: " + mage.Health);
                    if(mage.Health<=0)
                        Console.WriteLine("Mage is defeated!");
                }
            }

            Console.WriteLine("-------------------");
        }

        Console.WriteLine("\n=== BATTLE FINISHED ===");
    }
}