using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaBack.dominio
{
    public class Atencion
    {
        public int IdAtencion { get; set; }
        public DateTime Fecha { get; set; }
        public  List<DetalleAtencion> Detalles { get; set; }
        public Veterinario oVeterinario { get; set; }

        public Atencion()
        {
            oVeterinario = new Veterinario();
            Fecha = DateTime.Now;
            Detalles = new List<DetalleAtencion>();
        }

        public override string ToString()
        {
            return Fecha.ToString();
        }

        //add Detalle
        public void AddDetalle(DetalleAtencion detalle) {

            Detalles.Add(detalle);

        }

        //remove Detalle
        public void RemoveDetalle(DetalleAtencion detalle)
        {
            Detalles.Remove(detalle);
        }
    }
}
