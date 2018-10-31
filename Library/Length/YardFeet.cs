namespace Library.Length
{
    public class YardFeet : ILengthConversion
    {
        public decimal GetLength(decimal lengthIn)
        {
            return lengthIn * 3M;
        }
    }
}