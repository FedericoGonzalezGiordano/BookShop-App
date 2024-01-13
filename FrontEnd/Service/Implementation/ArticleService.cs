using FrontEnd.HTTPClient;
using FrontEnd.Service.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FrontEnd.Service.Implementation
{
    public class ArticleService : IArticleService
    {
        private const string host = "https://localhost:7101";
        public async Task<HttpResponse> ArticleRegistration(ArticleModel article)
        {
            string url = host + "/PostArticle";
            var cuerpo=JsonConvert.SerializeObject(article);
            var response=await ClientSingleton.GetInstance().PostAsync(url,cuerpo);
            return response;
            
        }

        public async Task<List<ArticleModel>> GetArticleAsync(string nameArticle)
        {
            //string url = host + $"/GetCustomer?name={name}&lastName={lastName}";
            string url = host + $"/GetArticle?nameArticle={nameArticle}";
            List<ArticleModel> result = new List<ArticleModel>();
            var response = await ClientSingleton.GetInstance().GetAsync(url);
            if (response != null && response.SuccessStatus)
            {
                result = JsonConvert.DeserializeObject<List<ArticleModel>>(response.Data);
            }
            return result;
        }
    }
    
}
