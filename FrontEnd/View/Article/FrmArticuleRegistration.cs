using FrontEnd.Factory.Interface;
using FrontEnd.Service.Implementation;
using FrontEnd.Service.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FrontEnd.View.Article
{
    public partial class FrmArticuleRegistration : Form
    {
        readonly IFactoryService factory;
        readonly IArticleService articleService;
        private readonly List<ArticleModel> lstArticles;
        public FrmArticuleRegistration(IFactoryService factory)
        {
            lstArticles = new List<ArticleModel>();
            this.factory = factory;
            articleService = factory.CreateArticleService();
            InitializeComponent();
        }
        private void ButonAdd_Click(object sender, EventArgs e)
        {
            if (Validated())
            {
                ArticleModel article = new ArticleModel()
                {
                    DescriptionArticle = TxtDescription.Text,
                    StockMinArticle = Convert.ToInt32(TxtMinStock.Text),
                    StockArticle = Convert.ToInt32(TxtStock.Text),
                    PriceUnitArticle = Convert.ToDouble(txtUnitPrice.Text),
                    ObservationArticle = TxtObservation.Text
                };

                lstArticles.Add(article);

                AddColumnsToDataGridView();

                DgvArticle.Rows.Add(
                    article.DescriptionArticle,
                    article.StockMinArticle,
                    article.StockArticle,
                    article.PriceUnitArticle,
                    article.ObservationArticle
                );

                Clean();

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
            if (string.IsNullOrEmpty(TxtMinStock.Text) || !int.TryParse(TxtMinStock.Text, out _))
            {
                MessageBox.Show("You must enter a minimum stock number..", "Add", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtMinStock.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(TxtStock.Text) || !int.TryParse(TxtStock.Text, out _))
            {
                MessageBox.Show("You must enter a stock number..", "Add", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtStock.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtUnitPrice.Text) || !int.TryParse(txtUnitPrice.Text, out _))
            {
                MessageBox.Show("You must enter a unit price ..\nPlease note that the price only accepts two decimal values", "Add", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUnitPrice.Focus();
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

        private void FrmArticuleRegistration_Load(object sender, EventArgs e)
        {
            DgvArticle.ReadOnly = true;
            Clean();
        }

        private void Clean()
        {
            foreach (Control control in GbpArticle.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
            }
        }

        private void AddColumnsToDataGridView()
        {
            if (DgvArticle.Columns.Count == 0)
            {
                DgvArticle.Columns.Add("DescriptionArticle", "Description");
                DgvArticle.Columns.Add("StockMinArticle", "Minimum stock");
                DgvArticle.Columns.Add("StockArticle", "Stock");
                DgvArticle.Columns.Add("PriceUnitArticle", "Unit Price");
                DgvArticle.Columns.Add("ObservationArticle", "Observation");

            }
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            if (lstArticles.Count > 0)
            {
                foreach (ArticleModel article in lstArticles)
                {
                    var result = await articleService.ArticleRegistration(article);

                    if (!result.SuccessStatus)
                    {
                        MessageBox.Show("Error loading an article: " + result.Data, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                Clean();

                MessageBox.Show("Article successfully loaded", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lstArticles.Clear();
                DgvArticle.Rows.Clear();
                DgvArticle.Refresh();
            }
            else
            {
                MessageBox.Show("No customers to load", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
