using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaBack.dominio;

namespace VeterinariaBack.datos
{
    class VeterinariaDao : IVeterinariaDao
    {
        public bool Login(Usuario oUsuario)
        {
            return HelperDao.GetInstance().Consulta_Login_Sql("PA_EXISTE_USUARIO", oUsuario);
        }
        public List<TipoMascota> GetTipoMascota()
        {
            List<TipoMascota> list = new List<TipoMascota>();

            DataTable tipo_mascotas = HelperDao.GetInstance().Consulta_Tipo_Mascota_Sql("PA_TIPO_MASCOTAS");

            foreach (DataRow row in tipo_mascotas.Rows)
            {
                TipoMascota tm = new TipoMascota();
                tm.IdTipoMascota = Convert.ToInt32(row[0].ToString());
                tm.Nombre = row[1].ToString();

                list.Add(tm);
            }

            return list;
        }
        public TipoMascota SaveTipoMascota(string descripcion)
        {
            return HelperDao.GetInstance().Guardar_Tipo_Mascota_Sql("PA_GUARDAR_TIPO_MASCOTA", descripcion);
        }
        public bool DeleteTipoMascota(TipoMascota oTm)
        {
            return HelperDao.GetInstance().Eliminar_Tipo_Mascota_Sql("PA_ELIMINAR_TIPO_MASCOTA", oTm);
        }
        public bool UpdateTipoMascota(TipoMascota oTm)
        {
            return HelperDao.GetInstance().Editar_Tipo_Mascota_Sql("PA_EDITAR_TIPO_MASCOTA", oTm);
        }
        public List<Cliente> GetClientes(string nombre)
        {
            List<Cliente> lst = new List<Cliente>();

            DataTable table = HelperDao.GetInstance().Consulta_Clientes_Sql("PA_CONSULTAR_CLIENTE", nombre);


            foreach (DataRow itm in table.Rows)
            {
                Cliente oCliente = new Cliente();
                oCliente.Codigo = Convert.ToInt32(itm["id_cliente"].ToString());
                oCliente.Nombre = itm["nombre"].ToString();
                oCliente.Sexo = itm["sexo"].ToString();

                lst.Add(oCliente);
            }

            return lst;
        }
        public List<Mascota> GetMascotas(int id_cliente)
        {
            List<Mascota> lst = new List<Mascota>();

            DataTable table = HelperDao.GetInstance().Consulta_Mascotas_Sql("PA_CONSULTAR_MASCOTA", id_cliente);

            foreach (DataRow itm in table.Rows)
            {
                Mascota oMascota = new Mascota();
                oMascota.IdMascota = Convert.ToInt32(itm["id_mascota"].ToString());
                oMascota.Nombre = itm["nombre"].ToString();
                oMascota.Edad = Convert.ToInt32(itm["edad"].ToString());

                TipoMascota oTipoMascota = new TipoMascota();
                oTipoMascota.IdTipoMascota = Convert.ToInt32(itm["id_tipo_mascota"].ToString());
                oTipoMascota.Nombre = itm["nombre_tipo"].ToString();

                oMascota.Tipo = oTipoMascota;

                lst.Add(oMascota);
            }

            return lst;
        }
        public Atencion GetUltimoIdAtencion()
        {
            return HelperDao.GetInstance().Consulta_Ultimo_Id_Atencion("PA_NEXT_ID_ATENCION");
        }
        public bool SaveAtencion(Mascota oMascota)
        {
            return HelperDao.GetInstance().Guardar_Atencion("PA_GUARDAR_ATENCION", oMascota);
        }
        public List<Atencion> GetAtenciones(Mascota oMascota)
        {
            List<Atencion> lstAtenciones = new List<Atencion>();

            DataTable table = HelperDao.GetInstance().Consulta_Atenciones_Sql("PA_CONSULTAR_ATENCIONES", oMascota);

            foreach (DataRow itm in table.Rows)
            {
                Atencion att = new Atencion();
                att.IdAtencion = Convert.ToInt32(itm["id_atencion"].ToString());
                att.Fecha = Convert.ToDateTime(itm["fecha_hora"].ToString());

                Veterinario vet = new Veterinario();
                vet.Codigo = Convert.ToInt32(itm["id_veterinario"].ToString());
                vet.Nombre = itm["nombre"].ToString();

                att.oVeterinario = vet;

                lstAtenciones.Add(att);
            }

            return lstAtenciones;
        }
        public bool UpdateAtencion(Atencion oAtencion)
        {
            return HelperDao.GetInstance().Editar_Atencion_Sql("PA_ACTUALIZAR_ATENCIONES", oAtencion);
        }
        public bool DeleteAtencion(Atencion oAtencion)
        {
            return HelperDao.GetInstance().Eliminar_Atencion_Sql("PA_ELIMINAR_ATENCIONES", oAtencion);
        }
        public bool SaveCliente(Cliente oCliente)
        {
            return HelperDao.GetInstance().Guardar_Cliente_Sql("PA_GUARDAR_CLIENTES", oCliente);
        }
        public bool UpdateCliente(Cliente oCliente)
        {
            return HelperDao.GetInstance().Editar_Cliente_Sql("PA_ACTUALIZAR_CLIENTES", oCliente);
        }
        public bool DeleteCliente(Cliente oCliente)
        {
            return HelperDao.GetInstance().Eliminar_Cliente_Sql("PA_ELIMINAR_CLIENTES", oCliente);
        }
        public bool UpdateMascota(Mascota oMascota)
        {
            return HelperDao.GetInstance().Editar_Mascota_Sql("PA_ACTUALIZAR_MASCOTAS", oMascota);
        }
        public bool DeleteMascota(Mascota oMascota)
        {
            return HelperDao.GetInstance().Eliminar_Mascota_Sql("PA_ELIMINAR_MASCOTAS", oMascota);
        }
        public int GetNextIdCliente()
        {
            return HelperDao.GetInstance().Consulta_Siguiente_Id_Cliente_Sql("PA_SIGUIENTE_ID_CLIENTE");
        }
        public int GetNextIdMascota()
        {
            return HelperDao.GetInstance().Consulta_Siguiente_Id_Mascota_Sql("PA_SIGUIENTE_ID_MASCOTA");
        }
        public bool SaveMascota(Cliente oCliente)
        {
            return HelperDao.GetInstance().Guardar_Mascota_Sql("PA_GUARDAR_MASCOTAS", oCliente);
        }

