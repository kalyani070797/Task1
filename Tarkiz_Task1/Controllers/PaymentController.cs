using Microsoft.AspNetCore.Mvc;
using Tarkiz_Task1.Core.Cust.Implementation;
using Tarkiz_Task1.Model.Cus;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tarkiz_Task1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        public readonly IPaymentCreator _paymentCreator;
        public PaymentController(IPaymentCreator paymentCreator)
        {
            _paymentCreator=paymentCreator;
        }
        // GET: api/<PaymentController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PaymentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PaymentController>
        [HttpPost]
        public void Post([FromBody] PaymentRequestModel paymentRequest )
        {
            _paymentCreator.CreatePayment( paymentRequest );
        }

        // PUT api/<PaymentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PaymentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
