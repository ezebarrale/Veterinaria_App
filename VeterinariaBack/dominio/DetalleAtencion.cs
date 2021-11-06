using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaBack.dominio
{
    public class DetalleAtencion
    {
        public int IdDetalle { get; set; }
        public string Descripcion { get; set; }
        public double Importe { get; set; }

        public DetalleAtencion()
        {
            IdDetalle = 0;
            Descripcion = "";
            Importe = 0;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
