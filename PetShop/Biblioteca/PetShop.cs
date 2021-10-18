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



        static PetShop()
        {
            //   Usuario = new List<Usuario>();
            Descuento = new Stack<Producto>();
            Usuario = new Dictionary<string, Usuario>();
            Producto = new List<Producto>();
            Cliente = new List<Cliente>();
            Ventas = new List<Venta>();
            usuario = new Usuario();
            listaProductosWork = new List<Producto>();
            HarcodearListas();
        }


        public static void HarcodearListas()
        {
            HarcodDescuentos();
            HardcodUsuariosClaveValor();
            //HardcodUsuarios();
            HardcodProductos();
            HardcodClientes();
            HardcodVentas();
        }

      

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



        public static Dictionary<string,Usuario> Usuario
        {
            get { return listaUsuariosClaveValor; }
            set { listaUsuariosClaveValor = value; }
        }



        //public static List<Usuario> Usuario
        //{
        //    get
        //    {
        //        return listaUsuarios;
        //    }
        //    set
        //    {
        //        listaUsuarios = value;
        //    }
        //}

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

        //private static void HardcodUsuarios()//diccionario
        //{
        // //   listaUsuarios += (new Usuario("20323205109", "Nicolas", "Letticugna", "pepe", "123", Entidades.Usuario.EPerfilUsuario.Empleado));
        //    listaUsuarios += (new Usuario("20323205109", "Nicolas", "Letticugna", "pepe", "123", Entidades.Usuario.EPerfilUsuario.Empleado));
        //    listaUsuarios += (new Usuario("20323205117", "Pedro", "Gomez", "pipo", "123", Entidades.Usuario.EPerfilUsuario.Empleado));
        //    listaUsuarios += (new Usuario("20323205125", "lolo", "Lopez", "admin", "admin", Entidades.Usuario.EPerfilUsuario.Admin));
        //    listaUsuarios += (new Usuario("20323205133", "Juan", "Lopez", "pupu", "123", Entidades.Usuario.EPerfilUsuario.Empleado));
        //}


        private static void HardcodUsuariosClaveValor()//diccionario
        {
            listaUsuariosClaveValor.Add ("20323205109", new Usuario("20323205109", "Nicolas", "Letticugna", "pepe", "123", Entidades.Usuario.EPerfilUsuario.Empleado));
            listaUsuariosClaveValor.Add("20323205117",new Usuario("20323205117", "Pedro", "Gomez", "pipo", "123", Entidades.Usuario.EPerfilUsuario.Empleado));
            listaUsuariosClaveValor.Add("20323205125", new Usuario("20323205125", "lolo", "Lopez", "admin", "admin", Entidades.Usuario.EPerfilUsuario.Admin));
            listaUsuariosClaveValor.Add("20323205133", new Usuario("20323205133", "Juan", "Lopez", "pupu", "123", Entidades.Usuario.EPerfilUsuario.Empleado));
        }




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


        private static void HarcodDescuentos()
        {
            listaDescuentos.Push ( new Cama("Cama pepito", "Cama lalala", "Cama grande descripcion",  11.11,20, Cama.ETamanio.Grande));
            listaDescuentos.Push(new Juguete("juguete pepito", "juguete  lalala", "juguete grande descripcion",  33.33,20, Juguete.EMaterial.Plastico));
            listaDescuentos.Push(new Alimento("Alimento pepito", "Alimento  lalala", "Alimento grande descripcion", 66.66,20, Alimento.ETipoAlimento.Balanceado));
        }
  


        private static void HardcodClientes()
        {
            listaClientes += (new Cliente("20323206008", "menagno", "lopez", 0));
            listaClientes += (new Cliente("20323206016", "sultano", "lopez", 0));
            listaClientes += (new Cliente("20323205109", "Fernando", "Talarga", 0));
            listaClientes += (new Cliente("20323206059", "fefe", "lopez", 0));
        }

        private static void HardcodVentas()
        {
            Producto prod1 = new Producto(1, "Dog Chow", "Dog Chow", 4000);

            listaVentas += (new Venta(new Usuario("123456789", "Lucas", "Rodriguez", "admin", "admin", Entidades.Usuario.EPerfilUsuario.Admin), new Cliente("20333232326", "Cosme", "Fulanito", 0), new List<Producto> { prod1 }));
            listaVentas += (new Venta(new Usuario("123456789", "Nicolas", "Letticugna", "lrodriguez", "lucas2021", Entidades.Usuario.EPerfilUsuario.Admin), new Cliente("20333232326", "Cosme", "Fulanito", 0), new List<Producto> { prod1 }));
            listaVentas += (new Venta(new Usuario("123456789", "Caro", "LaScrofani", "admin", "admin", Entidades.Usuario.EPerfilUsuario.Admin), new Cliente("20333232326", "Cosme", "Fulanito", 0), new List<Producto> { prod1 }));
            listaVentas += (new Venta(new Usuario("123456789", "bobo", "esponja", "admin", "admin", Entidades.Usuario.EPerfilUsuario.Admin), new Cliente("20333232326", "Cosme", "Fulanito", 0), new List<Producto> { prod1 }));
        }

        public static List<Venta> ObtenerListaVentas()
        {
            return listaVentas;
        }

        public static List<Cliente> ObtenerListaCliente()
        {
            return listaClientes;
        }

        public static void AddCliente(Cliente cliente)
        {
            listaClientes += cliente;
        }

        public static void AddProducto(Producto producto)
        {
            listaProductos += producto;
        }

        public static Dictionary<string, Usuario> ObtenerListaUsuarios()
        {
            return listaUsuariosClaveValor;
        }

        public static void AddUsuario(Usuario usuario)
        {
            listaUsuariosClaveValor.Add(usuario.Cuit,usuario);
        }

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



        public static List<Producto> ObtenerPorductos()
        {
            return listaProductos;
        }

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

        public static void LimpiarListaProductos()
        {
            listaProductos.Clear();
        }

        public static void LimpiarListaUsarios()
        {
            listaUsuariosClaveValor.Clear();
        }

        public static void LimpiarListaClientes()
        {
            listaClientes.Clear();
        }

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
