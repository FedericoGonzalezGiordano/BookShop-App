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
            LoadComboAsync();
            //Clean();
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
                    comboBox.SelectedIndex = -1;
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

            // Obtener el código del barrio del cliente
            int sellerCode = seller.IdSeller;

            // Configurar el índice del ComboBox basado en el código del barrio del cliente
            CboSeller.SelectedIndex = sellerCode - 1;

            // Asegurarse de que el índice no sea negativo
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
    }
}
