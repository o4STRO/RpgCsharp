namespace RpgCsharp.src.entities
{
    public class Warrior : Hero
    {
        public Warrior(string name, int level, string heroType) : base(name, level, heroType)
        {
        }

        public override string Attack()
        {
            return this.name + ":" + " Fez um ataque com a sua espada";
        }
    }
}