        public List<Veterinario> GetVeterinarios()
        {
            List<Veterinario> veterinarios = new List<Veterinario>();

            DataTable table = HelperDao.GetInstance().Consulta_Veterinarios_Sql("PA_CONSULTAR_VETERINARIOS");

            foreach (DataRow row in table.Rows)
            {
                Veterinario oVeterinario = new Veterinario();
                oVeterinario.Codigo = Convert.ToInt32(row["id_veterinario"].ToString());
                oVeterinario.Nombre = row["nombre"].ToString();
                oVeterinario.Sexo = row["sexo"].ToString();

                veterinarios.Add(oVeterinario);
            }

            return veterinarios;
        }

        public List<DetalleAtencion> GetDetallesAtencion(Atencion oAtencion)
        {
            List<DetalleAtencion> lstDetalles = new List<DetalleAtencion>();

            DataTable table = HelperDao.GetInstance().Consulta_Detalles_Atencion_Sql("PA_CONSULTAR_DETALLE_ATENCIONES", oAtencion);

            foreach (DataRow row in table.Rows)
            {
                DetalleAtencion oDetalle = new DetalleAtencion();

                oDetalle.IdDetalle = Convert.ToInt32(row["CODIGO"].ToString());
                oDetalle.Descripcion = row["DESCRIPCION"].ToString();
                oDetalle.Importe = Convert.ToDouble(row["IMPORTE"].ToString());

                lstDetalles.Add(oDetalle);
            }

            return lstDetalles;
        }
    }
}
