namespace Library.Mass
{
    public class OuncestoPounds : IMassConvert
    {
        public decimal GetMass(decimal massIn)
        {
            return massIn * 0.062500M;
        }
    }
}