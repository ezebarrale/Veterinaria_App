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
        }

        public static HelperDao GetInstance()
        {
            if (instancia == null)
            {
                instancia = new HelperDao();
            }
            return instancia;
        }

        public DataTable Consulta_Login_Sql(string procedure, Usuario oUsario)
        {

            SqlConnection cnn = new SqlConnection(connectionString);
            DataTable table = new DataTable();

            try
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand(procedure, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@user", oUsario.User);
                cmd.Parameters.AddWithValue("@pass", oUsario.Password);

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
        public DataTable Consulta_Clientes_Sql(string procedure, Cliente oCliente)
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            DataTable table = new DataTable();

            Cliente clt = new Cliente();
            clt.Nombre = oCliente.Nombre;
            clt.Apellido = oCliente.Apellido;

            try
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand(procedure, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombre", oCliente.Nombre);
                cmd.Parameters.AddWithValue("@apellido", oCliente.Apellido);

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

                foreach (DataRow itm in table.Rows)
                {
                    oCliente.Codigo = Convert.ToInt32(itm["id_cliente"].ToString());
                    oCliente.Nombre = itm["nombre"].ToString();
                    oCliente.Apellido = itm["apellido"].ToString();
                    oCliente.FakeNombre = itm["nombre"].ToString() + " " + itm["apellido"].ToString();
                    oCliente.Contacto = itm["contacto"].ToString();
                    oCliente.Dni = Convert.ToInt32(itm["dni"].ToString());
                    oCliente.Sexo = itm["sexo"].ToString();
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
        public Cliente Consulta_Clientes_X_DNI_Sql(string procedure, Cliente oCliente)
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            DataTable table = new DataTable();

            Cliente clt = new Cliente();

            try
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand(procedure, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dni", oCliente.Dni);

                table.Load(cmd.ExecuteReader());

                foreach (DataRow itm in table.Rows)
                {
                    clt.Codigo = Convert.ToInt32(itm["id_cliente"].ToString());
                    clt.Nombre = itm["nombre"].ToString();
                    clt.Apellido = itm["apellido"].ToString();
                    clt.FakeNombre = itm["nombre"].ToString() + " " + itm["apellido"].ToString();
                    clt.Contacto = itm["contacto"].ToString();
                    clt.Dni = Convert.ToInt32(itm["dni"].ToString());
                    clt.Sexo = itm["sexo"].ToString();
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

            return clt;
        }
        public int Consulta_Siguiente_Id_Cliente_Sql(string procedure)
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            int id = 0;

            try
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand(procedure, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter("@id_cliente", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;

                cmd.Parameters.Add(param);

                cmd.ExecuteNonQuery();

                id = Convert.ToInt32(param.Value);

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

            return id;
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
        public int Consulta_Siguiente_Id_Mascota_Sql(string procedure)
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            int id = 0;

            try
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand(procedure, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter("@id_mascota", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;

                cmd.Parameters.Add(param);

                cmd.ExecuteNonQuery();

                id = Convert.ToInt32(param.Value);

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

            return id;
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
            bool flagMaestro = false;
            bool flagSalida = false;

            SqlConnection cnn = new SqlConnection(connectionString);
            SqlTransaction t = null;

            Atencion oAtencion = new Atencion();

            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                foreach (Atencion att in oMascota.Atenciones)
                {
                    oAtencion = att;

                    SqlCommand cmd = new SqlCommand(procedure, cnn, t);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_veterinario", oAtencion.oVeterinario.Codigo);

                    SqlParameter param = new SqlParameter("@id_atencion", DbType.Int32);
                    param.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(param);

                    cmd.ExecuteNonQuery();

                    oAtencion.IdAtencion = Convert.ToInt32(param.Value);
                    
                    flagMaestro = true;
                }
            }
            catch (SqlException ex)
            {
                string mensaje = ex.Message;
                cnn.Close();
            }

            //INSERTO EL DETALLE

            if (flagMaestro)
            {
                try
                {
                    int idDetalle = 1;

                    foreach (DetalleAtencion detalle in oAtencion.Detalles)
                    {
                        SqlCommand cmd = new SqlCommand("PA_GUARDAR_DETALLE_ATENCION", cnn, t);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id_detalle", idDetalle);
                        cmd.Parameters.AddWithValue("@id_atencion", oAtencion.IdAtencion);
                        cmd.Parameters.AddWithValue("@id_mascota", oMascota.IdMascota);
                        cmd.Parameters.AddWithValue("@descrip", detalle.Descripcion);
                        cmd.Parameters.AddWithValue("@imp", detalle.Importe);

                        cmd.ExecuteNonQuery();

                        idDetalle++;

                    }

                    t.Commit();
                    flagSalida = true;

                }
                catch (Exception ex)
                {
                    t.Rollback();
                    flagSalida = false;
                }
                finally
                {
                    if (cnn != null && cnn.State == ConnectionState.Open)
                        cnn.Close();
                }
            }
            else
            {
                flagSalida = false;
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

                cmd.Parameters.AddWithValue("@id_atencion", oAtencion.IdAtencion);
                cmd.Parameters.AddWithValue("@id_vaterinario", oAtencion.oVeterinario.Codigo);

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

                cmd.Parameters.AddWithValue("@id_atencion", oAtencion.IdAtencion);

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
        public bool Guardar_Cliente_Sql(string procedure, Cliente oCliente)
        {
            bool flagSalida = false;
            int result = 0;
            SqlConnection cnn = new SqlConnection(connectionString);

            cnn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand(procedure, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombre", oCliente.Nombre);
                cmd.Parameters.AddWithValue("@apellido", oCliente.Apellido);
                cmd.Parameters.AddWithValue("@sexo", oCliente.Sexo);
                cmd.Parameters.AddWithValue("@contacto", oCliente.Contacto);
                cmd.Parameters.AddWithValue("@dni", oCliente.Dni);

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
                cmd.Parameters.AddWithValue("@apellido", oCliente.Apellido);
                cmd.Parameters.AddWithValue("@sexo", oCliente.Sexo);
                cmd.Parameters.AddWithValue("@contacto", oCliente.Contacto);
                cmd.Parameters.AddWithValue("@dni", oCliente.Dni);

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
        public bool Guardar_Mascota_Sql(string procedure, Cliente oCliente)
        {
            bool flagSalida = false;
            int result = 0;
            SqlConnection cnn = new SqlConnection(connectionString);

            cnn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand(procedure, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_cliente", oCliente.Codigo);
                foreach (Mascota msct in oCliente.Mascotas)
                {
                    cmd.Parameters.AddWithValue("@nombre", msct.Nombre);
                    cmd.Parameters.AddWithValue("@sexo", msct.Sexo);
                    cmd.Parameters.AddWithValue("@edad", msct.Edad);
                    cmd.Parameters.AddWithValue("@id_tipo_mascota", msct.Tipo.IdTipoMascota);
                    break;
                }

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
                cmd.Parameters.AddWithValue("@sexo", oMascota.Sexo);
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
        public DataTable Consulta_Veterinarios_Sql(string procedure)
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            DataTable table = new DataTable();
            cnn.Open();

            try
            {
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
        public DataTable Consulta_Detalles_Atencion_Sql(string procedure, Atencion oAtencion)
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            DataTable table = new DataTable();
            cnn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand(procedure, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_atencion", oAtencion.IdAtencion);

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
        public bool Guardar_Usuario_Sql(string procedure, Usuario oUsuario) {

            bool flagSalida = false;
            int result = 0;
            SqlConnection cnn = new SqlConnection(connectionString);

            cnn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand(procedure, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@usuario", oUsuario.User);
                cmd.Parameters.AddWithValue("@password", oUsuario.Password);
                cmd.Parameters.AddWithValue("@level", oUsuario.Level);

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
        public DataTable Consulta_Usuarios_Sql(string procedure, Usuario oUsuario)
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            DataTable table = new DataTable();
            cnn.Open();

            try
            {

                SqlCommand cmd = new SqlCommand(procedure, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@usuario", oUsuario.User);
                cmd.Parameters.AddWithValue("@todos", oUsuario.Todos);

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
        public bool Eliminar_Usuario_Sql(string procedure, Usuario oUsuario)
        {
            bool flagSalida = false;
            int result = 0;
            SqlConnection cnn = new SqlConnection(connectionString);

            cnn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand(procedure, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_usuario", oUsuario.Codigo);

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
        public bool Editar_Usuario_Sql(string procedure, Usuario oUsuario)
        {
            bool flagSalida = false;
            int result = 0;
            SqlConnection cnn = new SqlConnection(connectionString);

            cnn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand(procedure, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_usuario", oUsuario.Codigo);
                cmd.Parameters.AddWithValue("@usuario", oUsuario.User);
                cmd.Parameters.AddWithValue("@password", oUsuario.Password);
                cmd.Parameters.AddWithValue("@level", oUsuario.Level);

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
        public int Consulta_Siguiente_Id_Veterinario_Sql(string procedure)
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            int id = 0;

            try
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand(procedure, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter("@id_veterinario", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;

                cmd.Parameters.Add(param);

                cmd.ExecuteNonQuery();

                id = Convert.ToInt32(param.Value);

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

            return id;
        }
        public bool Editar_Veterinario_Sql(string procedure, Veterinario oVeterinario)
        {
            bool flagSalida = false;
            int result = 0;
            SqlConnection cnn = new SqlConnection(connectionString);

            cnn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand(procedure, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_veterinario", oVeterinario.Codigo);
                cmd.Parameters.AddWithValue("@nombre", oVeterinario.Nombre);
                cmd.Parameters.AddWithValue("@apellido", oVeterinario.Apellido);
                cmd.Parameters.AddWithValue("@contacto", oVeterinario.Contacto);
                cmd.Parameters.AddWithValue("@dni", oVeterinario.Dni);
                cmd.Parameters.AddWithValue("@sexo", oVeterinario.Sexo);

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
        public bool Eliminar_Veterinario_Sql(string procedure, Veterinario oVeterinario)
        {
            bool flagSalida = false;
            int result = 0;
            SqlConnection cnn = new SqlConnection(connectionString);

            cnn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand(procedure, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_veterinario", oVeterinario.Codigo);

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
        public Veterinario Consulta_Veterinarios_X_DNI_Sql(string procedure, Veterinario oVeterinario)
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            DataTable table = new DataTable();

            Veterinario vet = new Veterinario();

            try
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand(procedure, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dni", oVeterinario.Dni);

                table.Load(cmd.ExecuteReader());

                foreach (DataRow itm in table.Rows)
                {
                    vet.Codigo = Convert.ToInt32(itm["id_cliente"].ToString());
                    vet.Nombre = itm["nombre"].ToString();
                    vet.Apellido = itm["apellido"].ToString();
                    vet.FakeNombre = itm["nombre"].ToString() + " " + itm["apellido"].ToString();
                    vet.Contacto = itm["contacto"].ToString();
                    vet.Dni = Convert.ToInt32(itm["dni"].ToString());
                    vet.Sexo = itm["sexo"].ToString();
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

            return vet;
        }
        public bool Guardar_Veterinario_Sql(string procedure, Veterinario oVeterinario)
        {
            bool flagSalida = false;
            int result = 0;
            SqlConnection cnn = new SqlConnection(connectionString);

            cnn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand(procedure, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombre", oVeterinario.Nombre);
                cmd.Parameters.AddWithValue("@apellido", oVeterinario.Apellido);
                cmd.Parameters.AddWithValue("@sexo", oVeterinario.Sexo);
                cmd.Parameters.AddWithValue("@contacto", oVeterinario.Contacto);
                cmd.Parameters.AddWithValue("@dni", oVeterinario.Dni);

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
