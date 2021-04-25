using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class Reservas2
    {
        public string ID { get; set; }
        public DateTime Desde { get; set; }
        public string Estado { get; set; }
        public DateTime Hasta { get; set; }
        public string VehiculoID { get; set; }

    }
}
