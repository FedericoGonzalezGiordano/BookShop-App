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

namespace FrontEnd.View.Customer
{
    public partial class FrmCustomerWatch : Form
    {
        IFactoryService factory;
        ICustomerService customerService;

        public FrmCustomerWatch(IFactoryService factory)
        {
            this.factory = factory;
            customerService = factory.GetCustomerService();
            InitializeComponent();
            
        }



        private void FrmCustomerWatch_Load(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (Validated())
            {

            }
        }

        private bool Validated()
        {
            if (string.IsNullOrEmpty(TxtName.Text))
            {
                MessageBox.Show("You must enter a name...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtName.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(TxtLastName.Text))
            {
                MessageBox.Show("You must enter a  Last name...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtLastName.Focus();
                return false;
            }
            return true;

        }

        private void gpbCustomerSearch_Enter(object sender, EventArgs e)
        {

        }
    }
}
