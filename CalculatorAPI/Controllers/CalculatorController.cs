using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculatorLibrary;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CalculatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : Controller
    {
        [HttpGet]
        [Route("api/Calculator/Add/{num1}/{num2}")]
        public double GetAddResult(double num1, double num2)
        {
            return Calculator.Add(num1, num2);

        }

        [HttpGet]
        [Route("api/Calculator/Subract/{num1}/{num2}")]
        public double GetSubResult(double num1, double num2)
        {
            return Calculator.Subtract(num1, num2);
        }

        [HttpGet]
        [Route("api/Calculator/Div/{num1}/{num2}")]
        public double GetDivResult(double num1, double num2)
        {
            return Calculator.Divide(num1, num2);
        }

        [HttpGet]
        [Route("api/Calculator/Mul/{num1}/{num2}")]
        public double GetMulResult(double num1, double num2)
        {
            return Calculator.Multiply(num1, num2);
        }
    }

}
