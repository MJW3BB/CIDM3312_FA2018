namespace Library.Mass
{
    public class PoundstoOunces : IMassConvert
    {
        public decimal GetMass(decimal massIn)
        {
            return massIn * 16M;
        }
    }
}