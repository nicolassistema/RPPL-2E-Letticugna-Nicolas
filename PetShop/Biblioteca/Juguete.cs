using System.Text;

namespace Entidades
{
    public class Juguete : Producto
    {
        #region "Atributos"
        private EMaterial material;
        #endregion

        #region "Constructores"

        public Juguete()
        {

        }

        public Juguete(string marca, string nombre, string detalle, int stock, double precio, double kilogramos) : base(marca, nombre, detalle, stock, precio, kilogramos)
        {
          
        }

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

        public static explicit operator Juguete(Cama cama)
        {
            Juguete juguete = new Juguete(cama.Marca, cama.Nombre, cama.Descripcion, cama.Cantidad, cama.Precio, cama.Kilogramos);
            return juguete;
        }

        public static explicit operator Juguete(Alimento alimento)
        {
            Juguete juguete = new Juguete(alimento.Marca, alimento.Nombre, alimento.Descripcion, alimento.Cantidad, alimento.Precio, alimento.Kilogramos);
            return juguete;
        }


        public static explicit operator Juguete(ArtCuidadoMascota articulos)
        {
            Juguete jueguete = new Juguete(articulos.Marca, articulos.Nombre, articulos.Descripcion, articulos.Cantidad, articulos.Precio, articulos.Kilogramos);
            return jueguete;
        }



        #endregion
    }
}
