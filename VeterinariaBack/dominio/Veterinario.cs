﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaBack.dominio
{
    public class Veterinario
    {
        public string Nombre { get; set; }
        public string Sexo { get; set; }
        public int Codigo { get; set; }

        public Veterinario()
        {
            Nombre = "";
            Sexo = "";
            Codigo = 0;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
