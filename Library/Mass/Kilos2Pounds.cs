namespace Library.Mass
{
    public class KilostoPounds : IMassConvert
    {
        public decimal GetMass(decimal massIn)
        {
            return massIn * 2.2046M;
        }
    }
}