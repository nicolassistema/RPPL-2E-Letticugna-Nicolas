using System.Text;

namespace Entidades
{
    public class ArtCuidadoMascota : Producto
    {
        #region "Atributos"
        private ETipoCuidado tipoCuidado;
        #endregion

        #region "Constructor"

        public ArtCuidadoMascota()
        {

        }

        public ArtCuidadoMascota(string marca, string nombre, string detalle, int stock, double precio, double kilogramos) : base(marca, nombre, detalle, stock, precio, kilogramos)
        {

        }

        public ArtCuidadoMascota(string marca, string nombre, string detalle, double precio, double kilogramos, ETipoCuidado tipoCuidado) : base(marca, nombre, detalle, precio, kilogramos)
        {
            this.tipoCuidado = tipoCuidado;
        }


        public ArtCuidadoMascota(string marca, string nombre, string detalle, int stock, double precio, double kilogramos, ETipoCuidado tipoCuidado) : base(marca, nombre, detalle, stock, precio, kilogramos)
        {
            this.tipoCuidado = tipoCuidado;
        }
        #endregion

        #region "Enumerados"
        public enum ETipoCuidado
        {
            Farmacia,
            Limpieza
        }
        #endregion

        #region "Propiedades"
        /// <summary>
        /// setea y devuelve un dato
        /// </summary>
        public ETipoCuidado TipoCuidado
        {
            get
            {
                return this.tipoCuidado;
            }
            set
            {
                this.tipoCuidado = value;
            }
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
            sb.AppendLine(base.ToString());
            sb.AppendLine($"{this.tipoCuidado}");
            return sb.ToString();
        }



        public static explicit operator ArtCuidadoMascota(Cama cama)
        {
            ArtCuidadoMascota articulos = new ArtCuidadoMascota(cama.Marca, cama.Nombre, cama.Descripcion, cama.Cantidad, cama.Precio, cama.Kilogramos);
            return articulos;
        }

        public static explicit operator ArtCuidadoMascota(Alimento alimento)
        {
            ArtCuidadoMascota articulos = new ArtCuidadoMascota(alimento.Marca, alimento.Nombre, alimento.Descripcion, alimento.Cantidad, alimento.Precio, alimento.Kilogramos);
            return articulos;
        }


        public static explicit operator ArtCuidadoMascota(Juguete jueguete)
        {
            ArtCuidadoMascota articulos = new ArtCuidadoMascota(jueguete.Marca, jueguete.Nombre, jueguete.Descripcion, jueguete.Cantidad, jueguete.Precio, jueguete.Kilogramos);
            return articulos;
        }



        #endregion
    }
}

