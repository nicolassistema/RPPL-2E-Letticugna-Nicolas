using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class ClienteSinDineroExcepcion : Exception
    {

        /// <summary>
        /// Constructor sin parámetros de la clase ClienteSinDineroExcepcion.
        /// </summary>
        public ClienteSinDineroExcepcion()
        {

        }

        /// <summary>
        /// Constructor con parámetros de la clase ClienteSinDineroExcepcion.
        /// </summary>
        /// <param name="message"></param>
        public ClienteSinDineroExcepcion(string message) : base(message)
        {

        }

        /// <summary>
        /// Constructor con parámetros de la clase ClienteSinDineroExcepcion.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public ClienteSinDineroExcepcion(string message, Exception innerException) : base(message, innerException)
        {

        }




    }

 



}
