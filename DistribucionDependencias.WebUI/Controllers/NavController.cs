using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using DistribucionDependencias.Domain.Abstract;

namespace DistribucionDependencias.WebUI.Controllers
{
    public class NavController : Controller
    {
        private IProductoRepository repo;

        public NavController(IProductoRepository repoParam)
        {
            repo = repoParam;
        }

        public PartialViewResult CatMenu(string categoria = null)
        {
            ViewBag.CategoriaActiva = categoria;
            IEnumerable<string> categorias = repo.Productos.Select(x => x.Categoria.Nombre).Distinct().OrderBy(x => x);
            return PartialView(categorias);
        }
    }
}