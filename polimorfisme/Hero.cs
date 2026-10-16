using System;

namespace Polymorphism
{
    public class Hero
    {
        public string ?name;
        public int baseDamage;

        public virtual void useSkill()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Base Damage: " + baseDamage);
        }
    }
}