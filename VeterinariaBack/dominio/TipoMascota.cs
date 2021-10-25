using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria_Form.dominio
{
    public class TipoMascota
    {
        public int IdTipoMascota { get; set; }
        public string Nombre { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
