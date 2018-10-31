namespace Library.Temperature
{
    public class Celsius2Kelvin : ITempConvert
    {
        public decimal GetTemp(decimal tempIn) => tempIn + 273.15M;
    }
}