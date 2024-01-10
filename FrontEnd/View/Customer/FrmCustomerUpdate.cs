﻿using FrontEnd.Factory.Interface;
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

namespace FrontEnd.View.Customer
{
    public partial class FrmCustomerUpdate : Form
    {
        IFactoryService factoryService;
        CustomerModel customer;
        ICustomerService _customerService;
        private List<NeighborhoodModel> neighborhoodLst;

        public FrmCustomerUpdate(IFactoryService factoryService, CustomerModel cliente)
        {
            InitializeComponent();
            this.factoryService = factoryService;
            this.customer = cliente;
            _customerService = factoryService.GetCustomerService();
           
            
        }

        private async Task LoadDataAsync()
        {
            try
            {
                loadFields();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error en LoadDataAsync: {ex.Message}\nStackTrace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void loadFields()
        {
            try
            {
                // Cargar campos del cliente
                txtname.Text = customer.NameCustomer;
                TxtLastName.Text = customer.LastNameCustomer;
                txtStreet.Text = customer.StreetCustomer;
                TxtStreetNumber.Text = customer.StreetNumberCustomer.ToString();
                txtEmail.Text = customer.MailCustomer;
                txtTelephone.Text = customer.TelCustomer.ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en loadFields: {ex.Message}\nStackTrace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private async void FrmCustomerUpdate_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();
            await LoadComboAsync(customer);
        }

        private async Task LoadComboAsync(CustomerModel customer)
        {
            try
            {
                neighborhoodLst = await _customerService.GetNeighborhoodAsync();

                cboNeighborhood.ValueMember = "codNeighborHood";
                cboNeighborhood.DisplayMember = "nameNeighborhood";

                // Configurar la lista de barrios
                cboNeighborhood.DataSource = neighborhoodLst;
                cboNeighborhood.DropDownStyle = ComboBoxStyle.DropDownList;

                // Obtener el código del barrio del cliente
                int customerNeighborhoodCode = customer.Neighborhood.CodNeighborHood;

                // Configurar el índice del ComboBox basado en el código del barrio del cliente
                cboNeighborhood.SelectedIndex = customerNeighborhoodCode - 1;

                // Asegurarse de que el índice no sea negativo
                if (cboNeighborhood.SelectedIndex < 0)
                {
                    cboNeighborhood.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en LoadComboAsync: {ex.Message}\nStackTrace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }







        private void GpbCustomer_Enter(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private  void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (Validated())
            {

            }
        }

        private bool Validated()
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
        
    }
}
