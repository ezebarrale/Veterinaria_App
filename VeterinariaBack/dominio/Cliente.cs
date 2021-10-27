using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaBack.dominio
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Sexo { get; set; }
        public int Codigo { get; set; }
        public List<Mascota> Mascotas { get; set; }

        public Cliente()
        {
            Nombre = "";
            Sexo = "";
            Codigo = 0;
        }

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
