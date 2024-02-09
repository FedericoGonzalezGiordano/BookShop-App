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
    public class InvoiceService : IInvoiceService
    {
        private const string host = "https://localhost:7101";

        public async Task<List<ArticleModel>> GetAllArticles()
        {
            string url = host + "/GetArticleList";
            List<ArticleModel> result = new List<ArticleModel>();
            var response = await ClientSingleton.GetInstance().GetAsync(url);
            if (response != null && response.SuccessStatus)
            {
                result = JsonConvert.DeserializeObject<List<ArticleModel>>(response.Data);
            }
            return result;
        }

        public async Task<List<CustomerModel>> GetAllCustomers()
        {
            string url = host + "/GetCustomerList";
           
            List<CustomerModel> result = new List<CustomerModel>();
            var response = await ClientSingleton.GetInstance().GetAsync(url);
            if (response != null && response.SuccessStatus)
            {
                result = JsonConvert.DeserializeObject<List<CustomerModel>>(response.Data);
            }
            return result;
        }

        public async Task<List<SellerModel>> GetAllSellers()
        {
            string url = host + "/GetSellerList";
  
            List<SellerModel> result = new List<SellerModel>();
            var response = await ClientSingleton.GetInstance().GetAsync(url);
            if (response != null && response.SuccessStatus)
            {
                result = JsonConvert.DeserializeObject<List<SellerModel>>(response.Data);
            }
            return result;
        }

        public async Task<HttpResponse> InvoiceRegistration(InvoiceModel invoice)
        {
            string url = host + "/PostInvoice";
            var cuerpo = JsonConvert.SerializeObject(invoice);
            Clipboard.SetText(cuerpo);
            var response = await ClientSingleton.GetInstance().PostAsync(url, cuerpo);
            return response;
        }
    }
}
