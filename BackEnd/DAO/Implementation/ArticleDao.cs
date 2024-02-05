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
                SqlCommand cmd = new SqlCommand("sp_insert_articles", conn, transaction);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@description", article.DescriptionArticle);
                cmd.Parameters.AddWithValue("@stockmin", article.StockMinArticle);
                cmd.Parameters.AddWithValue("@stock", article.StockArticle);
                cmd.Parameters.AddWithValue("@preUnit", article.PriceUnitArticle);
                cmd.Parameters.AddWithValue("@obser", article.ObservationArticle);
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
                DataTable table = HelperDao.GetInstance().GetConsultParameter("SP_BUSCAR_ARTICULOO", parameter);
                
                foreach (DataRow row in table.Rows)
                {
                    ArticleModel article = new ArticleModel
                    {
                        CodArticle = IsDBNull(row[0]) ? 0 : Convert.ToInt32(row[0]),
                        DescriptionArticle = IsDBNull(row[1]) ? string.Empty : Convert.ToString(row[1]),
                        StockMinArticle = IsDBNull(row[2]) ? 0 : Convert.ToInt16(row[2]),
                        StockArticle = IsDBNull(row[3]) ? 0 : Convert.ToInt16(row[3]),
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

        public bool ArticleTermination(int id)
        {
            SqlConnection conn = null;
            SqlTransaction t=null;
            bool resultado = true;
            try
            {
                conn = HelperDao.GetInstance().GetConnection();
                conn.Open();
                t=conn.BeginTransaction();
                SqlCommand sqlCommand = new SqlCommand("SP_ELIMINAR_ARTICULO", conn, t);
                sqlCommand.CommandType=CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@cod", id);
                sqlCommand.ExecuteNonQuery();
                t.Commit();
            }
            catch (Exception)
            {
                if (t!=null)
                {
                    t.Rollback();
                    resultado=false;
                }
            }
            finally
            {
                if(conn!=null && conn.State == ConnectionState.Open)
                {
                    conn.Close();   
                }
            }
            return resultado;
        }

        public ArticleModel GetArticlesById(int id)
        {
            SqlConnection connection = HelperDao.GetInstance().GetConnection();
            SqlCommand command = null;
            ArticleModel article = null;

            try
            {
                connection.Open();
                command = new SqlCommand("SP_GET_ARTICLES_BY_ID", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@cod", id);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Console.WriteLine("Reading customer data from database...");

                        article = new ArticleModel
                        {
                            CodArticle = reader.GetInt32(0),
                            DescriptionArticle = reader.GetString(1),
                            StockMinArticle = reader.GetInt16(2),
                            StockArticle = reader.GetInt16(3),
                            PriceUnitArticle = Convert.ToDouble(reader.GetValue(4)), 
                            ObservationArticle = reader.GetString(5)
                        };

                        Console.WriteLine("Article data read successfully.");
                    }
                    else
                    {
                        Console.WriteLine("No data found for the specified article ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"GetArticleById failed: {ex.Message}");
                Console.WriteLine($"Exception Type: {ex.GetType().FullName}");
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

            return article;
        }

        public bool ArticleUpdate(ArticleModel article)
        {
            SqlConnection connection = HelperDao.GetInstance().GetConnection();
            SqlTransaction t = null;
            bool result = true;

            try
            {
                connection = HelperDao.GetInstance().GetConnection();
                connection.Open();
                t = connection.BeginTransaction();

                SqlCommand command = new SqlCommand("SP_MODIFCAR_ARTICULO", connection, t);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@cod", article.CodArticle);
                command.Parameters.AddWithValue("@descripcion", article.DescriptionArticle);
                command.Parameters.AddWithValue("@stockMin", article.StockMinArticle);
                command.Parameters.AddWithValue("@stock", article.StockArticle);
                command.Parameters.AddWithValue("@preUnit", article.PriceUnitArticle);
                command.Parameters.AddWithValue("@observacion", article.ObservationArticle);
               
                command.ExecuteNonQuery();
                t.Commit();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during article update: {ex.Message}");

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
    }
}

