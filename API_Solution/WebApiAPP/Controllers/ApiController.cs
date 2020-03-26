using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiAPP.Controllers
{
    [Route("api/[controller]/[action]")]
    public class ApiController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public double GetSum(int a, int b)
        {
            return a+b;
        }
        [HttpGet]
        public double GetProduct(int a, int b)
        {
            return a * b;
        }
        [HttpGet]
        public double GetSubtraction(int a, int b)
        {
            return a - b;
        }
        [HttpGet]
        public double GetDiv(int a, int b)
        {

            if (b == 0)
            {
               
                throw new System.DivideByZeroException();
            }
            else

            {
                return a / b;

        }
    }

        [HttpGet]
        public double GetResto(int a, int b)
        {
            return a % b;

        }
       
        [HttpGet]
        public double GetAverage(double a, double b)
        {
            double[] numeri = new double[] { a, b };
            double media = numeri[0];
            double somma = 0;
            for (int i=0;i<numeri.Length;i++)
            {
                somma += numeri[i];
            }
            return media = somma / numeri.Length;
        }
        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";

        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
