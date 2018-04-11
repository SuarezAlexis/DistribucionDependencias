using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Moq;
using Ninject;
using DistribucionDependencias.Domain.Abstract;
using DistribucionDependencias.Domain.Concrete;
using DistribucionDependencias.Domain.Entities;
using DistribucionDependencias.WebUI.Infrastructure.Abstract;
using DistribucionDependencias.WebUI.Infrastructure.Concrete;

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
            /*
            Mock<IProductoRepository> productoRepositoryMock = new Mock<IProductoRepository>();
            productoRepositoryMock.Setup(m => m.Productos).Returns(new List<Producto> {
                new Producto { ProductoID = "0", Nombre = "Articulo 1", NombreCorto = "Art1", Precio = 13.25M, Categoria = new Categoria { CategoriaID = 0, Nombre = "Categoria 0", Descripcion = "Blablabla categoria 0" } },
                new Producto { ProductoID = "1", Nombre = "Articulo 2", NombreCorto = "Art2", Precio = 0.25M, Categoria = new Categoria { CategoriaID = 0, Nombre = "Categoria 0", Descripcion = "Blablabla categoria 0" } },
                new Producto { ProductoID = "2", Nombre = "Articulo 3", NombreCorto = "Art3", Precio = 100.0M, Categoria = new Categoria { CategoriaID = 1, Nombre = "Categoria 1", Descripcion = "Blablabla categoria 1" } },
                new Producto { ProductoID = "3", Nombre = "Articulo 4", NombreCorto = "Art4", Precio = 57.30M, Categoria = new Categoria { CategoriaID = 1, Nombre = "Categoria 1", Descripcion = "Blablabla categoria 1" } }
            });
            kernel.Bind<IProductoRepository>().ToConstant(productoRepositoryMock.Object);
            */
            /*
            Mock<ICategoriaRepository> categoriaRepositoryMock = new Mock<ICategoriaRepository>();
            categoriaRepositoryMock.Setup(m => m.Categorias).Returns(new List<Categoria> {
                new Categoria { CategoriaID = 0, Nombre = "Abarrotes", Descripcion = "Artículos de abarrotes" },
                new Categoria { CategoriaID = 1, Nombre = "Papelería", Descripcion = "Artículos de papelería" },
                new Categoria { CategoriaID = 2, Nombre = "Farmacia", Descripcion = "Artículos de farmacia" }
            });
            kernel.Bind<ICategoriaRepository>().ToConstant(categoriaRepositoryMock.Object);
            */
            kernel.Bind<ICategoriaRepository>().To<SQLSCategoriaRepository>();
            kernel.Bind<IProductoRepository>().To<SQLProductoRepository>();
            kernel.Bind<IListaRepository>().To<SQLListaRepository>();
            kernel.Bind<IMembershipProvider>().ToConstant<MembershipProvider>();
        }
    }
}