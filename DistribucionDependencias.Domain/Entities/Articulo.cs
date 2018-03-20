using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistribucionDependencias.Domain.Entities
{
    public class Articulo
    {
        public string ArticuloID { get; set; }
        public string Nombre { get; set; }
        public string NombreCorto { get; set; }
        public decimal Precio { get; set; }
        public Categoria categoria { get; set; }
    }
}
