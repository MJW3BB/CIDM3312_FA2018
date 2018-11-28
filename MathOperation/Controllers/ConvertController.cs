using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MathOperation.Models;
using MathLibrary;


namespace Draft01.Controllers
{
    public class ConvertController : Controller
    {
        public IActionResult Index()
        {
            string message = "this is the message";
            ViewData["Message"] = message;            
            return View();
        }
        public IActionResult Converter()
        {
            return View();
        }
        [HttpPost]
        /*public IActionResult DoConversions(ConverterViewModel model)
        {
            model.ConvertedValue = model.ValueToConvert * model.ValueToConvert;
            return View(model);
        }*/
        public string Add(decimal left, decimal right)
        {
            return $"{left} plus {right} is: {MathConverter.Add(left,right)}";
        }
        public string Subtract(decimal left, decimal right)
        {
            return $"{left} minus {right} is: {MathConverter.Subtract(left,right)}";
        }
        public string Multiply(decimal left, decimal right)
        {
            return $"{left} multiplied by {right} is: {MathConverter.Multiply(left, right)}";
        }
        public string Divide(decimal left, decimal right)
        {
            return $"{left} divided by {right} is: {MathConverter.Divide(left, right)}";
        }
        public string Powers(double left, double right)
        {
            return $"{left} to the power of {right} is: {MathConverter.Power(left, right)}";
        }
        public string Ceiling(decimal number)
        {
            return $"The ceiling of {number} is: {MathConverter.Ceiling(number)}";
        }
        public string Floor(decimal number)
        {
            return $"The floor of {number} is: {MathConverter.Floor(number)};";
        }
    }
}

