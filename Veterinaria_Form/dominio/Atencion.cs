using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria_Form.dominio
{
    class Atencion
    {
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public double Importe { get; set; }

        public Atencion(DateTime fecha, string descripcion, double importe)
        {
            Fecha = fecha;
            Descripcion = descripcion;
            Importe = importe;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
