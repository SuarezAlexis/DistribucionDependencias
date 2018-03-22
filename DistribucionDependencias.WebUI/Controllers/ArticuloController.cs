using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DistribucionDependencias.Domain.Abstract;
using DistribucionDependencias.Domain.Entities;

namespace DistribucionDependencias.WebUI.Controllers
{
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

    public class ArticuloController : Controller
    {
        private IArticuloRepository repo;

        public ArticuloController(IArticuloRepository articuloRepository)
        {
            this.repo = articuloRepository;
        }

        public ViewResult List()
        {
            return View(repo.Articulos);
        }
    }
}