using FrontEnd.Factory.Interface;
using FrontEnd.Service.Implementation;
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
using System.Xml.Linq;

namespace FrontEnd.View.Article
{
    public partial class FrmArticleUpdate : Form
    {
        IFactoryService _factoryService;
        ArticleModel _articleModel;
        IArticleService _articleService;
        public FrmArticleUpdate(IFactoryService factoryService, ArticleModel article)
        {

            InitializeComponent();
            this._factoryService = factoryService;
            this._articleModel = article;
            _articleService = factoryService.CreateArticleService();

        }
        private void loadArticle()
        {
            TxtDescription.Text = _articleModel.DescriptionArticle;
            TxtStockMin.Text = _articleModel.StockMinArticle.ToString();
            TxtStock.Text = _articleModel.StockArticle.ToString();
            TxtUnitPrice.Text = _articleModel.PriceUnitArticle.ToString();
            TxtObservation.Text = _articleModel.ObservationArticle;
        }
        private void updateArticle()
        {
            _articleModel.DescriptionArticle = TxtDescription.Text;
            _articleModel.StockMinArticle = Convert.ToInt16(TxtStockMin.Text);
            _articleModel.StockArticle = Convert.ToInt16(TxtStock.Text);
            _articleModel.PriceUnitArticle = Convert.ToDouble(TxtUnitPrice.Text);
            _articleModel.ObservationArticle = TxtObservation.Text;

        }
        private void FrmArticleUpdate_Load(object sender, EventArgs e)
        {
            loadArticle();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async void BtnUpdate_Click(object sender, EventArgs e)
        {
            await PerformUpdateAsync();
        }

        private async Task PerformUpdateAsync()
        {
            if (Validated())
            {
                updateArticle();
                var response = await _articleService.ArticleUpdate(_articleModel);

                
                Debug.WriteLine($"Response Content: {response?.Data}");

          
                if (response != null)
                {
                    if (response.SuccessStatus)
                    {
                        MessageBox.Show($"Article updated successfully. Response Content: {response?.Data}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose(); 
                        
                    }
                    else
                    {
                        Debug.WriteLine($"Error updating an article. Response Content: {response?.Data}");
                        MessageBox.Show($"Error updating an article. Response Content: {response?.Data}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Debug.WriteLine("Error updating article. Null response received.");
                    MessageBox.Show("Error updating article. Null response received.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private bool Validated()
        {
            if (string.IsNullOrEmpty(TxtDescription.Text))
            {
                MessageBox.Show("You must enter a description...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtDescription.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(TxtStockMin.Text) || !int.TryParse(TxtStockMin.Text, out _))
            {
                MessageBox.Show("You must enter a minimum stock number..", "Add", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtStockMin.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(TxtStock.Text) || !int.TryParse(TxtStock.Text, out _))
            {
                MessageBox.Show("You must enter a stock number..", "Add", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtStock.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(TxtUnitPrice.Text) || !double.TryParse(TxtUnitPrice.Text, out _))
            {
                MessageBox.Show("You must enter a unit price ..\nPlease note that the price only accepts two decimal values", "Add", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtUnitPrice.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(TxtObservation.Text))
            {
                MessageBox.Show("You must enter a observation...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtObservation.Focus();
                return false;
            }
            return true;
        }
    }
}
