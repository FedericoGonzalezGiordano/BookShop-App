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

        public List<ArticleModel> GetArticles(string nameArticle)
        {
            List<ArticleModel>lstArticles = new List<ArticleModel> ();
            Parameter parameter=new Parameter("@descripcion",nameArticle);
          
            try
            {
                DataTable table = HelperDao.GetInstance().GetConsultParameter("SP_BUSCAR_ARTICULO", parameter);
                
                foreach (DataRow row in table.Rows)
                {
                    ArticleModel article = new ArticleModel
                    {
                        CodArticle = IsDBNull(row[0]) ? 0 : Convert.ToInt32(row[0]),
                        DescriptionArticle = IsDBNull(row[1]) ? string.Empty : Convert.ToString(row[1]),
                        StockMinArticle = IsDBNull(row[2]) ? 0 : Convert.ToInt32(row[2]),
                        StockArticle = IsDBNull(row[3]) ? 0 : Convert.ToInt32(row[3]),
                        PriceUnitArticle = IsDBNull(row[4]) ? 0 : Convert.ToDouble(row[4]),
                        ObservationArticle = IsDBNull(row[5]) ? string.Empty : Convert.ToString(row[5])
                    };
                    lstArticles.Add(article);
                }
      
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred in GetCustomer: {ex.Message}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
                throw;

            }
            return lstArticles;
        }



        static bool IsDBNull(object value)
        {
            return value == DBNull.Value || value == null;
        }

    }
}

