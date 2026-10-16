namespace Polymorphism
{
    public class Wizard : Hero
    {
        public int bonusMagic;

        public override void useSkill()
        {
            base.useSkill();
            Console.WriteLine("Bonus magic =    " + bonusMagic);
        }
    }
}