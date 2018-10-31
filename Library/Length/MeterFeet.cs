namespace Library.Length
{
    public class MeterFeet : ILengthConversion
    {
        public decimal GetLength(decimal lengthIn)
        {
            return lengthIn / 0.3048M;
        }
    }
}