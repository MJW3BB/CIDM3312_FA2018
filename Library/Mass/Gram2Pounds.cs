namespace Library.Mass
{
    public class GramstoPounds : IMassConvert
    {
        public decimal GetMass(decimal massIn)
        {
            return massIn * 0.0022046M;
        }
    }
}