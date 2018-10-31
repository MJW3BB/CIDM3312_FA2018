namespace Library.Mass
{
    public class KilostoOunces : IMassConvert
    {
        public decimal GetMass(decimal massIn)
        {
            return massIn * 35.274M;
        }
    }
}