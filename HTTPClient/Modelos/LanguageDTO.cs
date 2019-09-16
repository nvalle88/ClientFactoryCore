using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientFactoryCore.HTTPClient.Modelos
{
    public class LanguageDTO
    {
        public string iso639_1 { get; set; }
        public string iso639_2 { get; set; }
        public string name { get; set; }
        public string nativeName { get; set; }
    }
}
