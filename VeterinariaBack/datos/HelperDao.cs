using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaBack.datos
{
    class HelperDao
    {
        private static HelperDao instancia;
        private string connectionString;

        private HelperDao()
        {
            connectionString = @"Data Source=DESKTOP-40GJNU6\SQLEXPRESS;Initial Catalog=VETERINARIA;Integrated Security=True";
            //connectionString = Properties.Resources.stringConecction;
        }

        public static HelperDao GetInstance()
        {
            if (instancia == null)
            {
                instancia = new HelperDao();
            }
            return instancia;
        }

        public DataTable Consulta_Tipo_Mascota_Sql(string procedure)
        {

            SqlConnection cnn = new SqlConnection(connectionString);
            DataTable table = new DataTable();
            try
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand(procedure, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                table.Load(cmd.ExecuteReader());

            }
            catch (SqlException ex)
            {
                string mensaje = ex.Message;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return table;
        }
    }
}
