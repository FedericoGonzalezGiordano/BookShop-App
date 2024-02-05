using FrontEnd.Factory.Interface;
using FrontEnd.Service.Implementation;
using FrontEnd.Service.Interface;
using FrontEnd.View.Customer;
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

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            if (DgvArticleWatch.SelectedRows.Count > 0)
            {
                DataGridViewRow row = DgvArticleWatch.SelectedRows[0];
                int idArt = Convert.ToInt32(row.Cells[0].Value);
                try
                {
                    var result = await articleService.ArticleTermination(idArt);
                    MessageBox.Show("Customer deleted with ID: " + idArt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                    MessageBox.Show("Error deleting an article. Details: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No selected rows in DataGridView");
                MessageBox.Show("Select an article before deleting.");
            }
        }

        private async void BtnModify_Click(object sender, EventArgs e)
        {
            if (DgvArticleWatch.SelectedRows.Count > 0)
            {
                DataGridViewRow row = DgvArticleWatch.SelectedRows[0];
                int idArticulo = Convert.ToInt32(row.Cells[0].Value);
                ArticleModel article = await articleService.GetArticleByIdAsync(idArticulo);
                if (article != null)
                {

                    FrmArticleUpdate frmArticleUpdate = new FrmArticleUpdate(factoryService, article);
                    frmArticleUpdate.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Error getting article details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
