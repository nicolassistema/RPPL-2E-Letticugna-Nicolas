using System;
using System.Collections.Generic;
using System.Linq;

namespace Entidades
{
    public static class PetShop
    {

        private const int CP_NOCLOSE_BUTTON = 0x200;
        static List<Usuario> listaUsuarios;
        public static List<Producto> listaProductos;
        public static Dictionary<string, Usuario> listaUsuariosClaveValor;
        public static Stack<Producto> listaDescuentos;

        static List<Producto> listaProductosWork;
        static List<Cliente> listaClientes;
        public static List<Venta> listaVentas;
        public static List<Facturacion> listaFacturas;
        static Usuario usuario;
        static Venta venta;


        /// <summary>
        /// Constructor sin parámetros de la clase PetShop.
        /// </summary>
        static PetShop()
        {
            Descuento = new Stack<Producto>();
            Usuario = new Dictionary<string, Usuario>();
            Producto = new List<Producto>();
            Cliente = new List<Cliente>();
            Ventas = new List<Venta>();
            usuario = new Usuario();
            listaProductosWork = new List<Producto>();
            HarcodearListas();
        }

        /// <summary>
        /// Harcodeo de datos
        /// </summary>
        public static void HarcodearListas()
        {
            HarcodDescuentos();
            HardcodUsuariosClaveValor();
            HardcodProductos();
            HardcodClientes();
            HardcodVentas();
        }


        /// <summary>
        /// Propuiedad del Stack
        /// </summary>
        public static Stack<Producto> Descuento
        {
            get
            {
                return listaDescuentos;
            }
            set
            {
                listaDescuentos = value;
            }
        }


        /// <summary>
        /// Propiedad del dicicionario
        /// </summary>
        public static Dictionary<string, Usuario> Usuario
        {
            get { return listaUsuariosClaveValor; }
            set { listaUsuariosClaveValor = value; }
        }


        /// <summary>
        /// Pripiedad de la lista
        /// </summary>
        public static List<Producto> Producto
        {
            get
            {
                return listaProductos;
            }
            set
            {
                listaProductos = value;
            }
        }



        /// <summary>
        /// Pripiedad de la lista
        /// </summary>
        public static List<Cliente> Cliente
        {
            get
            {
                return listaClientes;
            }
            set
            {
                listaClientes = value;
            }
        }



        /// <summary>
        /// Pripiedad de la lista
        /// </summary>
        public static List<Venta> Ventas
        {
            get
            {
                return listaVentas;
            }
            set
            {
                listaVentas = value;
            }
        }


        /// <summary>
        /// Harcodeo de usuarios
        /// </summary>
        private static void HardcodUsuariosClaveValor()
        {
            listaUsuariosClaveValor.Add("20323205109", new Usuario("20323205109", "Nicolas", "Letticugna", "pepe", "123", Entidades.Usuario.EPerfilUsuario.Empleado));
            listaUsuariosClaveValor.Add("20323205117", new Usuario("20323205117", "Pedro", "Gomez", "pipo", "123", Entidades.Usuario.EPerfilUsuario.Empleado));
            listaUsuariosClaveValor.Add("20323205125", new Usuario("20323205125", "lolo", "Lopez", "admin", "admin", Entidades.Usuario.EPerfilUsuario.Admin));
            listaUsuariosClaveValor.Add("20323205133", new Usuario("20323205133", "Juan", "Lopez", "pupu", "123", Entidades.Usuario.EPerfilUsuario.Empleado));
        }



        /// <summary>
        /// Harcodeo de productos
        /// </summary>
        private static void HardcodProductos()
        {
            listaProductos += (new Cama("Cama pepito           ", "Cama lalala", "Cama grande descripcion", 35, 11.11, 20, Cama.ETamanio.Grande));
            listaProductos += (new Cama("Cama  pepito          ", "Cama lalala", "Cama grande descripcion", 35, 22.22, 15, Cama.ETamanio.Chico));
            listaProductos += (new Juguete("juguete pepito        ", "juguete  lalala", "juguete grande descripcion", 35, 33.33, 3, Juguete.EMaterial.Plastico));
            listaProductos += (new Juguete("juguete pepito        ", "juguete lalala", "juguete grande descripcion", 35, 44.44, 3, Juguete.EMaterial.Goma));
            listaProductos += (new Alimento("Alimento pepito       ", "Alimento  lalala", "Alimento grande descripcion", 35, 55.55, 3, Alimento.ETipoAlimento.Natural));
            listaProductos += (new Alimento("Alimento pepito       ", "Alimento  lalala", "Alimento grande descripcion", 35, 66.66, 3, Alimento.ETipoAlimento.Balanceado));
            listaProductos += (new ArtCuidadoMascota("Farmacia pepito       ", "Farmacia  lalala", "farmacia grande descripcion", 35, 77.77, 3, ArtCuidadoMascota.ETipoCuidado.Farmacia));
            listaProductos += (new ArtCuidadoMascota("Farmacia pepito      ", "Farmacia  lalala", "Limpieza grande descripcion", 35, 88.05, 3, ArtCuidadoMascota.ETipoCuidado.Limpieza));
        }


