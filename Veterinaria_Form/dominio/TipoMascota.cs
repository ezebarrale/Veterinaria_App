using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria_Form.dominio
{
    class TipoMascota
    {
        public string Nombre { get; set; }

        public TipoMascota(string nombre)
        {
            Nombre = nombre;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
