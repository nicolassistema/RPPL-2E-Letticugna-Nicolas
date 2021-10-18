using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class UsuarioInvalidoException : Exception
    {
        /// <summary>
        /// Constructor sin parámetros de la clase UsuarioInvalidoException.
        /// </summary>
        public UsuarioInvalidoException()
        {

        }


        /// <summary>
        /// Constructor con parámetros de la clase UsuarioInvalidoException.
        /// </summary>
        /// <param name="message"></param>
        public UsuarioInvalidoException(string message) : base(message)
        {

        }


        /// <summary>
        /// Constructor con parámetros de la clase UsuarioInvalidoException.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public UsuarioInvalidoException(string message, Exception innerException) : base(message, innerException)
        {

        }

    }
}
