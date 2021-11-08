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
        public string FakeNombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public string Contacto { get; set; }
        public string Sexo { get; set; }
        public int Codigo { get; set; }
        public List<Mascota> Mascotas { get; set; }

        public Cliente()
        {
            Mascotas = new List<Mascota>();
        }

        public override string ToString()
        {
            return Nombre + " " +Apellido;
        }

        //add Mascota
        public void AgregarMascota(Mascota oMascota) {
            Mascotas.Add(oMascota);  
        }

        //remove all Mascotas
        public void EliminarMascotas()
        {
            Mascotas.Clear();
        }
    }
}
