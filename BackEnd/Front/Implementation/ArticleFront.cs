using BackEnd.DAO.Implementation;
using BackEnd.DAO.Interface;
using BackEnd.Front.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Front.Implementation
{
    public class ArticleFront : IArticleFront
    {

        private readonly IArticleDao articleDao;

        public ArticleFront()
        {
                articleDao=new ArticleDao();
        }
        public bool ArticleRegistration(ArticleModel article)
        {
            return articleDao.ArticleRegistration(article);
        }

        public bool ArticleTermination(int id)
        {
            return articleDao.ArticleTermination(id);       
        }

        public bool ArticleUpdate(ArticleModel article)
        {
            return articleDao.ArticleUpdate(article);
        }

        public List<ArticleModel> GetArticles(string nameArticle)
        {
            return articleDao.GetArticles(nameArticle);
        }

        public ArticleModel GetArticlesById(int id)
        {
            return articleDao.GetArticlesById(id);
        }
    }
}
