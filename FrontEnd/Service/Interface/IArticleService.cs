using FrontEnd.HTTPClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.Service.Interface
{
    public interface IArticleService
    {
        Task<HttpResponse> ArticleRegistration(ArticleModel article);
        Task<List<ArticleModel>> GetArticleAsync(string nameArticle);

        Task<HttpResponse> ArticleTermination(int id);
    }
}
