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

namespace FrontEnd.View.Login
{
    public partial class FrmLogin : Form
    {
        IFactoryService factory;
        ILoginService loginService;
        private List<SellerModel> lstSellers;
        public FrmLogin(IFactoryService factory)
        {
            this.factory = factory;
            loginService = factory.CreateLoginService();
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            LoadComboAsync();
        }

        private async void LoadComboAsync()
        {
            lstSellers = await loginService.GetSellerAsync();
            cboSeller.ValueMember = "IdSeller";
            cboSeller.DisplayMember = "NameSeller";
            cboSeller.DataSource = lstSellers;
        }
    }
}
