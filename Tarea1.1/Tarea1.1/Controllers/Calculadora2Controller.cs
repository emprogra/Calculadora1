using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tarea1._1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Calculadora2Controller : ControllerBase
    {
        // GET: api/<Calculadora2Controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Calculadora2Controller>/5
        [HttpGet("{x}/{y}/{operacion}")]
        public float Get(float x,float y,string operacion)
        {
           
             if (operacion == "suma") 
            {
                return (x + y);
            }
            else
            {
                if (operacion == "resta")
                {
                    return (x - y);
                }
                else
                {
                    if (operacion == "multiplicacion")
                    {
                        return (x * y);
                    }
                    else
                    {
                        if (operacion == "division")
                        {
                            return (x / y);
                        }
                        else
                        {
                            return (0);
                        }
                    }
                }
            }
        }

        
    }
}




