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
        public Cliente Consulta_Clientes_X_ID_Sql(string procedure, int id)
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            DataTable table = new DataTable();

            Cliente oCliente = new Cliente();
            oCliente.Codigo = id;

            try
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand(procedure, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", oCliente.Codigo);

                table.Load(cmd.ExecuteReader());

                foreach (DataRow item in table.Rows)
                {
                    oCliente.Nombre = item["nombre"].ToString();
                    oCliente.Sexo = item["sexo"].ToString();
                    break;
                }

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

            return oCliente;
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
        public Atencion Consulta_Ultimo_Id_Atencion(string procedure) {

            Atencion att = new Atencion();
            att.IdAtencion = 0;
            SqlConnection cnn = new SqlConnection(connectionString);

            try
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand(procedure,cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter("@id_atencion", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);

                cmd.ExecuteNonQuery();

                att.IdAtencion = Convert.ToInt32(param.Value);
            }
            catch (SqlException ex)
            {
                string mensaje = ex.Message;
            }
            finally {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return att;
            
        }
        public bool Guardar_Atencion(string procedure, Mascota oMascota) {
            bool flagSalida = false;
            SqlConnection cnn = new SqlConnection(connectionString);
            int exito = 0;
            try
            {
                cnn.Open();

                foreach (Atencion att in oMascota.Atenciones)
                {
                    SqlCommand cmd = new SqlCommand(procedure, cnn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@descrip", att.Descripcion);
                    cmd.Parameters.AddWithValue("@imp", att.Importe);
                    cmd.Parameters.AddWithValue("@id_mascota", oMascota.IdMascota);

                    exito = cmd.ExecuteNonQuery();

                    if (exito == 1)
                        flagSalida = true;

                    break;
                }
            }
            catch (SqlException ex)
            {
                string mensaje = ex.Message;
            }
            finally {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return flagSalida;
        }
        public DataTable Consulta_Atenciones_Sql(string procedure, Mascota oMascota) {
            
            SqlConnection cnn = new SqlConnection(connectionString);
            DataTable table = new DataTable();
            cnn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand(procedure, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_mascota", oMascota.IdMascota);

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
        public bool Editar_Atencion_Sql(string procedure, Atencion oAtencion) {

            bool flagSalida = false;
            int result = 0;
            SqlConnection cnn = new SqlConnection(connectionString);

            cnn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand(procedure, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", oAtencion.IdAtencion);
                cmd.Parameters.AddWithValue("@descripcion", oAtencion.Descripcion);
                cmd.Parameters.AddWithValue("@importe_atencion", oAtencion.Importe);

                result = cmd.ExecuteNonQuery();

                if (result == 1)
                {
                    flagSalida = true;
                }

            }
            catch (SqlException ex)
            {
                string msj = ex.Message;
            }
            finally {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return flagSalida;
        }
        public bool Eliminar_Atencion_Sql(string procedure, Atencion oAtencion) {

            bool flagSalida = false;
            int result = 0;
            SqlConnection cnn = new SqlConnection(connectionString);

            cnn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand(procedure, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", oAtencion.IdAtencion);

                result = cmd.ExecuteNonQuery();

                if (result == 1)
                {
                    flagSalida = true;
                }

            }
            catch (SqlException ex)
            {
                string msj = ex.Message;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return flagSalida;
        }
        public bool Editar_Cliente_Sql(string procedure, Cliente oCliente)
        {
            bool flagSalida = false;
            int result = 0;
            SqlConnection cnn = new SqlConnection(connectionString);

            cnn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand(procedure, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", oCliente.Codigo);
                cmd.Parameters.AddWithValue("@nombre", oCliente.Nombre);
                cmd.Parameters.AddWithValue("@sexo", oCliente.Sexo);

                result = cmd.ExecuteNonQuery();

                if (result == 1)
                {
                    flagSalida = true;
                }

            }
            catch (SqlException ex)
            {
                string msj = ex.Message;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return flagSalida;
        }
        public bool Eliminar_Cliente_Sql(string procedure, Cliente oCliente)
        {
            bool flagSalida = false;
            int result = 0;
            SqlConnection cnn = new SqlConnection(connectionString);

            cnn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand(procedure, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", oCliente.Codigo);

                result = cmd.ExecuteNonQuery();

                if (result == 1)
                {
                    flagSalida = true;
                }

            }
            catch (SqlException ex)
            {
                string msj = ex.Message;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return flagSalida;
        }
        public bool Editar_Mascota_Sql(string procedure, Mascota oMascota)
        {
            bool flagSalida = false;
            int result = 0;
            SqlConnection cnn = new SqlConnection(connectionString);

            cnn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand(procedure, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", oMascota.IdMascota);
                cmd.Parameters.AddWithValue("@nombre", oMascota.Nombre);
                cmd.Parameters.AddWithValue("@edad", oMascota.Edad);
                cmd.Parameters.AddWithValue("@id_tipo_mascota", oMascota.Tipo.IdTipoMascota);

                result = cmd.ExecuteNonQuery();

                if (result == 1)
                {
                    flagSalida = true;
                }

            }
            catch (SqlException ex)
            {
                string msj = ex.Message;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return flagSalida;
        }
        public bool Eliminar_Mascota_Sql(string procedure, Mascota oMascota)
        {
            bool flagSalida = false;
            int result = 0;
            SqlConnection cnn = new SqlConnection(connectionString);

            cnn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand(procedure, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", oMascota.IdMascota);

                result = cmd.ExecuteNonQuery();

                if (result == 1)
                {
                    flagSalida = true;
                }

            }
            catch (SqlException ex)
            {
                string msj = ex.Message;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return flagSalida;
        }
    }
}