        /// <summary>
        /// Harcodeo de descuentos
        /// </summary>
        private static void HarcodDescuentos()
        {
            listaDescuentos.Push(new Cama("Cama pepito", "Cama lalala", "Cama grande descripcion", 11.11, 20, Cama.ETamanio.Grande));
            listaDescuentos.Push(new Juguete("juguete pepito", "juguete  lalala", "juguete grande descripcion", 33.33, 20, Juguete.EMaterial.Plastico));
            listaDescuentos.Push(new Alimento("Alimento pepito", "Alimento  lalala", "Alimento grande descripcion", 66.66, 20, Alimento.ETipoAlimento.Balanceado));
        }


        /// <summary>
        /// Harcodeo de clientes
        /// </summary>
        private static void HardcodClientes()
        {
            listaClientes += (new Cliente("20323206008", "menagno", "lopez", 0));
            listaClientes += (new Cliente("20323206016", "sultano", "lopez", 0));
            listaClientes += (new Cliente("20323205109", "Fernando", "Talarga", 0));
            listaClientes += (new Cliente("20323206059", "fefe", "lopez", 0));
        }


        /// <summary>
        /// Harcodeo de ventas
        /// </summary>
        private static void HardcodVentas()
        {
            Producto prod1 = new Producto(1, "Dog Chow", "Dog Chow", 4000);
            listaVentas += (new Venta(new Usuario("123456789", "Lucas", "Rodriguez", "admin", "admin", Entidades.Usuario.EPerfilUsuario.Admin), new Cliente("20333232326", "Cosme", "Fulanito", 0), new List<Producto> { prod1 }));
            listaVentas += (new Venta(new Usuario("123456789", "Nicolas", "Letticugna", "lrodriguez", "lucas2021", Entidades.Usuario.EPerfilUsuario.Admin), new Cliente("20333232326", "Cosme", "Fulanito", 0), new List<Producto> { prod1 }));
            listaVentas += (new Venta(new Usuario("123456789", "Caro", "LaScrofani", "admin", "admin", Entidades.Usuario.EPerfilUsuario.Admin), new Cliente("20333232326", "Cosme", "Fulanito", 0), new List<Producto> { prod1 }));
            listaVentas += (new Venta(new Usuario("123456789", "bobo", "esponja", "admin", "admin", Entidades.Usuario.EPerfilUsuario.Admin), new Cliente("20333232326", "Cosme", "Fulanito", 0), new List<Producto> { prod1 }));
        }


        /// <summary>
        /// Obetener lista venta
        /// </summary>
        /// <returns>lista</returns>
        public static List<Venta> ObtenerListaVentas()
        {
            return listaVentas;
        }


        /// <summary>
        /// Obtener lista cliente
        /// </summary>
        /// <returns>lista</returns>
        public static List<Cliente> ObtenerListaCliente()
        {
            return listaClientes;
        }


        /// <summary>
        /// Suna el objeto cliente a la lista de objetos cliente por medio de sobrecarga de operador
        /// </summary>
        /// <param name="cliente"></param>
        public static void AddCliente(Cliente cliente)
        {
            listaClientes += cliente;
        }

        /// <summary>
        /// Suna el objeto cliente a la lista de objetos prodcuto por medio de sobrecarga de operador
        /// </summary>
        /// </summary>
        /// <param name="producto"></param>
        public static void AddProducto(Producto producto)
        {
            listaProductos += producto;
        }


