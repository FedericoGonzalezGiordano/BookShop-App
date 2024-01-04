using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Intrinsics.X86;
using System.Reflection.Metadata;


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
        public DataTable GetConsultParameters(string nombreSP, List<Parameter> lstParametros)
        {
            DataTable table= new DataTable();   
            Connect();
            SqlCommand comando = new SqlCommand();
            comando.Connection = _connection;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            comando.Parameters.Clear();
            foreach (Parameter p in lstParametros)
            {
                comando.Parameters.AddWithValue(p.Name, p.Value);
            }
            table.Load(comando.ExecuteReader());
            Disconect();
            return table;
        }


    }
}
