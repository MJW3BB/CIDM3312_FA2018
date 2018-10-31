using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppConverter.Models;
using Database;
using Libray.Length;
using Library.Mass;
using Libary.Temperature;

namespace UnitConvertWebApp.Controllers
{
    public class ConversionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TempConvert(decimal numIn)
        {
            // Instantiate new objects that implement ITempConversions
            ITempConvert cToF = new Celsius2Fahrenheit();
            ITempConvert fToC = new Fahrenheit2Celsius();
            ITempConvert cToK = new Celsius2Kelvin();
            ITempConvert kToC = new Kelvin2Celsius();
            ITempConvert fToK = new Fahrenhe2Kelvin();
            ITempConvert kToF = new Kelvin2Fahrenheit();

            ViewData["NumInput"] = numIn;
            ViewData["CtoF"] = Math.Round(cToF.GetTemp(numIn), 2);
            ViewData["FtoC"] = Math.Round(fToC.GetTemp(numIn), 2);
            ViewData["CtoK"] = Math.Round(cToK.GetTemp(numIn), 2);
            ViewData["KtoC"] = Math.Round(kToC.GetTemp(numIn), 2);
            ViewData["FtoK"] = Math.Round(fToK.GetTemp(numIn), 2);
            ViewData["KtoF"] = Math.Round(kToF.GetTemp(numIn), 2);
            return View();
        }

        public IActionResult LengthConvert(decimal numIn)
        {
            ILengthConvert mToF = new MeterFeet();
            ILengthConvert fToM = new FeetMeter();
            ILengthConvert mToY = new MeterYard();
            ILengthConvert yToM = new YardMeter();
            ILengthConvert fToY = new FeetYard();
            ILengthConvert yToF = new YardFeet();

            ViewData["NumInput"] = numIn;
            ViewData["MtoF"] = Math.Round(mToF.GetLength(numIn), 2);
            ViewData["FtoM"] = Math.Round(fToM.GetLength(numIn), 2);
            ViewData["MtoY"] = Math.Round(mToY.GetLength(numIn), 2);
            ViewData["YtoM"] = Math.Round(yToM.GetLength(numIn), 2);
            ViewData["FtoY"] = Math.Round(fToY.GetLength(numIn), 2);
            ViewData["YtoF"] = Math.Round(yToF.GetLength(numIn), 2);

            return View();
        }

        public IActionResult MassConvert(decimal numIn)
        {
            IMassConversions gToK = new Gram2Kilogram();
            IMassConversions kToG = new Kilogram2Gram();
            IMassConversions gToO = new Gram2Ounce();
            IMassConversions oToG = new Ounce2Gram();
            IMassConversions gToP = new Gram2Pound();
            IMassConversions pToG = new Pound2Gram();
            IMassConversions pToO = new Pound2Ounce();
            IMassConversions oToP = new Ounce2Pounds();
            IMassConversions kToO = new Kilogram2Ounce();
            IMassConversions oToK = new Ounce2Kilogram();
            IMassConversions pToK = new Pound2Kilogram();
            IMassConversions kToP = new Kilogram2Pound();

            ViewData["NumInput"] = numIn;
            ViewData["OtoL"] = Math.Round(oToP.GetMass(numIn), 2);
            ViewData["LtoO"] = Math.Round(pToO.GetMass(numIn), 2);
            ViewData["OtoG"] = Math.Round(oToG.GetMass(numIn), 2);
            ViewData["GtoO"] = Math.Round(gToO.GetMass(numIn), 2);
            ViewData["OtoK"] = Math.Round(oToK.GetMass(numIn), 2);
            ViewData["KtoO"] = Math.Round(kToO.GetMass(numIn), 2);
            ViewData["LtoG"] = Math.Round(pToG.GetMass(numIn), 2);
            ViewData["GtoL"] = Math.Round(gToP.GetMass(numIn), 2);
            ViewData["LtoK"] = Math.Round(pToK.GetMass(numIn), 2);
            ViewData["KtoL"] = Math.Round(kToP.GetMass(numIn), 2);
            ViewData["GtoK"] = Math.Round(gToK.GetMass(numIn), 2);
            ViewData["KtoG"] = Math.Round(kToG.GetMass(numIn), 2);

            return View();
        }
    }
}