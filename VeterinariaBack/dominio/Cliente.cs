using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria_Form.dominio
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public char Sexo { get; set; }
        public int Codigo { get; set; }
        public List<Mascota> Mascotas { get; set; }

        public Cliente(List<Mascota> mascotas)
        {
            Mascotas = mascotas;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        //add Mascota

        //remove Mascota
    }
}
