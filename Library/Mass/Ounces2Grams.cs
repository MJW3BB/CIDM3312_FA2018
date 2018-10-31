namespace Library.Mass
{
    public class OuncestoGrams : IMassConvert
    {
        public decimal GetMass(decimal massIn)
        {
            return massIn / 0.035274M;
        }
    }
}