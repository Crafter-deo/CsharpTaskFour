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

            
            ViewBag.Result1 = firstNumbersqrt;
            ViewBag.Result2 = secondNumbersqrt;
            
            if (firstNumbersqrt <= 0)
            {
                Console.WriteLine("Enter positive numbers only");
            }

            if (secondNumbersqrt <= 0)
            {
                Console.WriteLine("Enter positive numbers only");
            }

            return View();

        }
    }
}