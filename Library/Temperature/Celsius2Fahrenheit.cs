namespace Library.Temperature
{
    public class Celsius2Fahrenheit : ITempConvert
    {
        public decimal GetTemp(decimal tempIn)
        {
            return tempIn * (9M / 5M) + 32;
        }
    }
}