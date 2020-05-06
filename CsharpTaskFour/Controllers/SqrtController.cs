using System;
using Microsoft.AspNetCore.Mvc;

namespace CsharpTaskFour.Controllers
{
    public class SqrtController : Controller
    {
        [HttpGet]
        public ActionResult Compare()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Compare(string firstNumber, string secondNumber)
        {
            double firstNumbersqrt = Math.Sqrt(double.Parse(firstNumber));
            double secondNumbersqrt = Math.Sqrt(double.Parse(secondNumber));

            double result = Math.Max(firstNumbersqrt, secondNumbersqrt);

            ViewBag.Result = result;
            return View();
        }
    }
}