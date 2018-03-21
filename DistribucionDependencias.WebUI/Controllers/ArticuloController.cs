using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DistribucionDependencias.Domain.Abstract;
using DistribucionDependencias.Domain.Entities;

namespace DistribucionDependencias.WebUI.Controllers
{
    public class ArticuloController : Controller
    {
        private IArticuloRepository repository;

        public ArticuloController(IArticuloRepository articuloRepository)
        {
            this.repository = articuloRepository;
        }

        public ViewResult List()
        {
            return View(repository.Articulos);
        }
    }
}