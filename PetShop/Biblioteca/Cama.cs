using System.Text;

namespace Entidades
{
    public sealed class Cama : Producto
    {
        #region "Atributo"
        private ETamanio tamanio;
        #endregion

        #region "Constructor"
        /// <summary>
        /// Constructor sin parámetros de la clase Cama.
        /// </summary>
        public Cama()
        {

        }

        /// <summary>
        /// Constructor con parámetros de la clase Cama.
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="nombre"></param>
        /// <param name="detalle"></param>
        /// <param name="stock"></param>
        /// <param name="precio"></param>
        /// <param name="kilogramos"></param>
        public Cama(string marca, string nombre, string detalle, int stock, double precio, double kilogramos) : base(marca, nombre, detalle, stock, precio, kilogramos)
        {

        }

        /// <summary>
        /// Constructor con parámetros de la clase Cama.
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="nombre"></param>
        /// <param name="detalle"></param>
        /// <param name="precio"></param>
        /// <param name="kilogramos"></param>
        /// <param name="tamanio"></param>
        public Cama(string marca, string nombre, string detalle, double precio, double kilogramos, ETamanio tamanio) : base(marca, nombre, detalle, precio, kilogramos)
        {
            this.tamanio = tamanio;
        }

        /// <summary>
        /// Constructor con parámetros de la clase Cama.
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="nombre"></param>
        /// <param name="detalle"></param>
        /// <param name="cantidad"></param>
        /// <param name="precio"></param>
        /// <param name="kilogramos"></param>
        /// <param name="tamanio"></param>
        public Cama(string marca, string nombre, string detalle, int cantidad, double precio, double kilogramos,  ETamanio tamanio) : base(marca, nombre, detalle, cantidad, precio, kilogramos)
        {
            this.tamanio = tamanio;
        }
        #endregion

        #region "Propiedades"

        public ETamanio Tamanio
        {
            get
            {
                return this.tamanio;
            }
            set
            {
                this.tamanio = value;
            }
        }

        #endregion

        #region "Enumerados"
        public enum ETamanio
        {
            Grande,
            Chico
        }
        #endregion

        #region "Utils"
        /// <summary>
        /// muestra informacion del objeto
        /// </summary>
        /// <returns>muestra informacion del objeto</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{base.ToString() } | {this.tamanio}");
            return sb.ToString();
        }


        /// <summary>
        /// Conversion explicita
        /// </summary>
        /// <param name="juguete"></param>
        public static explicit operator Cama(Juguete  juguete)
        {
            Cama cama = new Cama( juguete.Marca, juguete.Nombre, juguete.Descripcion, juguete.Cantidad, juguete.Precio, juguete.Kilogramos); 
            return cama;
        }


        /// <summary>
        /// Conversion explicita
        /// </summary>
        /// <param name="alimento"></param>
        public static explicit operator Cama(Alimento alimento)
        {
            Cama cama = new Cama(alimento.Marca, alimento.Nombre, alimento.Descripcion, alimento.Cantidad, alimento.Precio, alimento.Kilogramos);
            return cama;
        }

        /// <summary>
        /// Conversion explicita
        /// </summary>
        /// <param name="articulos"></param>
        public static explicit operator Cama(ArtCuidadoMascota articulos)
        {
            Cama cama = new Cama(articulos.Marca, articulos.Nombre, articulos.Descripcion, articulos.Cantidad, articulos.Precio, articulos.Kilogramos);
            return cama;
        }


        #endregion
    }
}
