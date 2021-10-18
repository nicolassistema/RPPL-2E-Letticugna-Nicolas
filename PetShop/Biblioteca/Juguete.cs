using System.Text;

namespace Entidades
{
    public class Juguete : Producto
    {
        #region "Atributos"
        private EMaterial material;
        #endregion

        #region "Constructores"

        /// <summary>
        /// Constructor sin parámetros de la clase Juguete.
        /// </summary>
        public Juguete()
        {

        }


        /// <summary>
        /// Constructor con parámetros de la clase Juguete.
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="nombre"></param>
        /// <param name="detalle"></param>
        /// <param name="stock"></param>
        /// <param name="precio"></param>
        /// <param name="kilogramos"></param>
        public Juguete(string marca, string nombre, string detalle, int stock, double precio, double kilogramos) : base(marca, nombre, detalle, stock, precio, kilogramos)
        {
          
        }


        /// <summary>
        /// Constructor con parámetros de la clase Juguete.
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="nombre"></param>
        /// <param name="detalle"></param>
        /// <param name="precio"></param>
        /// <param name="kilogramos"></param>
        /// <param name="material"></param>
        public Juguete(string marca, string nombre, string detalle,  double precio, double kilogramos, EMaterial material) : base(marca, nombre, detalle,  precio, kilogramos)
        {
            this.material = material;
        }


        /// <summary>
        /// Constructor con parámetros de la clase Juguete.
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="nombre"></param>
        /// <param name="detalle"></param>
        /// <param name="stock"></param>
        /// <param name="precio"></param>
        /// <param name="kilogramos"></param>
        /// <param name="material"></param>
        public Juguete(string marca, string nombre, string detalle, int stock, double precio,double kilogramos, EMaterial material) : base(marca, nombre, detalle, stock, precio, kilogramos)
        {
            this.material = material;
        }
        #endregion

        #region "Propiedades"
        /// <summary>
        /// Setea y devuelve el dato
        /// </summary>
        public EMaterial Material
        {
            get
            {
                return this.material;
            }
            set
            {
                this.material = value;
            }
        }
        #endregion

        #region "Enumerados"
        public enum EMaterial
        {
            Plastico,
            Metal,
            Goma
        }
        #endregion

        #region "Utils"
        /// <summary>
        /// Muestra informacion del juguete
        /// </summary>
        /// <returns> Muestra informacion del juguete</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append($" {this.Nombre}| {this.Precio}");
            return sb.ToString();
        }

        /// <summary>
        /// Conversion explicita
        /// </summary>
        /// <param name="cama"></param>
        public static explicit operator Juguete(Cama cama)
        {
            Juguete juguete = new Juguete(cama.Marca, cama.Nombre, cama.Descripcion, cama.Cantidad, cama.Precio, cama.Kilogramos);
            return juguete;
        }

        /// <summary>
        /// Conversion explicita
        /// </summary>
        /// <param name="alimento"></param>
        public static explicit operator Juguete(Alimento alimento)
        {
            Juguete juguete = new Juguete(alimento.Marca, alimento.Nombre, alimento.Descripcion, alimento.Cantidad, alimento.Precio, alimento.Kilogramos);
            return juguete;
        }

        /// <summary>
        /// Conversion explicita
        /// </summary>
        /// <param name="articulos"></param>
        public static explicit operator Juguete(ArtCuidadoMascota articulos)
        {
            Juguete jueguete = new Juguete(articulos.Marca, articulos.Nombre, articulos.Descripcion, articulos.Cantidad, articulos.Precio, articulos.Kilogramos);
            return jueguete;
        }
        #endregion
    }
}
