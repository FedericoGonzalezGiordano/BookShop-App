using BackEnd.DAO.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Front.Interface
{
    public interface IArticleFront
    {
      bool ArticleRegistration(ArticleModel article);
      List<ArticleModel> GetArticles(string nameArticle);
      bool ArticleTermination(int id);
    }
}
