using BackEnd.DAO.Helper;
using BackEnd.DAO.Implementation;
using BackEnd.DAO.Interface;
using FrontEnd.Factory.Interface;
using FrontEnd.Service.Implementation;
using FrontEnd.Service.Interface;
using FrontEnd.View.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd.View.Login
{
    public partial class FrmLogin : Form
    {
        IFactoryService factory;
        ILoginService loginService;
      
        
        private List<SellerModel> sellerLst;

        public FrmLogin(IFactoryService factory)
        {
            this.factory = factory;
            loginService = factory.CreateLoginService();
            InitializeComponent();
        }


        private async void FrmLogin_Load(object? sender, EventArgs e)
        {
            LoadComboAsync();
            
        }

        private async void LoadComboAsync()
        {
            sellerLst = await loginService.GetSellerAsync();
            cboSeller.ValueMember = "IdSeller";
            cboSeller.DisplayMember = "CompleteName";
            cboSeller.DataSource = sellerLst;
            cboSeller.SelectedIndex = -1;
            cboSeller.DropDownStyle=ComboBoxStyle.DropDownList;
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (Validated())
            {
                SellerModel selectedSeller = (SellerModel)cboSeller.SelectedItem;
                string pass = TxtPassword.Text;
                if (selectedSeller.PasswordSeller == pass)
                {
                    MessageBox.Show("Correct password", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmMainAlphabetCRUD main = new FrmMainAlphabetCRUD(factory);
                    this.Hide();
                    main.ShowDialog();
                    TxtPassword.Text=string.Empty;
                }
                else
                {
                    MessageBox.Show("Incorrect password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool Validated()
        {
            if (cboSeller.SelectedIndex == -1)
            {
                MessageBox.Show("You must choose a seller", "Attention!", MessageBoxButtons.OK);
                cboSeller.Focus();
                return false;
            }
            string password = TxtPassword.Text.Trim();

            Regex regex = new Regex("^[a-zA-Z0-9]*$"); // Allows any length and also allows blank

            if (!regex.IsMatch(password))
            {
                MessageBox.Show("The password must contain only letters and numbers", "Attention!", MessageBoxButtons.OK);
                TxtPassword.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("The password cannot be blank", "Attention!", MessageBoxButtons.OK);
                TxtPassword.Focus();
                return false;
            }
            if (password.Length != 9)
            {
                MessageBox.Show("The password must be exactly 10 characters long", "Attention!", MessageBoxButtons.OK);
                TxtPassword.Focus();
                return false;
            }
            return true;
        }
    }
}
