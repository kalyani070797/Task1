using Microsoft.AspNetCore.Mvc;
using Tarkiz_Task1.Core.Cust.Interface;
using Tarkiz_Task1.Model.Cus;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tarkiz_Task1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        public readonly IBookingCreator _bookinCreator;
        public BookingController(IBookingCreator bookinCreator)
        {
            _bookinCreator = bookinCreator;
        }


        // GET: api/<BookingController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<BookingController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BookingController>
        [HttpPost]
        public void Post([FromBody] BookingRequestModel bookingRequest)
        {
            _bookinCreator.CreateBooking(bookingRequest);
        }

        // PUT api/<BookingController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BookingController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
