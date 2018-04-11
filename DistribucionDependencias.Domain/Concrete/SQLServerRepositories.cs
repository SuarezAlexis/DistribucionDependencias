using DistribucionDependencias.Domain.Entities;
using DistribucionDependencias.Domain.Abstract;
using System.Collections.Generic;
using System.Data;
using System;

namespace DistribucionDependencias.Domain.Concrete
{
    public class SQLSCategoriaRepository : ICategoriaRepository
    {
        private SQLServerDbContext context = new SQLServerDbContext();

        public IEnumerable<Categoria> Categorias
        {
            get { return context.Categorias; }
        }

        public Categoria GetCategoria(string ID)
        {
            return context.GetCategoria("ID = " + ID);
        }

        public void SaveCategoria(Categoria categoria)
        {
            if(categoria.CategoriaID == 0)
            { context.AddCategoria(categoria); }
            else
            { context.UpdateCategoria(categoria); }
        }

    }

    public class SQLProductoRepository : IProductoRepository
    {
        private SQLServerDbContext context = new SQLServerDbContext();

        public IEnumerable<Producto> Productos
        {
            get { return context.Productos; }
        }

        public Producto GetProducto(string ID)
        {
            return context.GetProducto("ID = '" + ID + "'");
        }

        public void SaveProducto(Producto producto)
        {
            if ( String.IsNullOrEmpty(producto.ProductoID) )
            { context.AddProducto(producto); }
            else
            { context.UpdateProducto(producto); }
        }

    }

    public class SQLListaRepository : IListaRepository
    {
        private SQLServerDbContext context = new SQLServerDbContext();

        public IEnumerable<Lista> Listas
        {
            get { return context.Listas; }
        }

        public Lista GetLista(string ID)
        {
            return context.GetLista("ID " + ID);
        }

        public void SaveLista(Lista lista)
        {
            if (lista.ListaID == 0)
            { context.AddLista(lista); }
            else
            { context.UpdateLista(lista); }
        }

    }

}
