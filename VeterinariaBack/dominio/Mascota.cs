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
        public TipoMascota Tipo { get; set; }
        public List<Atencion> Atenciones { get; set; }

        public Mascota(List<Atencion> atenciones)
        {
            Atenciones = atenciones;
        }

        public Mascota()
        {
            IdMascota = 0;
            Nombre = "";
            Edad = 0;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        //add Atencion

        //remove Atencion

    }
}
