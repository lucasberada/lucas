using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicativo.Models
{
    class Eventos
    {
        public int id { get; set; }

        public string TimeCasa { get; set; }
        public string TimeVisitante { get; set; }
        public byte[] logoCasa { get; set; }
        public byte[] logoVisitante { get; set; }

        public string Preco { get; set; }
    }
}
