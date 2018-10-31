namespace Library.Mass
{
    public class PoundstoKilos : IMassConvert
    {
        public decimal GetMass(decimal massIn)
        {
            return massIn / 2.2046M;
        }
    }
}