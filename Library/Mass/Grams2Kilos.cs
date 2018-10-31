namespace Library.Mass
{
    public class Grams2Kilos : IMassConvert
    {
        public decimal GetMass(decimal massIn)
        {
            return massIn * 1000M;
        }
    }
}