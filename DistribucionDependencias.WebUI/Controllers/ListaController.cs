using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using DistribucionDependencias.Domain.Abstract;
using DistribucionDependencias.Domain.Entities;

namespace DistribucionDependencias.WebUI.Controllers
{
    public class ListaController : Controller
    {
        private IProductoRepository productoRepo;
        private IListaRepository listaRepo;

        public ListaController(IProductoRepository productoRepoParam, IListaRepository listaRepoParam)
        {
            productoRepo = productoRepoParam;
            listaRepo = listaRepoParam;
        }

        public ViewResult List()
        {
            IEnumerable<Lista> model = listaRepo.Listas;
            return View(model);
        }

        public RedirectToRouteResult Agregar(string productoID, string returnUrl)
        { //Validar que ya exista el producto, solo agregar cantidad
            Producto prod = productoRepo.GetProducto(productoID);

            if(prod == null)
            {
                
            }
            return RedirectToAction("Index", new { returnUrl });
        }
    }
}