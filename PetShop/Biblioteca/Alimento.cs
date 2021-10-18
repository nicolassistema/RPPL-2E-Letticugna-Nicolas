using System.Text;

namespace Entidades
{
    public class Alimento : Producto
    {

        private ETipoAlimento tipoAlimento;

        /// <summary>
        /// Constructor sin parámetros de la clase alimento.
        /// </summary>
        public Alimento()
        {

        }

        /// <summary>
        /// Constructor con parámetros de la clase Alimento.
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="nombre"></param>
        /// <param name="detalle"></param>
        /// <param name="stock"></param>
        /// <param name="precio"></param>
        /// <param name="kilogramos"></param>
        public Alimento(string marca, string nombre, string detalle, int stock, double precio, double kilogramos) : base(marca, nombre, detalle, stock, precio, kilogramos)
        {

        }


        /// <summary>
        /// Constructor con parámetros de la clase Alimento.
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="nombre"></param>
        /// <param name="detalle"></param>
        /// <param name="precio"></param>
        /// <param name="kilogramos"></param>
        /// <param name="tipoAlimento"></param>
        public Alimento(string marca, string nombre, string detalle, double precio, double kilogramos, ETipoAlimento tipoAlimento) : base(marca, nombre, detalle, precio, kilogramos)
        {
            this.tipoAlimento = tipoAlimento;
        }


        /// <summary>
        /// Constructor con parámetros de la clase Alimento.
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="nombre"></param>
        /// <param name="detalle"></param>
        /// <param name="cantidad"></param>
        /// <param name="precio"></param>
        /// <param name="kilogramos"></param>
        /// <param name="tipoAlimento"></param>
        public Alimento(string marca, string nombre, string detalle, int cantidad, double precio, double kilogramos, ETipoAlimento tipoAlimento) : base(marca, nombre, detalle, cantidad, precio, kilogramos)
        {
            this.tipoAlimento = tipoAlimento;
        }

        /// <summary>
        /// Enumerado
        /// </summary>
        public enum ETipoAlimento
        {
            Balanceado,
            Natural
        }

        /// <summary>
        /// enumarado
        /// </summary>
        public ETipoAlimento TipoAlimento
        {
            get
            {
                return this.tipoAlimento;
            }
            set
            {
                this.tipoAlimento = TipoAlimento;
            }
        }


        /// <summary>
        /// muestra informacion del objeto
        /// </summary>
        /// <returns>muestra informacion del objeto</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"{this.tipoAlimento} | {this.Cantidad}");
            return sb.ToString();
        }


        /// <summary>
        /// Conversion explicita
        /// </summary>
        /// <param name="cama"></param>
        public static explicit operator Alimento(Cama cama)
        {
            Alimento alimento = new Alimento(cama.Marca, cama.Nombre, cama.Descripcion, cama.Cantidad, cama.Precio, cama.Kilogramos);
            return alimento;
        }

        /// <summary>
        /// Conversion explicita
        /// </summary>
        /// <param name="articulo"></param>
        public static explicit operator Alimento(ArtCuidadoMascota articulo)
        {
            Alimento alimento = new Alimento(articulo.Marca, articulo.Nombre, articulo.Descripcion, articulo.Cantidad, articulo.Precio, articulo.Kilogramos);
            return alimento;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="jueguete"></param>
        public static explicit operator Alimento(Juguete jueguete)
        {
            Alimento alimento = new Alimento(jueguete.Marca, jueguete.Nombre, jueguete.Descripcion, jueguete.Cantidad, jueguete.Precio, jueguete.Kilogramos);
            return alimento;
        }

    }
}
