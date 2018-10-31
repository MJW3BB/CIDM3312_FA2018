namespace Library.Temperature
{
    public class Kelvin2Celsius : ITempConvert
    {
        public decimal GetTemp(decimal tempIn)
        {
            return tempIn - 273.15M;
        }
    }
}