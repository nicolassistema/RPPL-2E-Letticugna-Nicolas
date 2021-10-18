using System.Collections.Generic;
using System.Text;
using System.Timers;
using System.Linq;

namespace Entidades
{
    public class Venta
    {

        List<Producto> productos;
        Cliente cliente;
        Usuario usuario;
        int numeroFactura;
        double montoTotal;
        double montoEnvio;
        double montoTipoEnvio;

        /// <summary>
        /// Constructor sin parámetros de la clase Venta.
        /// </summary>
        public Venta()
        {
            productos = new List<Producto>();
        }


        /// <summary>
        /// Constructor con parámetros de la clase Venta.
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="cliente"></param>
        /// <param name="monto"></param>
        /// <param name="productos"></param>
        /// <param name="montoEnvio"></param>
        /// <param name="montoTipoEnvio"></param>
        public Venta(Usuario usuario, Cliente cliente, double monto, List<Producto> productos, double montoEnvio, double montoTipoEnvio) : this()
        {
            this.NumeroFactura = IdFacturacionAutoIncremental();
            this.Cliente = cliente;
            this.MontoTotal = monto;
            this.Usuario = usuario;
            this.productos = productos;
            this.montoEnvio = montoEnvio;
            this.montoTipoEnvio = montoTipoEnvio;
        }


        /// <summary>
        /// Constructor con parámetros de la clase Venta.
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="cliente"></param>
        /// <param name="productos"></param>
        public Venta(Usuario usuario, Cliente cliente, List<Producto> productos) : this()
        {
            this.NumeroFactura = IdFacturacionAutoIncremental();
            this.Cliente = cliente;
            this.productos = productos;
            this.MontoTotal = CalcularMontoTotal();
            this.Usuario = usuario;

        }
        #region "Propiedades"
        /// <summary>
        /// Propiedad MontoTipoEnvio
        /// </summary>
        public double MontoTipoEnvio
        {
            get
            {
                return this.montoTipoEnvio;
            }
            set
            {
                this.montoTipoEnvio = value;
            }
        }


        /// <summary>
        /// propiedad MontoEnvio
        /// </summary>
        public double MontoEnvio
        {
            get
            {
                return this.montoEnvio;
            }
            set
            {
                this.montoEnvio = value;
            }
        }


        /// <summary>
        /// propiedad MontoTotal
        /// </summary>
        public double MontoTotal
        {
            get
            {
                return this.montoTotal;
            }
            set
            {
                this.montoTotal = value;
            }
        }


        /// <summary>
        /// propiedad NumeroFactura
        /// </summary>
        public int NumeroFactura
        {
            get
            {
                return this.numeroFactura;
            }
            set
            {
                this.numeroFactura = value;
            }
        }


        /// <summary>
        /// propiedad Cliente
        /// </summary>
        public Cliente Cliente
        {
            get
            {
                return cliente;
            }
            set
            {
                cliente = value;
            }
        }


