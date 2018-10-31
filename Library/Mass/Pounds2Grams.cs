namespace Library.Mass
{
    public class PoundstoGrams : IMassConvert
    {
        public decimal GetMass(decimal massIn)
        {
            return massIn / 0.0022046M;
        }
    }
}