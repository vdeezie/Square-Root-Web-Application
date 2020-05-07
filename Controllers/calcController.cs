using System;
using Microsoft.AspNetCore.Mvc;

namespace DeezieWeb
{
    public class CalcController : Controller
    {
        [HttpGet]

        public ActionResult SquareRoot()
        {
            return View();
        }

        [HttpPost]

        public ActionResult SquareRoot(string firstNumber, string secondNumber)
        {
            var One = firstNumber;
            var Two = secondNumber;
            int numberOne;
            int numberTwo;

            while ((!int.TryParse(One, out numberOne)) || (!int.TryParse(Two, out numberTwo)))
            {
                One = firstNumber;
                Two = secondNumber;
            }
            
            double sqr1 = Math.Sqrt(numberOne);
            double sqr2 = Math.Sqrt(numberTwo);

            ViewBag.N1 = numberOne;
            ViewBag.N2 = numberTwo;

            ViewBag.Result1 = sqr1;
            ViewBag.Result2 = sqr2;

            return View();
        }
    }
}
