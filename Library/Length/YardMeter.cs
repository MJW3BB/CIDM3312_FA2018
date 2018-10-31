namespace Library.Length
{
    public class YardMeter : ILengthConversion
    {
        public decimal GetLength(decimal lengthIn)
        {
            return lengthIn * 0.9144M;
        }
    }
}
