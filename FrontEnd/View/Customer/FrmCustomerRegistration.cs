using FrontEnd.Factory.Interface;
using FrontEnd.Service.Interface;

namespace FrontEnd
{
    public partial class FrmCustomerRegistration : Form
    {
        IFactoryService factory;
        ICustomerService _customerService;
        private List<NeighborhoodModel> neighborhoodLst;
        public FrmCustomerRegistration(IFactoryService factory)
        {
            this.factory = factory;
            _customerService = factory.CreateClienteService();
            InitializeComponent();
            

        }

        private void FrmCustomerRegistration_Load(object sender, EventArgs e)
        {
            LoadComboAsync();
        }

        private async void LoadComboAsync()
        {
            neighborhoodLst = await _customerService.GetNeighborhoodAsync();
            cboNeighborhood.ValueMember = "codNeighborHood";
            cboNeighborhood.DisplayMember = "nameNeighborhood";
            cboNeighborhood.DataSource = neighborhoodLst;
        }

        private async void  btnLoad_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                CustomerModel customer = new CustomerModel();
                customer.NameCustomer = txtname.Text;
                customer.LastNameCustomer = TxtLastName.Text;
                customer.StreetCustomer = txtStreet.Text;
                customer.StreetNumberCustomer = Convert.ToInt32(TxtStreetNumber.Text);
                customer.Neighborhood= (NeighborhoodModel)cboNeighborhood.SelectedItem;
                customer.TelCustomer = Convert.ToInt32(txtTelephone.Text);
                customer.MailCustomer=txtEmail.Text;
                var result = await _customerService.CustomerRegistration(customer);
                if (result.SuccessStatus)
                {
                    MessageBox.Show("Customer successfully generated", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtLastName.Text = string.Empty;
                    txtname.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                    txtStreet.Text = string.Empty;
                    TxtStreetNumber.Text = string.Empty;
                    txtTelephone.Text = string.Empty;
                    cboNeighborhood.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Error loading client: " + result.Data, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            if (string.IsNullOrEmpty(txtTelephone.Text) || !int.TryParse(txtTelephone.Text, out _))
            {
                MessageBox.Show("You must enter a telephone number..", "Add", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTelephone.Focus();
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