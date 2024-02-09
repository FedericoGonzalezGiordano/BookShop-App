using BackEnd.DAO.Implementation;
using FrontEnd.Factory.Interface;
using FrontEnd.Service.Implementation;
using FrontEnd.Service.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FrontEnd.View.Invoice
{
    public partial class FrmInvoiceRegistration : Form
    {
        IFactoryService _factoryService;
        IInvoiceService _invoiceService;

        private List<SellerModel> _sellerModels;
        private List<CustomerModel> _customerModels;
        private List<ArticleModel> _articleModels;
        SellerModel seller;

        private InvoiceModel invoice;

        int total;



        public FrmInvoiceRegistration(IFactoryService factory, SellerModel seller)
        {
            _factoryService = factory;
            _invoiceService = _factoryService.GetInvoiceService();
            this.seller = seller;


            InitializeComponent();


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmInvoiceRegistration_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Enabled = true;
            LoadComboAsync();
        }

        private void Clean()
        {
            foreach (Control control in GpbInvoice.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }

                else if (control is ComboBox comboBox)
                {
                    CboArticle.SelectedIndex = -1;
                    CboCustomer.SelectedIndex = -1;

                }
            }
        }
        private async void LoadComboAsync()
        {
            _sellerModels = await _invoiceService.GetAllSellers();
            CboSeller.Enabled = false;
            CboSeller.ValueMember = "idSeller";
            CboSeller.DisplayMember = "CompleteName";
            CboSeller.DataSource = _sellerModels;

            CboSeller.DropDownStyle = ComboBoxStyle.DropDownList;


            int sellerCode = seller.IdSeller;

            CboSeller.SelectedIndex = sellerCode - 1;


            if (CboSeller.SelectedIndex < 0)
            {
                CboSeller.SelectedIndex = 0;
            }

            _customerModels = await _invoiceService.GetAllCustomers();
            CboCustomer.ValueMember = "codCustomer";
            CboCustomer.DisplayMember = "CompleteName";
            CboCustomer.DataSource = _customerModels;
            CboCustomer.SelectedIndex = -1;
            CboCustomer.DropDownStyle = ComboBoxStyle.DropDownList;

            _articleModels = await _invoiceService.GetAllArticles();
            CboArticle.ValueMember = "codArticle";
            CboArticle.DisplayMember = "descriptionArticle";
            CboArticle.DataSource = _articleModels;
            CboArticle.SelectedIndex = -1;
            CboArticle.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private bool Validated()
        {
            if (CboCustomer.SelectedIndex == -1)
            {
                MessageBox.Show("You must choose a customer.", "\nAtention!", MessageBoxButtons.OK);
                CboCustomer.Focus();
                return false;
            }
            if (CboArticle.SelectedIndex == -1)
            {
                MessageBox.Show("You must choose an article.", "\nAtention!", MessageBoxButtons.OK);
                CboCustomer.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(TxtUnitPrice.Text) || !double.TryParse(TxtUnitPrice.Text, out _))
            {
                MessageBox.Show("You must choose an article.", "\nAtention!", MessageBoxButtons.OK);
                CboCustomer.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(TxtAmount.Text) || !int.TryParse(TxtAmount.Text, out _))
            {
                MessageBox.Show("You must choose an article.", "\nAtention!", MessageBoxButtons.OK);
                CboCustomer.Focus();
                return false;
            }

            return true;
        }


        private async void BtnRegistration_Click(object sender, EventArgs e)
        {
            try
            {
                var result = await _invoiceService.InvoiceRegistration(invoice);

                if (result.StatusCode == HttpStatusCode.OK)
                {
                    MessageBox.Show("INVOICE generated successfully", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clean();
                    dataGridView1.Rows.Clear();
                }
                else
                {

                    string errorMessage = $"Error loading Invoice. StatusCode: {result.StatusCode}, Message: {result.Data}";
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                string errorMessage = $"Error gral: {ex.Message}";
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddColumnsToDataGridView()
        {

            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("ArticleDescription", "Article Description");
                dataGridView1.Columns.Add("Amount", "Amount");
                dataGridView1.Columns.Add("UnitPriceInvoice", "Unit Price");
            }
        }


        private async void BtnAdd_Click(object sender, EventArgs e)
        {
            if (Validate())
            {

                ArticleModel selectedArticle = (ArticleModel)CboArticle.SelectedItem;


                InvoiceDetailsModel detail = new InvoiceDetailsModel
                {
                    Article = selectedArticle,
                    Amount = Convert.ToInt32(TxtAmount.Text),
                    UnitPriceInvoice = Convert.ToDouble(TxtUnitPrice.Text)
                };


                if (invoice == null)
                {
                    invoice = new InvoiceModel
                    {
                        Date = dateTimePicker1.Value,
                        Customer = (CustomerModel)CboCustomer.SelectedItem,
                        Seller = (SellerModel)CboSeller.SelectedItem,
                        lDetails = new List<InvoiceDetailsModel>()
                    };
                }


                invoice.lDetails.Add(detail);

                AddColumnsToDataGridView();

                foreach (InvoiceDetailsModel invoiceDetail in invoice.lDetails)
                {
                    dataGridView1.Rows.Add(
                        invoiceDetail.Article.DescriptionArticle,
                        invoiceDetail.Amount,
                        invoiceDetail.UnitPriceInvoice
                    );
                }

                total = 0;
                foreach (InvoiceDetailsModel invoiceDetail in invoice.lDetails)
                {
                    total += (int)(invoiceDetail.Amount * invoiceDetail.UnitPriceInvoice);
                }

                LblTotally.Text ="Totally :"+ total.ToString();
            }
        }

    }
}
