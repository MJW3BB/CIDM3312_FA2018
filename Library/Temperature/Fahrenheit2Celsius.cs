namespace Library.Temperature
{
    public class Fahrenheit2Celsius : ITempConvert
    {
        public decimal GetTemp(decimal tempIn)
        {
            return (tempIn - 32) / 9M * 5M;
        }
    }
}