        /// <summary>
        /// propiedad Usuario
        /// </summary>
        public Usuario Usuario
        {
            get
            {
                return usuario;
            }
            set
            {
                usuario = value;
            }
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Verifica que el producto se encuentre en la lista de ventas
        /// </summary>
        /// <param name="productos"></param>
        /// <param name="producto"></param>
        /// <returns>Devuelve true si el prodcuto si se encuentra en la lista de venta</returns>
        public static bool operator ==(List<Venta> productos, Venta producto)
        {
            foreach (Venta auxProducto in productos)
            {
                if (producto == auxProducto)
                    return true;
            }
            return false;
        }


        /// <summary>
        /// Verifica que el producto NO se encuentre en la lista de ventas
        /// </summary>
        /// <param name="productos"></param>
        /// <param name="producto"></param>
        /// <returns>Devuelve true si el prodcuto NO se encuentre en la lista de venta</returns>
        public static bool operator !=(List<Venta> productos, Venta producto)
        {
            return !(productos == producto);
        }


        public static List<Venta> operator +(List<Venta> ventas, Venta venta)
        {
            if (ventas != venta)
            {
                ventas.Add(venta);
                return ventas;
            }
            return ventas;
        }
        #endregion

        #region "Utils"
        /// <summary>
        /// Incrementea el id de la factura
        /// </summary>
        /// <returns>devuelve el id incrementado</returns>
        public int IdFacturacionAutoIncremental()
        {
            for (int i = 0; i <= PetShop.ObtenerListaVentas().Count; i++)
            {
                this.numeroFactura = i + 1;
            }
            return this.numeroFactura;
        }


        /// <summary>
        /// Suma el total por porducto
        /// </summary>
        /// <param name="productos"></param>
        /// <param name="producto"></param>
        /// <returns>devuelve la suma</returns>
        public double SumaTotalPorProducto(List<Producto> productos, Producto producto)
        {
            double aux = 0;
            foreach (var item in productos)
            {
                if (producto.Codigo == item.Codigo)
                {
                    aux += item.Precio;
                }
            }
            return aux;
        }


        /// <summary>
        /// cuenta la cantidad de porductos de la lista
        /// </summary>
        /// <param name="productos"></param>
        /// <param name="producto"></param>
        /// <returns>devuelve al cantidad</returns>
        public int CantidadPorProducto(List<Producto> productos, Producto producto)
        {
            int cantidad = 0;
            foreach (var item in productos)
            {
                if (producto.Codigo == item.Codigo)
                {
                    cantidad++;
                }
            }
            return cantidad;
        }


        /// <summary>
        /// Muestra el resumen de la venta en un string simil impresion de ticket 
        /// </summary>
        /// <returns>Mdevuelve  el resumen de la venta en un string simil impresion de ticket </returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("------------------------------------------------");
            sb.AppendLine("C.  CONCEPTO                PRECIO      IMPORTE");
            sb.AppendLine("------------------------------------------------");

            var totales = from d in productos
                          group d by new { d.Codigo, d.Nombre, d.Precio } into totals
                          select new
                          {
                              codigo = totals.Key,
                              Nombre = totals.Key.Nombre,
                              nombre = totals.Key.Nombre,
                              Precio = totals.Key.Precio,
                              Total = totals.Sum(c => c.Precio),
                              cant = totals.Count()
                          };
            foreach (var total in totales)
            {
                sb.AppendLine(" " + total.cant.ToString() + "   " + total.Nombre.ToString() + "      $" + string.Format("{0:f2}", total.Precio) + "         $" + string.Format("{0:f2}", total.Total));
            }
            sb.AppendLine("------------------------------------------------");
            if (this.montoEnvio != 0)
            {
                if (!(this.montoTipoEnvio == 500))
                {
                    sb.AppendLine($"      Costo de envio (Moto): $ {this.montoTipoEnvio}");
                }
                else
                {
                    sb.AppendLine($"          Costo de envio (Miniflete): $ {this.montoTipoEnvio}");
                }
                sb.AppendLine($"              Costo por Cant. Cuadras: ${this.montoEnvio}");
                sb.AppendLine($"                     Costo Total de envio: ${this.montoEnvio + this.montoTipoEnvio}");
            }
            else
            {
                sb.AppendLine($"                 Sin Envio   ");
            }
            sb.AppendLine("------------------------------------------------");
            sb.AppendLine("   TODOS LOS PROD. CON I.V.A. INCLUD.     ");
            sb.AppendLine("------------------------------------------------");
            sb.AppendLine("                           TOTAL : $" + string.Format("{0:f2}", this.montoTotal));
            sb.AppendLine("------------------------------------------------");
            sb.AppendLine($"Fue atendid@ por: {usuario.Nombre} {usuario.Apellido}");
            return sb.ToString();
        }


        /// <summary>
        /// Calcular el monto total de los importes
        /// </summary>
        /// <returns>devuelve el monto total</returns>
        public double CalcularMontoTotal()
        {
            double monto = 0;
            for (int i = 0; i < productos.Count; i++)
            {
                monto += productos[i].Precio;
            }
            return monto;
        }


        /// <summary>
        /// muestar el objetos
        /// </summary>
        /// <returns>muestra el objeto</returns>
        public string MostrarFactura()
        {
            return ToString();
        }

        #endregion
    }
}
