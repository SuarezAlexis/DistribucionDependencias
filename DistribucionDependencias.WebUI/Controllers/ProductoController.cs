using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DistribucionDependencias.Domain.Abstract;
using DistribucionDependencias.Domain.Entities;
using DistribucionDependencias.WebUI.Models;

namespace DistribucionDependencias.WebUI.Controllers
{
    public class ProductoController : Controller
    {
        private IProductoRepository productoRepo;
        private IListaRepository listaRepo;
        public int PageSize = 3;

        public ProductoController(IProductoRepository productoRepository, IListaRepository listaRepository)
        {
            this.productoRepo = productoRepository;
            this.listaRepo = listaRepository;
        }

        public ViewResult List(string categoria, int page = 1)
        {
            ProductoListView model = new ProductoListView
            {
                Productos = productoRepo.Productos.Where(p => categoria == null || p.Categoria.Nombre == categoria).OrderBy(p => p.ProductoID).Skip((page - 1) * PageSize).Take(PageSize),
                Paginacion = new PagingInfo { CurrentPage = page, ItemsPerPage = PageSize, TotalItems = productoRepo.Productos.Where(p => categoria == null || p.Categoria.Nombre == categoria).Count() },
                CategoriaActiva = categoria,
                Listas = listaRepo.Listas
            };
            return View( model );
        }
    }
    /*
    public class CategoriaController : Controller
    {
        private ICategoriaRepository repo;

        public CategoriaController(ICategoriaRepository categoriaRepository)
        {
            this.repo = categoriaRepository;
        }

        public ViewResult List()
        {
            return View(repo.Categorias);
        }
    }
    */
}