using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.DAO.Interface
{
    public interface IArticleDao
    {
         bool ArticleRegistration(ArticleModel article);
        List<ArticleModel> GetArticles(string nameArticle);

        bool ArticleTermination(int id);

        ArticleModel GetArticlesById(int id);

        bool ArticleUpdate(ArticleModel article);
    }
}
