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
            ConfigureDataGridView();
        }

        private void ConfigureDataGridView()
        {
            DgvCustomerWatch.AutoGenerateColumns = false;


            DgvCustomerWatch.Columns.Add("CodCustomer", "Code");
            DgvCustomerWatch.Columns.Add("NameCustomer", "Name");
            DgvCustomerWatch.Columns.Add("LastNameCustomer", "Last Name");
            DgvCustomerWatch.Columns.Add("StreetCustomer", "Street");
            DgvCustomerWatch.Columns.Add("StreetNumberCustomer", "Number");
            DgvCustomerWatch.Columns.Add("NeighborhoodName", "Neighborhood");
            DgvCustomerWatch.Columns.Add("TelCustomer", "Phone");
            DgvCustomerWatch.Columns.Add("MailCustomer", "Email");


            DgvCustomerWatch.Columns["CodCustomer"].DataPropertyName = "CodCustomer";
            DgvCustomerWatch.Columns["NameCustomer"].DataPropertyName = "NameCustomer";
            DgvCustomerWatch.Columns["LastNameCustomer"].DataPropertyName = "LastNameCustomer";
            DgvCustomerWatch.Columns["StreetCustomer"].DataPropertyName = "StreetCustomer";
            DgvCustomerWatch.Columns["StreetNumberCustomer"].DataPropertyName = "StreetNumberCustomer";
            DgvCustomerWatch.Columns["NeighborhoodName"].DataPropertyName = "Neighborhood.NameNeighborhood";
            DgvCustomerWatch.Columns["TelCustomer"].DataPropertyName = "TelCustomer";
            DgvCustomerWatch.Columns["MailCustomer"].DataPropertyName = "MailCustomer";
        }

        private void FrmCustomerWatch_Load(object sender, EventArgs e)
        {
            DgvCustomerWatch.ReadOnly = true;
        }

        private async void BtnSearch_Click(object sender, EventArgs e)
        {
            if (Validated())
            {
                try
                {
                    string name = TxtName.Text;
                    string lastName = TxtLastName.Text;
                    List<CustomerModel> customers = await customerService.GetCustomerAsync(name, lastName);
                    DgvCustomerWatch.Rows.Clear();

                    if (customers.Count > 0)
                    {
                        foreach (CustomerModel c in customers)
                        {
                            DgvCustomerWatch.Rows.Add(
                                c.CodCustomer,
                                c.NameCustomer ?? string.Empty,
                                c.LastNameCustomer ?? string.Empty,
                                c.StreetCustomer ?? string.Empty,
                                c.StreetNumberCustomer,
                                c.Neighborhood != null ? c.Neighborhood.NameNeighborhood : string.Empty,
                                c.TelCustomer,
                                c.MailCustomer ?? string.Empty

                            );
                        }
                        DgvCustomerWatch.ClearSelection();
                    }
                    else
                    {
                        MessageBox.Show("No customers were found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                    MessageBox.Show($"Exception Details: {ex.ToString()}");
                    MessageBox.Show("An error occurred while searching for customers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void LblLastName_Click(object sender, EventArgs e)
        {

        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            if (DgvCustomerWatch.SelectedRows.Count > 0)
            {
                DataGridViewRow row = DgvCustomerWatch.SelectedRows[0];
                int idCliente = Convert.ToInt32(row.Cells[0].Value);

                MessageBox.Show($"Before CustomerTermination: {idCliente}");

                try
                {
                    var result = await customerService.CustomerTermination(idCliente);
                    MessageBox.Show("Customer deleted with ID: " + idCliente);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                    MessageBox.Show("Error deleting customer. Details: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No selected rows in DataGridView");
                MessageBox.Show("Select a customer before deleting.");
            }
        }



    }


}


