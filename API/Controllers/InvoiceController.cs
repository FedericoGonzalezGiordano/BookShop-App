using BackEnd.Front.Implementation;
using BackEnd.Front.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        IInvoiceFront invoiceFront;
        public InvoiceController()
        {
                invoiceFront=new InvoiceFront();
        }

        [HttpPost("/PostInvoice")]
        public IActionResult PostInvoice(InvoiceModel invoice)
        {
            try
            {
                if (invoice == null)
                {
                    return BadRequest("Incorrect invoice details!");
                }

                bool registrationResult = invoiceFront.InvoiceRegistration(invoice);

                if (registrationResult)
                {
                    return Ok("Invoice registered successfully!");
                }
                else
                {
                    return BadRequest("Failed to register the invoice. Check server logs for details.");
                }
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"Exception: {ex.Message}");
                return StatusCode(500, "Internal Server Error");
            }
        }




        [HttpGet("/GetSellerList")]
        public IActionResult GetSeller()
        {
            try
            {
                var result = invoiceFront.GetSellerList();
                if (result == null)
                {
                    return StatusCode(500, "An error ocurred while searching sellers");
                }
                return Ok(result);
            }
            catch (Exception)
            {

                return StatusCode(500);
            }

        }


        [HttpGet("/GetArticleList")]
        public IActionResult GetArticle()
        {
            try
            {
                var result = invoiceFront.GetArticleList();
                if (result == null)
                {
                    return StatusCode(500, "An error ocurred while searching articles");
                }
                return Ok(result);
            }
            catch (Exception)
            {

                return StatusCode(500);
            }

        }
        [HttpGet("/GetCustomerList")]
        public IActionResult GetCustomer()
        {
            try
            {
                var result = invoiceFront.GetCustomerList();
                if (result == null)
                {
                    return StatusCode(500, "An error ocurred while searching customers");
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
