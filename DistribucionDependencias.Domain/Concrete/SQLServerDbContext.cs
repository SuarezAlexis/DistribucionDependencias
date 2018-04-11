using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using DistribucionDependencias.Domain.Entities;

namespace DistribucionDependencias.Domain.Concrete
{
    class SQLServerDbContext
    {
        /*********  Propiedades privadas     *********/
        private string connString;
        private SqlConnection conn;
        private SqlCommand cmd;
        private DataTable data;
        private string nowTime { get { return "'" + DateTime.Now.ToString("yyyyMMdd hh:mm:ss tt") + "'"; } }

        /*********  Propiedades públicas     *********/
        public List<Categoria> Categorias
        {
            get
            {
                List<Categoria> lista = new List<Categoria>();
                foreach (DataRow dr in TableQuery("SELECT * FROM Categoria").Rows)
                {
                    lista.Add(new Categoria
                    {
                        CategoriaID = Convert.ToInt32(dr["ID"]),
                        Nombre = dr["Nombre"].ToString(),
                        Descripcion = dr["Descripcion"].ToString()
                    });
                }

                return lista;
            }
        }
        public List<Producto> Productos
        {
            get
            {
                List<Producto> lista = new List<Producto>();
                foreach (DataRow dr in TableQuery("SELECT * FROM Producto").Rows)
                {
                    lista.Add(new Producto
                    {
                        ProductoID = dr["Codigo"].ToString(),
                        Nombre = dr["Nombre"].ToString(),
                        NombreCorto = dr["NombreCorto"].ToString(),
                        Categoria = GetCategoria("ID = " + dr["Categoria"].ToString()),
                        Precio = Convert.ToDecimal(dr["Precio"])
                    });
                }

                return lista;
            }
        }
        public List<Lista> Listas
        {
            get
            {
                List<Lista> listas = new List<Lista>();
                foreach (DataRow dr in TableQuery("SELECT * FROM Lista").Rows)
                {
                    listas.Add(new Lista
                    {
                        ListaID = Convert.ToInt64(dr["ID"]),
                        Nombre = Convert.ToString(dr["Nombre"])
                    });
                }
                return listas;
            }
        }

        /********   Métodos públicos     *********/
        /// <summary>
        /// Constructor. Inicializa los datos de la conexión a la base de datos
        /// </summary>
        public SQLServerDbContext()
        {
            connString = ConfigurationManager.ConnectionStrings["SQLServerDbContext"].ConnectionString;
            conn = new SqlConnection(connString);
        }

        /*** Registros individuales ***/
        public Categoria GetCategoria(string condicion)
        {
            DataRow dr = FirstRowQuery("SELECT * FROM Categoria WHERE " + condicion);
            return new Categoria
            {
                CategoriaID = Convert.ToInt32(dr["ID"]),
                Nombre = Convert.ToString(dr["Nombre"]),
                Descripcion = Convert.ToString(dr["Descripcion"])
            };
        }

        public Producto GetProducto(string condicion)
        {
            return ProductoFromDataRow(FirstRowQuery("SELECT * FROM Producto WHERE " + condicion));
        }

        public Lista GetLista(string condicion)
        {
            DataRow ListaDR = FirstRowQuery("SELECT * FROM Lista WHERE " + condicion);
            TableQuery("SELECT PL.ID, PL.Cantidad, P.* FROM Producto_Lista PL JOIN Producto P ON (PL.Codigo = P.Codigo) WHERE PL.ListaID = " + ListaDR["ID"]);
            if(data.Rows.Count > 0)
            {
                List<RegistroLista> lista = new List<RegistroLista>();
                foreach (DataRow dr in data.Rows)
                {
                    lista.Add(new RegistroLista
                    {
                        ID = Convert.ToInt64(dr["ID"]),
                        Cantidad = Convert.ToInt32(dr["Cantidad"]),
                        Producto = ProductoFromDataRow(dr)
                    });
                }
                return new Lista
                {
                    ListaID = Convert.ToInt64(ListaDR["ID"]),
                    Nombre = Convert.ToString(ListaDR["Nombre"]),
                    Registros = lista
                };
            }
            else { return null; }
            
        }

        /*** Nuevos registros ***/
        public void AddCategoria(Categoria cat)
        {

        }