        /// <summary>
        /// Obtener lista de usarios
        /// </summary>
        /// <returns>diccionario</returns>
        public static Dictionary<string, Usuario> ObtenerListaUsuarios()
        {
            return listaUsuariosClaveValor;
        }


        /// <summary>
        /// Suna el objeto usuario a diccionario de objetos usuario
        /// </summary>
        /// <param name="usuario"></param>
        public static void AddUsuario(Usuario usuario)
        {
            listaUsuariosClaveValor.Add(usuario.Cuit, usuario);
        }


        /// <summary>
        /// Obtener usaurio
        /// </summary>
        /// <param name="usuarioNombre"></param>
        /// <param name="password"></param>
        /// <returns>usuario</returns>
        public static Usuario ObtenerUsuario(string usuarioNombre, string password)
        {
            Dictionary<string, Usuario> auxList = PetShop.Usuario;
            foreach (var item in auxList)
            {
                if (item.Value.NameUsuario == usuarioNombre && item.Value.PassUsuario == password)
                {
                    return item.Value;
                }
            }

            return null;
        }

        /// <summary>
        /// Obtiene un usuario por medio del cuil
        /// </summary>
        /// <param name="cuit"></param>
        /// <returns>usuario</returns>
        public static Usuario ObtenerUsuarioByCuit(string cuit)
        {
            Dictionary<string, Usuario> auxList = PetShop.Usuario;
            foreach (var item in auxList)
            {
                if (item.Value.Cuit == cuit)
                {
                    return item.Value;
                    break;
                }
            }
            return null;
        }


        /// <summary>
        /// obtiene un cliente por medio del cuil
        /// </summary>
        /// <param name="cuit"></param>
        /// <returns>cliente</returns>
        public static Cliente ObtenerClienteByCuit(string cuit)
        {
            List<Cliente> auxList = PetShop.Cliente;
            foreach (var item in auxList)
            {
                if (item.Cuit == cuit)
                {
                    return item;
                    break;
                }
            }

            return null;
        }

        /// <summary>
        /// valida el cuit del usuario
        /// </summary>
        /// <param name="cuit"></param>
        /// <returns>true si esta, false si no</returns>
        public static bool ValidaUsuarioExistenteByCuit(string cuit)
        {
            Dictionary<string, Usuario> auxList = PetShop.Usuario;
            foreach (var item in auxList)
            {
                if (item.Value.Cuit == cuit)
                {
                    return true;
                    break;
                }
            }
            return false;
        }


        /// <summary>
        /// valida el cuit del cliente
        /// </summary>
        /// <param name="cuit"></param>
        /// <returns>true si esta, false si no</returns>
        public static bool ValidaClienteExistenteByCuit(string cuit)
        {
            List<Cliente> auxList = PetShop.Cliente;
            foreach (var item in auxList)
            {
                if (item.Cuit == cuit)
                {
                    return true;
                    break;
                }
            }
            return false;
        }


        /// <summary>
        /// obtiene un produto de la lista
        /// </summary>
        /// <param name="id"></param>
        /// <returns>producto</returns>
        public static Producto ObtenerProductoByID(int id)
        {
            List<Producto> auxList = PetShop.Producto;
            foreach (var item in auxList)
            {
                if (item.Codigo == id)
                {
                    return item;
                }
            }
            return null;
        }


