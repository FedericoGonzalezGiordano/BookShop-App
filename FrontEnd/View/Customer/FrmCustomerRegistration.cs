using FrontEnd.Factory.Interface;
using FrontEnd.Service.Interface;

namespace FrontEnd
{
    public partial class FrmCustomerRegistration : Form
    {
        IFactoryService factory;
        ICustomerService _customerService;
        public FrmCustomerRegistration(IFactoryService factory)
        {
            InitializeComponent();
            this.factory = factory;
            _customerService = factory.CreateClienteService();
        }

        private void FrmCustomerRegistration_Load(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (Validate())
            {

            }
        }

        private bool Validate()
        {
            if (string.IsNullOrEmpty(txtname.Text))
            {
                MessageBox.Show("You must enter a name...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtname.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(TxtLastName.Text))
            {
                MessageBox.Show("You must enter a lastname...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtLastName.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtStreet.Text))
            {
                MessageBox.Show("You must enter a street...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtStreet.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(TxtStreetNumber.Text) || !int.TryParse(TxtStreetNumber.Text, out _))
            {
                MessageBox.Show("You must enter a street number..", "Add", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtStreetNumber.Focus();
                return false;
            }
            if (cboNeighborhood.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a neighborhood...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboNeighborhood.Focus();
                return false;

            }
            if (string.IsNullOrEmpty(txtTelefono.Text) || !int.TryParse(txtTelefono.Text, out _))
            {
                MessageBox.Show("You must enter a telephone number..", "Add", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTelefono.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("You must enter a Email...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEmail.Focus();
                return false;
            }

            return true;
        }
    }
}