using FrontEnd.Factory.Interface;
using FrontEnd.Service.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd.View.Article
{
    public partial class FrmArticleWatch : Form
    {
        readonly IFactoryService factoryService;
        readonly IArticleService articleService;
        public FrmArticleWatch(IFactoryService fservice)
        {
            this.factoryService = fservice;
            InitializeComponent();
            articleService = factoryService.CreateArticleService();
            ConfigureDataGridView();
        }
        private void ConfigureDataGridView()
        {
            DgvArticleWatch.AutoGenerateColumns = false;          
            DgvArticleWatch.Columns.Add("CodArticle", "Code");
            DgvArticleWatch.Columns.Add("DescriptionArticle", "Description");
            DgvArticleWatch.Columns.Add("StockMinArticle", "Minimum Stock");
            DgvArticleWatch.Columns.Add("StockArticle", "Stock");
            DgvArticleWatch.Columns.Add("PriceUnitArticle", "Unit Price");
            DgvArticleWatch.Columns.Add("ObservationArticle", "Observation");

            DgvArticleWatch.Columns["CodArticle"].DataPropertyName = "CodArticle";
            DgvArticleWatch.Columns["DescriptionArticle"].DataPropertyName = "DescriptionArticle";
            DgvArticleWatch.Columns["StockMinArticle"].DataPropertyName = "StockMinArticle";
            DgvArticleWatch.Columns["StockArticle"].DataPropertyName = "StockArticle";
            DgvArticleWatch.Columns["PriceUnitArticle"].DataPropertyName = "PriceUnitArticle";
            DgvArticleWatch.Columns["ObservationArticle"].DataPropertyName = "ObservationArticle";
        }
        private async void BtnSearch_Click(object sender, EventArgs e)
        {
            if (Validated())
            {
                try
                {
                    string Description = TxtDescription.Text;

                    // Agrega un mensaje de log antes de la llamada a la API
                    Debug.WriteLine($"Calling articleService.GetArticleAsync with Description: {Description}");

                    List<ArticleModel> lstArticles = await articleService.GetArticleAsync(Description);
                    DgvArticleWatch.Rows.Clear();

                    // Agrega un mensaje de log después de la llamada a la API
                    Debug.WriteLine($"Received {lstArticles.Count} articles from the API");

                    if (lstArticles.Count > 0)
                    {
                        foreach (ArticleModel article in lstArticles)
                        {
                            DgvArticleWatch.Rows.Add(
                                article.CodArticle != null ? article.CodArticle : 0,
                                article.DescriptionArticle ?? string.Empty,
                                article.StockMinArticle != null ? article.StockMinArticle : 0,
                                article.StockArticle != null ? article.StockArticle : 0,
                                article.PriceUnitArticle != null ? article.PriceUnitArticle : 0,
                                article.ObservationArticle ?? string.Empty
                            );
                        }

                        DgvArticleWatch.ClearSelection();
                    }
                    else
                    {
                        MessageBox.Show("No articles were found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while searching for articles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show($"Exception Details: {ex.ToString()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private bool Validated()
        {
            if (string.IsNullOrEmpty(TxtDescription.Text))
            {
                MessageBox.Show("You must enter a description to filter an articles or the articles");
                TxtDescription.Focus();
                return false;
            }
            return true;
        }

        private void FrmArticleWatch_Load(object sender, EventArgs e)
        {

        }
    }
}
