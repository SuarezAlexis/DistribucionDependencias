using System.Collections.Generic;
using DistribucionDependencias.Domain.Entities;

namespace DistribucionDependencias.WebUI.Models
{
    public class ProductoListView
    {
        public IEnumerable<Producto> Productos { get; set; }
        public PagingInfo Paginacion { get; set; }
        public string CategoriaActiva { get; set; }
        public IEnumerable<Lista> Listas { get; set; }
    }
}