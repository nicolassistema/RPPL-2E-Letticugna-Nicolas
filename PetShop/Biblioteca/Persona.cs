using System;
using System.Text;

namespace Entidades
{

    public abstract class Persona
    {
        #region "Atributos"
        private string nombre;
        private string apellido;
        private string cuit;
        #endregion

        #region "Constructor"
        /// <summary>
        /// Constructor con parámetros de la clase Persona.
        /// </summary>
        public Persona()
        {
            this.Cuit = String.Empty;
            this.Nombre = String.Empty;
            this.Apellido = String.Empty;
        }

        /// <summary>
        /// Constructor con parámetros de la clase Persona.
        /// </summary>
        /// <param name="cuit"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        public Persona(string cuit, string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Cuit = cuit;
        }
        #endregion

        #region "Propiedades"
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }

        public string Cuit
        {
            get
            {
                return this.cuit;
            }
            set
            {
                this.cuit = value;
            }
        }

        #endregion

        #region "utils"

        /// <summary>
        /// Sobre carga de mostrar
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.Apellido} |");
            sb.Append($"{this.Nombre} |");

            return sb.ToString();
        }
    
        #endregion

    }
}
