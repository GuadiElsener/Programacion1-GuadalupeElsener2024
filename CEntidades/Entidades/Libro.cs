using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class Libro
    {
        public int IdLibro { get; set; }
        public string NombreLibro { get; set; }
        public string DescripcionLibro { get; set; }
        public DateTime FechaCreacionLibro { get; set; }
    }
}
