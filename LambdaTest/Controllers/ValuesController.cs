using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LambdaTest.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public IActionResult Get()
        {
            Response response = new Response();
            response.status = 200;
            response.message = "Data";
            List<PersonData> data = new List<PersonData>(); 
            for (int i = 0; i <= 11000; i++)
            {
                data.Add(new PersonData
                { 
                    Name = "juan" + i.ToString(),
                    age = i 
                
                });
            }
            response.data = data;
            return Ok(response);
        }  
        

     
        // POST api/<ValuesController>
        [HttpPost]
        public IActionResult Post([FromBody] int value)
        {
            Response response = new Response();
            response.status = 200;
            response.message = "Data";
            List<PersonData> data = new List<PersonData>();
            for (int i = 0; i <= value; i++)
            {
                data.Add(new PersonData
                {
                    Name = "juan" + i.ToString(),
                    age = i

                });
            }
            response.data = data;
            return Ok(response);
        }
    }
}
