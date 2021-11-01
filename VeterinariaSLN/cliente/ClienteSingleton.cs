using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaSLN.cliente
{
    class ClienteSingleton
    {
        private static ClienteSingleton instancia;
        private HttpClient client;

        private ClienteSingleton()
        {
            client = new HttpClient();
        }

        public static ClienteSingleton GetInstance()
        {
            if (instancia == null)
            {
                instancia = new ClienteSingleton();
            }
            return instancia;
        }

        public async Task<bool> PostAsync(string url, string data)
        {
            StringContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            var result = await client.PostAsync(url, content);

            bool rps = false;
            if (result.IsSuccessStatusCode)
                rps = true;

            return rps;
        }
    }
}
