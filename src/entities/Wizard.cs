namespace RpgCsharp.src.entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType) : base(name, level, heroType)
        {
        }

        public override string Attack()
        {
            return this.name + ":" + " Lançou uma Magia";
        }

        public string Attack(int bonus)
        {
            string resultAttackBonus = this.name + ":";
            if(bonus > 6) return resultAttackBonus + " Lançou uma Magia Super Efetiva com bonus de ataque " + bonus;
            return resultAttackBonus + " Lançou uma Magia com bonus" + bonus;
        }
    }
}