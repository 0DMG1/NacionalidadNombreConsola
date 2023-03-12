using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace NacionalidadNombre.Class
{
    internal class NationalizeAPI
    {
        public async Task<NamePredict?> withHttpClientRaw(string name)
        {

            HttpClient client = new HttpClient();
            
            HttpResponseMessage response = client.GetAsync($"https://api.nationalize.io?name={name}", new CancellationToken()).Result;
            NamePredict? namePredict;
            //response.EnsureSuccessStatusCode();

            if (response.IsSuccessStatusCode)
            {
                namePredict = await response.Content.ReadFromJsonAsync<NamePredict>();
            }
            else
                namePredict = new NamePredict("name");

            return namePredict;
        }

    }
}
