using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class Prestamo
    {
        public int IdPrestamo { get; set; }
        public int DescripcionPrestamo { get;set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucionPrestamo { get; set; }
        public int MontoPrestamo { get; set; }  
    }
}
