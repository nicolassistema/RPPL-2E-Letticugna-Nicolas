using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Cliente : Persona
    {
        #region "Atributos"
        private int idCliente;
        private double saldo;
        #endregion

        #region "Constructores"
        /// <summary>
        /// Constructor sin parámetros de la clase cliente.
        /// </summary>
        public Cliente() : base()
        {


        }

        /// <summary>
        /// Constructor con parámetros de la clase cliente.
        /// </summary>
        /// <param name="cuit"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        public Cliente(string cuit, string nombre, string apellido) : base(cuit, nombre, apellido)
        {
            this.idCliente = IdAutoIncremental();

        }

        /// <summary>
        /// Constructor con parámetros de la clase cliente.
        /// </summary>
        /// <param name="cuit"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="saldo"></param>
        public Cliente(string cuit, string nombre, string apellido, double saldo) : base(cuit, nombre, apellido)
        {
            this.idCliente = IdAutoIncremental();
            this.saldo = saldo;
        }
        #endregion

        #region "Propiedades"
        /// <summary>
        /// Propiedad
        /// </summary>
        public int IdCliente
        {
            get
            {
                return this.idCliente;
            }
            set
            {
                this.idCliente = value;
            }
        }

        /// <summary>
        /// Propiedad
        /// </summary>
        public double Saldo
        {
            get
            {
                return this.saldo;
            }
            set
            {
                this.saldo = value;
            }
        }
        #endregion

        #region "Enumerados"
        public enum ETipoPago
        {
            MercadoPago,
            Efectivo,
            TarjetaDebito
        }
        #endregion

        #region "Operadores"

        /// <summary>
        /// Sobre carga de operador
        /// </summary>
        /// <param name="clientes"></param>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public static List<Cliente> operator +(List<Cliente> clientes, Cliente cliente)
        {
            if (clientes != cliente)
            {
                clientes.Add(cliente);
                return PetShop.Cliente;
            }
            else
                return PetShop.Cliente;
        }

        /// <summary>
        /// Sobre carga de operador
        /// </summary>
        /// <param name="clientes"></param>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public static List<Cliente> operator -(List<Cliente> clientes, Cliente cliente)
        {

            if (clientes == cliente)
            {
                clientes.Remove(cliente);
                return clientes;
            }
            else
                return clientes;
        }

        /// <summary>
        /// Sobre carga de operador
        /// </summary>
        /// <param name="clientes"></param>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public static bool operator ==(List<Cliente> clientes, Cliente cliente)
        {
            foreach (Cliente auxCliente in PetShop.Cliente)
            {
                if (cliente == auxCliente)
                    return true;
            }

            return false;
        }


        /// <summary>
        /// Sobre carga de operador
        /// </summary>
        /// <param name="clientes"></param>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public static bool operator !=(List<Cliente> clientes, Cliente cliente)
        {
            return !(clientes == cliente);
        }

        #endregion

        #region "Utils"

        /// <summary>
        /// Muestra la informacion del cliente
        /// </summary>
        /// <returns>Devuelve un mensaje</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            return sb.ToString();
        }

        /// <summary>
        /// Genera un id autoIncremental
        /// </summary>
        /// <returns>Devuelve el id autoincrementedo</returns>
        public int IdAutoIncremental()
        {
            for (int i = 0; i <= PetShop.ObtenerListaCliente().Count; i++)
            {
                IdCliente = i + 1;
            }
            return IdCliente;
        }
        #endregion
    }
}
