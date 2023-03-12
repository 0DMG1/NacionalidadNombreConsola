using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NacionalidadNombre.Class
{
    internal class NamePredict
    {
        public string name { get; set; }
        public List<CountryPredict> country { get; set; }
        public NamePredict(string name)
        {
            this.name = name;
            country = new();
        }
    }
}
