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
        [HttpGet("/GetCustomer")]
        public IActionResult GetCustomer([FromQuery] string name, [FromQuery] string lastName)
        {
            try
            {
                var result = front.GetCustomer(name, lastName);

                if (result == null)
                {
                    return StatusCode(500, "An error occurred while searching for customers");
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
                return StatusCode(500, $"An error occurred while processing your request. Details: {ex.Message}");
            }
        }

    }
}
