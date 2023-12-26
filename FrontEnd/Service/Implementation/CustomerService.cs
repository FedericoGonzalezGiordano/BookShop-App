using FrontEnd.HTTPClient;
using FrontEnd.Service.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FrontEnd.Service.Implementation
{
    public class CustomerService : ICustomerService
    {
        private const string host = "https://localhost:7107";
        public async Task<HttpResponse> CustomerRegistration(CustomerModel customer)
        {
            string url = host + "/PostCliente";
            var cuerpo = JsonConvert.SerializeObject(customer);
            var response = await ClientSingleton.GetInstance().PostAsync(url, cuerpo);
            return response;
        }
    }
}
