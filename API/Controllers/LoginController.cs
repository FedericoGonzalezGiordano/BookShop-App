using BackEnd.Front.Implementation;
using BackEnd.Front.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        ILoginFront front;
        public LoginController()
        {
                front=new LoginFront();
        }

        [HttpGet("/GetSeller")]
        public IActionResult GetSeller()
        {

            try
            {
                var result = front.GetSeller();
                if (result == null)
                {
                    return StatusCode(500, "An error occurred while searching for Sellers");
                }
                return Ok(result);

            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }







    }
}
