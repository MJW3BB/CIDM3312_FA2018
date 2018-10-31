namespace Library.Mass
{
    public class OuncestoKilos : IMassConvert
    {
        public decimal GetMass(decimal massIn)
        {
            return massIn / 35.274M;
        }
    }
}