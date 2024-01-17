using BackEnd.DAO.Helper;
using BackEnd.DAO.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.DAO.Implementation
{
    public class InvoiceDao : IInvoiceDao
    {
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
