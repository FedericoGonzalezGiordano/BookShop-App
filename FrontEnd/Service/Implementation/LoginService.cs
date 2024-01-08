using FrontEnd.HTTPClient;
using FrontEnd.Service.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.Service.Implementation
{
    public class LoginService : ILoginService
    {
        private const string host = "https://localhost:7101";
        public async Task<List<SellerModel>> GetSellerAsync()
        {
                
                string url = host + "/GetSeller";
                List<SellerModel> result = new List<SellerModel>();
                var response = await ClientSingleton.GetInstance().GetAsync(url);
                if (response != null && response.SuccessStatus)
                {
                    result = JsonConvert.DeserializeObject<List<SellerModel>>(response.Data);
                }
                return result;
        }
    }
}
