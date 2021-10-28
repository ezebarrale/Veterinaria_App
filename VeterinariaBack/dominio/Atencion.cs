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
        public string Descripcion { get; set; }
        public double Importe { get; set; }

        public Atencion()
        {
            Fecha = DateTime.Now;
            Descripcion = "";
            Importe = 0;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
