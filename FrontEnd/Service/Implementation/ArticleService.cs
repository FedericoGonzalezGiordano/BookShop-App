﻿using FrontEnd.HTTPClient;
using FrontEnd.Service.Interface;
using FrontEnd.View.Article;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public async Task<HttpResponse> ArticleTermination(int id)
        {
            string url = host + $"/DeleteArticle?id={id}";
            var response= await ClientSingleton.GetInstance().DeleteAsync(url);
            return response;
        }

        public async Task<HttpResponse> ArticleUpdate(ArticleModel article)
        {
            try
            {
                string url = host + "/UpdateArticle";
                var cuerpo = JsonConvert.SerializeObject(article);
                var response = await ClientSingleton.GetInstance().PutAsync(url, cuerpo);
                return response;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"An error occurred during article update: {ex.Message}\nStackTrace: {ex.StackTrace}");
                MessageBox.Show($"An error occurred during article update: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public async Task<List<ArticleModel>> GetArticleAsync(string nameArticle)
        {
          
            string url = host + $"/GetArticle?nameArticle={nameArticle}";
            List<ArticleModel> result = new List<ArticleModel>();
            var response = await ClientSingleton.GetInstance().GetAsync(url);
            if (response != null && response.SuccessStatus)
            {
                result = JsonConvert.DeserializeObject<List<ArticleModel>>(response.Data);
            }
            return result;
        }

        public async Task<ArticleModel> GetArticleByIdAsync(int articleID)
        {
            try
            {
                string url = host + $"/GetArticleByID?cod={articleID}";
                ArticleModel result = null;
                var response = await ClientSingleton.GetInstance().GetAsync(url);

                if (response != null && response.SuccessStatus)
                {
                    result = JsonConvert.DeserializeObject<ArticleModel>(response.Data);
                }
                else
                {
                    MessageBox.Show("Error retrieving article data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
    
}
