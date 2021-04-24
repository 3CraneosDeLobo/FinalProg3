using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class Factura
    {
        public string ID { get; set; }
            public string ClienteID { get; set; }
            public string Debe { get; set; }
            public string Desde { get; set; }
            public string Estado { get; set; }
            public string Hasta { get; set; }
            public string Monto { get; set; }
            public string Pagada { get; set; }
            public string Pagado { get; set; }
            public string VehiculoID { get; set; }
        
    }
}
