namespace Assignment1
{
    public class PrimaryAttribute
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }

        /// <summary>
        /// Override of the + operator, adds the correct stats together
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns></returns>
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