
using RpgCsharp.src.entities;

namespace MainSystem
{
    class Program
    {
        static void Main(string [] args)
        {
            Warrior hero1 = new Warrior("Anvor", 12, "Warrior");
            Wizard hero2 = new Wizard("Maris", 13, "Magic");

            Console.WriteLine(hero1.Attack());
            Console.WriteLine(hero2.Attack(7));
        }
    }    
}


