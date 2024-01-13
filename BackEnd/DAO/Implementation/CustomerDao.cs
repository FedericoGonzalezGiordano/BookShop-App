using BackEnd.DAO.Helper;
using BackEnd.DAO.Interface;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Diagnostics;

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
            catch (Exception )
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

                throw new Exception("GetNeighborhood failed", ex);
            }

            return lstNeighborhood;
        }


        public List<CustomerModel> GetCustomer(string nameCustomer, string lastNameCustomer)
        {
            List<CustomerModel> lstCustomers = new List<CustomerModel>();
            List<Parameter> lstParams = new List<Parameter>();
            lstParams.Add(new Parameter("@name", nameCustomer));
            lstParams.Add(new Parameter("@lastName", lastNameCustomer));

            try
            {
                DataTable table = HelperDao.GetInstance().GetConsultParameters("sp_search_customers", lstParams);

                foreach (DataRow r in table.Rows)
                {
                    CustomerModel customer = new CustomerModel
                    {
                        CodCustomer = IsDBNull(r["cod_cliente"]) ? 0 : Convert.ToInt32(r["cod_cliente"]),
                        NameCustomer = IsDBNull(r["nom_cliente"]) ? string.Empty : r["nom_cliente"].ToString(),
                        LastNameCustomer = IsDBNull(r["ape_cliente"]) ? string.Empty : r["ape_cliente"].ToString(),
                        StreetCustomer = IsDBNull(r["calle"]) ? string.Empty : r["calle"].ToString(),
                        StreetNumberCustomer = IsDBNull(r["altura"]) ? 0 : Convert.ToInt32(r["altura"]),
                        Neighborhood = new NeighborhoodModel
                        {
                            CodNeighborHood = IsDBNull(r["cod_barrio"]) ? 0 : Convert.ToInt32(r["cod_barrio"]),
                            NameNeighborhood = IsDBNull(r["NombreBarrio"]) ? string.Empty : r["NombreBarrio"].ToString()
                        },
                        TelCustomer = IsDBNull(r["nro_tel"]) ? 0 : Convert.ToInt32(r["nro_tel"]),
                        MailCustomer = IsDBNull(r["e-mail"]) ? string.Empty : r["e-mail"].ToString()
                    };

                    lstCustomers.Add(customer);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred in GetCustomer: {ex.Message}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
                throw;
            }

            return lstCustomers;
        }

        static bool IsDBNull(object value)
        {
            return value == DBNull.Value || value == null;
        }

        public bool CustomerTermination(int id)
        {
            SqlConnection connection = null;
            SqlTransaction t = null;
            bool resultado = true;

            try
            {
                connection = HelperDao.GetInstance().GetConnection();
                connection.Open();
                t = connection.BeginTransaction();

                SqlCommand command = new SqlCommand("SP_BORRAR_CLIENTE", connection, t);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@id", id);

                command.ExecuteNonQuery();
                t.Commit();
            }
            catch (SqlException sqlEx)
            {
                if (t != null)
                {
                    t.Rollback();
                }

                Console.WriteLine("SQL Exception: " + sqlEx.Message);
                Console.WriteLine("Error Number: " + sqlEx.Number);

                resultado = false;
            }
            catch (Exception ex)
            {
                if (t != null)
                {
                    t.Rollback();
                }

                Console.WriteLine("Exception: " + ex.Message);

                resultado = false;
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return resultado;
        }

        public bool CustomerUpdate(CustomerModel customer)
        {
            SqlConnection connection = HelperDao.GetInstance().GetConnection();
            SqlTransaction t = null;
            bool result = true;

            try
            {
                connection = HelperDao.GetInstance().GetConnection();
                connection.Open();
                t = connection.BeginTransaction();

                SqlCommand command = new SqlCommand("sp_modify_customer", connection, t);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@cod", customer.CodCustomer);
                command.Parameters.AddWithValue("@nom", customer.NameCustomer);
                command.Parameters.AddWithValue("@ape", customer.LastNameCustomer);
                command.Parameters.AddWithValue("@calle", customer.StreetCustomer);
                command.Parameters.AddWithValue("@altura", customer.StreetNumberCustomer);
                command.Parameters.AddWithValue("@codbarrio", customer.Neighborhood.CodNeighborHood);
                command.Parameters.AddWithValue("@tel", customer.TelCustomer);
                command.Parameters.AddWithValue("@mail", customer.MailCustomer);
                command.ExecuteNonQuery();
                t.Commit();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during customer update: {ex.Message}");

                if (t != null)
                    t.Rollback();
                result = false;
            }
            finally
            {

                if (connection != null && connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return result;
        }

        public CustomerModel GetCustomerById(int idCliente)
        {
            SqlConnection connection = HelperDao.GetInstance().GetConnection();
            SqlCommand command = null;
            CustomerModel customer = null;

            try
            {
                connection.Open();
                command = new SqlCommand("sp_get_customer_by_id", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@cod", idCliente);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Console.WriteLine("Reading customer data from database...");

                        customer = new CustomerModel
                        {
                            CodCustomer = reader["cod_cliente"] as int? ?? 0, 
                            NameCustomer = reader["nom_cliente"] as string,
                            LastNameCustomer = reader["ape_cliente"] as string,
                            StreetCustomer = reader["calle"] as string,
                            StreetNumberCustomer = reader["altura"] as int? ?? 0,
                            Neighborhood = new NeighborhoodModel
                            {
                                CodNeighborHood = reader["cod_barrio"] as int? ?? 0,
                                NameNeighborhood = reader["barrio"] as string ?? string.Empty
                            },
                            TelCustomer = reader["nro_tel"] as long? ?? 0,
                            MailCustomer = reader["e-mail"] as string
                        };

                        Console.WriteLine("Customer data read successfully.");
                    }
                    else
                    {
                        Console.WriteLine("No data found for the specified customer ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en GetCustomerById: {ex.Message}");
                Console.WriteLine($"Tipo de excepción: {ex.GetType().FullName}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
                throw;
            }
            finally
            {
                if (command != null)
                {
                    command.Dispose();
                }

                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return customer;
        }


    }
}



