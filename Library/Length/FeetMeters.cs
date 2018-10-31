namespace Library.Length
{
    public class FeetMeters : ILengthConversion
    {
        public decimal GetLength(decimal lengthIn)
        {
            return lengthIn * 3.2808M;
        }
    }
}