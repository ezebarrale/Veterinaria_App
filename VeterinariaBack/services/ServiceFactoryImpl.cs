using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaBack.services
{
    public class ServiceFactoryImpl : ServiceFactory
    {
        public override IVeterinariaApp CrearService()
        {
            return new VeterinariaApp();
        }
    }
}
