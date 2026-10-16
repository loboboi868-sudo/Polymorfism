using System;

namespace Polymorphism
{
    public class MainClass
    {
        public static void Main(string[] args)
    {

        Knight k = new Knight();
        k.baseDamage = 100;
        k.name = "iwan";
        k.bonusArmor = 50;

        Wizard w = new Wizard();
        w.baseDamage = 100;
        w.name = "iwan";
        w.bonusMagic = 50;

        CalculateTotalDamage(k);
        CalculateTotalDamage(w);
    }

 public static void CalculateTotalDamage(Hero h)
        {
            if (h is Knight)
            {
                Knight k = (Knight)h;
                int total = k.baseDamage + k.bonusArmor;
                Console.WriteLine("Damage =" + total);
            }
            else if (h is Wizard)
            {
             Wizard w = (Wizard)h;
                int total = w.baseDamage + w.bonusMagic;
                Console.WriteLine("Damage =" + total);   
            }
        }
}

//Hero h = new Hero();
        //h.useSkill();

        //Hero w = new Wizard();
        //w.useSkill();

        //Hero k = new Knight();
        //k.useSkill();
    }