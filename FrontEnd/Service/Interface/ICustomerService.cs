using FrontEnd.HTTPClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace FrontEnd.Service.Interface
{
    public interface ICustomerService
    {
        Task<HttpResponse> CustomerRegistration(CustomerModel customer);
    }
}