        /// <summary>
        /// elimina el producto de la lista
        /// </summary>
        /// <param name="producto"></param>
        /// <returns>lista actualizada</returns>
        public static List<Producto> ItemProductUpdate(Producto producto)
        {
            foreach (var item in PetShop.ObtenerPorductos())
            {
                if (producto.Codigo == item.Codigo)
                {
                    PetShop.EliminarProducto(item);
                    PetShop.AddProducto(producto);
                    break;
                }
            }
            return PetShop.ObtenerPorductos();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns>obtiene la lista de prodcutos</returns>
        public static List<Producto> ObtenerPorductos()
        {
            return listaProductos;
        }


        /// <summary>
        /// Eliminar el producto
        /// </summary>
        /// <param name="producto"></param>
        /// <returns>true si pudo eliminar, false si no</returns>
        public static bool EliminarProducto(Producto producto)
        {
            List<Producto> auxList = PetShop.Producto;
            foreach (var item in auxList)
            {
                if (item == producto)
                {
                    auxList.Remove(item);
                    return true;
                }
            }
            return false;
        }


        /// <summary>
        /// Eliminar usuario y devolver la lista actualizada
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns>Devolver la lista de usuarios actualizada</returns>
        public static bool EliminarUsuario(Usuario usuario)
        {
            Dictionary<string, Usuario> auxList = PetShop.Usuario;
            foreach (var item in auxList)
            {
                if (item.Key == usuario.Cuit)
                {
                    auxList.Remove(item.Key);
                    return true;
                }
            }
            return false;
        }


        /// <summary>
        /// Limpiar la lista de productos
        /// </summary>
        public static void LimpiarListaProductos()
        {
            listaProductos.Clear();
        }


        /// <summary>
        /// Limpiar la lista de usuarios
        /// </summary>
        public static void LimpiarListaUsarios()
        {
            listaUsuariosClaveValor.Clear();
        }


        /// <summary>
        /// Limpiar la lista de clientes
        /// </summary>
        public static void LimpiarListaClientes()
        {
            listaClientes.Clear();
        }

        /// <summary>
        /// Limpiar la lista de productos y la vuelva a cargar con la lista pasada por parametro
        /// </summary>
        /// <param name="listaProductosAux"></param>
        /// <returns>Devuelve la lista que fue cragada por parametro</returns>
        public static List<Producto> CargarListaNuevamenteProducto(List<Producto> listaProductosAux)
        {
            if (!(listaProductosAux is null))
            {
                LimpiarListaProductos();
                foreach (var item in listaProductosAux)
                {
                    AddProducto(item);
                }
                return ObtenerPorductos();
            }
            return null;
        }


        /// <summary>
        /// Limpiar la lista de usuarios y la vuelve a cargar con la que se pasa por parametro
        /// </summary>
        /// <param name="listaUsuariosAux"></param>
        /// <returns>Devuelve la lista que se paso por parametro</returns>
        public static Dictionary<string, Usuario> CargarListaNuevamente(Dictionary<string, Usuario> listaUsuariosAux)
        {
            if (!(listaUsuariosAux is null))
            {
                LimpiarListaUsarios();
                foreach (var item in listaUsuariosAux)
                {
                    AddUsuario(item.Value);
                }
                return ObtenerListaUsuarios();
            }
            return null;
        }


        /// <summary>
        /// Limpia lista de clientes y se carga con la que se pasa por parametro
        /// </summary>
        /// <param name="listaClienteAux"></param>
        /// <returns>Devuelve la lista cagada por parametro</returns>
        public static List<Cliente> CargarListaNuevamenteClientes(List<Cliente> listaClienteAux)
        {
            if (!(listaClienteAux is null))
            {
                LimpiarListaClientes();
                foreach (var item in listaClienteAux)
                {
                    AddCliente(item);
                }
                return ObtenerListaCliente();
            }
            return null;
        }


        /// <summary>
        /// busca una palabra que este incluida en algunos de los atributos del objeto cliente
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="palabra"></param>
        /// <returns>Devuelve true si la encontro, false si no</returns>
        public static bool BuscarClientePorString(Cliente cliente, string palabra)
        {
            if (cliente.IdCliente.ToString().Contains(palabra) ||
                cliente.Cuit.ToString().Contains(palabra) ||
                cliente.Nombre.ToLower().Contains(palabra) ||
                cliente.Apellido.ToLower().Contains(palabra))
            {
                return true;
            }
            return false;
        }


        /// <summary>
        /// busca una palabra que este incluida en algunos de los atributos del objeto producto
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="palabra"></param>
        /// <returns></returns>
        public static bool BuscarProductoPorString(Producto producto, string palabra)
        {
            if (producto.Codigo.ToString().Contains(palabra) ||
                producto.Marca.ToLower().Contains(palabra) ||
                producto.Nombre.ToLower().Contains(palabra) ||
                producto.Descripcion.ToLower().Contains(palabra) ||
                producto.Descripcion.ToLower().Contains(palabra) ||
                producto.Cantidad.ToString().Contains(palabra) ||
                producto.Precio.ToString().Contains(palabra) ||
                producto.Kilogramos.ToString().Contains(palabra))
            {
                return true;
            }
            return false;
        }

        public static Cliente ObtenerClientePorCuit(string cuit)
        {
            foreach (Cliente item in listaClientes)
            {
                if (item.Cuit == cuit)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
