using System;
using Library.Temperature;
using Library.Mass;
using Library.Length;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Temp Conversions
            Console.WriteLine("---------------Temperature Conversions----------------");
            ITempConversion cToF = new CelsiusToFahrenheit();
            ITempConversion fToC = new FahrenheitToCelsius();
            ITempConversion cToK = new CelsiusToKelvin();
            ITempConversion kToC = new KelvinToCelsius();
            ITempConversion fToK = new FahrenheitToKelvin();
            ITempConversion kToF = new KelvinToFahrenheit();
            Console.WriteLine(Math.Round(cToF.GetTemp(15), 2));
            Console.WriteLine(Math.Round(fToC.GetTemp(15), 2));
            Console.WriteLine(Math.Round(cToK.GetTemp(15), 2));
            Console.WriteLine(Math.Round(kToC.GetTemp(15), 2));
            Console.WriteLine(Math.Round(fToK.GetTemp(15), 2));
            Console.WriteLine(Math.Round(kToF.GetTemp(15), 2));
            #endregion

            #region Mass Conversions
            Console.WriteLine("\n--------------Mass Conversions----------------------");
            IMassConversion gToK = new GramToKilogram();
            IMassConversion kToG = new KilogramToGram();
            IMassConversion gToO = new GramToOunce();
            IMassConversion oToG = new OunceToGram();
            IMassConversion gToP = new GramToPound();
            IMassConversion pToG = new PoundToGram();
            IMassConversion pToO = new PoundToOunce();
            IMassConversion oToP = new OunceToPounds();
            IMassConversion kToO = new KilogramToOunce();
            IMassConversion oToK = new OunceToKilogram();
            IMassConversion pToK = new PoundToKilogram();
            IMassConversion kToP = new KilogramToPound();
            Console.WriteLine(Math.Round(gToK.GetMass(50), 2));
            Console.WriteLine(Math.Round(kToG.GetMass(50), 2));
            Console.WriteLine(Math.Round(gToO.GetMass(50), 2));
            Console.WriteLine(Math.Round(oToG.GetMass(50), 2));
            Console.WriteLine(Math.Round(gToP.GetMass(50), 2));
            Console.WriteLine(Math.Round(pToG.GetMass(50), 2));
            Console.WriteLine(Math.Round(pToO.GetMass(50), 2));
            Console.WriteLine(Math.Round(oToP.GetMass(50), 2));
            Console.WriteLine(Math.Round(kToO.GetMass(50), 2));
            Console.WriteLine(Math.Round(oToK.GetMass(50), 2));
            Console.WriteLine(Math.Round(pToK.GetMass(50), 2));
            Console.WriteLine(Math.Round(kToP.GetMass(50), 2));
            #endregion

            #region Length Conversions
            Console.WriteLine("\n--------------Length Conversions----------------------");
            ILengthConversions fToM = new FeetToMeters();
            ILengthConversions mToF = new MetersToFeet();
            ILengthConversions fToY = new FeetToYards();
            ILengthConversions yToF = new YardsToFeet();
            ILengthConversions yToM = new YardsToMeters();
            ILengthConversions mToY = new MetersToYards();
            Console.WriteLine(Math.Round(fToM.GetLength(25), 2));
            Console.WriteLine(Math.Round(mToF.GetLength(25), 2));
            Console.WriteLine(Math.Round(fToY.GetLength(25), 2));
            Console.WriteLine(Math.Round(yToF.GetLength(25), 2));
            Console.WriteLine(Math.Round(yToM.GetLength(25), 2));
            Console.WriteLine(Math.Round(mToY.GetLength(25), 2));
            #endregion

            Console.WriteLine();
        }
    }
}
