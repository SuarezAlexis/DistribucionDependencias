using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Moq;
using Ninject;
using DistribucionDependencias.Domain.Abstract;
using DistribucionDependencias.Domain.Entities;

namespace DistribucionDependencias.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            Mock<IArticuloRepository> articuloRepositoryMock = new Mock<IArticuloRepository>();
            articuloRepositoryMock.Setup(m => m.Articulos).Returns(new List<Articulo> {
                new Articulo { ArticuloID = "0", Nombre = "Articulo 1", NombreCorto = "Art1", Precio = 13.25M, Categoria = new Categoria { CategoriaID = 0, Nombre = "Categoria 0", Descripcion = "Blablabla categoria 0" } },
                new Articulo { ArticuloID = "1", Nombre = "Articulo 2", NombreCorto = "Art2", Precio = 0.25M, Categoria = new Categoria { CategoriaID = 0, Nombre = "Categoria 0", Descripcion = "Blablabla categoria 0" } },
                new Articulo { ArticuloID = "2", Nombre = "Articulo 3", NombreCorto = "Art3", Precio = 100.0M, Categoria = new Categoria { CategoriaID = 1, Nombre = "Categoria 1", Descripcion = "Blablabla categoria 1" } },
                new Articulo { ArticuloID = "3", Nombre = "Articulo 4", NombreCorto = "Art4", Precio = 57.30M, Categoria = new Categoria { CategoriaID = 1, Nombre = "Categoria 1", Descripcion = "Blablabla categoria 1" } }
            });
            kernel.Bind<IArticuloRepository>().ToConstant(articuloRepositoryMock.Object);

            Mock<ICategoriaRepository> categoriaRepositoryMock = new Mock<ICategoriaRepository>();
            categoriaRepositoryMock.Setup(m => m.Categorias).Returns(new List<Categoria> {
                new Categoria { CategoriaID = 0, Nombre = "Abarrotes", Descripcion = "Artículos de abarrotes" },
                new Categoria { CategoriaID = 1, Nombre = "Papelería", Descripcion = "Artículos de papelería" },
                new Categoria { CategoriaID = 2, Nombre = "Farmacia", Descripcion = "Artículos de farmacia" }
            });
            kernel.Bind<ICategoriaRepository>().ToConstant(categoriaRepositoryMock.Object);
        }
    }
}