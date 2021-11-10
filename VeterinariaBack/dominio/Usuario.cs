using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaBack.dominio
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public int Level { get; set; }
        public int Todos { get; set; }

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
