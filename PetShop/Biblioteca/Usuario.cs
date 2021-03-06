using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Usuario : Persona
    {
        #region "Atributos"
        string usuario;
        string password;
        EPerfilUsuario perfilUsuario;
        #endregion

        #region "Constructores"

        /// <summary>
        /// Constructor sin parámetros de la clase Usuario.
        /// </summary>
        public Usuario() : base()
        {

        }


        /// <summary>
        /// Constructor con parámetros de la clase Usuario.
        /// </summary>
        /// <param name="cuit"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="usuario"></param>
        /// <param name="password"></param>
        /// <param name="perfilUsuario"></param>
        public Usuario(string cuit, string nombre, string apellido, string usuario, string password, EPerfilUsuario perfilUsuario) : base(cuit, nombre, apellido)
        {
            this.usuario = usuario;
            this.password = password;
            this.perfilUsuario = perfilUsuario;
        }
        #endregion

        #region "Propiedades"
        /// <summary>
        /// Recibe y setea el dato 
        /// </summary>
        public string NameUsuario
        {
            get
            {
                return this.usuario;
            }
            set
            {
                this.usuario = value;
            }
        }


        /// <summary>
        /// Recibe y setea el dato 
        /// </summary>
        public string PassUsuario
        {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
            }
        }


        /// <summary>
        /// Recibe y setea el dato 
        /// </summary>
        public EPerfilUsuario PerfilUsuario
        {
            get
            {
                return this.perfilUsuario;
            }
            set
            {
                this.perfilUsuario = value;
            }
        }
        #endregion

        #region "Enumerados"

        /// <summary>
        /// enumerados
        /// </summary>
        public enum EPerfilUsuario
        {
            Admin,
            Empleado
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Agrega el obejto si no se encuentra en la lista
        /// </summary>
        /// <param name="usuarios"></param>
        /// <param name="usuario"></param>
        /// <returns>devueve la lista con el objeto a agregar</returns>
        public static Dictionary<string, Usuario> operator +(Dictionary<string, Usuario> usuarios, Usuario usuario)
        {
            if (usuarios != usuario)
            {
                PetShop.Usuario.Add(usuario.Cuit, usuario);
                return PetShop.Usuario;
            }
            else
                return PetShop.Usuario;
        }


        /// <summary>
        /// Elimina el objeto de la lista si es que se encuentra
        /// </summary>
        /// <param name="usuarios"></param>
        /// <param name="usuario"></param>
        /// <returns>devuelve la lista sin el objeto a eliminar</returns>
        public static Dictionary<string, Usuario> operator -(Dictionary<string, Usuario> usuarios, Usuario usuario)
        {

            if (usuarios == usuario)
            {
                PetShop.Usuario.Remove(usuario.Cuit);
                return PetShop.Usuario;
            }
            else
                return PetShop.Usuario;
        }


        /// <summary>
        /// Verifica que el objeto  se encuentre en la lista
        /// </summary>
        /// <param name="usuarios"></param>
        /// <param name="usuario"></param>
        /// <returns>Devuelve true si  se encuentra el objeto esta en la lista </returns>
        public static bool operator ==(Dictionary<string, Usuario> usuarios, Usuario usuario)
        {
            foreach (var item in usuarios)
            {
                if (usuario.Cuit == item.Key)
                    return true;
            }

            return false;
        }


        /// <summary>
        /// Verifica que el objeto NO se encuentre en la lista
        /// </summary>
        /// <param name="usuarios"></param>
        /// <param name="usuario"></param>
        /// <returns>Devuelve true si NO se encuentra el objeto esta en la lista </returns>
        public static bool operator !=(Dictionary<string, Usuario> usuarios, Usuario usuario)
        {
            return !(usuarios == usuario);
        }
        #endregion

        #region "Utils"
        /// <summary>
        /// Devuelve informacion del objeto como string
        /// </summary>
        /// <returns>Devuelve informacion del objeto como string</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Apellido} {this.Nombre}");
            return sb.ToString();
        }


        /// <summary>
        /// Muestra mensaje tomando de ToString sobresescrita de la clase
        /// </summary>
        /// <returns>Devuelve un string</returns>
        public string Mostrar()
        {
            return ToString();
        }

        /// <summary>
        /// Proegunta si el usuario en admin
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns>Devuelve true si admin o false si no</returns>
        public static bool IsAdmin(Usuario usuario)
        {
            if (usuario.PerfilUsuario == EPerfilUsuario.Admin)
            {
                return true;
            }
            return false;
        }

        #endregion
    }
}
