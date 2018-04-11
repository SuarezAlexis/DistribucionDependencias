using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DistribucionDependencias.Domain.Entities;

namespace DistribucionDependencias.Domain.Abstract
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
        Categoria GetCategoria(string ID);
        void SaveCategoria(Categoria categoria);
    }

    public interface IProductoRepository
    {
        IEnumerable<Producto> Productos { get; }
        Producto GetProducto(string ID);
        void SaveProducto(Producto producto);
    }

    public interface IListaRepository
    {
        IEnumerable<Lista> Listas { get; }
        Lista GetLista(string ID);
        void SaveLista(Lista lista);
    }
}
