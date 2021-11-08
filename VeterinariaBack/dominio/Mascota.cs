using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaBack.dominio
{
    public class Mascota
    {
        public int IdMascota { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public TipoMascota Tipo { get; set; }
        public List<Atencion> Atenciones { get; set; }

        public Mascota()
        {
            Atenciones = new List<Atencion>();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        //add Atencion
        public void SaveAtencion(Atencion att) {
            Atenciones.Add(att);
        }

        //remove Atencion
        public void RemoveAtencion(Atencion att)
        {
            Atenciones.Remove(att);
        }

        //remove all Atenciones
        public void RemoveAtenciones()
        {
            Atenciones.Clear();
        }
    }
}
