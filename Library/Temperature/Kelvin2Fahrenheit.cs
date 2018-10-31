namespace Library.Temperature
{
    public class Kelvin2Fahrenheit : ITempConvert
    {
        public decimal GetTemp(decimal tempIn) => tempIn * (9M / 5M) - 459.67M;
    }
}