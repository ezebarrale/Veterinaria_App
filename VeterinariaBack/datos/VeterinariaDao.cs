using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria_Form.dominio;

namespace VeterinariaBack.datos
{
    class VeterinariaDao : IVeterinariaDao
    {
        public List<TipoMascota> GetTipoMascota()
        {
            List<TipoMascota> mascotas = new List<TipoMascota>();
            DataTable tipo_mascotas = HelperDao.GetInstance().Consulta_Tipo_Mascota_Sql("PA_TIPO_MASCOTAS");
            foreach (DataRow row in tipo_mascotas.Rows)
            {
                TipoMascota tm = new TipoMascota();
                tm.IdTipoMascota = Convert.ToInt32(row[0].ToString());
                tm.Nombre = row[1].ToString();

                mascotas.Add(tm);
            }

            return mascotas;
        }
    }
}
