using FrontEnd.HTTPClient;
using FrontEnd.Service.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FrontEnd.Service.Implementation
{
    public class CustomerService : ICustomerService
    {
        private const string host = "https://localhost:7101";
        public async Task<HttpResponse> CustomerRegistration(CustomerModel customer)
        {
            string url = host + "/PostCustomer";
            var cuerpo = JsonConvert.SerializeObject(customer);
            var response = await ClientSingleton.GetInstance().PostAsync(url, cuerpo);
            return response;
        }

        public  async Task<List<NeighborhoodModel>> GetNeighborhoodAsync()
        {
            string url = host + "/GetNeighborhood";
            List<NeighborhoodModel> result = new List<NeighborhoodModel>();
            var response = await ClientSingleton.GetInstance().GetAsync(url);
            if (response != null && response.SuccessStatus)
            {
                result = JsonConvert.DeserializeObject<List<NeighborhoodModel>>(response.Data);
            }
            return result;
        }
        public async Task<List<CustomerModel>> GetCustomerAsync(string name, string lastName)
        {
            try
            {
                string url = host + $"/GetCustomer?name={name}&lastName={lastName}";
                List<CustomerModel> result = new List<CustomerModel>();
                var response = await ClientSingleton.GetInstance().GetAsync(url);

                if (response != null && response.SuccessStatus)
                {
                    result = JsonConvert.DeserializeObject<List<CustomerModel>>(response.Data);
                }
                else
                {
                   
                    MessageBox.Show("Error retrieving customer data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return result;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<CustomerModel>();
            }
        }

        

        public async Task<HttpResponse> CustomerTermination(int id)
        {
            string url = host + $"/DeleteCustomer?id={id}";


            var response = await ClientSingleton.GetInstance().DeleteAsync(url);


            return response;
        }
    }
}
