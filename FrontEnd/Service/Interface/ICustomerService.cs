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
        Task<List<NeighborhoodModel>> GetNeighborhoodAsync();
        Task<List<CustomerModel>> GetCustomerAsync(string name, string lastName);

        Task<CustomerModel> GetCustomerByIdAsync(int customerId);
        Task<HttpResponse> CustomerTermination(int id);
        Task<HttpResponse> CustomerUpdate(CustomerModel customer);
    }
}
