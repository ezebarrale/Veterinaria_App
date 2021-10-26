using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaBack.dominio
{
    class Usuario
    {
        public string User { get; set; }
        public string Password { get; set; }

        public Usuario(string user, string password)
        {
            User = user;
            Password = password;
        }

        public Usuario()
        {
            User = "";
            Password = "";
        }

    }
}
