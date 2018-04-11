using System.Collections.Generic;
using System.Linq;

namespace DistribucionDependencias.Domain.Entities
{
    public class Lista
    {
        public long ListaID;
        public string Nombre;
        private List<RegistroLista> registros = new List<RegistroLista>();
        public IEnumerable<RegistroLista> Registros
        {
            get { return registros; }
            set
            {
                registros.Clear();
                foreach(RegistroLista rl in value)
                {
                    registros.Add(rl);
                }
            }
        }

        public void AgregarItem(Producto prod, int cantidad)
        {
            RegistroLista registro = registros.Where(p => p.Producto.ProductoID == prod.ProductoID).FirstOrDefault();

            if (registro == null)
                registros.Add(new RegistroLista { Producto = prod, Cantidad = cantidad });
            else
                registro.Cantidad += cantidad;
        }

        public void QuitarItem(Producto prod)
        {
            registros.RemoveAll(r => r.Producto.ProductoID == prod.ProductoID);
        }

        public decimal CalcularTotal()
        {
            return registros.Sum(e => e.Producto.Precio * e.Cantidad);
        }

        public void Limpiar()
        {
            registros.Clear();
        }

    }

    public class RegistroLista
    {
        public long ID { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
    }
}
