using Microsoft.AspNetCore.Mvc;
using Tarkiz_Task1.Core.Cust.Interface;
using Tarkiz_Task1.Model.Cus;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tarkiz_Task1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        public readonly IVehicleCreator _vehicleCreator;
        public VehicleController(IVehicleCreator vehicleCreator)
        {
            _vehicleCreator= vehicleCreator;
        }

        // GET: api/<VehicleController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<VehicleController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<VehicleController>
        [HttpPost]
        public void Post([FromBody] VehicleRequestModel vehicleRequest)
        {
            _vehicleCreator.CreateVehicle(vehicleRequest);
        }

        // PUT api/<VehicleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VehicleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
