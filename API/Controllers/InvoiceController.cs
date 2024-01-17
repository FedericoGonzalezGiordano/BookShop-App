using BackEnd.Front.Implementation;
using BackEnd.Front.Interface;
using Microsoft.AspNetCore.Mvc;

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
                var result = invoiceFront.InvoiceRegistration(invoice);
                if (result == false)
                {
                    return StatusCode(500, "An error occurred while registering an invoice");
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
