using FrontEnd.HTTPClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.Model;

namespace FrontEnd.Factory.Interface
{
    public interface ICustomerService
    {
        Task<HttpResponse> AltaCliente(CustomerModel cliente);
    }
}
