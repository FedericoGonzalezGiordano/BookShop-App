using BackEnd.DAO.Helper;
using BackEnd.DAO.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.DAO.Implementation
{
    public class InvoiceDao : IInvoiceDao
    {
        public List<ArticleModel> GetArticlesList()
        {
            List<ArticleModel> lstArticle = new List<ArticleModel>();
            try
            {
                DataTable table = HelperDao.GetInstance().GetConsult("SP_OBTENER_ARTICULOS", CommandType.StoredProcedure);
                foreach (DataRow row in table.Rows)
                {
                    ArticleModel article = new ArticleModel
                    {
                        CodArticle = Convert.ToInt32(row["cod_articulo"]),
                        DescriptionArticle = row["descripcion"].ToString(),
                        StockMinArticle = row["stock_minimo"] != DBNull.Value ? Convert.ToInt32(row["stock_minimo"]) : 0,
                        StockArticle = Convert.ToInt32(row["stock"]),
                        PriceUnitArticle = Convert.ToDouble(row["pre_unitario"]),
                        ObservationArticle = row["observaciones"] != DBNull.Value ? row["observaciones"].ToString() : null
                    };

                    lstArticle.Add(article);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetArticlesList: {ex.Message}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
            }

            return lstArticle;
        }

        public List<CustomerModel> GetCustomerList()
        {
            List<CustomerModel> lstCustomer = new List<CustomerModel>();
            try
            {
                DataTable table = HelperDao.GetInstance().GetConsult("SP_OBTENER_CLIENTES", CommandType.StoredProcedure);
                foreach (DataRow row in table.Rows)
                {
                    CustomerModel customer = new CustomerModel
                    {
                        CodCustomer = Convert.ToInt32(row["cod_cliente"]),
                        NameCustomer = row["nom_cliente"].ToString(),
                        LastNameCustomer = row["ape_cliente"].ToString(),
                        StreetCustomer = row["calle"].ToString(),
                        StreetNumberCustomer = Convert.ToInt32(row["altura"]),
                        Neighborhood = new NeighborhoodModel
                        {
                            CodNeighborHood = row["cod_barrio"] != DBNull.Value ? Convert.ToInt32(row["cod_barrio"]) : 0,
                            NameNeighborhood = row["NombreBarrio"] != DBNull.Value ? row["NombreBarrio"].ToString() : null
                        },
                        TelCustomer = row["nro_tel"] != DBNull.Value ? Convert.ToInt32(row["nro_tel"]) : 0,
                        MailCustomer = row["e-mail"] != DBNull.Value ? row["e-mail"].ToString() : null
                  
                    };

                    lstCustomer.Add(customer);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error in GetArticlesList: {ex.Message}");
                Debug.WriteLine($"StackTrace: {ex.StackTrace}");
            }

            return lstCustomer;
        }

        public List<SellerModel> GetSellerList()
        {
            List<SellerModel> lstSeller = new List<SellerModel>();
            try
            {
                DataTable table = HelperDao.GetInstance().GetConsult("Sp_Obtener_Vendedores", CommandType.StoredProcedure);
                foreach (DataRow row in table.Rows)
                {
                    SellerModel seller = new SellerModel
                    {
                        IdSeller = Convert.ToInt32(row["cod_vendedor"]),
                        NameSeller = row["nom_vendedor"].ToString(),
                        LastNameSeller = row["ape_vendedor"].ToString(),
                        StreetSeller = row["calle"].ToString(),
                        StreetNumberSeller = Convert.ToInt32(row["altura"]),
                        Neighborhood = new NeighborhoodModel
                        {
                            CodNeighborHood = row["cod_barrio"] != DBNull.Value ? Convert.ToInt32(row["cod_barrio"]) : 0,
                            NameNeighborhood = row["NombreBarrio"] != DBNull.Value ? row["NombreBarrio"].ToString() : null
                        },
                        NumberTelephoneSeller = row["nro_tel"] != DBNull.Value ? Convert.ToInt32(row["nro_tel"]) : 0,
                        MailSeller = row["e-mail"].ToString(),
                        BirthdaySeller = DateTime.TryParse(row["fec_nac"].ToString(), out DateTime birthdateSeller) ? birthdateSeller : DateTime.MinValue,
                        PasswordSeller = row["contrasenia"].ToString()
                    };

                    lstSeller.Add(seller);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetSellerList: {ex.Message}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
            }

            return lstSeller;
        }
      
        public bool InvoiceRegistration(InvoiceModel invoice)
        {
			SqlConnection conn = HelperDao.GetInstance().GetConnection();
			SqlTransaction t= null;
			bool resultado = true;
			try
			{
				conn.Open();
				t = conn.BeginTransaction();
				SqlCommand cmd = new SqlCommand("INSERTAR_FACTURA", conn, t);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@Fecha", invoice.Date);
				cmd.Parameters.AddWithValue("@CodCliente", invoice.CustomerCode.CodCustomer);
                cmd.Parameters.AddWithValue("@CodVendedor", invoice.SellerCode.IdSeller);
                SqlParameter paramOut = new SqlParameter();
                paramOut.ParameterName = "@NroFactura";
                paramOut.DbType = DbType.Int32;
                paramOut.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(paramOut);
                cmd.ExecuteNonQuery();

                int invoiceNro = (int)paramOut.Value;
               

                SqlCommand cmdDetalle;
                foreach (InvoiceDetailsModel detail in invoice.lDetails)
                {
                    cmdDetalle = new SqlCommand("INSERTAR_DETALLE_FACTURA", conn, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@NroFactura", invoiceNro);
                    cmdDetalle.Parameters.AddWithValue("@CodArticulo", detail.ArticleCode.CodArticle);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", detail.Amount);
                    cmdDetalle.Parameters.AddWithValue("@monto", detail.UnitPriceInvoice);
                    cmdDetalle.ExecuteNonQuery();
                }


            }
            catch (Exception)
			{
				if(t != null )
				{
					t.Rollback();
					resultado= false;
				}
			}
			finally
			{
                if (conn != null && conn.State == ConnectionState.Open)
                    conn.Close();
            }
			return resultado;
        }
    }
}
