using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DistribucionDependencias.Domain.Entities;

namespace DistribucionDependencias.Domain.Abstract
{
    public interface IArticuloRepository
    {
        IEnumerable<Articulo> Articulos { get; }
    }
}
