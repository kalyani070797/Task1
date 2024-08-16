using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tarkiz_Task1.Core.Cust.Implementation;
using Tarkiz_Task1.Core.Cust.Interface;
using Tarkiz_Task1.Infrastructure.PracticeDBContext;
using Tarkiz_Task1.Model.Cus;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tarkiz_Task1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public readonly ICustomerCreator _customerCreator;
        public readonly IGetDetails  _getDetails;
        public CustomerController(ICustomerCreator customerCreator, IGetDetails getDetails)
        {
            _customerCreator = customerCreator;
          _getDetails = getDetails;
        }

        // GET: api/<CustomerController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CustomerController>
        [HttpPost]
        public void Post([FromBody] CustomerRequestModel customerRequest)
        {
            _customerCreator.CreateCustomer(customerRequest);
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpGet("GetCustomersByStartingLocation")]
        public IActionResult GetCustomersByStartingLocation(string startingLocation)
        {
           var detials=  _getDetails.Detils( startingLocation );
            return Ok(detials);
        }
    }
}
