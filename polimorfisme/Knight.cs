namespace Polymorphism
{
    public class Knight : Hero
    {
        public int bonusArmor;

        public override void useSkill()
        {
            base.useSkill();
            Console.WriteLine("Bonus armor =    " + bonusArmor);
        }
    }
}