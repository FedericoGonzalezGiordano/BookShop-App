using FrontEnd.Factory.Interface;
using FrontEnd.Service.Interface;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class FrmCustomerRegistration : Form
    {
        IFactoryService factory;
        ICustomerService _customerService;
        private List<NeighborhoodModel> neighborhoodLst;
        private List<CustomerModel> lst = new List<CustomerModel>();
        public FrmCustomerRegistration(IFactoryService factory)
        {
            this.factory = factory;
            _customerService = factory.CreateClienteService();
            InitializeComponent();
            
        }

        private void FrmCustomerRegistration_Load(object sender, EventArgs e)
        {
            DgvCustomer.ReadOnly = true;
            Clean();
            LoadComboAsync();
        }

        private void Clean()
        {
            foreach (Control control in GpbCustomer.Controls)
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
            neighborhoodLst = await _customerService.GetNeighborhoodAsync();
            cboNeighborhood.ValueMember = "codNeighborHood";
            cboNeighborhood.DisplayMember = "nameNeighborhood";
            cboNeighborhood.DataSource = neighborhoodLst;
            cboNeighborhood.SelectedIndex = -1;
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            if (lst.Count > 0)
            {
                foreach (CustomerModel customer in lst)
                {
                    var result = await _customerService.CustomerRegistration(customer);

                    if (!result.SuccessStatus)
                    {
                        MessageBox.Show("Error loading client: " + result.Data, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                Clean();

                MessageBox.Show("Customers successfully loaded", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lst.Clear();  // Limpiar la lista después de cargar los clientes en la base de datos
                DgvCustomer.Rows.Clear();
                DgvCustomer.Refresh();
            }
            else
            {
                MessageBox.Show("No customers to load", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (string.IsNullOrEmpty(txtStreet.Text) || !txtStreet.Text.All(char.IsLetter))
            {
                MessageBox.Show("You must enter a valid street name with only letters.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtStreet.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(TxtStreetNumber.Text) || !TxtStreetNumber.Text.All(char.IsDigit))
            {
                MessageBox.Show("You must enter a valid street number with only numbers.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtStreet.Focus();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lst.Clear();  // Limpiar la lista de clientes
            Clean();
            DgvCustomer.Rows.Clear();
            DgvCustomer.Refresh();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtStreet_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboNeighborhood_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
        }

        private void AddColumnsToDataGridView()
        {
            if (DgvCustomer.Columns.Count == 0)
            {
                DgvCustomer.Columns.Add("NameCustomer", "First Name");
                DgvCustomer.Columns.Add("LastNameCustomer", "Last Name");
                DgvCustomer.Columns.Add("StreetCustomer", "Street");
                DgvCustomer.Columns.Add("StreetNumberCustomer", "Street Number");
                DgvCustomer.Columns.Add("NeighborhoodName", "Neighborhood");
                DgvCustomer.Columns.Add("TelCustomer", "Phone");
                DgvCustomer.Columns.Add("MailCustomer", "Email");
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                CustomerModel customer = new CustomerModel
                {
                    NameCustomer = txtname.Text,
                    LastNameCustomer = TxtLastName.Text,
                    StreetCustomer = txtStreet.Text,
                    StreetNumberCustomer = int.Parse(TxtStreetNumber.Text),
                    Neighborhood = (NeighborhoodModel)cboNeighborhood.SelectedItem,
                    TelCustomer = int.Parse(txtTelephone.Text),
                    MailCustomer = txtEmail.Text
                };

                lst.Add(customer);

                AddColumnsToDataGridView();

                DgvCustomer.Rows.Add(
                    customer.NameCustomer,
                    customer.LastNameCustomer,
                    customer.StreetCustomer,
                    customer.StreetNumberCustomer,
                    customer.Neighborhood.NameNeighborhood,
                    customer.TelCustomer,
                    customer.MailCustomer
                );

                Clean();

            }
        }




        private void DgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}