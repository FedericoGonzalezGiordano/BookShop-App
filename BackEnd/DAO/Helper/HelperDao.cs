using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Intrinsics.X86;


namespace BackEnd.DAO.Helper
{
    public class HelperDao
    {
        private SqlConnection _connection;
        private string stringConexion = "Data Source=.\\SQLEXPRESS;Initial Catalog = LIBRERIA_LCI2023;Integrated Security = True";
        private static HelperDao instance;

        private HelperDao()
        {
            _connection = new SqlConnection(stringConexion);
        }

        public static HelperDao GetInstance()
        {
            if (instance == null)
            {
                instance = new HelperDao();
            }
            return instance;
        }

        public SqlConnection GetConnection()
        {
            return this._connection;
        }

        private void Connect()
        {
            if (_connection.State == ConnectionState.Closed)
                _connection.Open();
        }

        private void Disconect()
        {
            if (_connection.State != ConnectionState.Closed)
                _connection.Close();
        }
        public DataTable GetConsult(string sp, CommandType type)
        {
            Connect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _connection;
            cmd.CommandType = type;
            cmd.CommandText = sp;
            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());
            Disconect();
            return tabla;
        }
        public string IsValidUser(string sp, string selectedName, string selectedLastName, int selectedUserId)
        {
            Connect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _connection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sp;

            // Agregar parámetro para el nombre de usuario
            SqlParameter usernameParam = new SqlParameter("@pName", SqlDbType.VarChar, 10);
            usernameParam.Value = selectedName;
            cmd.Parameters.Add(usernameParam);

            // Agregar parámetro para el apellido de usuario
            SqlParameter userLastNameParam = new SqlParameter("@pApe", SqlDbType.VarChar, 10);
            userLastNameParam.Value = selectedLastName;
            cmd.Parameters.Add(userLastNameParam);

            // Agregar parámetro de salida para la contraseña
            SqlParameter passwordParam = new SqlParameter("@pPassword", SqlDbType.VarChar, 10);
            passwordParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(passwordParam);

            // Agregar parámetro para el código de usuario
            SqlParameter userIdParam = new SqlParameter("@cod", SqlDbType.Int);
            userIdParam.Value = selectedUserId;
            cmd.Parameters.Add(userIdParam);

            cmd.ExecuteNonQuery();
            Disconect();

            // Recuperar el valor de la contraseña del parámetro de salida
            string password = (string)passwordParam.Value;
            return password;
        }
      

    }
}