        public void AddProducto(Producto prod)
        {

        }

        public void AddLista(Lista lista)
        {
            string query = "INSERT INTO Lista VALUES (" +
                "'" + lista.Nombre + "'," + 
                "'" + nowTime + "'," +
                "'" + nowTime + "')";
            //Por hacer: Insertar en Usuario_Lista
            if ( NonQuery(query) == 1 )
            {
                foreach(RegistroLista rl in lista.Registros)
                {
                    query = "INSERT INTO Producto_Lista VALUES (" +
                        lista.ListaID + "," +
                        rl.Producto.ProductoID + "," +
                        rl.Cantidad + ")";
                    NonQuery(query);

                    query = "INSERT INTO HistoricoProducto_Lista VALUES(" +
                        lista.ListaID + "," +
                        rl.Producto.ProductoID + "," +
                        "'I'," +
                        nowTime + "," +
                        "NULL," +
                        "NULL)"; //Por hacer: Agregar Usuario
                    NonQuery(query);
                }
            }
        }

        /*** Actualizar registro existente ***/
        public void UpdateCategoria(Categoria cat)
        {

        }

        public void UpdateProducto(Producto prod)
        {

        }

        public void UpdateLista(Lista lista)
        {
            Lista prev = GetLista("ID = " + lista.ListaID);
            if (  prev != null )
            {
                if (prev.Nombre != lista.Nombre)
                {
                    NonQuery("UPDATE Lista SET " + 
                        "Nombre = '" + lista.Nombre + "'," +
                        "UltimaMod = " + nowTime + " " +
                        "WHERE ID = " + lista.ListaID);
                }
                foreach(RegistroLista rl in lista.Registros)
                {
                    RegistroLista encontrado = null;
                    foreach (RegistroLista prl in prev.Registros)
                    {
                        if(rl.Producto.ProductoID.Equals(prl.Producto.ProductoID))
                        {
                            encontrado = prl;
                            if (rl.Cantidad != prl.Cantidad)
                            { //Actualizar cantidad
                                NonQuery("UPDATE Producto_Lista SET " +
                                    "Cantidad = " + rl.Cantidad + " " +
                                    "WHERE ID = " + prl.ID);
                                NonQuery("");
                            }       
                            break;
                        }
                    }
                    if(encontrado == null)
                    {//No se encontró producto en lista previa. Agregar.
                        NonQuery("INSERT INTO Producto_Lista");
                    }
                    else
                    {
                        List<RegistroLista> l = new List<RegistroLista>(prev.Registros);
                        l.Remove(encontrado);
                        prev.Registros = l;
                    }
                }
                foreach(RegistroLista prl in prev.Registros)
                {
                    //Borrar estos registros
                }
            }
        }
        /*********  Métodos privados     ********/
        private Producto ProductoFromDataRow(DataRow dr)
        {
            //Agregar validación de DataRow
            return new Producto
            {
                ProductoID = Convert.ToString(dr["Codigo"]),
                Nombre = Convert.ToString(dr["Nombre"]),
                NombreCorto = Convert.ToString(dr["NombreCorto"]),
                Categoria = GetCategoria("ID = " + Convert.ToString(dr["Categoria"])),
                Precio = Convert.ToDecimal(dr["Precio"])
            };
        }

        /// <summary>
        /// Devuelve los resultados de la consulta a la base de datos en forma de tabla de datos.
        /// </summary>
        /// <param name="query">Consulta que se envía a la base de datos</param>
        /// <returns>Tabla con los resultados</returns>
        private DataTable TableQuery(string query)
        {
            data = new DataTable();
            cmd = new SqlCommand(query, conn);
            conn.Open();
            data.Load(cmd.ExecuteReader(CommandBehavior.CloseConnection));
            return data;
        }

        /// <summary>
        /// Devuelve el primer registro del resultado de la consulta a la base de datos en forma de renglón de datos.
        /// </summary>
        /// <param name="query">Consulta que se envía a la base de datos</param>
        /// <returns>Primer renglón del resultado</returns>
        private DataRow FirstRowQuery(string query)
        {
            return TableQuery(query).Rows[0];
        }

        private int NonQuery(string query)
        {
            cmd = new SqlCommand(query, conn);
            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            return rows;
        }
    }
}
