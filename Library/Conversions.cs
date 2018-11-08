namespace Library.Conversions 
{
// -------------------------------- LENGTH CONVERSIONS -------------------------------- \\
    public interface ILengthConversions
    {
        decimal GetLength(decimal lenghtIn);
    }
    // ---------- || FEET || ----------\\
    public class FeetToMeters : ILengthConversions
    {
        public decimal GetLength(decimal lenghtIn)
        {
            return lenghtIn * 3.2808M;
        }
    }
    public class FeetToYards : ILengthConversions
    {
        public decimal GetLength(decimal lenghtIn)
        {
            return lenghtIn * 0.3333333333M;
        }
    }
    // ----------|| METERS || ----------\\
    public class MetersToFeet : ILengthConversions
    {
        public decimal GetLength(decimal lenghtIn)
        {
            return lenghtIn / 0.3048M;
        }
    }
    public class MetersToYards : ILengthConversions
    {
        public decimal GetLength(decimal lenghtIn)
        {
            return lenghtIn * 1.0936132983M;
        }
    }
    // ---------- || YARDS || ---------- \\
    public class YardsToFeet : ILengthConversions
    {
        public decimal GetLength(decimal lenghtIn)
        {
            return lenghtIn * 3M;
        }
    }
    public class YardsToMeters : ILengthConversions
    {
        public decimal GetLength(decimal lenghtIn)
        {
            return lenghtIn * 0.9144M;
        }
    }
    // -------------------------------- MASS CONVERSIONS -------------------------------- \\
    public interface IMassConversions
    {
        decimal GetMass(decimal massIn);

    }
    // ---------- || GRAMS || ----------\\
    public class GramToKilogram : IMassConversions
    {
        public decimal GetMass(decimal massIn)
        {
            return massIn * 1000M;
        }
    }
    public class GramToOunce : IMassConversions
    {
        public decimal GetMass(decimal massIn)
        {
            return massIn * 0.035274M;
        }
    }
    public class GramToPound : IMassConversions
    {
        public decimal GetMass(decimal massIn)
        {
            return massIn * 0.0022046M;
        }
    }
    // ---------- || KILOGRAMS || ---------- \\
    public class KilogramToGram : IMassConversions
    {
        public decimal GetMass(decimal massIn)
        {
            return massIn / 1000M;
        }
    }
    public class KilogramToOunce : IMassConversions
    {
        public decimal GetMass(decimal massIn)
        {
            return massIn * 35.274M;
        }
    }
    public class KilogramToPound : IMassConversions
    {
        public decimal GetMass(decimal massIn)
        {
            return massIn * 2.2046M;
        }
    }
    // ---------- || OUNCES || ---------- \\
    public class OunceToGram : IMassConversions
    {
        public decimal GetMass(decimal massIn)
        {
            return massIn / 0.035274M;
        }
    }
    public class OunceToKilogram : IMassConversions
    {
        public decimal GetMass(decimal massIn)
        {
            return massIn / 35.274M;
        }
    }
    public class OunceToPounds : IMassConversions
    {
        public decimal GetMass(decimal massIn)
        {
            return massIn * 0.062500M;
        }
    }
    // ---------- || POUNDS || ---------- \\
    public class PoundToGram : IMassConversions
    {
        public decimal GetMass(decimal massIn)
        {
            return massIn / 0.0022046M;
        }
    }
    public class PoundToKilogram : IMassConversions
    {
        public decimal GetMass(decimal massIn)
        {
            return massIn / 2.2046M;
        }
    }
    public class PoundToOunce : IMassConversions
    {
        public decimal GetMass(decimal massIn)
        {
            return massIn * 16M;
        }
    }
    // -------------------------------- \\ TEMPERATURE CONVERSIONS // -------------------------------- \\
    public interface ITempConversions
    {
        decimal GetTemp(decimal tempIn);

    }
    // ----------|| CELSIUS || ----------\\
    public class CelsiusToFahrenheit : ITempConversions
    {
        public decimal GetTemp(decimal tempIn)
        {
            return ((tempIn * 9M) / 5M) + 32;
        }
    }
    public class CelsiusToKelvin : ITempConversions
    {
        public decimal GetTemp(decimal tempIn)
        {
            return tempIn + 273.15M;
        }

    }
    // ---------- || FAHRENHEIT || ---------- \\
    public class FahrenheitToCelsius : ITempConversions
    {
        public decimal GetTemp(decimal tempIn)
        {
            return (tempIn - 32) / 9M * 5M;
        }
    }
    public class FahrenheitToKelvin : ITempConversions
    {
        public decimal GetTemp(decimal tempIn)
        {
            return (tempIn + 459.67M) * 5M / 9M;
        }
    }
    // ---------- || KELVIN || ---------- \\
    public class KelvinToCelsius : ITempConversions
    {
        public decimal GetTemp(decimal tempIn)
        {
            return tempIn - 273.15M;
        }
    }
    public class KelvinToFahrenheit : ITempConversions
    {
        public decimal GetTemp(decimal tempIn)
        {
            return tempIn * (9M / 5M) - 459.67M;
        }
    }



}