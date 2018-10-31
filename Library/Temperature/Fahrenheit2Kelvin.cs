namespace Library.Temperature
{
    public class Fahrenheit2Kelvin : ITempConvert
    {
        public decimal GetTemp(decimal tempIn)
        {
            return (tempIn + 459.67M) * 5M / 9M;
        }
    }
}