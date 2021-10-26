using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaBack.dominio;

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

        public bool Consulta_Login_Sql(string procedure, string usr, string pass)
        {

            SqlConnection cnn = new SqlConnection(connectionString);
            int exito = 0;
            bool flagSalida = false;

            Usuario oUsario = new Usuario(usr, pass);

            try
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand(procedure, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@user", oUsario.User);
                cmd.Parameters.AddWithValue("@pass", oUsario.Password);

                SqlParameter param = new SqlParameter("@existe", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);

                cmd.ExecuteNonQuery();

                exito = Convert.ToInt32(param.Value);

                //exito cuando es 1
                if(exito == 1)
                    flagSalida = true;

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

            return flagSalida;
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
