namespace Library.Mass
{
    public class KilostoGrams : IMassConvert
    {
        public decimal GetMass(decimal massIn)
        {
            return massIn / 1000M;
        }
    }
}