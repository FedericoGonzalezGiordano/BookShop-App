﻿using BackEnd.DAO.Implementation;
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

        private IArticleDao articleDao;

        public ArticleFront()
        {
                articleDao=new ArticleDao();
        }
        public bool ArticleRegistration(ArticleModel article)
        {
            return articleDao.ArticleRegistration(article);
        }
    }
}
