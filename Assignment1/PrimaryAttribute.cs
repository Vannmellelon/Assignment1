namespace Assignment1
{
    class PrimaryAttribute
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }

        public static PrimaryAttribute operator +(PrimaryAttribute lhs, PrimaryAttribute rhs)
        {
            return new PrimaryAttribute
            {
                Strength = lhs.Strength + rhs.Strength,
                Dexterity = lhs.Dexterity + rhs.Dexterity,
                Intelligence = lhs.Intelligence + rhs.Intelligence
            };
        }
    }
}