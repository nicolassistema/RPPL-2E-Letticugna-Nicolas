using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class ClienteSinDineroExcepcion : Exception
    {


        public ClienteSinDineroExcepcion()
        {

        }


        public ClienteSinDineroExcepcion(string message) : base(message)
        {

        }

        public ClienteSinDineroExcepcion(string message, Exception innerException) : base(message, innerException)
        {

        }




    }

 



}
