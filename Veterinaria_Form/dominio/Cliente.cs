using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria_Form.dominio
{
    class Cliente
    {
        public string Nombre { get; set; }
        public char Sexo { get; set; }
        public int Codigo { get; set; }
        public List<Mascota> Mascotas { get; set; }

        public Cliente(string nombre, char sexo, int codigo, List<Mascota> mascotas)
        {
            Nombre = nombre;
            Sexo = sexo;
            Codigo = codigo;
            Mascotas = mascotas;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
