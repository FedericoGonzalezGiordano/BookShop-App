using BackEnd.Front.Implementation;
using BackEnd.Front.Interface;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerFront front;
        public CustomerController()
        {
            front = new CustomerFront();
        }

        [HttpGet("/GetNeighborhood")]
        public IActionResult GetNeighborhood()
        {

            try
            {
                var result = front.GetNeighborhood();
                if (result == null)
                {
                    return StatusCode(500, "An error occurred while searching for neighborhoods");
                }
                return Ok(result);

            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }
        [HttpPost("/PostCustomer")]
        public IActionResult PostCliente(CustomerModel customer)
        {

            try
            {
                var result = front.CustomerRegistration(customer);
                if (result == false)
                {
                    return StatusCode(500, "An error occurred while registering a client");
                }
                return Ok(result);

            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }

        //// GET: api/<CustomerController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<CustomerController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<CustomerController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<CustomerController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<CustomerController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
