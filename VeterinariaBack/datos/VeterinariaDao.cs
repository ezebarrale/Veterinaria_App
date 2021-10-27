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
    }
}
