namespace Library.Length
{
    public class FeetYards : ILengthConversion
    {
        public decimal GetLength(decimal lengthIn)
        {
            return lengthIn * 0.3333333333M;
        }
    }
} 