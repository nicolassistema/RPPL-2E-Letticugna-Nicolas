using System.Text;

namespace Entidades
{
    public class Alimento : Producto
    {

        private ETipoAlimento tipoAlimento;


        public Alimento()
        {

        }

        public Alimento(string marca, string nombre, string detalle, int stock, double precio, double kilogramos) : base(marca, nombre, detalle, stock, precio, kilogramos)
        {

        }




        public Alimento(string marca, string nombre, string detalle, int cantidad, double precio, double kilogramos, ETipoAlimento tipoAlimento) : base(marca, nombre, detalle, cantidad, precio, kilogramos)
        {
            this.tipoAlimento = tipoAlimento;

        }


        public enum ETipoAlimento
        {
            Balanceado,
            Natural
        }

        /// <summary>
        /// setea y devuelve el dato
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



        public static explicit operator Alimento(Cama cama)
        {
            Alimento alimento = new Alimento(cama.Marca, cama.Nombre, cama.Descripcion, cama.Cantidad, cama.Precio, cama.Kilogramos);
            return alimento;
        }

        public static explicit operator Alimento(ArtCuidadoMascota articulo)
        {
            Alimento alimento = new Alimento(articulo.Marca, articulo.Nombre, articulo.Descripcion, articulo.Cantidad, articulo.Precio, articulo.Kilogramos);
            return alimento;
        }


        public static explicit operator Alimento(Juguete jueguete)
        {
            Alimento alimento = new Alimento(jueguete.Marca, jueguete.Nombre, jueguete.Descripcion, jueguete.Cantidad, jueguete.Precio, jueguete.Kilogramos);
            return alimento;
        }



    }
}
