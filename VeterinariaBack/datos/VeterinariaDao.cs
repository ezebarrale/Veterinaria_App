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

                /*
                TipoMascota tm = new TipoMascota();
                tm.IdTipoMascota = Convert.ToInt32(itm["id_tipo_mascota"].ToString());

                DataTable table1 = HelperDao.Consulta_Tipo_Mascota_XID_Sql("PA_TIPO_MASCOTAS_X_ID", tm.IdTipoMascota);
                
                foreach (DataRow item in table1.Rows)
                {
                    tm.Nombre = item["descripcion"].ToString();
                }
                
                tm.Nombre = table1.Rows[1][1].ToString();

                oMascota.Tipo = tm;
                */
                lst.Add(oMascota);
            }

            return lst;
        }
    }
}
