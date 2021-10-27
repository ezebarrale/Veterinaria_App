using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaBack.services
{
    public abstract class ServiceFactory
    {
        public abstract IVeterinariaApp CrearService();
    }
}
