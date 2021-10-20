using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria_Form.dominio
{
    class Mascota
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public TipoMascota Tipo { get; set; }

        public Mascota(string nombre, int edad, TipoMascota tipo)
        {
            Nombre = nombre;
            Edad = edad;
            Tipo = tipo;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
