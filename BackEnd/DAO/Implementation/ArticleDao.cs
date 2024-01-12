using BackEnd.DAO.Helper;
using BackEnd.DAO.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BackEnd.DAO.Implementation
{
    public class ArticleDao : IArticleDao
    {
 
        public bool ArticleRegistration(ArticleModel article)
        {
            bool result = true;
            SqlConnection conn = HelperDao.GetInstance().GetConnection();
            SqlTransaction transaction = null;

            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                SqlCommand cmd = new SqlCommand("SP_INSERTAR_ARTICULO", conn, transaction);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@descripcion", article.DescriptionArticle);
                cmd.Parameters.AddWithValue("@stockminimo", article.StockMinArticle);
                cmd.Parameters.AddWithValue("@stock", article.StockArticle);
                cmd.Parameters.AddWithValue("@precioUnitario", article.PriceUnitArticle);
                cmd.Parameters.AddWithValue("@observaciones", article.ObservationArticle);
                cmd.ExecuteNonQuery();
                transaction.Commit();
                result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error general: {ex.Message}");
                if (transaction != null)
                    transaction.Rollback();
                result = false;
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                    conn.Close();
            }
            return result;
        }
    }
}
