namespace RPG_Game
{
    public interface ISpelCaster
    {
        int Mana { get; }

        void CastSpell(Character target);

        void RestoreMana(int amount);
    }
}
