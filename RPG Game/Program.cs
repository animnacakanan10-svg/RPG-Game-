using System;

namespace RPG_Game
{
    public class DarkMage : Enemy, ISpelCaster
    {
        private int _mana;

        public int Mana
        {
            get => _mana;
            private set => _mana = Math.Max(0, value);
        }
        public DarkMage() : base(60, 10, "Dark Mage", 80)
        {
        }

        public int Mana => throw new NotImplementedException();

        public override void Attack(Character target)
        {
            throw new NotImplementedException();
        }

        public void CastSpell(Character target)
        {
            throw new NotImplementedException();
        }

        public void RestoreMana(int amount)
        {
            throw new NotImplementedException();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
