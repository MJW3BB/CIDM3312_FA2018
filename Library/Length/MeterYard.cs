namespace Library.Length
{
    public class MeterYard : ILengthConversion
    {
        public decimal GetLength(decimal lengthIn)
        {
            return lengthIn * 1.0936132983M;
        }
    }
}