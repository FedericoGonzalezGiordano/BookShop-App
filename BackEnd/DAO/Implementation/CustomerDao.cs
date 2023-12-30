using BackEnd.DAO.Helper;
using BackEnd.DAO.Interface;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.DAO.Implementation
{
    public class CustomerDao : ICustomerDao
    {
        public bool CustomerRegistration(CustomerModel customer)
        {
            bool result = true;
            SqlConnection connection = HelperDao.GetInstance().GetConnection();
            SqlTransaction transaction = null;
            try
            {
                connection.Open();
                transaction = connection.BeginTransaction();
                SqlCommand command = new SqlCommand("SP_INSERTAR_CLIENTE", connection, transaction);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@nombre", customer.NameCustomer);
                command.Parameters.AddWithValue("@apellido", customer.LastNameCustomer);
                command.Parameters.AddWithValue("@calle", customer.StreetCustomer);
                command.Parameters.AddWithValue("@altura", customer.StreetNumberCustomer);
                command.Parameters.AddWithValue("@codBarrio", customer.Neighborhood.CodNeighborHood);
                command.Parameters.AddWithValue("@nroTel", customer.TelCustomer);
                command.Parameters.AddWithValue("@mail", customer.MailCustomer);
                command.ExecuteNonQuery();
                transaction.Commit();
                result = true;
            }
            catch (Exception ex)
            {
                if (transaction != null)
                    transaction.Rollback();
                result = false;
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return result;
        }
        public List<NeighborhoodModel> GetNeighborhood()
        {
            List<NeighborhoodModel> lstNeighborhood = new List<NeighborhoodModel>();
            try
            {
                DataTable table = HelperDao.GetInstance().GetConsult("SP_CONSULTAR_BARRIOS", CommandType.StoredProcedure);
                foreach (DataRow row in table.Rows)
                {
                    int idNeighborhood = int.Parse(row["cod_barrio"].ToString());
                    string nameNeighborhood = row["barrio"].ToString();

                    NeighborhoodModel n = new NeighborhoodModel(idNeighborhood, nameNeighborhood);
                    lstNeighborhood.Add(n);
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error en GetNeighborhood", ex);
            }

            return lstNeighborhood;
        }

        //public bool CustomerTermination(string number)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool CustomerUpdate(CustomerModel customer)
        //{
        //    throw new NotImplementedException();
        //}

       
       
    }
    
}
