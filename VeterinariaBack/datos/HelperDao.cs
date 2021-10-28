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

        public bool Consulta_Login_Sql(string procedure, Usuario oUsario)
        {

            SqlConnection cnn = new SqlConnection(connectionString);
            int exito = 0;
            bool flagSalida = false;

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

        public DataTable Consulta_Tipo_Mascota_XID_Sql(string procedure, int id_tipo_mascota)
        {

            SqlConnection cnn = new SqlConnection(connectionString);
            DataTable table = new DataTable();

            TipoMascota tm = new TipoMascota();
            tm.IdTipoMascota = id_tipo_mascota;

            try
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand(procedure, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_tipo", tm.IdTipoMascota);

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

        public TipoMascota Guardar_Tipo_Mascota_Sql(string procedure, string descripcion) {

            SqlConnection cnn = new SqlConnection(connectionString);
            int id_exito = 0;

            TipoMascota tm = new TipoMascota();
            tm.Nombre = descripcion;

            try
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand(procedure, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@descrip", tm.Nombre);

                SqlParameter param = new SqlParameter("@id_exito", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);

                cmd.ExecuteNonQuery();

                id_exito = Convert.ToInt32(param.Value);
                tm.IdTipoMascota = id_exito;

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

            //retorna objeto tipo mascota con el id generado en la bd por la nueva insercion
            return tm;
        }

        public bool Eliminar_Tipo_Mascota_Sql(string procedure, TipoMascota oTm)
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            int exito = 0;
            bool flagSalida = false;

            TipoMascota tm = new TipoMascota();
            tm.IdTipoMascota = oTm.IdTipoMascota;

            try
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand(procedure, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_tipo_mascota", tm.IdTipoMascota);

                exito = cmd.ExecuteNonQuery();

                if (exito == 1)
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

            //retorna si fue exitosa o no la operacion
            return flagSalida;
        }

        public bool Editar_Tipo_Mascota_Sql(string procedure, TipoMascota oTm)
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            int exito = 0;
            bool flagSalida = false;

            TipoMascota tm = new TipoMascota();
            tm.IdTipoMascota = oTm.IdTipoMascota;
            tm.Nombre = oTm.Nombre;

            try
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand(procedure, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_tipo_mascota", tm.IdTipoMascota);
                cmd.Parameters.AddWithValue("@descripcion", tm.Nombre);

                exito = cmd.ExecuteNonQuery();

                if (exito == 1)
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

            //retorna si fue exitosa o no la operacion
            return flagSalida;
        }

        public DataTable Consulta_Clientes_Sql(string procedure, string nombre)
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            DataTable table = new DataTable();

            Cliente oCliente = new Cliente();
            oCliente.Nombre = nombre;

            try
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand(procedure, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombre", oCliente.Nombre);

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

        public DataTable Consulta_Mascotas_Sql(string procedure, int id_cliente)
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            DataTable table = new DataTable();

            Cliente clt = new Cliente();
            clt.Codigo = id_cliente;

            try
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand(procedure, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_cliente", clt.Codigo);

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
