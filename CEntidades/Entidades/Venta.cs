using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public string DescripcionVenta { get; set; }
        public DateTime FechaVenta { get; set; }
        public float MontoFecha { get; set; }
    }
}
