using FrontEnd.HTTPClient;
using FrontEnd.Service.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.Service.Interface
{
    public interface IInvoiceService
    {
        Task<HttpResponse> InvoiceRegistration(InvoiceModel invoice);
        Task<List<ArticleModel>> GetAllArticles();
        Task<List<CustomerModel>> GetAllCustomers();
        Task<List<SellerModel>> GetAllSellers();


    }
}
