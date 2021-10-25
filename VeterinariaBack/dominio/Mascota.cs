using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria_Form.dominio
{
    public class Mascota
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public TipoMascota Tipo { get; set; }
        public List<Atencion> Atenciones { get; set; }

        public Mascota(List<Atencion> atenciones)
        {
            Atenciones = atenciones;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        //add Atencion

        //remove Atencion

    }
}
